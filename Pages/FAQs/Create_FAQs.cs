using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using System;

namespace MealSync_APP.Pages.FAQsFolder
{
    public partial class Create_FAQs : Form
    {
        static protected FAQs faq = new FAQs();
        public Create_FAQs()
        {
            InitializeComponent();
        }
        private void BtnSendQuestion_Click(object sender, EventArgs e)
        {
            faq.Question = tbQuestion.Text;
            faq.IsActive = true;
            faq.IsAnswered = false;
            FAQs_BLL.Create_FAQ(faq);
        }
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                faq.ID_User = 0;
            }
            else
            {
                faq.ID_User = CurrentSession.User.ID;
            }
        }

    }
}
