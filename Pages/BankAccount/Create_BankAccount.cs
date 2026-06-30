using MealSync_APP.Globals;
using System.Windows.Forms;
using System.Data.SqlTypes;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP.BankAccountFolder
{
    public partial class Create_BankAccount : Form
    {
        private static readonly BankAccount _bk = new BankAccount();
        private static readonly User _user = CurrentSession.User;
        public Create_BankAccount()
        {
            InitializeComponent();
        }
        private void Create_BankAccount_Load(object sender, EventArgs e)
        {
            LogCheck.UserIsLogged(this);
        }
        private void BtnCreate_BankAccount_Click(object sender, EventArgs e)
        {
            try
            {
                _bk.AccountType = cbAccountType.SelectedItem.ToString();
                _bk.Balance = decimal.Parse("2.15");
                _bk.CreatedAt = DateTime.Now;
                _bk.Password = tbPassword.Text;
                _bk.Iban = Iban.Create();

                string passwordConfirm = tbPasswordConfirm.Text;
                var createBk = BankAuth.CreateBankAccount(_bk,passwordConfirm);
                if (createBk.IsValid)
                {
                    var createHolder = HolderAuth.CreateHolder(_user, _bk);
                    if (createHolder.IsValid)
                    {
                        BankAccountData.Save(_bk);
                        MessageBox.Show("Conta Bancaria criado com sucessso", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _bk.Clear();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show(createHolder.ErrorMessage, createHolder.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show(createBk.ErrorMessage, createBk.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            } 
        }
        private void LinkLabelAssociateBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){OpenForm.AssociateToBankAccount();}

        //Métodos Auxiliares
        private void ClearFields()
        {
            cbAccountType.ResetText();
            tbPassword.Clear();
            tbPasswordConfirm.Clear();
        }
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
        private void LbPasswordConfirm_Click(object sender, EventArgs e)
        {
            if (lbPasswordConfirm.Text.Contains("🔒"))
            {
                tbPasswordConfirm.PasswordChar = '\0';
                lbPasswordConfirm.Text = "🔓";
            }
            else
            {
                tbPasswordConfirm.PasswordChar = '*';
                lbPasswordConfirm.Text = "🔒";
            }
        }

        
    }
}
