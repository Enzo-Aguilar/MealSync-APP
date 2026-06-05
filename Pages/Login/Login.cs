using System.Windows.Forms;
using MealSync_APP.Utils;
using System;
using MealSync_APP.Globals;

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
            CurrentSession.User.Reset();
            BankAccountData.Reset();
        }

        //Métodos dos componentes graficos
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                user.Name = tbName.Text;
                user.Password = tbPassword.Text;
                var login = UserAuth.Login(user);

                if (login.IsValid)
                {
                    var save = UserData.Save(user);
                    BankAccountData.Load_BkAccountsAssociatedToUser();
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
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar fazer login: {ex.Message}","EXCEPTION",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                user.Reset();
            }
        }
        private void LbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { RegisterForm.Open(this); }

        //Métodos Auxiliares
        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text.Contains("🔒"))
            {
                tbPassword.PasswordChar = '\0';
                lbPassword.Text = "🔓";
            }
            else
            {
                tbPassword.PasswordChar = '*';
                lbPassword.Text = "🔒";
            }
        }
        private void LbRandomNameGenerator_Click(object sender, EventArgs e)
        {

        }
    }
}