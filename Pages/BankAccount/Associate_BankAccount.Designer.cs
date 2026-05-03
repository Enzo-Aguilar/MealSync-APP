namespace MealSync_APP.BankAccountFolder
{
    partial class Associate_BankAccount
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
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAssociateAccount = new System.Windows.Forms.Button();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbIBAN = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.lbBankAccountID = new System.Windows.Forms.Label();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(24, 18);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.Size = new System.Drawing.Size(403, 324);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.Location = new System.Drawing.Point(484, 117);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(272, 20);
            this.tbAccountOwner.TabIndex = 1;
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(484, 270);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.ReadOnly = true;
            this.tbIBAN.Size = new System.Drawing.Size(272, 20);
            this.tbIBAN.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(484, 354);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(272, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnAssociateAccount
            // 
            this.btnAssociateAccount.Location = new System.Drawing.Point(52, 374);
            this.btnAssociateAccount.Name = "btnAssociateAccount";
            this.btnAssociateAccount.Size = new System.Drawing.Size(170, 64);
            this.btnAssociateAccount.TabIndex = 4;
            this.btnAssociateAccount.Text = "Associar";
            this.btnAssociateAccount.UseVisualStyleBackColor = true;
            this.btnAssociateAccount.Click += new System.EventHandler(this.BtnAssociateAccount_Click);
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(572, 89);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(82, 13);
            this.lbOwner.TabIndex = 5;
            this.lbOwner.Text = "Dono da Conta:";
            // 
            // lbIBAN
            // 
            this.lbIBAN.AutoSize = true;
            this.lbIBAN.Location = new System.Drawing.Point(596, 245);
            this.lbIBAN.Name = "lbIBAN";
            this.lbIBAN.Size = new System.Drawing.Size(35, 13);
            this.lbIBAN.TabIndex = 6;
            this.lbIBAN.Text = "IBAN:";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(587, 326);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 7;
            this.lbPassword.Text = "Password:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(228, 374);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 64);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(762, 357);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 9;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // lbBankAccountID
            // 
            this.lbBankAccountID.AutoSize = true;
            this.lbBankAccountID.Location = new System.Drawing.Point(587, 159);
            this.lbBankAccountID.Name = "lbBankAccountID";
            this.lbBankAccountID.Size = new System.Drawing.Size(67, 13);
            this.lbBankAccountID.TabIndex = 11;
            this.lbBankAccountID.Text = "ID da Conta:";
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.Location = new System.Drawing.Point(484, 190);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(272, 20);
            this.tbBankAccountID.TabIndex = 10;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(606, 21);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(50, 13);
            this.lbSearch.TabIndex = 13;
            this.lbSearch.Text = "Procurar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(662, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // Associate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbBankAccountID);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbIBAN);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.btnAssociateAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.Name = "Associate_BankAccount";
            this.Text = "Associar Conta Bancaria";
            this.Load += new System.EventHandler(this.Associate_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnAssociateAccount;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbIBAN;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Label lbBankAccountID;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}