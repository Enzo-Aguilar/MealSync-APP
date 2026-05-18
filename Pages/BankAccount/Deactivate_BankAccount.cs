using System.Windows.Forms;
using MealSync_APP.Globals;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System.Data;
using System;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Deactivate_BankAccount : Form
    {
        private static readonly BankAccount bankAccount = new BankAccount();
        private static readonly User currentUser = CurrentSession.User;

        public Deactivate_BankAccount()
        {
            InitializeComponent();
        }
        //Load do form
        private void Deactivate_BankAccount_Load(object sender, EventArgs e)
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
        private void BtnDeactivateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbBankAccountID.Text))
                {
                    bankAccount.ID = int.Parse(tbBankAccountID.Text);
                    bankAccount.Password = tbPassword.Text;
                    currentUser.ID = CurrentSession.User.ID;
                    var deactivate = HolderAuth.DeactivateBkAccountToUser(currentUser, bankAccount);
                    if (deactivate.IsValid)
                    {
                        var res = MessageBox.Show("Tem certeza que deseja desativar conta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            MessageBox.Show("Conta desativado com sucesso");
                            ResetElements();
                        }
                    }
                    else
                    {
                        MessageBox.Show(deactivate.ErrorMessage);
                    }
                }
                else
                {
                    MessageBox.Show("Não pode associar! Campos invalidos");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ocorreu um erro ao desativar a conta: " + err.Message, "Error");
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

        }

        //Métodos Auxiliares
        private void LoadBankAccountData()
        {
            try
            {
                DataTable dt = BankAccount_BLL.DataTable_BkAccount_With_OwnerData();

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

        private void tbBankAccountID_TextChanged(object sender, EventArgs e)
        {

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
    }
}
