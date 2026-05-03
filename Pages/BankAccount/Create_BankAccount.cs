using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        //Load do form
        private void Create_BankAccount_Load(object sender, EventArgs e)
        {

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
                    HolderAuth.Create_Holder(bankAccount, Data.CurrentUser, 1);
                    ResetElements();
                }
                else
                {
                    MessageBox.Show("Não foi possível criar a conta bancária: " + createBankAccount.errorMessage);
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
            if (checkBoxPassword.Checked)
            {//Mostrar a senha
                tbPassword.PasswordChar = '\0';
            }
            else
            {//Esconder a senha
                tbPassword.PasswordChar = '*';
            }
        }
        private void CheckBoxPasswordConfirm_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPasswordConfirm.Checked)
            {//Mostrar a senha
                tbPasswordConfirm.PasswordChar = '\0';
            }
            else
            {//Esconder a senha
                tbPasswordConfirm.PasswordChar = '*';
            }
        }

        //Métodos Auxiliares
        private void ResetElements()
        {
            cbAccountType.SelectedIndex = -1;
            tbPassword.Clear();
            tbPasswordConfirm.Clear();
        }
    }
}
