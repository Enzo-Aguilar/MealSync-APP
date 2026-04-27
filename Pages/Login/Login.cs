using System.Windows.Forms;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //Load do form
        private void Index_Load(object sender, EventArgs e)
        {
            UserData.Reset();
        }

        //Métodos dos componentes graficos
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string password = tbPassword.Text;

            if (UserAuth.Login(name, password).IsValid)
            {
                UserData.Save(name);
                FormUtils.Open_Home();
            }
            else
            {
                MessageBox.Show(UserAuth.Login(name, password).errorMessage);
            }
        }
        private void lbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUtils.Open_Register(this);
        }
    }
}