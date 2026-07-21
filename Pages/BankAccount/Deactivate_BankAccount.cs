using BusinessLogicLayer;
using MealSync_APP.Globals;
using MealSync_APP.Utils;
using System;
using System.Windows.Forms;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Deactivate_BankAccount : Form
    {
        private readonly BankAccount _bk = new BankAccount();
        private readonly User _user = CurrentSession.User;

        public Deactivate_BankAccount()
        {
            InitializeComponent();
        }
        private void Deactivate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadBkAccountData();
        }
        private void TbSearch_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSearch.Text))
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
            else
            {
                LoadBkAccountData();
            }
        }
        private void BtnDeactivateAccount_Click(object sender, EventArgs e)
        {
            try
            {
                var res = MessageBox.Show("Tem certeza que deseja desativar conta?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    if (!string.IsNullOrEmpty(tbIban.Text))
                    {
                        _bk.ID = int.Parse(tbIban.Text);
                        _bk.Password = tbPassword.Text;

                        var deactivate = HolderAuth.DeactivateBkToUser(_user, _bk);
                        if (deactivate.IsValid)
                        {
                            MessageBox.Show($"Conta bancária desativada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            BtnUpdate_Click(null, null);
                        }
                        else
                        {
                            MessageBox.Show(deactivate.ErrorMessage, deactivate.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Utilizador não pode desativar, campos invalidos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro a desativar a conta: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadBkAccountData();
                ClearFields();
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)//Sabor "atualizar"
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
                    tbIban.Text = accountID.ToString();
                    tbBankAccountID.Text = iban;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Helpers
        private void LoadBkAccountData()
        {
            try
            {
                var dt = BankAccount_BLL.Active_BkAccounts_WithOwnerData();
                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum utilizador conta bancária ativa e coletiva foi encontrado", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvBankAccounts.DataSource = dt;
                if (dgvBankAccounts.Columns.Count >= 5)
                {
                    dgvBankAccounts.Columns[0].HeaderText = "Nome";
                    dgvBankAccounts.Columns[1].HeaderText = "Email";
                    dgvBankAccounts.Columns[2].HeaderText = "NumTel";
                    dgvBankAccounts.Columns[3].HeaderText = "ID Conta";
                    dgvBankAccounts.Columns[4].HeaderText = "IBAN";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro a carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearFields()
        {
            tbAccountOwner.Clear();
            tbIban.Clear();
            tbBankAccountID.Clear();
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

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquise usando o nome do dono da conta bancária.");
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
