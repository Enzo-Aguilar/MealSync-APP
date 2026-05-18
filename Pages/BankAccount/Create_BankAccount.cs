using System.Windows.Forms;
using System.Data.SqlTypes;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;

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

                var createBankAccount = BankAuth.Create_BankAccount(bankAccount,passwordConfirm);
                if (createBankAccount.IsValid)
                {
                    MessageBox.Show("Conta criada com sucesso!");
                    HolderAuth.Create_Holder(bankAccount, CurrentSession.User, 1);
                    BankAccountData.Save(bankAccount);//Falta Adicionar as contas ja vinculadas anteriormente
                    ResetElements();
                }
                else
                {
                    MessageBox.Show("Não foi possível criar a conta bancária: " + createBankAccount.ErrorMessage);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar criar a conta bancária: " + err.Message);
            }
        }
        private void LinkLabelAssociateBankAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e){OpenForm.AssociateToBankAccount();}

        private void CheckBoxPassword_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void CheckBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {

        }

        //Métodos Auxiliares
        private void ResetElements()
        {
            cbAccountType.SelectedIndex = -1;
            tbPassword.Clear();
            tbPasswordConfirm.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("🔒"))
            {
                tbPasswordConfirm.PasswordChar = '\0';
                label1.Text = "🔓";
            }
            else
            {
                tbPasswordConfirm.PasswordChar = '*';
                label1.Text = "🔒";
            }
        }
    }
}
