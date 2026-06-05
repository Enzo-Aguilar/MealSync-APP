using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Data.SqlTypes;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace MealSync_APP.BankAccountFolder
{
    public partial class Create_BankAccount : Form
    {
        static private readonly BankAccount bankAccount = new BankAccount();
        public Create_BankAccount()
        {
            InitializeComponent();
        }
        //Métodos dos componentes gráficos
        private void BtnCreate_BankAccount_Click(object sender, EventArgs e)
        {
            try
            {
                bankAccount.AccountType = cbAccountType.SelectedItem.ToString();
                bankAccount.Balance = SqlMoney.Parse("2.15");
                bankAccount.CreatedAt = DateTime.Now;
                bankAccount.Password = tbPassword.Text;
                bankAccount.IBAN = IBAN.Create();
                string passwordConfirm = tbPasswordConfirm.Text;

                var createBK = BankAuth.Create_BankAccount(bankAccount,passwordConfirm);
                if (createBK.IsValid)
                {
                    MessageBox.Show("Conta criada com sucesso!");
                    HolderAuth.Create_Holder(bankAccount, CurrentSession.User, 1);
                    BankAccountData.Save(bankAccount);
                    ClearFields();
                    bankAccount.Reset();
                }
                else
                {
                    MessageBox.Show($"Não foi possível criar a conta bancária: {createBK.ErrorMessage}");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar criar a conta bancária: {ex.Message}");
            }
        }
        private void LinkLabelAssociateBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){OpenForm.AssociateToBankAccount();}

        //Métodos Auxiliares
        private void ClearFields()
        {
            cbAccountType.SelectedIndex = -1;
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
                tbPassword.PasswordChar = '\0';
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
