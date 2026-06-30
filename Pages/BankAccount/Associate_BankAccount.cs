using MealSync_APP.Globals;
using System.Windows.Forms;
using BusinessLogicLayer;
using MealSync_APP.Utils;
using System.Data;
using System;


namespace MealSync_APP.BankAccountFolder
{
    public partial class Associate_BankAccount : Form
    {
        private readonly User _user = CurrentSession.User;
        private readonly BankAccount _bk = new BankAccount();
        public Associate_BankAccount()
        {
            InitializeComponent();
        }
        private void Associate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadBkAccountData();
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadBkAccountData();
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
        private void BtnAssociateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                _bk.ID = int.Parse(tbBankAccountID.Text);
                _bk.Iban = tbIBAN.Text;
                var associate = HolderAuth.AssociateBkToUser(_user, _bk);
                if(associate.IsValid)
                {
                    BankAccountData.Save(_bk);
                    MessageBox.Show("Conta Bancária associada com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(associate.ErrorMessage,associate.Source,MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar associar a conta bancária: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                _bk.Clear();
                _user.Clear();
                ClearFields();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //Helpers
        private void LoadBkAccountData()
        {
            try
            {
                var dt = BankAccount_BLL.Active_BkAccounts_WithOwnerData();
                if(dt == null || dt.Rows.Count == 0)
                {
                    dgvBankAccounts.DataSource = null;
                    MessageBox.Show("Nenhum utilizador com conta bancárica coletiva encontrado");
                    return;
                }
                dgvBankAccounts.DataSource = dt;
                if(dgvBankAccounts.Columns.Count >= 5)
                {
                    dgvBankAccounts.Columns[0].HeaderText = "Nome";
                    dgvBankAccounts.Columns[1].HeaderText = "Email";
                    dgvBankAccounts.Columns[2].HeaderText = "NumeroTel";
                    dgvBankAccounts.Columns[3].HeaderText = "ID conta bancária";
                    dgvBankAccounts.Columns[4].HeaderText = "IBAN";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro a carregar os dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            tbAccountOwner.Clear();
            tbBankAccountID.Clear();
            tbIBAN.Clear();

            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
            dgvBankAccounts.Visible = true;
        }
        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text.Contains("🔒"))
            {
                tbIBAN.PasswordChar = '\0';
                lbPassword.Text = "🔓";
            }
            else
            {
                tbIBAN.PasswordChar = '*';
                lbPassword.Text = "🔒";
            }
        }
    }
}
