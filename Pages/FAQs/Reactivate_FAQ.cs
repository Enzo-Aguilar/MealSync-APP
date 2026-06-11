using System.Windows.Forms;
using BusinessLogicLayer;
using System;
using MealSync_APP.Globals;
using MealSync_APP.Utils;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Reactivate_Faq : Form
    {
        private static readonly Faq _faq = new Faq();
        public Reactivate_Faq()
        {
            InitializeComponent();
        }
        private void Reactivate_FAQ_Load(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void BtnReactivate_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.Question = tbQuestion.Text;
                var reactivate = FaqAuth.ReactivateQuestion(_faq);
                if (reactivate.IsValid)
                {
                    MessageBox.Show("Pergunta Reativada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _faq.Clear();
                }
                else
                {
                    MessageBox.Show(reactivate.ErrorMessage, reactivate.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadContent();
                ClearFields();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e) { LoadContent(); }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadContent();
            }
            else
            {
                dgvFAQs.DataSource = Faq_BLL.Search_UnansweredQuestions(tbSearch.Text);
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
                catch(Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Helpers
        private void LoadContent()
        {
            dgvFAQs.Visible = false;
            dgvFAQs.DataSource = Faq_BLL.Show_DeactivatedFAQs();
            dgvFAQs.Visible = true;
        }
        private void ClearFields()
        {
            tbQuestion.Clear();
            tbSearch.Clear();
        }
    }
}
