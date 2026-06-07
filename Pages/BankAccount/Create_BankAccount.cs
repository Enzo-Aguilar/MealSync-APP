using MealSync_APP.Globals;
using System.Windows.Forms;
using System.Data.SqlTypes;
using MealSync_APP.Utils;
using System;

namespace MealSync_APP.BankAccountFolder
{
    public partial class Create_BankAccount : Form
    {
        static private readonly BankAccount _bk = new BankAccount();
        static private readonly User _user = CurrentSession.User;
        public Create_BankAccount()
        {
            InitializeComponent();
        }
        //Métodos dos componentes gráficos
        private void BtnCreate_BankAccount_Click(object sender, EventArgs e)
        {
            int ownerNumber = 1;
            try
            {
                _bk.AccountType = cbAccountType.SelectedItem.ToString();
                _bk.Balance = SqlMoney.Parse("2.15");
                _bk.CreatedAt = DateTime.Now;
                _bk.Password = tbPassword.Text;
                _bk.Iban = Iban.Create();
                string passwordConfirm = tbPasswordConfirm.Text;

                var createBk = BankAuth.CreateBankAccount(_bk, passwordConfirm);
                if (createBk.IsValid)
                {
                    HolderAuth.CreateHolder(_user,_bk,ownerNumber);
                    BankAccountData.Save(_bk);
                    MessageBox.Show("Conta criada com sucesso");
                }
                else
                {
                    MessageBox.Show($"Não é possivel criar conta bancária: {createBk.ErrorMessage}",createBk.Source,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro a criar conta bancária: {ex.Message}","Erro",MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            finally
            {
                _bk.Clear();
                _user.Clear();
                ClearFields();
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
