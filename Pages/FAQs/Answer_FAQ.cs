using System.Windows.Forms;
using BusinessLogicLayer;
using System;
using MealSync_APP.Globals;
using MealSync_APP.Utils;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Answer_Faq : Form
    {
        private static readonly Faq _faq = new Faq();
        public Answer_Faq()
        {
            InitializeComponent();
        }
        private void Answer_Faq_Load(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void DgvFAQs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    tbQuestion.Text = dgvFAQs.Rows[e.RowIndex].Cells[0].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                }
            }
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadContent();
            }
            else
            {
                dgvFAQs.DataSource = Faq_BLL.Search_UnansweredQuestion(tbSearch.Text);
            }
        }
        private void BtnAnswerQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.UserId = CurrentSession.User.ID;
                _faq.Answer = tbAnswer.Text;
                _faq.Question = tbQuestion.Text;
                var answerQuestion = FaqAuth.AnswerQuestion(_faq);
                if (answerQuestion.IsValid)
                {
                    MessageBox.Show("Pergunta respondida com sucesso", "Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _faq.Clear();
                }
                else
                {
                    MessageBox.Show(answerQuestion.ErrorMessage, answerQuestion.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.Question = tbQuestion.Text;
                var deactivate = FaqAuth.DeactivateQuestion(_faq);
                if (deactivate.IsValid)
                {
                    var message = MessageBox.Show("Tem certeza", "Info", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (message == DialogResult.Yes)
                    {

                        MessageBox.Show("Pergunta desativada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _faq.Clear();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(deactivate.ErrorMessage, deactivate.Source,MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadContent();
        }

        // Helpers
        private void LoadContent()
        {
            dgvFAQs.Visible = false;
            dgvFAQs.DataSource = Faq_BLL.Show_UnansweredFAQs();
            dgvFAQs.Visible = true;
        }
        private void ClearFields()
        {
            LoadContent();
            tbAnswer.Clear();
            tbQuestion.Clear();
            tbSearch.Clear();
        }
    }
}
