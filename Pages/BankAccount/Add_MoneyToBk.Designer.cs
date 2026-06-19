namespace MealSync_APP.Pages.BankAccountFolder
{
    partial class Add_MoneyToBk
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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbBkOwner = new System.Windows.Forms.Label();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.lbIban = new System.Windows.Forms.Label();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.lbBkID = new System.Windows.Forms.Label();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.lbAddedAmount = new System.Windows.Forms.Label();
            this.tbAddedAmount = new System.Windows.Forms.TextBox();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(12, 25);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.Size = new System.Drawing.Size(367, 364);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBkAccounts_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(601, 18);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(199, 20);
            this.tbSearch.TabIndex = 1;
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(464, 25);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(131, 13);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Procurar (ID do Utilizador):";
            // 
            // lbBkOwner
            // 
            this.lbBkOwner.AutoSize = true;
            this.lbBkOwner.Location = new System.Drawing.Point(402, 74);
            this.lbBkOwner.Name = "lbBkOwner";
            this.lbBkOwner.Size = new System.Drawing.Size(82, 13);
            this.lbBkOwner.TabIndex = 4;
            this.lbBkOwner.Text = "Dono da Conta:";
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.Location = new System.Drawing.Point(405, 99);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(321, 20);
            this.tbAccountOwner.TabIndex = 3;
            // 
            // lbIban
            // 
            this.lbIban.AutoSize = true;
            this.lbIban.Location = new System.Drawing.Point(402, 134);
            this.lbIban.Name = "lbIban";
            this.lbIban.Size = new System.Drawing.Size(35, 13);
            this.lbIban.TabIndex = 6;
            this.lbIban.Text = "IBAN:";
            // 
            // tbIban
            // 
            this.tbIban.Location = new System.Drawing.Point(405, 159);
            this.tbIban.Name = "tbIban";
            this.tbIban.ReadOnly = true;
            this.tbIban.Size = new System.Drawing.Size(321, 20);
            this.tbIban.TabIndex = 5;
            // 
            // lbBkID
            // 
            this.lbBkID.AutoSize = true;
            this.lbBkID.Location = new System.Drawing.Point(402, 193);
            this.lbBkID.Name = "lbBkID";
            this.lbBkID.Size = new System.Drawing.Size(66, 13);
            this.lbBkID.TabIndex = 8;
            this.lbBkID.Text = "ID da conta:";
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.Location = new System.Drawing.Point(405, 221);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(321, 20);
            this.tbBankAccountID.TabIndex = 7;
            // 
            // lbAddedAmount
            // 
            this.lbAddedAmount.AutoSize = true;
            this.lbAddedAmount.Location = new System.Drawing.Point(402, 356);
            this.lbAddedAmount.Name = "lbAddedAmount";
            this.lbAddedAmount.Size = new System.Drawing.Size(103, 13);
            this.lbAddedAmount.TabIndex = 10;
            this.lbAddedAmount.Text = "Quantia a Adicionar:";
            // 
            // tbAddedAmount
            // 
            this.tbAddedAmount.Location = new System.Drawing.Point(511, 356);
            this.tbAddedAmount.Name = "tbAddedAmount";
            this.tbAddedAmount.Size = new System.Drawing.Size(168, 20);
            this.tbAddedAmount.TabIndex = 9;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.Location = new System.Drawing.Point(225, 417);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(113, 57);
            this.btnAddMoney.TabIndex = 13;
            this.btnAddMoney.Text = "Adicionar";
            this.btnAddMoney.UseVisualStyleBackColor = true;
            this.btnAddMoney.Click += new System.EventHandler(this.BtnAddMoney_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(457, 416);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(113, 57);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(685, 359);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(13, 13);
            this.lbText.TabIndex = 15;
            this.lbText.Text = "€";
            // 
            // Add_MoneyToBk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.lbAddedAmount);
            this.Controls.Add(this.tbAddedAmount);
            this.Controls.Add(this.lbBkID);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.lbIban);
            this.Controls.Add(this.tbIban);
            this.Controls.Add(this.lbBkOwner);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvBankAccounts);
            this.Name = "Add_MoneyToBk";
            this.Text = "Add_MoneyToBk";
            this.Load += new System.EventHandler(this.Add_MoneyToBk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbBkOwner;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.Label lbIban;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.Label lbBkID;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.Label lbAddedAmount;
        private System.Windows.Forms.TextBox tbAddedAmount;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
    }
}