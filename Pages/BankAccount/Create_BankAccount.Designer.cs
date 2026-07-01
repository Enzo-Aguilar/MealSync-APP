namespace MealSync_APP.BankAccountFolder
{
    partial class Create_BankAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_BankAccount));
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.linkLabelAssociateBankAccount = new System.Windows.Forms.LinkLabel();
            this.lbText = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnCreateBankAccount = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbPasswordConfirm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(82, 207);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(219, 34);
            this.tbPassword.TabIndex = 0;
            // 
            // cbAccountType
            // 
            this.cbAccountType.BackColor = System.Drawing.SystemColors.InfoText;
            this.cbAccountType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAccountType.ForeColor = System.Drawing.SystemColors.Window;
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Coletiva",
            "Individual"});
            this.cbAccountType.Location = new System.Drawing.Point(82, 116);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(219, 32);
            this.cbAccountType.TabIndex = 2;
            // 
            // linkLabelAssociateBankAccount
            // 
            this.linkLabelAssociateBankAccount.AutoSize = true;
            this.linkLabelAssociateBankAccount.BackColor = System.Drawing.Color.Transparent;
            this.linkLabelAssociateBankAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.linkLabelAssociateBankAccount.LinkColor = System.Drawing.Color.Snow;
            this.linkLabelAssociateBankAccount.Location = new System.Drawing.Point(254, 438);
            this.linkLabelAssociateBankAccount.Name = "linkLabelAssociateBankAccount";
            this.linkLabelAssociateBankAccount.Size = new System.Drawing.Size(47, 13);
            this.linkLabelAssociateBankAccount.TabIndex = 3;
            this.linkLabelAssociateBankAccount.TabStop = true;
            this.linkLabelAssociateBankAccount.Text = "Associar";
            this.linkLabelAssociateBankAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAssociateBankAccount_LinkClicked);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbText.Location = new System.Drawing.Point(79, 438);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(164, 13);
            this.lbText.TabIndex = 5;
            this.lbText.Text = "Deseja associar-se a uma conta?";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordConfirm.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPasswordConfirm.Location = new System.Drawing.Point(82, 300);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '*';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(219, 34);
            this.tbPasswordConfirm.TabIndex = 6;
            // 
            // btnCreateBankAccount
            // 
            this.btnCreateBankAccount.BackColor = System.Drawing.Color.Sienna;
            this.btnCreateBankAccount.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreateBankAccount.Location = new System.Drawing.Point(127, 362);
            this.btnCreateBankAccount.Name = "btnCreateBankAccount";
            this.btnCreateBankAccount.Size = new System.Drawing.Size(134, 41);
            this.btnCreateBankAccount.TabIndex = 8;
            this.btnCreateBankAccount.Text = "Criar";
            this.btnCreateBankAccount.UseVisualStyleBackColor = false;
            this.btnCreateBankAccount.Click += new System.EventHandler(this.BtnCreate_BankAccount_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPassword.Location = new System.Drawing.Point(307, 213);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(34, 25);
            this.lbPassword.TabIndex = 9;
            this.lbPassword.Text = "🔒";
            this.lbPassword.Click += new System.EventHandler(this.LbPassword_Click);
            // 
            // lbPasswordConfirm
            // 
            this.lbPasswordConfirm.AutoSize = true;
            this.lbPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPasswordConfirm.Location = new System.Drawing.Point(302, 306);
            this.lbPasswordConfirm.Name = "lbPasswordConfirm";
            this.lbPasswordConfirm.Size = new System.Drawing.Size(34, 25);
            this.lbPasswordConfirm.TabIndex = 10;
            this.lbPasswordConfirm.Text = "🔒";
            this.lbPasswordConfirm.Click += new System.EventHandler(this.LbPasswordConfirm_Click);
            // 
            // Create_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(379, 530);
            this.Controls.Add(this.lbPasswordConfirm);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btnCreateBankAccount);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.linkLabelAssociateBankAccount);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.tbPassword);
            this.MinimizeBox = false;
            this.Name = "Create_BankAccount";
            this.Text = "Criar Conta Bancaria";
            this.Load += new System.EventHandler(this.Create_BankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.LinkLabel linkLabelAssociateBankAccount;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Button btnCreateBankAccount;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbPasswordConfirm;
    }
}