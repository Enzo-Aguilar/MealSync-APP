using MealSync_APP.Utils;
using System;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace MealSync_APP
{
    public partial class Login : Form
    {
        static protected User user = new User();
        public Login()
        {
            InitializeComponent();
        }
        //Load do form
        private void Login_Load(object sender, EventArgs e)
        {
            UserData.Reset();
            BankAccountData.Reset();
        }

        //Métodos dos componentes graficos
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            UserData.Reset();
            try
            {
                user.Name = tbName.Text;
                user.Password = tbPassword.Text;
                var login = UserAuth.Login(user);

                if (login.IsValid)
                {
                    MessageBox.Show("Bem-Vindo", "SUCCESS");
                    UserData.Save(user);
                    HomeForm.Open(this);
                }
                else
                {
                    MessageBox.Show(login.errorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + err.Message,"EXCEPTION",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { RegisterForm.Open(this); }

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
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