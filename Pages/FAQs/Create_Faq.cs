using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System;
using System.Data;
using MealSync_APP.Utils;

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
                _faq.IsAnswered = false;
                _faq.Question = tbQuestion.Text;
                if (checkBox.Checked)
                    _faq.UserId = -1;
                else
                    _faq.UserId = CurrentSession.User.ID;
                
                var createQuestion = FaqAuth.CreateQuestion(_faq);
                if (createQuestion.IsValid)
                {
                    MessageBox.Show("Pergunta criada com sucesso", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            finally
            {
                ClearFields();
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
