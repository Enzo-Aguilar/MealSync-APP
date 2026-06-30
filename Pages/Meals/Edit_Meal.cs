using System.Collections.Generic;
using System.Windows.Forms;
using MealSync_APP.Globals;
using System.Data.SqlTypes;
using MealSync_APP.Utils;
using System.Drawing;
using System.Linq;
using System;

namespace MealSync_APP.MealFolder
{
    public partial class Edit_Meal : Form
    {
        private Meal originalMeal = null;
        private Meal currentMeal = null;
        private bool isEditMode = false;
        private readonly Dictionary<int, bool> mealEditableMap = new Dictionary<int, bool>();

        public Edit_Meal()
        {
            InitializeComponent();
        }

        private void Edit_Meal_Load(object sender, EventArgs e)
        {
            LogCheck.UserIsLogged(this);
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMealsByName(tbSearch.Text);
        }
        private void FilterMealsByName(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadMealsByDate(dateTimerPickerMeals.Value);
                return;
            }

            foreach (Control control in panelMealCards.Controls)
            {
                if (control is Panel panel && panel.Tag is Meal meal)
                {
                    panel.Visible = meal.Name.IndexOf(searchTerm, StringComparison.OrdinalIgnoreCase) >= 0;
                }
            }
        }
        private void OnMealCardClicked(Meal meal, Panel mealCard)
        {
            foreach (Control control in panelMealCards.Controls)
            {
                if (control is Panel panel && panel.Tag is Meal prevMeal && prevMeal.ID != meal.ID)
                {
                    if (mealEditableMap.TryGetValue(prevMeal.ID, out bool prevEditable))
                    {
                        panel.BackColor = prevEditable ? Color.LightGreen : Color.LightGray;
                    }
                }
            }

            mealCard.BackColor = Color.LightCyan;
            DisplayMealDetails(meal);
        }
        private void DisplayMealDetails(Meal meal)
        {
            originalMeal = new Meal
            {
                ID = meal.ID,
                Date = meal.Date,
                Description = meal.Description,
                IsActive = meal.IsActive,
                MealImage = meal.MealImage,
                Name = meal.Name,
                Price = meal.Price,
                Type = meal.Type
            };

            currentMeal = new Meal
            {
                ID = meal.ID,
                Date = meal.Date,
                Description = meal.Description,
                IsActive = meal.IsActive,
                MealImage = meal.MealImage,
                Name = meal.Name,
                Price = meal.Price,
                Type = meal.Type
            };

            tbMealName.Text = meal.Name;
            tbMealDescription.Text = meal.Description;
            cbMealType.SelectedItem = meal.Type;
            tbMealPrice.Text = meal.Price.ToString();
            mealTimePicker.Value = meal.Date ?? DateTime.Today;

            if (meal.MealImage != null && meal.MealImage.Length > 0)
            {
                pictureBoxMealImage.Image = Image.FromStream(new System.IO.MemoryStream(meal.MealImage));
            }
            else
            {
                pictureBoxMealImage.Image = null;
            }

            DisableEditMode();
            isEditMode = false;
        }
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Meal updatedMeal = new Meal();
                if (updatedMeal != null)
                {
                    updatedMeal = new Meal
                    {
                        ID = originalMeal.ID,
                        Date = dateTimerPickerMeals.Value,
                        Description = tbMealDescription.Text,
                        IsActive = true,
                        MealImage = ImageUtils.ImageToBytes(pictureBoxMealImage.Image),
                        Name = tbMealName.Text,
                        Price = decimal.Parse(tbMealPrice.Text),
                        Type = cbMealType.SelectedItem.ToString(),
                    };
                }
                var editMeal = MealAuth.EditMeal(updatedMeal);
                if (mealEditableMap.TryGetValue(originalMeal.ID, out bool isEditable) || !isEditable)
                {
                    if (HasChanges())
                    {
                        if (editMeal.IsValid)
                        {
                            MessageBox.Show("Refeição editada com sucesso");
                        }
                        else
                        {
                            MessageBox.Show(editMeal.ErrorMessage, editMeal.Source);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhuma alteração foi efetuada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Só é possivel editar refeições com 7 dias de antecedencia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                EnableEditMode();
                isEditMode = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                DisableEditMode();
                isEditMode = false;
                LoadMealsByDate(dateTimerPickerMeals.Value);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadMealsByDate(DateTime.Today);
        }
        private void PictureBoxMealImage_Click(object sender, EventArgs e)
        {
            if (!isEditMode)
            {
                MessageBox.Show("Entre em modo de edição para alterar a imagem.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                    ofd.Title = "Selecionar uma Imagem";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxMealImage.Image = null;
                        pictureBoxMealImage.Image = Image.FromFile(ofd.FileName);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar imagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DateTimePickerMeals_ValueChanged(object sender, EventArgs e)
        {
            LoadMealsByDate (dateTimerPickerMeals.Value);
        }

        //Helpers
        private bool AreMealImagesEqual(Image currentImage, byte[] originalImageBytes)
        {
            if (currentImage == null && (originalImageBytes == null || originalImageBytes.Length == 0))
                return true;

            if (currentImage == null || originalImageBytes == null || originalImageBytes.Length == 0)
                return false;

            byte[] currentImageBytes = ImageUtils.ImageToBytes(currentImage);
            return currentImageBytes.SequenceEqual(originalImageBytes);
        }
        private bool AreStringsEqual(string str1, string str2)
        {
            return string.Equals(str1 ?? "", str2 ?? "", StringComparison.OrdinalIgnoreCase);
        }
        private void DisableEditMode()
        {
            tbMealName.ReadOnly = true;
            tbMealDescription.ReadOnly = true;
            cbMealType.Enabled = false;
            tbMealPrice.ReadOnly = true;
            mealTimePicker.Enabled = false;
            pictureBoxMealImage.Enabled = false;
            btnEdit.Text = "Editar";
            btnUpdate.Enabled = false;
        }
        private void DisableMealPanel()
        {
            tbMealName.Clear();
            tbMealDescription.Clear();
            cbMealType.ResetText();
            tbMealPrice.Clear();
            mealTimePicker.Value = DateTime.Today;
            pictureBoxMealImage.Image = null;
            DisableEditMode();
        }
        private void EnableEditMode()
        {
            tbMealName.ReadOnly = false;
            tbMealDescription.ReadOnly = false;
            cbMealType.Enabled = true;
            tbMealPrice.ReadOnly = false;
            mealTimePicker.Enabled = true;
            pictureBoxMealImage.Enabled = true;
            btnEdit.Text = "Cancelar";
            btnUpdate.Enabled = true;
        }
        private bool HasChanges()
        {
            return !AreStringsEqual(tbMealName.Text, originalMeal.Name) ||
                   !AreStringsEqual(tbMealDescription.Text, originalMeal.Description) ||
                   !AreStringsEqual(cbMealType.SelectedItem?.ToString() ?? "", originalMeal.Type) ||
                   !AreStringsEqual(tbMealPrice.Text, originalMeal.Price.ToString()) ||
                   mealTimePicker.Value != originalMeal.Date ||
                   !AreMealImagesEqual(pictureBoxMealImage.Image, originalMeal.MealImage);
        }
        private void LoadMealsByDate(DateTime date)
        {
            try
            {
                panelMealCards.Controls.Clear();
                mealEditableMap.Clear();

                Meal[] meals = MealAuth.IndexMeals(date);
                if(meals == null)
                {
                    MessageBox.Show("Nenhuma refeição encontrada para a data selecionada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableMealPanel();
                    return;
                }
                foreach(Meal m in meals)
                {
                    bool isEditable = MealValidator.IsMealOnTimeToBeEditable(m.Date);
                    mealEditableMap[m.ID] = isEditable;
                    Panel mealCard = CreateMealComponent(m, isEditable);
                    panelMealCards.Controls.Add(mealCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        // Methods for Dinamic Elements Creation
        private Panel CreateMealComponent(Meal meal, bool isEditable, int width = 200, int height = 320)
        {
            string mealName = meal.Name;
            string description = meal.Description;
            string menuType = meal.Type;
            SqlMoney price = meal.Price;
            Image mealImage = meal.MealImage != null && meal.MealImage.Length > 0
                ? Image.FromStream(new System.IO.MemoryStream(meal.MealImage))
                : null;

            Panel mealPanel = new Panel
            {
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = isEditable ? Color.LightGreen : Color.LightGray,
                Tag = meal,
                Cursor = isEditable ? Cursors.Hand : Cursors.Default
            };

            if (isEditable)
            {
                mealPanel.Click += (s, e) => OnMealCardClicked(meal, mealPanel);
                mealPanel.MouseEnter += (s, e) => mealPanel.BackColor = Color.LightBlue;
                mealPanel.MouseLeave += (s, e) => mealPanel.BackColor = Color.LightGreen;
            }

            PictureBox pictureBox = new PictureBox
            {
                Image = mealImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(width - 4, 160),
                Location = new Point(2, 2)
            };

            Label nameLabel = new Label
            {
                Text = mealName,
                Location = new Point(5, 170),
                Size = new Size(width - 10, 30),
                AutoSize = false,
                Font = new Font("Arial", 10, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            Label typeLabel = new Label
            {
                Text = $"Tipo: {menuType}",
                Location = new Point(5, 205),
                Size = new Size(width - 10, 20),
                AutoSize = false,
                Font = new Font("Arial", 9)
            };

            Label priceLabel = new Label
            {
                Text = $"Preço: €{price}",
                Location = new Point(5, 230),
                Size = new Size(width - 10, 20),
                AutoSize = false,
                Font = new Font("Arial", 9)
            };

            Label dateLabel = new Label
            {
                Text = $"Data: {meal.Date:dd/MM/yyyy}",
                Location = new Point(5, 255),
                Size = new Size(width - 10, 20),
                AutoSize = false,
                Font = new Font("Arial", 9)
            };

            Label editableLabel = new Label
            {
                Text = isEditable ? "✓ Editável" : "✗ Não Editável",
                Location = new Point(5, 280),
                Size = new Size(width - 10, 25),
                AutoSize = false,
                Font = new Font("Arial", 8, FontStyle.Bold),
                ForeColor = isEditable ? Color.DarkGreen : Color.DarkRed,
                TextAlign = ContentAlignment.MiddleCenter
            };

            mealPanel.Controls.Add(pictureBox);
            mealPanel.Controls.Add(nameLabel);
            mealPanel.Controls.Add(typeLabel);
            mealPanel.Controls.Add(priceLabel);
            mealPanel.Controls.Add(dateLabel);
            mealPanel.Controls.Add(editableLabel);

            return mealPanel;
        }
    }
}
