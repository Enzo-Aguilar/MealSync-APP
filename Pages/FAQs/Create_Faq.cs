using System.Windows.Forms;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Create_Faq : Form
    {
        static protected Faq _faq = new Faq();
        public Create_Faq()
        {
            InitializeComponent();
        }
        private void BtnSendQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                _faq.Question = tbQuestion.Text;
                if (checkBox.Checked)
                    _faq.UserId = null;
                else
                    _faq.UserId = CurrentSession.User.ID;

                var createQuestion = FaqAuth.CreateQuestion(_faq);
                if (createQuestion.IsValid)
                {
                    MessageBox.Show("Pergunta enviada com sucesso","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    ClearFields();
                    _faq.Clear();
                }
                else
                {
                    MessageBox.Show(createQuestion.ErrorMessage, createQuestion.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Helpers
        private void ClearFields()
        {
            tbQuestion.Clear();
            checkBox.Checked = false;
        }
    }
}
