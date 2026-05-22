using System.Windows.Forms;
using MealSync_APP.Utils;
using System;

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
                    var save = UserData.Save(user);
                    if (save.IsValid)
                    {
                        MessageBox.Show("Bem-Vindo", "SUCCESS");
                        HomeForm.Open(this);
                    }
                    else
                    {
                        MessageBox.Show(save.ErrorMessage);
                    }
                }
                else
                {
                    MessageBox.Show(login.ErrorMessage, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar fazer login: " + err.Message,"EXCEPTION",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { RegisterForm.Open(this); }
        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("🔒"))
            {
                tbPassword.PasswordChar = '\0';
                label1.Text = "🔓";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                label1.Text = "🔒";
            }
        }
    }
}