using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System;
using System.Data;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Create_FAQs : Form
    {
        static protected Faq faq = new Faq { UserId = CurrentSession.User.ID};
        public Create_FAQs()
        {
            InitializeComponent();
        }
        private void BtnSendQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Faq_BLL.GetQuestion(tbQuestion.Text);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Está pergunta já foi feita");
                }
                else
                {
                    faq.Question = tbQuestion.Text;
                    faq.IsActive = true;
                    faq.IsAnswered = false;
                    Faq_BLL.Create_FAQ(faq);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro: " + err.Message);
            }
        }
        private int CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                return faq.UserId = 0;
            }
            else
            {
                return faq.UserId = CurrentSession.User.ID;
            }
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
