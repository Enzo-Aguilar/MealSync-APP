using System.Windows.Forms;
using BusinessLogicLayer;
using System;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Reactivate_FAQ : Form
    {
        public Reactivate_FAQ()
        {
            InitializeComponent();
        }
        //Load do Form
        private void Reactivate_FAQ_Load(object sender, EventArgs e)
        {
            LoadContent();
        }

        //Métodos dos componentes graficos
        private void BtnReactivate_Click(object sender, EventArgs e)
        {
            try
            {
                string question = tbQuestion.Text;
                FAQs_BLL.Reactivate_FAQ(question);
                ResetElements();
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadContent();
            }
            else
            {
                dgvFAQs.DataSource = FAQs_BLL.GetUnansweredQuestions(tbSearch.Text);
            }
        }
        private void DgvFAQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    tbQuestion.Text = dgvFAQs.Rows[e.RowIndex].Cells[0].Value?.ToString();
                }
                catch(Exception err)
                {
                    MessageBox.Show("Ocorreu um erro: "+err.Message);
                }
            }
        }

        //Métodos Auxiliares
        private void LoadContent()
        {
            dgvFAQs.Visible = false;
            dgvFAQs.DataSource = FAQs_BLL.Show_DeactivatedFAQs();
            dgvFAQs.Visible = true;
        }
        private void ResetElements()
        {
            LoadContent();
            tbQuestion.Clear();
            tbSearch.Clear();
        }
    }
}
