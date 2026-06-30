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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reactivate_BankAccount));
            this.btnDeactivatedAccounts = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.tbBankAccountID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.lbPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeactivatedAccounts
            // 
            this.btnDeactivatedAccounts.BackColor = System.Drawing.Color.Sienna;
            this.btnDeactivatedAccounts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivatedAccounts.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeactivatedAccounts.Location = new System.Drawing.Point(593, 534);
            this.btnDeactivatedAccounts.Name = "btnDeactivatedAccounts";
            this.btnDeactivatedAccounts.Size = new System.Drawing.Size(138, 69);
            this.btnDeactivatedAccounts.TabIndex = 43;
            this.btnDeactivatedAccounts.Text = "Reativar";
            this.btnDeactivatedAccounts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivatedAccounts.UseVisualStyleBackColor = false;
            this.btnDeactivatedAccounts.Click += new System.EventHandler(this.BtnReactivateAccounts_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(729, 12);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(218, 30);
            this.tbSearch.TabIndex = 41;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // tbBankAccountID
            // 
            this.tbBankAccountID.BackColor = System.Drawing.SystemColors.ControlText;
            this.tbBankAccountID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBankAccountID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbBankAccountID.Location = new System.Drawing.Point(600, 269);
            this.tbBankAccountID.Name = "tbBankAccountID";
            this.tbBankAccountID.ReadOnly = true;
            this.tbBankAccountID.Size = new System.Drawing.Size(279, 30);
            this.tbBankAccountID.TabIndex = 39;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(747, 534);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 69);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(600, 472);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(233, 30);
            this.tbPassword.TabIndex = 32;
            // 
            // tbIBAN
            // 
            this.tbIBAN.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbIBAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIBAN.ForeColor = System.Drawing.SystemColors.Window;
            this.tbIBAN.Location = new System.Drawing.Point(600, 366);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.ReadOnly = true;
            this.tbIBAN.Size = new System.Drawing.Size(279, 30);
            this.tbIBAN.TabIndex = 31;
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbAccountOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAccountOwner.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAccountOwner.Location = new System.Drawing.Point(600, 173);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.ReadOnly = true;
            this.tbAccountOwner.Size = new System.Drawing.Size(279, 30);
            this.tbAccountOwner.TabIndex = 30;
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.Location = new System.Drawing.Point(12, 52);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.RowHeadersWidth = 51;
            this.dgvBankAccounts.Size = new System.Drawing.Size(535, 317);
            this.dgvBankAccounts.TabIndex = 29;
            this.dgvBankAccounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellClick);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbPassword.Location = new System.Drawing.Point(839, 476);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(20, 24);
            this.lbPassword.TabIndex = 44;
            this.lbPassword.Text = "€";
            this.lbPassword.Click += new System.EventHandler(this.LbPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(787, 538);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 37);
            this.label2.TabIndex = 47;
            this.label2.Text = "🔄";
            this.label2.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(636, 538);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 37);
            this.label3.TabIndex = 48;
            this.label3.Text = "🔓";
            this.label3.Click += new System.EventHandler(this.BtnReactivateAccounts_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(688, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 31);
            this.label1.TabIndex = 49;
            this.label1.Text = "   ";
            // 
            // Reactivate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 651);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnDeactivatedAccounts);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbBankAccountID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dgvBankAccounts);
            this.MinimizeBox = false;
            this.Name = "Reactivate_BankAccount";
            this.Text = "Reativar conta";
            this.Load += new System.EventHandler(this.Reactivate_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeactivatedAccounts;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.TextBox tbBankAccountID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}