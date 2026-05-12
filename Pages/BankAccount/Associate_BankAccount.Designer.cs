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
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnAssociateAccount = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(12, 80);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersWidth = 51;
            this.dgvBankAccounts.Size = new System.Drawing.Size(449, 237);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbAccountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountOwner.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAccountOwner.Location = new System.Drawing.Point(569, 199);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(460, 35);
            this.tbAccountOwner.TabIndex = 1;
            // 
            // tbIBAN
            // 
            this.tbIBAN.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIBAN.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIBAN.Location = new System.Drawing.Point(569, 456);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.ReadOnly = true;
            this.tbIBAN.Size = new System.Drawing.Size(460, 35);
            this.tbIBAN.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(569, 370);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(460, 35);
            this.tbPassword.TabIndex = 3;
            // 
            // btnAssociateAccount
            // 
            this.btnAssociateAccount.BackColor = System.Drawing.Color.Sienna;
            this.btnAssociateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssociateAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssociateAccount.Location = new System.Drawing.Point(63, 478);
            this.btnAssociateAccount.Name = "btnAssociateAccount";
            this.btnAssociateAccount.Size = new System.Drawing.Size(170, 70);
            this.btnAssociateAccount.TabIndex = 4;
            this.btnAssociateAccount.Text = "Associar";
            this.btnAssociateAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssociateAccount.UseVisualStyleBackColor = false;
            this.btnAssociateAccount.Click += new System.EventHandler(this.BtnAssociateAccount_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(245, 478);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(169, 70);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbBankAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankAccountID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbBankAccountID.Location = new System.Drawing.Point(569, 284);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(460, 35);
            this.tbBankAccountID.TabIndex = 10;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(569, 114);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(310, 35);
            this.tbSearch.TabIndex = 12;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(304, 483);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "🔄";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(127, 488);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 33);
            this.label2.TabIndex = 14;
            this.label2.Text = "🔗‍";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1048, 463);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "👁️";
            // 
            // Associate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1189, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAssociateAccount);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
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
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}