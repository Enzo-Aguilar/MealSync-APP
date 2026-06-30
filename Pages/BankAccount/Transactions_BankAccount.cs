using BusinessLogicLayer;
using MealSync_APP.Globals;
using System;
using System.Data;
using System.Windows.Forms;

namespace MealSync_APP.Pages.BankAccountFolder
{
    public partial class Transactions_BankAccount : Form
    {
        public Transactions_BankAccount()
        {
            InitializeComponent();
        }
        private void Transactions_BankAccount_Load(object sender, EventArgs e)
        {
            int rows = CurrentSession.UserBkAccountsDataTable.Rows.Count;
            if (rows <= 0)
            {
                MessageBox.Show("O utilizado não tem contas bancarias associadas");
            }
            dgvBankAccounts.DataSource = CurrentSession.UserBkAccountsDataTable;
        }

        // Métodos dos componentes gráficos
        private void DgvBankAccounts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure that the click is on a valid row
            {
                DataGridViewRow selectedRow = dgvBankAccounts.Rows[e.RowIndex];
                int bankAccountId = Convert.ToInt32(selectedRow.Cells["ID"].Value); // Adjust the column name as needed

                // Fetch transactions for the selected bank account
                dgvTransaction.DataSource = Transaction_BLL.Show_BankAccountTransactions(bankAccountId);
            }

        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvBankAccounts.Visible = false;
            dgvBankAccounts.DataSource = CurrentSession.UserBkAccountsDataTable;
            dgvBankAccounts.Visible = true;

            dgvTransaction.Visible = false;
            dgvTransaction.DataSource = null; 
            dgvTransaction.Visible = true;
        }
        private void BtnCleanSelection_Click(object sender, EventArgs e)
        {
            dgvTransaction.DataSource = null;
        }
    }
}
