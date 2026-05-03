using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Reactivate_BankAccount : Form
    {
        private static readonly BankAccount bankAccount = new BankAccount();
        private static readonly User currentUser = Data.CurrentUser;
        public Reactivate_BankAccount()
        {
            InitializeComponent();
        }
        //Load do Form
        private void Reactivate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Métodos dos componentes graficos
        private void BtnDeactivatedAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbBankAccountID.Text))
                {
                    /*
                        1º Criar metodos pra reativar na BLL
                        2º Criar HolderAuth && BkAuth 
                        3º Mostrar e atulizar aqui baseado no form 'Deactivate_BankAccount.cs'
                     */
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao tentar ativar a conta: " + err.Message, "Error");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvBankAccounts.Visible = false;
            LoadData();
            dgvBankAccounts.Visible = true;
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadData();
            }
            else
            {
                DataTable dt = BankAccount_BLL.Search_AccountUserDataByName(tbSearch.Text);
                if (dt.Rows.Count == 0)
                {
                    dgvBankAccounts.DataSource = null;
                }
                else
                {
                    dgvBankAccounts.DataSource = dt;
                }
            }
        }
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
        //Métodos Auxiliares
        private void LoadData()
        {
            try
            {
                DataTable dt = BankAccount_BLL.GetUserDeactivatedBankAccountData();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum utilizador encontrado", "Info");
                    return;
                }

                dgvBankAccounts.DataSource = dt;

                // Format column headers
                if (dgvBankAccounts.Columns.Count >= 5)
                {
                    dgvBankAccounts.Columns[0].HeaderText = "Name";
                    dgvBankAccounts.Columns[1].HeaderText = "Email";
                    dgvBankAccounts.Columns[2].HeaderText = "Phone Number";
                    dgvBankAccounts.Columns[3].HeaderText = "Account ID";
                    dgvBankAccounts.Columns[4].HeaderText = "IBAN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro carregando dados: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ResetElements()
        {
            tbAccountOwner.Text = string.Empty;
            tbBankAccountID.Text = string.Empty;
            tbIBAN.Text = string.Empty;
            tbPassword.Text = string.Empty;
            BtnUpdate_Click(null, null);
        }

    }
}
