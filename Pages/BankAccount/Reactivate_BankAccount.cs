using System.Windows.Forms;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using BusinessLogicLayer;
using System.Data;
using System;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Reactivate_BankAccount : Form
    {
        private readonly User _user = CurrentSession.User;
        private readonly BankAccount _bk = new BankAccount();
        public Reactivate_BankAccount()
        {
            InitializeComponent();
        }
        private void Reactivate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadBkAccountData();
        }
        private void BtnReactivateAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja reativar a conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(tbBankAccountID.Text))
                    {
                        _bk.ID = int.Parse(tbBankAccountID.Text);
                        _bk.Password = tbPassword.Text;
                        var reactivate = HolderAuth.ReassociateBkToUser(_user, _bk);
                        if (reactivate.IsValid)
                        {
                            MessageBox.Show($"Conta bancária {_bk.ID} reativada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show(reactivate.ErrorMessage,reactivate.Source,MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não é possivel reativar conta bancária, campos invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao reativar conta bancária: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                ClearFields();
                _user.Clear();
                _bk.Clear();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
            dgvBankAccounts.Visible = true;
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbSearch.Text))
            {
                LoadBkAccountData();
            }
            else
            {
                var dt = BankAccount_BLL.Search_AccountUserDataByName(tbSearch.Text);
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
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //Helpers
        private void LoadBkAccountData()
        {
            try
            {
                DataTable dt = BankAccount_BLL.Deactivated_BkAccounts_WithOwnerData();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum utilizador encontrado", "Info");
                    dgvBankAccounts.DataSource = null;
                    return;
                }
                dgvBankAccounts.DataSource = dt;
                if (dgvBankAccounts.Columns.Count >= 5)
                {
                    dgvBankAccounts.Columns[0].HeaderText = "Nome";
                    dgvBankAccounts.Columns[1].HeaderText = "Email";
                    dgvBankAccounts.Columns[2].HeaderText = "NumTel";
                    dgvBankAccounts.Columns[3].HeaderText = "Conta ID";
                    dgvBankAccounts.Columns[4].HeaderText = "IBAN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro carregando dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            tbAccountOwner.Clear();
            tbBankAccountID.Clear();
            tbIBAN.Clear();
            tbPassword.Clear();

            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
            dgvBankAccounts.Visible = true;
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
    }
}
