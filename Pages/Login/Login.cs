using System.Windows.Forms;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP
{
    public partial class Login : Form
    {
        private static readonly User _user = new User();
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            CurrentSession.Clear();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                _user.Name = tbName.Text;
                _user.Password = tbPassword.Text;
                var login = UserAuth.Login(_user);
                if (login.IsValid)
                {
                    var save = UserData.Save(_user);
                    BankAccountData.LoadBkAssociatedToUser();
                    if (save.IsValid)
                    {
                        MessageBox.Show("Bem-Vindo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HomeForm.Open(this);
                    }
                    else
                    {
                        MessageBox.Show(save.ErrorMessage,save.Source,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(login.ErrorMessage, login.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro a fazer login: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void LbLink_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) { RegisterForm.Open(this); }

        //Helpers
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
    }
}