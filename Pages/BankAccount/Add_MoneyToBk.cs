using MealSync_APP.Globals;
using System.Windows.Forms;
using System;
using MealSync_APP.Utils;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Add_MoneyToBk : Form
    {
        private static readonly BankAccount _bk = new BankAccount();
        public Add_MoneyToBk()
        {
            InitializeComponent();
        }
        private void Add_MoneyToBk_Load(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void DgvBkAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                    tbIban.Text = iban;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void BtnAddMoney_Click(object sender, EventArgs e)
        {
            try
            {
                _bk.Iban = tbIban.Text;
                _bk.ID = int.Parse(tbBankAccountID.Text);
                decimal addedAmount = decimal.Parse(tbAddedAmount.Text);

                var addAmount = BankAuth.AddAmountToBkAccount(_bk, addedAmount);
                if (addAmount.IsValid)
                {
                    MessageBox.Show("Valor adicionado com sucesso", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearFields();
                    _bk.Clear();
                }
                else
                {
                    MessageBox.Show(addAmount.ErrorMessage, addAmount.Source, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
            }
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            LoadContent();
        }
        private void LbInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Pesquise usando o nome do dono da conta bancária.");
        }

        // Helpers
        private void LoadContent()
        {
            dgvBankAccounts.Visible = false;
            dgvBankAccounts.DataSource = null;//Um metodos que returna uma tabela com as contas daquele user e as associadas. o parametro da função é o ID do User
            dgvBankAccounts.Visible = true;
        }
        private void ClearFields()
        {
            tbSearch.Clear();
            tbAccountOwner.Clear();
            tbIban.Clear();
            tbBankAccountID.Clear();
            tbAddedAmount.Clear();
        }
    }
}
