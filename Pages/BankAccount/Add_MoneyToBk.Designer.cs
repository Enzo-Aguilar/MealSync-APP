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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_MoneyToBk));
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.tbAddedAmount = new System.Windows.Forms.TextBox();
            this.btnAddMoney = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(12, 51);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.Size = new System.Drawing.Size(575, 329);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBkAccounts_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.Color.Black;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.Color.White;
            this.tbSearch.Location = new System.Drawing.Point(760, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(256, 31);
            this.tbSearch.TabIndex = 1;
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbAccountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountOwner.Location = new System.Drawing.Point(642, 187);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(306, 31);
            this.tbAccountOwner.TabIndex = 3;
            // 
            // tbIban
            // 
            this.tbIban.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIban.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIban.Location = new System.Drawing.Point(642, 286);
            this.tbIban.Name = "tbIban";
            this.tbIban.ReadOnly = true;
            this.tbIban.Size = new System.Drawing.Size(306, 31);
            this.tbIban.TabIndex = 5;
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.BackColor = System.Drawing.Color.Black;
            this.tbBankAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankAccountID.ForeColor = System.Drawing.Color.White;
            this.tbBankAccountID.Location = new System.Drawing.Point(642, 372);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(199, 31);
            this.tbBankAccountID.TabIndex = 7;
            // 
            // tbAddedAmount
            // 
            this.tbAddedAmount.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbAddedAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddedAmount.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAddedAmount.Location = new System.Drawing.Point(642, 460);
            this.tbAddedAmount.Name = "tbAddedAmount";
            this.tbAddedAmount.Size = new System.Drawing.Size(199, 29);
            this.tbAddedAmount.TabIndex = 9;
            // 
            // btnAddMoney
            // 
            this.btnAddMoney.BackColor = System.Drawing.Color.Sienna;
            this.btnAddMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMoney.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddMoney.Location = new System.Drawing.Point(642, 527);
            this.btnAddMoney.Name = "btnAddMoney";
            this.btnAddMoney.Size = new System.Drawing.Size(166, 78);
            this.btnAddMoney.TabIndex = 13;
            this.btnAddMoney.Text = "Adicionar";
            this.btnAddMoney.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddMoney.UseVisualStyleBackColor = false;
            this.btnAddMoney.Click += new System.EventHandler(this.BtnAddMoney_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(825, 527);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(166, 78);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText.Location = new System.Drawing.Point(847, 462);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(23, 25);
            this.lbText.TabIndex = 15;
            this.lbText.Text = "€";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(875, 532);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 42);
            this.label3.TabIndex = 30;
            this.label3.Text = "🔄";
            this.label3.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(690, 533);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "➕";
            this.label1.Click += new System.EventHandler(this.BtnAddMoney_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(719, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(35, 31);
            this.lbInfo.TabIndex = 32;
            this.lbInfo.Text = "   ";
            this.lbInfo.Click += new System.EventHandler(this.LbInfo_Click);
            // 
            // Add_MoneyToBk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 661);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAddMoney);
            this.Controls.Add(this.tbAddedAmount);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.tbIban);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.dgvBankAccounts);
            this.MaximizeBox = false;
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
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.TextBox tbIban;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.TextBox tbAddedAmount;
        private System.Windows.Forms.Button btnAddMoney;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbInfo;
    }
}