using System.Windows.Forms;
using System.Data.SqlTypes;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System.Drawing;
using System.Data;
using System;

namespace MealSync_APP.MealFolder
{
    public partial class Remove_Meal : Form
    {
        private Meal selectedMeal = null;
        public Remove_Meal()
        {
            InitializeComponent();
        }

        private void Remove_Meal_Load(object sender, EventArgs e)
        {
            MealDateTime.Value = DateTime.Today;
            LoadMealsForDate(MealDateTime.Value);
        }
        private void BtnDeativatMeal_Click(object sender, EventArgs e)
        {
            if (selectedMeal == null)
            {
                MessageBox.Show("Por favor selecione uma refeição.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (MealDateTime.Value <= DateTime.Today)
            {
                MessageBox.Show("Não pode remover refeições de datas já passadas");
                return;
            }
            else if (!MealValidator.IsMealOnTimeToBeEditable(MealDateTime.Value))
            {
                MessageBox.Show("Só é possivel remover refeições com 1 semana de antecedencia");
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show(
                    $"Tem a certeza que deseja remover a refeição '{selectedMeal.Name}'?",
                    "Confirmar Remoção",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Meal_BLL.Deactivate_Meal(selectedMeal.ID);
                    MessageBox.Show("Refeição removida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadMealsForDate(MealDateTime.Value);
                    selectedMeal = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            MealDateTime.Visible = false;
            LoadMealsForDate(MealDateTime.Value);
            MealDateTime.Visible = true;
        }
        private void OnMealCardClicked(Meal meal, Panel mealCard)
        {
            // Deselect previous meal card
            if (selectedMeal != null && selectedMeal.ID != meal.ID)
            {
                foreach (Control control in panelMeals.Controls)
                {
                    if (control is Panel panel && panel.Tag is Meal prevMeal && prevMeal.ID == selectedMeal.ID)
                    {
                        panel.BackColor = Color.White;
                    }
                }
            }

            // Select new meal
            selectedMeal = meal;
            mealCard.BackColor = Color.LightBlue;
        }

        // Create the Meal Components
        private Panel CreateMealComponent(Meal meal, int width = 200, int height = 280)
        {
            string mealName = meal.Name;
            string description = meal.Description;
            string menuType = meal.Type;
            SqlMoney price = meal.Price;
            Image mealImage = meal.MealImage != null ? Image.FromStream(new System.IO.MemoryStream(meal.MealImage)) : null;

            // Main container panel
            Panel mealPanel = new Panel
            {
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Tag = meal,
                Cursor = Cursors.Hand
            };

            // Add click handler to select meal
            mealPanel.Click += (s, e) => OnMealCardClicked(meal, mealPanel);
            mealPanel.MouseEnter += (s, e) => mealPanel.BackColor = Color.LightGray;
            mealPanel.MouseLeave += (s, e) => mealPanel.BackColor = selectedMeal?.ID == meal.ID ? Color.LightBlue : Color.White;

            // PictureBox for meal image
            PictureBox pictureBox = new PictureBox
            {
                Image = mealImage,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Size = new Size(width - 10, 120),
                Location = new Point(5, 5),
            };

            // Label for meal name
            Label nameLabel = new Label
            {
                Text = mealName,
                Font = new Font("Arial", 11, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 10, 30),
                Location = new Point(5, pictureBox.Bottom + 5),
                TextAlign = ContentAlignment.TopLeft,
            };

            //Label for meal description
            Label descriptionLabel = new Label
            {
                Text = $"Descrição:{description}",
                Font = new Font("Arial", 9),
                AutoSize = false,
                Size = new Size(width - 10, 40),
                Location = new Point(5, nameLabel.Bottom + 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.Gray,
            };

            // Label for menu type
            Label typeLabel = new Label
            {
                Text = $"Tipe: {menuType}",
                Font = new Font("Arial", 9),
                AutoSize = false,
                Size = new Size(width - 10, 25),
                Location = new Point(5, descriptionLabel.Bottom + 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.Gray,
            };

            // Label for price
            Label priceLabel = new Label
            {
                Text = $"€{price:F2}",
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 10, 25),
                Location = new Point(5, typeLabel.Bottom + 5),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.Green,
            };

            // Add controls to panel
            mealPanel.Controls.Add(pictureBox);
            mealPanel.Controls.Add(descriptionLabel);
            mealPanel.Controls.Add(nameLabel);
            mealPanel.Controls.Add(typeLabel);
            mealPanel.Controls.Add(priceLabel);

            // Add click handlers to child controls as well
            foreach (Control control in mealPanel.Controls)
            {
                control.Click += (s, e) => OnMealCardClicked(meal, mealPanel);
                control.MouseEnter += (s, e) => mealPanel.BackColor = Color.LightGray;
                control.MouseLeave += (s, e) => mealPanel.BackColor = selectedMeal?.ID == meal.ID ? Color.LightBlue : Color.White;
            }

            panelMeals.Controls.Add(mealPanel);
            return mealPanel;
        }

        //Helpers
        private void LoadMealsForDate(DateTime selectedDate)
        {
            panelMeals.Controls.Clear();
            selectedMeal = null;

            int xPosition = 10;
            int yPosition = 10;
            int cardWidth = 200;
            int cardHeight = 280;
            int cardSpacing = 10;
            int cardCount = 0;

            var todayMeals = Utils.OrderUtils.IndexTodayMeals(selectedDate);
            foreach (Meal m in todayMeals)
            {
                if (m == null) continue;
                Panel mealCard = CreateMealComponent(m);

                mealCard.Location = new Point(xPosition, yPosition);
                panelMeals.Controls.Add(mealCard);

                cardCount++;
                if (cardCount == 3)//3 cards por linha
                {
                    xPosition = 10;
                    yPosition += cardHeight + cardSpacing;
                }
                else
                {
                    xPosition += cardWidth + cardSpacing;
                }
            }
        }
        private void MealDateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadMealsForDate(MealDateTime.Value);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
