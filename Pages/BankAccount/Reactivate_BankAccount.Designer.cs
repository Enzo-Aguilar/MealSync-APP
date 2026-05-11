namespace MealSync_APP.Pages.BankAccountFolder
{
    partial class Reactivate_BankAccount
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
            this.btnDeactivatedAccounts = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbBankAccountID = new System.Windows.Forms.Label();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbIBAN = new System.Windows.Forms.Label();
            this.lbOwner = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivatedAccounts
            // 
            this.btnDeactivatedAccounts.Location = new System.Drawing.Point(72, 368);
            this.btnDeactivatedAccounts.Name = "btnDeactivatedAccounts";
            this.btnDeactivatedAccounts.Size = new System.Drawing.Size(112, 64);
            this.btnDeactivatedAccounts.TabIndex = 43;
            this.btnDeactivatedAccounts.Text = "Reativar";
            this.btnDeactivatedAccounts.UseVisualStyleBackColor = true;
            this.btnDeactivatedAccounts.Click += new System.EventHandler(this.BtnReactivateAccounts_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(596, 22);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(50, 13);
            this.lbSearch.TabIndex = 42;
            this.lbSearch.Text = "Procurar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(652, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(135, 20);
            this.tbSearch.TabIndex = 41;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbBankAccountID
            // 
            this.lbBankAccountID.AutoSize = true;
            this.lbBankAccountID.Location = new System.Drawing.Point(577, 160);
            this.lbBankAccountID.Name = "lbBankAccountID";
            this.lbBankAccountID.Size = new System.Drawing.Size(67, 13);
            this.lbBankAccountID.TabIndex = 40;
            this.lbBankAccountID.Text = "ID da Conta:";
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.Location = new System.Drawing.Point(474, 191);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(272, 20);
            this.tbBankAccountID.TabIndex = 39;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(752, 358);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 38;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(247, 368);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 64);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(577, 327);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(56, 13);
            this.lbPassword.TabIndex = 36;
            this.lbPassword.Text = "Password:";
            // 
            // lbIBAN
            // 
            this.lbIBAN.AutoSize = true;
            this.lbIBAN.Location = new System.Drawing.Point(586, 246);
            this.lbIBAN.Name = "lbIBAN";
            this.lbIBAN.Size = new System.Drawing.Size(35, 13);
            this.lbIBAN.TabIndex = 35;
            this.lbIBAN.Text = "IBAN:";
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(562, 90);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(82, 13);
            this.lbOwner.TabIndex = 34;
            this.lbOwner.Text = "Dono da Conta:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(474, 355);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(272, 20);
            this.tbPassword.TabIndex = 32;
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(474, 271);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.ReadOnly = true;
            this.tbIBAN.Size = new System.Drawing.Size(272, 20);
            this.tbIBAN.TabIndex = 31;
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.Location = new System.Drawing.Point(474, 118);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(272, 20);
            this.tbAccountOwner.TabIndex = 30;
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(14, 19);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersWidth = 51;
            this.dgvBankAccounts.Size = new System.Drawing.Size(403, 324);
            this.dgvBankAccounts.TabIndex = 29;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // Reactivate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeactivatedAccounts);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbBankAccountID);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbIBAN);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.Name = "Reactivate_BankAccount";
            this.Text = "Reativar conta";
            this.Load += new System.EventHandler(this.Reactivate_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivatedAccounts;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbBankAccountID;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbIBAN;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.DataGridView dgvBankAccounts;
    }
}