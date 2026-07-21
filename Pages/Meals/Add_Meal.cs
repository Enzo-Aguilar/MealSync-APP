using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.MealFolder
{
    public partial class Add_Meal : Form
    {
        private static Meal meal = new Meal();
        public Add_Meal()
        {
            InitializeComponent();  
        }

        //Metodos dos Componentes Graficos
        private void BtnCreateMeal_Click(object sender, EventArgs e)
        {
            try
            {
                meal = new Meal
                {
                    Date = mealTimePicker.Value,
                    Description = tbMealDescription.Text,
                    IsActive = true,
                    MealImage = ImageUtils.ImageToBytes(pictureBoxMealImage.Image),
                    Name = tbMealName.Text,
                    Price = decimal.Parse(tbMealPrice.Text),
                    Type = cbMealType.SelectedItem.ToString()
                };
                var create_meal = MealAuth.CreateMeal(meal);
                if (create_meal.IsValid)
                {
                    MessageBox.Show("Refeição criada com sucesso!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show($"Erro ao criar refeição: {create_meal.ErrorMessage}","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar criar refeição: {ex.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PictureBoxMealImage_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                    ofd.Title = "Select an Image";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        pictureBoxMealImage.Image = null;
                        pictureBoxMealImage.Image = Image.FromFile(ofd.FileName);
                        pictureBoxUserMealImagePreview.Image = Image.FromFile(ofd.FileName);
                        meal.MealImage = ImageUtils.ImageToBytes(pictureBoxMealImage.Image);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar carregar imagem: {ex.Message}");
            }
        }
        private void TbMealName_TextChanged(object sender, EventArgs e)
        {
            lbMealNameUserPreview.Text = "Nome: ";
            lbMealNameUserPreview.Text += tbMealName.Text;
        }
        private void TbMealDescription_TextChanged(object sender, EventArgs e)
        {
            lbMealDescriptionUserPreview.Text = "Descrição: ";
            lbMealDescriptionUserPreview.Text += tbMealDescription.Text;
        }
        private void CbMealType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbMealTypeUserPreview.Text = "Tipo: ";
            lbMealTypeUserPreview.Text += cbMealType.SelectedItem.ToString();
        }
        private void TbMealPrice_TextChanged(object sender, EventArgs e)
        {
            lbMealPriceUserPreview.Text = "Preço: ";
            lbMealPriceUserPreview.Text += tbMealPrice.Text + " €";
        }
        private void BtnCancelMeal_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        // Métodos Auxiliares
        private void ClearFields()
        {
            pictureBoxMealImage.Image = null;
            tbMealName.Clear();
            tbMealDescription.Clear();
            cbMealType.ResetText();
            tbMealPrice.Clear();
            
            // Campos 
            pictureBoxUserMealImagePreview.Image = null;
            lbMealNameUserPreview.Text = "Nome: ";
            lbMealDescriptionUserPreview.Text = "Descrição: ";
            lbMealTypeUserPreview.Text = "Tipo: ";
            lbMealPriceUserPreview.Text = "Preço: ";
        }
    }
}
