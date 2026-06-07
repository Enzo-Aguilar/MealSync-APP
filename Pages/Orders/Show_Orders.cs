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

namespace MealSync_APP.OrderFolder
{
    public partial class Show_Orders : Form
    {
        public Show_Orders()
        {
            InitializeComponent();
        }
        private void Show_Orders_Load(object sender, EventArgs e)
        {
            OrderDateTime.Value = DateTime.Today;
            LoadUserOrdersForDate(OrderDateTime.Value);
            LogCheck.UserIsLogged(this);
        }
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Create the Meal Components for ordered meals
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
                BackColor = Color.LightGreen, // Different color to indicate ordered status
                Tag = meal,
                Cursor = Cursors.Default
            };

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

            // Label for meal description
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

            // Label indicating ordered status
            Label orderedLabel = new Label
            {
                Text = "✓ Marcado",
                Font = new Font("Arial", 9, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 10, 20),
                Location = new Point(5, priceLabel.Bottom + 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.DarkGreen,
            };

            // Add controls to panel
            mealPanel.Controls.Add(pictureBox);
            mealPanel.Controls.Add(nameLabel);
            mealPanel.Controls.Add(descriptionLabel);
            mealPanel.Controls.Add(typeLabel);
            mealPanel.Controls.Add(priceLabel);
            mealPanel.Controls.Add(orderedLabel);

            panelMeals.Controls.Add(mealPanel);
            return mealPanel;
        }

        // Helpers
        private void LoadUserOrdersForDate(DateTime selectedDate)
        {
            panelMeals.Controls.Clear();

            int xPosition = 10;
            int yPosition = 10;
            int cardWidth = 200;
            int cardHeight = 280;
            int cardSpacing = 10;
            int cardCount = 0;

            var userOrders = Utils.OrderUtils.GetUserOrderedMeals(CurrentSession.User, selectedDate);

            if (userOrders.Length == 0)
            {
                Label noOrdersLabel = new Label
                {
                    Text = "Nenhuma marcação para este dia",
                    Font = new Font("Arial", 14, FontStyle.Bold),
                    ForeColor = Color.Gray,
                    Location = new Point(200, 150),
                    AutoSize = true
                };
                panelMeals.Controls.Add(noOrdersLabel);
                return;
            }

            foreach (Meal m in userOrders)
            {
                if (m == null) continue;
                Panel mealCard = CreateMealComponent(m);

                mealCard.Location = new Point(xPosition, yPosition);
                panelMeals.Controls.Add(mealCard);

                cardCount++;
                if (cardCount == 3) // 3 cards per line
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

        private void OrderDateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadUserOrdersForDate(OrderDateTime.Value);
        }
    }
}
