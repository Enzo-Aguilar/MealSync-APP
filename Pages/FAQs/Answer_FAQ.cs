using MealSync_APP.Globals;
using System.Windows.Forms;
using MealSync_APP.Utils;
using BusinessLogicLayer;
using System;

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

        private void BtnAnswerQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.Answer = tbAnswer.Text;
                _faq.Question = tbQuestion.Text;
                var answerQuestion = FaqAuth.AnswerQuestion(_faq);
                if (answerQuestion.IsValid)
                {
                    MessageBox.Show("Pergunta Respondida", "Info", MessageBoxButtons.OK,MessageBoxIcon.Information);
                    _faq.Clear();
                    ClearFields();
                    LoadContent();
                }
                else
                {
                    MessageBox.Show(answerQuestion.ErrorMessage, answerQuestion.Source, MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BtnDeactivate_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.Question = tbQuestion.Text;
                var message = MessageBox.Show("Tem certeza?", "Info",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if(message == DialogResult.Yes)
                {
                    var deactivateAnswer = FaqAuth.DeactivateQuestion(_faq);
                    if (deactivateAnswer.IsValid)
                    {
                        MessageBox.Show("Pergunta desativada", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _faq.Clear();
                        ClearFields();
                        LoadContent();
                    }
                    else
                    {
                        MessageBox.Show(deactivateAnswer.ErrorMessage,deactivateAnswer.Source,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
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
