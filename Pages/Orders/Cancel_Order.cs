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
    public partial class Cancel_Order : Form
    {
        private Dictionary<int, int> mealOrderMap = new Dictionary<int, int>(); // Maps Meal ID to Order ID
        private Dictionary<int, bool> mealCancellableMap = new Dictionary<int, bool>(); // Maps Meal ID to cancellable status

        public Cancel_Order()
        {
            InitializeComponent();
        }

        private void Cancel_Order_Load(object sender, EventArgs e)
        {
            MealDateTime.Value = DateTime.Today;
            LoadCancellableOrdersForDate(MealDateTime.Value);
            LogCheck.UserIsLogged(this);
        }

        private void BtnMakeOrder_Click(object sender, EventArgs e)
        {
            // Find selected meal (cancellable only)
            Meal selectedMeal = null;
            int selectedOrderId = -1;
            bool isCancellable = false;

            foreach (Control control in panelMeals.Controls)
            {
                if (control is Panel panel && panel.BackColor == Color.LightCoral)
                {
                    if (panel.Tag is Meal meal)
                    {
                        selectedMeal = meal;
                        if (mealOrderMap.TryGetValue(meal.ID, out int orderId))
                        {
                            selectedOrderId = orderId;
                        }
                        if (mealCancellableMap.TryGetValue(meal.ID, out bool cancellable))
                        {
                            isCancellable = cancellable;
                        }
                        break;
                    }
                }
            }

            if (selectedMeal == null)
            {
                MessageBox.Show("Por favor selecione uma marcação para desmarcar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isCancellable)
            {
                MessageBox.Show("Não pode desmarcar refeições com menos de uma semana para o dia marcado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DialogResult result = MessageBox.Show(
                    $"Tem certeza que deseja desmarcar a refeição '{selectedMeal.Name}' para {selectedMeal.Date:dd/MM/yyyy}?",
                    "Confirmar Desmarcação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int deleteResult = Order_BLL.Delete_Order(selectedOrderId);
                    if (deleteResult > 0)
                    {
                        MessageBox.Show("Marcação desmarcada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadCancellableOrdersForDate(MealDateTime.Value);
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro ao desmarcar a refeição.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadCancellableOrdersForDate(MealDateTime.Value);
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnMealCardClicked(Meal meal, Panel mealCard, bool isCancellable)
        {
            // Deselect previous meal card
            foreach (Control control in panelMeals.Controls)
            {
                if (control is Panel panel && panel.Tag is Meal prevMeal && prevMeal.ID != meal.ID)
                {
                    bool prevCancellable = mealCancellableMap.ContainsKey(prevMeal.ID) ? mealCancellableMap[prevMeal.ID] : false;
                    panel.BackColor = prevCancellable ? Color.LightYellow : Color.LightGray;
                }
            }

            // Select new meal
            mealCard.BackColor = Color.LightCoral;
        }

        // Create the Meal Components for cancellable orders
        private Panel CreateMealComponent(Meal meal, bool isCancellable, int width = 200, int height = 320)
        {
            string mealName = meal.Name;
            string description = meal.Description;
            string menuType = meal.Type;
            SqlMoney price = meal.Price;
            Image mealImage = meal.MealImage != null ? Image.FromStream(new System.IO.MemoryStream(meal.MealImage)) : null;

            // Main container panel - Yellow if cancellable, Gray if not
            Panel mealPanel = new Panel 
            {
                Size = new Size(width, height),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = isCancellable ? Color.LightYellow : Color.LightGray,
                Tag = meal,
                Cursor = isCancellable ? Cursors.Hand : Cursors.Default
            };

            // Add click handler only if cancellable
            if (isCancellable)
            {
                mealPanel.Click += (s, e) => OnMealCardClicked(meal, mealPanel, isCancellable);
                mealPanel.MouseEnter += (s, e) => mealPanel.BackColor = Color.LightCoral;
                mealPanel.MouseLeave += (s, e) => mealPanel.BackColor = Color.LightYellow;
            }

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

            // Label for date
            Label dateLabel = new Label
            {
                Text = $"Data: {meal.Date:dd/MM/yyyy}",
                Font = new Font("Arial", 9, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 10, 20),
                Location = new Point(5, priceLabel.Bottom + 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = Color.DarkBlue,
            };

            // Label indicating cancellation status
            string statusText = isCancellable ? "✓ Pode Desmarcar" : "✗ Sem Prazo";
            Color statusColor = isCancellable ? Color.DarkGreen : Color.DarkRed;

            Label statusLabel = new Label
            {
                Text = statusText,
                Font = new Font("Arial", 9, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(width - 10, 20),
                Location = new Point(5, dateLabel.Bottom + 2),
                TextAlign = ContentAlignment.TopLeft,
                ForeColor = statusColor,
            };

            // Add controls to panel
            mealPanel.Controls.Add(pictureBox);
            mealPanel.Controls.Add(nameLabel);
            mealPanel.Controls.Add(descriptionLabel);
            mealPanel.Controls.Add(typeLabel);
            mealPanel.Controls.Add(priceLabel);
            mealPanel.Controls.Add(dateLabel);
            mealPanel.Controls.Add(statusLabel);

            // Add click handlers to child controls if cancellable
            if (isCancellable)
            {
                foreach (Control control in mealPanel.Controls)
                {
                    control.Click += (s, e) => OnMealCardClicked(meal, mealPanel, isCancellable);
                    control.MouseEnter += (s, e) => mealPanel.BackColor = Color.LightCoral;
                    control.MouseLeave += (s, e) => mealPanel.BackColor = Color.LightYellow;
                }
            }

            panelMeals.Controls.Add(mealPanel);
            return mealPanel;
        }

        // Helpers
        private void LoadCancellableOrdersForDate(DateTime selectedDate)
        {
            panelMeals.Controls.Clear();
            mealOrderMap.Clear();
            mealCancellableMap.Clear();

            int xPosition = 10;
            int yPosition = 10;
            int cardWidth = 200;
            int cardHeight = 320;
            int cardSpacing = 10;
            int cardCount = 0;

            // Get all user orders
            var userOrders = Utils.OrderUtils.GetUserOrderedMealsWithOrderId(CurrentSession.User, selectedDate, out Dictionary<int, int> orderMap);
            mealOrderMap = orderMap;

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

            foreach (Meal meal in userOrders)
            {
                if (meal == null) continue;

                //Check if meal can be cancelled (at least 7 days in advance)
                TimeSpan daysUntilMeal = meal.Date - DateTime.Today;
                bool isCancellable = daysUntilMeal.TotalDays >= 7;

                mealCancellableMap[meal.ID] = isCancellable;

                Panel mealCard = CreateMealComponent(meal, isCancellable);
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

        private void MealDateTime_ValueChanged(object sender, EventArgs e)
        {
            LoadCancellableOrdersForDate(MealDateTime.Value);
        }
    }
}
