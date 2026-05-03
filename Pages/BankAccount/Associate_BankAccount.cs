using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Globals;
using MealSync_APP.Utils;

namespace MealSync_APP.BankAccountFolder
{
    public partial class Associate_BankAccount : Form
    {
        private static readonly BankAccount bankAccount = new BankAccount();
        private static readonly User currentUser = Data.CurrentUser;
        public Associate_BankAccount()
        {
            InitializeComponent();
        }
        //Load do form
        private void Associate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadBankAccountData();
        }

        //Métodos dos componentes gráficos
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadBankAccountData();
            }
            else
            {
                DataTable dt = BankAccount_BLL.Search_AccountUserDataByName(tbSearch.Text);
                if(dt.Rows.Count == 0)
                {
                    dgvBankAccounts.DataSource = null;
                }
                else
                {
                    dgvBankAccounts.DataSource = dt;
                }
            }
        }
        private void BtnAssociateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                bankAccount.ID = int.Parse(tbBankAccountID.Text);
                bankAccount.IBAN = tbIBAN.Text;
                bankAccount.Password = tbPassword.Text;
                var associate = HolderAuth.AssociateBankAccountToUser(currentUser, bankAccount);
                if(!associate.IsValid)
                {
                    MessageBox.Show(associate.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Conta bancária associada com sucesso!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BankAccountData.Save(bankAccount);
                    ResetElemets();
                }
            }
            catch(Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao associar a conta bancária: " + err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)//Sabor "atualizar"
        {
            dgvBankAccounts.Visible = false;
            LoadBankAccountData();
            dgvBankAccounts.Visible = true;
        }
        private void DgvBankAccounts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    string accountOwner = dgvBankAccounts.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? string.Empty;
                    int accountID = Convert.ToInt32(dgvBankAccounts.Rows[e.RowIndex].Cells[3].Value);
                    string iban = dgvBankAccounts.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? string.Empty;

                    tbAccountOwner.Text = accountOwner;
                    tbBankAccountID.Text = accountID.ToString();
                    tbIBAN.Text = iban;
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ocorreu um erro selecionando a tabela: " + err.Message, "Error");
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
        private void LoadBankAccountData()
        {
            try
            {
                DataTable dt = BankAccount_BLL.GetUserBankAccountData();

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
        private void ResetElemets()
        {
            tbAccountOwner.Text = string.Empty;
            tbBankAccountID.Text = string.Empty;
            tbIBAN.Text = string.Empty;
            tbPassword.Text = string.Empty;
            BtnUpdate_Click(null, null);
        }
    }
}
