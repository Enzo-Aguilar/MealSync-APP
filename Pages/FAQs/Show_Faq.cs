using System.Windows.Forms;
using BusinessLogicLayer;
using System.Data;
using System;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Show_Faq : Form
    {
        public Show_Faq()
        {
            InitializeComponent();
        }
        //Load do form
        private void Show_FAQs_Load(object sender, EventArgs e)
        {
            LoadContent();
        }
        //Métodos dos componentes graficos
        private void DgvQuestions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                try
                {
                    string question = dgvQuestions.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    DataTable dt = Faq_BLL.Search_AnsweredQuestions(question);
                    string answer = dt.Rows[0][2].ToString();
                    tbAnswers.Text = answer;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                dgvQuestions.DataSource = Faq_BLL.Show_FAQs();
            }
            else
            {
                dgvQuestions.DataSource = Faq_BLL.DataTable_AnsweredQuestions(tbSearch.Text);
            }  
        }

        //Helpers
        private void LoadContent()
        {
            dgvQuestions.Visible = false;
            dgvQuestions.DataSource = Faq_BLL.Show_FAQs();
            dgvQuestions.Visible = true;
        }
    }
}
