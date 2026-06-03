namespace MealSync_APP.Pages.BankAccountFolder
{
    partial class Transactions_BankAccount
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
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbBankAccount = new System.Windows.Forms.Label();
            this.lbTrasactions = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(31, 108);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.Size = new System.Drawing.Size(330, 387);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellContentClick);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(455, 108);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.Size = new System.Drawing.Size(381, 385);
            this.dgvTransaction.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 522);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(122, 77);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbBankAccount
            // 
            this.lbBankAccount.AutoSize = true;
            this.lbBankAccount.Location = new System.Drawing.Point(116, 80);
            this.lbBankAccount.Name = "lbBankAccount";
            this.lbBankAccount.Size = new System.Drawing.Size(150, 13);
            this.lbBankAccount.TabIndex = 4;
            this.lbBankAccount.Text = "Contas Bancarias Associadas:";
            // 
            // lbTrasactions
            // 
            this.lbTrasactions.AutoSize = true;
            this.lbTrasactions.Location = new System.Drawing.Point(603, 80);
            this.lbTrasactions.Name = "lbTrasactions";
            this.lbTrasactions.Size = new System.Drawing.Size(63, 13);
            this.lbTrasactions.TabIndex = 5;
            this.lbTrasactions.Text = "Transações";
            // 
            // Transactions_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 611);
            this.Controls.Add(this.lbTrasactions);
            this.Controls.Add(this.lbBankAccount);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.dgvBankAccounts);
            this.Name = "Transactions_BankAccount";
            this.Text = "Transactions_BankAccount";
            this.Load += new System.EventHandler(this.Transactions_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbBankAccount;
        private System.Windows.Forms.Label lbTrasactions;
    }
}