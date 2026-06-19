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
    public partial class Add_MoneyToBk : Form
    {
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

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

        }

        // Helpers
        private void LoadContent()
        {
            dgvBankAccounts.Visible = false;
            dgvBankAccounts.DataSource = null;//Uma metodos que returna uma tabela com as contas daquele user e as associadas. o parametro da função é o ID do User
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

        private void lbText_Click(object sender, EventArgs e)
        {

        }
    }
}
