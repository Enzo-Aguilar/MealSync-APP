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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Associate_BankAccount));
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.btnAssociateAccount = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbAssociateBk = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbInfo = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbBankAccountId = new System.Windows.Forms.TextBox();
            this.tbIban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(12, 51);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersWidth = 51;
            this.dgvBankAccounts.Size = new System.Drawing.Size(536, 323);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbAccountOwner.Enabled = false;
            this.tbAccountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountOwner.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAccountOwner.Location = new System.Drawing.Point(609, 147);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(298, 30);
            this.tbAccountOwner.TabIndex = 1;
            // 
            // btnAssociateAccount
            // 
            this.btnAssociateAccount.BackColor = System.Drawing.Color.Sienna;
            this.btnAssociateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociateAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssociateAccount.Location = new System.Drawing.Point(762, 537);
            this.btnAssociateAccount.Name = "btnAssociateAccount";
            this.btnAssociateAccount.Size = new System.Drawing.Size(145, 72);
            this.btnAssociateAccount.TabIndex = 4;
            this.btnAssociateAccount.Text = "Associar";
            this.btnAssociateAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssociateAccount.UseVisualStyleBackColor = false;
            this.btnAssociateAccount.Click += new System.EventHandler(this.BtnAssociateAccount_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(603, 537);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 72);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(739, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(223, 30);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.BackColor = System.Drawing.Color.Sienna;
            this.lbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbUpdate.Location = new System.Drawing.Point(646, 540);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(54, 37);
            this.lbUpdate.TabIndex = 13;
            this.lbUpdate.Text = "🔄";
            this.lbUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbAssociateBk
            // 
            this.lbAssociateBk.AutoSize = true;
            this.lbAssociateBk.BackColor = System.Drawing.Color.Sienna;
            this.lbAssociateBk.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAssociateBk.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbAssociateBk.Location = new System.Drawing.Point(805, 544);
            this.lbAssociateBk.Name = "lbAssociateBk";
            this.lbAssociateBk.Size = new System.Drawing.Size(48, 33);
            this.lbAssociateBk.TabIndex = 14;
            this.lbAssociateBk.Text = "🔗‍";
            this.lbAssociateBk.Click += new System.EventHandler(this.BtnAssociateAccount_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPassword.Location = new System.Drawing.Point(917, 434);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(31, 24);
            this.lbPassword.TabIndex = 15;
            this.lbPassword.Text = "🔒";
            this.lbPassword.Click += new System.EventHandler(this.LbPassword_Click);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.BackColor = System.Drawing.Color.Transparent;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfo.Location = new System.Drawing.Point(698, 12);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(35, 31);
            this.lbInfo.TabIndex = 33;
            this.lbInfo.Text = "   ";
            this.lbInfo.Click += new System.EventHandler(this.LbInfo_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(609, 433);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(298, 30);
            this.tbPassword.TabIndex = 35;
            // 
            // tbBankAccountId
            // 
            this.tbBankAccountId.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbBankAccountId.Enabled = false;
            this.tbBankAccountId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankAccountId.ForeColor = System.Drawing.SystemColors.Window;
            this.tbBankAccountId.Location = new System.Drawing.Point(609, 337);
            this.tbBankAccountId.Name = "tbBankAccountId";
            this.tbBankAccountId.ReadOnly = true;
            this.tbBankAccountId.Size = new System.Drawing.Size(298, 30);
            this.tbBankAccountId.TabIndex = 38;
            // 
            // tbIban
            // 
            this.tbIban.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbIban.Enabled = false;
            this.tbIban.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIban.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIban.Location = new System.Drawing.Point(609, 243);
            this.tbIban.Name = "tbIban";
            this.tbIban.ReadOnly = true;
            this.tbIban.Size = new System.Drawing.Size(298, 30);
            this.tbIban.TabIndex = 39;
            // 
            // Associate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 643);
            this.Controls.Add(this.tbIban);
            this.Controls.Add(this.tbBankAccountId);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbAssociateBk);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAssociateAccount);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button btnAssociateAccount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbAssociateBk;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbBankAccountId;
        private System.Windows.Forms.TextBox tbIban;
    }
}