using BusinessLogicLayer;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.MealFolder
{
    public partial class Edit_Meal : Form
    {
        private Meal originalMeal = null;
        private Meal currentMeal = null;
        private bool isEditMode = false;
        private Dictionary<int, bool> mealEditableMap = new Dictionary<int, bool>();

        public Edit_Meal()
        {
            InitializeComponent();
        }

        private void Edit_Meal_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            LoadMealsForDate(dateTimePicker1.Value);
            LogCheck.UserIsLogged(this);
            tbSearch.TextChanged += TbSearch_TextChanged;
            dateTimePicker1.ValueChanged += DateTimePicker1_ValueChanged;
            btnEdit.Click += BtnEdit_Click;
            btnUpdate.Click += BtnUpdate_Click;
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            LoadMealsForDate(dateTimePicker1.Value);
        }

        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            FilterMealsByName(tbSearch.Text);
        }

        private void LoadMealsForDate(DateTime date)
        {
            try
            {
                panelMealCards.Controls.Clear();
                mealEditableMap.Clear();

                DataTable dt = Meal_BLL.Show_MealsByDate(date);
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhuma refeição encontrada para a data selecionada.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableMealPanel();
                    return;
                }

                foreach (DataRow row in dt.Rows)
                {
                    Meal meal = new Meal
                    {
                        ID = Convert.ToInt32(row["ID"]),
                        Date = Convert.ToDateTime(row["Date"]),
                        Description = row["Description"].ToString(),
                        IsActive = Convert.ToBoolean(row["IsActive"]),
                        MealImage = row["MealImage"] != DBNull.Value ? (byte[])row["MealImage"] : Array.Empty<byte>(),
                        Name = row["Name"].ToString(),
                        Price = row["Price"] != DBNull.Value ? (SqlMoney)row["Price"] : SqlMoney.Zero,
                        Type = row["Type"].ToString()
                    };

                    bool isEditable = IsEditable(meal.Date);
                    mealEditableMap[meal.ID] = isEditable;

                    Panel mealCard = CreateMealComponent(meal, isEditable);
                    panelMealCards.Controls.Add(mealCard);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar refeições: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsEditable(DateTime mealDate)
        {
            DateTime today = DateTime.Today;
            DateTime sevenDaysLater = today.AddDays(7);
            return mealDate >= sevenDaysLater;
        }

        private void FilterMealsByName(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                LoadMealsForDate(dateTimePicker1.Value);
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
                if (originalMeal == null)
                {
                    MessageBox.Show("Por favor selecione uma refeição.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!mealEditableMap.TryGetValue(originalMeal.ID, out bool isEditable) || !isEditable)
                {
                    MessageBox.Show("Apenas refeições com pelo menos 7 dias de antecedência podem ser editadas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if any changes were made
                if (!HasChanges())
                {
                    MessageBox.Show("Nenhuma alteração foi detectada. Por favor, altere pelo menos um campo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                EnableEditMode();
                isEditMode = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao entrar em modo de edição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private bool AreStringsEqual(string str1, string str2)
        {
            return string.Equals(str1 ?? "", str2 ?? "", StringComparison.OrdinalIgnoreCase);
        }

        private bool AreMealImagesEqual(Image currentImage, byte[] originalImageBytes)
        {
            if (currentImage == null && (originalImageBytes == null || originalImageBytes.Length == 0))
                return true;

            if (currentImage == null || originalImageBytes == null || originalImageBytes.Length == 0)
                return false;

            byte[] currentImageBytes = ImageUtils.ImageToBytes(currentImage);
            return currentImageBytes.SequenceEqual(originalImageBytes);
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

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (originalMeal == null)
                {
                    MessageBox.Show("Nenhuma refeição selecionada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate inputs
                ValidatorResult nameValidation = MealValidator.Validate_Name(tbMealName.Text);
                if (!nameValidation.IsValid)
                {
                    MessageBox.Show(nameValidation.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ValidatorResult descValidation = MealValidator.Validate_Description(tbMealDescription.Text);
                if (!descValidation.IsValid)
                {
                    MessageBox.Show(descValidation.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ValidatorResult dateValidation = MealValidator.Validate_DateTimePicker(mealTimePicker.Value);
                if (!dateValidation.IsValid)
                {
                    MessageBox.Show(dateValidation.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlMoney parsedPrice;
                try
                {
                    parsedPrice = SqlMoney.Parse(tbMealPrice.Text);
                }
                catch
                {
                    MessageBox.Show("Preço inválido. Use um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                ValidatorResult priceValidation = MealValidator.Validate_Price(parsedPrice);
                if (!priceValidation.IsValid)
                {
                    MessageBox.Show(priceValidation.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbMealType.SelectedItem == null)
                {
                    MessageBox.Show("Por favor selecione um tipo de refeição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Meal updatedMeal = new Meal
                {
                    ID = originalMeal.ID,
                    Date = mealTimePicker.Value,
                    Description = tbMealDescription.Text,
                    IsActive = true,
                    MealImage = ImageUtils.ImageToBytes(pictureBoxMealImage.Image),
                    Name = tbMealName.Text,
                    Price = parsedPrice,
                    Type = cbMealType.SelectedItem.ToString()
                };

                int result = Meal_BLL.Update_Meal(updatedMeal);
                if (result > 0)
                {
                    MessageBox.Show("Refeição atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DisableEditMode();
                    isEditMode = false;
                    LoadMealsForDate(dateTimePicker1.Value);
                }
                else
                {
                    MessageBox.Show("Erro ao atualizar refeição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar refeição: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
