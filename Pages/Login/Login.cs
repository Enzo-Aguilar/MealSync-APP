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
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = tbName.Text; string password = tbPassword.Text;
            var login = UserAuth.Login(name, password);
            
            if (login.IsValid)
            {
                UserData.Save(name);
                HomeForm.Open(this);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + login.errorMessage,"ERROR");
            }
        }

        private void LbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { RegisterForm.Open(this); }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {//Mostrar a senha
                tbPassword.PasswordChar = '\0';
            }
            else
            {//Esconder a senha
                tbPassword.PasswordChar = '*';
            }
        }
    }
}