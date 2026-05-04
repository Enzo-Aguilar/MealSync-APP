namespace MealSync_APP.Pages.BankAccountFolder
{
    partial class Deactivate_BankAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbBankAccountID = new System.Windows.Forms.Label();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbIBAN = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.btnDesassociateAccount = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(795, 22);
            this.lbSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 16);
            this.lbSearch.TabIndex = 27;
            this.lbSearch.Text = "Procurar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(869, 18);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 22);
            this.tbSearch.TabIndex = 26;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbBankAccountID
            // 
            this.lbBankAccountID.AutoSize = true;
            this.lbBankAccountID.Location = new System.Drawing.Point(769, 192);
            this.lbBankAccountID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBankAccountID.Name = "lbBankAccountID";
            this.lbBankAccountID.Size = new System.Drawing.Size(80, 16);
            this.lbBankAccountID.TabIndex = 25;
            this.lbBankAccountID.Text = "ID da Conta:";
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.Location = new System.Drawing.Point(632, 230);
            this.tbBankAccountID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(361, 22);
            this.tbBankAccountID.TabIndex = 24;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(1003, 436);
            this.checkBoxPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(18, 17);
            this.checkBoxPassword.TabIndex = 23;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(314, 448);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 79);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(769, 398);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(70, 16);
            this.lbPassword.TabIndex = 21;
            this.lbPassword.Text = "Password:";
            // 
            // lbIBAN
            // 
            this.lbIBAN.AutoSize = true;
            this.lbIBAN.Location = new System.Drawing.Point(781, 298);
            this.lbIBAN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIBAN.Name = "lbIBAN";
            this.lbIBAN.Size = new System.Drawing.Size(41, 16);
            this.lbIBAN.TabIndex = 20;
            this.lbIBAN.Text = "IBAN:";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(749, 106);
            this.lbOwner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(100, 16);
            this.lbOwner.TabIndex = 19;
            this.lbOwner.Text = "Dono da Conta:";
            // 
            // btnDesassociateAccount
            // 
            this.btnDesassociateAccount.Location = new System.Drawing.Point(118, 448);
            this.btnDesassociateAccount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDesassociateAccount.Name = "btnDesassociateAccount";
            this.btnDesassociateAccount.Size = new System.Drawing.Size(149, 79);
            this.btnDesassociateAccount.TabIndex = 18;
            this.btnDesassociateAccount.Text = "Desativar conta";
            this.btnDesassociateAccount.UseVisualStyleBackColor = true;
            this.btnDesassociateAccount.Click += new System.EventHandler(this.BtnDeactivateAccount_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(632, 432);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(361, 22);
            this.tbPassword.TabIndex = 17;
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(632, 329);
            this.tbIBAN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.ReadOnly = true;
            this.tbIBAN.Size = new System.Drawing.Size(361, 22);
            this.tbIBAN.TabIndex = 16;
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.Location = new System.Drawing.Point(632, 140);
            this.tbAccountOwner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(361, 22);
            this.tbAccountOwner.TabIndex = 15;
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(19, 18);
            this.dgvBankAccounts.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersWidth = 51;
            this.dgvBankAccounts.Size = new System.Drawing.Size(537, 399);
            this.dgvBankAccounts.TabIndex = 14;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // Deactivate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbBankAccountID);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbIBAN);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.btnDesassociateAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Deactivate_BankAccount";
            this.Text = "Desativar conta bancaria";
            this.Load += new System.EventHandler(this.Deactivate_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbBankAccountID;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbIBAN;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Button btnDesassociateAccount;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.DataGridView dgvBankAccounts;
    }
}