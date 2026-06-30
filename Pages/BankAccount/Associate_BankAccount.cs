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
                _bk.ID = int.Parse(tbtbBankAccountID.Text);
                _bk.Iban = tbIban.Text;

                var associateToBk = HolderAuth.AssociateBkToUser(_user, _bk);
            }
            //try
            //{
            //    _bk.ID = int.Parse(tbIban.Text);
            //    _bk.Iban = tbtbBankAccountID.Text;
            //    var associate = HolderAuth.AssociateBkToUser(_user, _bk);
            //    if(associate.IsValid)
            //    {
            //        BankAccountData.Save(_bk);
            //        MessageBox.Show("Conta Bancária associada com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        MessageBox.Show(associate.ErrorMessage,associate.Source,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            //    }
            //}
            //catch(Exception ex)
            //{
            //    MessageBox.Show($"Ocorreu um erro ao tentar associar a conta bancária: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    _bk.Clear();
            //    _user.Clear();
            //    ClearFields();
            //}
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
            dgvBankAccounts.Visible = true;
        }
        // Mock: injeta saldo nas contas do utilizador logado (as mesmas usadas para pagar refeições).
        private void money_put_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable myAccounts = BankAccount_BLL.Load_BkAccountAssociatedWithUser(CurrentSession.User);
                if (myAccounts == null || myAccounts.Rows.Count == 0)
                {
                    MessageBox.Show("Não tem nenhuma conta bancária associada para carregar saldo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                decimal? chosen = PromptForAmount();
                if (chosen == null)
                {
                    return;
                }
                decimal amount = chosen.Value;

                foreach (DataRow row in myAccounts.Rows)
                {
                    int accountId = Convert.ToInt32(row["ID"]);
                    decimal currentBalance = Convert.ToDecimal(BankAccount_BLL.Get_BkBalance(accountId));
                    BankAccount_BLL.Update_BankAccountBalance(accountId, currentBalance + amount);
                }

                // Atualiza a cópia em sessão para o Make_Order ver os novos saldos.
                BankAccountData.LoadBkAssociatedToUser();

                MessageBox.Show($"Foram adicionados {amount}€ (mock) à(s) sua(s) conta(s). Já pode pagar refeições.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao adicionar saldo (mock): {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    tbIban.Text = iban;
                    tbtbBankAccountID.Text = accountID.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro selecionando a tabela: {ex.Message}","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        //Helpers
        // Pede ao utilizador o valor a introduzir. Devolve null se cancelar ou se o valor for inválido.
        private decimal? PromptForAmount()
        {
            using (Form prompt = new Form())
            {
                prompt.Text = "Introduzir saldo";
                prompt.Width = 320;
                prompt.Height = 170;
                prompt.FormBorderStyle = FormBorderStyle.FixedDialog;
                prompt.StartPosition = FormStartPosition.CenterParent;
                prompt.MaximizeBox = false;
                prompt.MinimizeBox = false;
                prompt.ShowInTaskbar = false;

                Label label = new Label { Left = 15, Top = 15, Width = 280, Text = "Quanto deseja introduzir? (€)" };
                TextBox input = new TextBox { Left = 15, Top = 40, Width = 270 };
                Button ok = new Button { Text = "OK", Left = 128, Width = 70, Top = 75, DialogResult = DialogResult.OK };
                Button cancel = new Button { Text = "Cancelar", Left = 208, Width = 77, Top = 75, DialogResult = DialogResult.Cancel };

                prompt.Controls.Add(label);
                prompt.Controls.Add(input);
                prompt.Controls.Add(ok);
                prompt.Controls.Add(cancel);
                prompt.AcceptButton = ok;
                prompt.CancelButton = cancel;

                if (prompt.ShowDialog(this) != DialogResult.OK)
                {
                    return null;
                }

                // Aceita "," ou "." como separador decimal.
                string text = input.Text.Trim().Replace(',', '.');
                if (decimal.TryParse(text, System.Globalization.NumberStyles.Number, System.Globalization.CultureInfo.InvariantCulture, out decimal amount) && amount > 0)
                {
                    return amount;
                }

                MessageBox.Show("Valor inválido. Introduza um número maior que 0.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }
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
            tbIban.Clear();
            tbtbBankAccountID.Clear();

            dgvBankAccounts.Visible = false;
            LoadBkAccountData();
            dgvBankAccounts.Visible = true;
        }
        private void LbPassword_Click(object sender, EventArgs e)
        {
            if (lbPassword.Text.Contains("🔒"))
            {
                tbtbBankAccountID.PasswordChar = '\0';
                lbPassword.Text = "🔓";
            }
            else
            {
                tbtbBankAccountID.PasswordChar = '*';
                lbPassword.Text = "🔒";
            }
        }
    }
}
