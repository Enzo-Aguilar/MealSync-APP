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
        private static readonly BankAccount bankAccount = new BankAccount();
        private static readonly User currentUser = CurrentSession.User;
        public Reactivate_BankAccount()
        {
            InitializeComponent();
        }
        //Load do Form
        private void Reactivate_BankAccount_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Métodos dos componentes grafícos
        private void BtnReactivateAccounts_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbBankAccountID.Text))
                { 
                    bankAccount.ID = int.Parse(tbBankAccountID.Text);
                    bankAccount.Password = tbPassword.Text;
                    var reactivate = HolderAuth.ReactivateBkAccountAndHolder(currentUser, bankAccount);
                    if (reactivate.IsValid)
                    {
                        var res = MessageBox.Show("Tem certeza que deseja reativar a conta?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (res == DialogResult.Yes)
                        {
                            MessageBox.Show("Conta reativada com sucesso");
                            ResetElements();
                        }
                    }
                    else
                    {
                        MessageBox.Show(reactivate.ErrorMessage);
                    }
                }
                else
                {
                    MessageBox.Show("Não pode associar! Campos invalidos");
                }
            }
            catch (Exception err)
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
            //if(checkBoxPassword.Checked)
            //{//Mostrar a senha
            //    tbPassword.PasswordChar = '\0';
            //}
            //else
            //{//Esconder a senha
            //    tbPassword.PasswordChar = '*';
            //}
        }
        //Métodos Auxiliares
        private void LoadData()
        {
            try
            {
                DataTable dt = BankAccount_BLL.DataTable_DeactivatedBkAccount_With_OwnerData();

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum utilizador encontrado", "Info");
                    dgvBankAccounts.DataSource = null;
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
            BtnUpdate_Click(null,null);
        }

        private void Reactivate_BankAccount_Load_1(object sender, EventArgs e)
        {

        }
    }
}
