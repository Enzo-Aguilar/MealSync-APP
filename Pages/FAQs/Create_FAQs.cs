using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System;
using System.Data;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Create_FAQs : Form
    {
        static protected FAQs faq = new FAQs { ID_User = CurrentSession.User.ID};
        public Create_FAQs()
        {
            InitializeComponent();
        }
        private void BtnSendQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = FAQs_BLL.GetQuestion(tbQuestion.Text);
                if (dt.Rows.Count >= 1)
                {
                    MessageBox.Show("Está pergunta já foi feita");
                }
                else
                {
                    faq.Question = tbQuestion.Text;
                    faq.IsActive = true;
                    faq.IsAnswered = false;
                    FAQs_BLL.Create_FAQ(faq);
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
                return faq.ID_User = 0;
            }
            else
            {
                return faq.ID_User = CurrentSession.User.ID;
            }
        }

    }
}
