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
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.cbAccountType = new System.Windows.Forms.ComboBox();
            this.linkLabelAssociateBankAccount = new System.Windows.Forms.LinkLabel();
            this.lbPIN = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.lbPINConfirm = new System.Windows.Forms.Label();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnCreateBankAccount = new System.Windows.Forms.Button();
            this.checkBoxPasswordConfirm = new System.Windows.Forms.CheckBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(48, 160);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(178, 20);
            this.tbPassword.TabIndex = 0;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(99, 21);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(77, 13);
            this.lbAccountType.TabIndex = 1;
            this.lbAccountType.Text = "Tipo de Conta:";
            // 
            // cbAccountType
            // 
            this.cbAccountType.FormattingEnabled = true;
            this.cbAccountType.Items.AddRange(new object[] {
            "Coletiva",
            "Individual"});
            this.cbAccountType.Location = new System.Drawing.Point(48, 56);
            this.cbAccountType.Name = "cbAccountType";
            this.cbAccountType.Size = new System.Drawing.Size(178, 21);
            this.cbAccountType.TabIndex = 2;
            // 
            // linkLabelAssociateBankAccount
            // 
            this.linkLabelAssociateBankAccount.AutoSize = true;
            this.linkLabelAssociateBankAccount.Location = new System.Drawing.Point(199, 405);
            this.linkLabelAssociateBankAccount.Name = "linkLabelAssociateBankAccount";
            this.linkLabelAssociateBankAccount.Size = new System.Drawing.Size(47, 13);
            this.linkLabelAssociateBankAccount.TabIndex = 3;
            this.linkLabelAssociateBankAccount.TabStop = true;
            this.linkLabelAssociateBankAccount.Text = "Associar";
            this.linkLabelAssociateBankAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAssociateBankAccount_LinkClicked);
            // 
            // lbPIN
            // 
            this.lbPIN.AutoSize = true;
            this.lbPIN.Location = new System.Drawing.Point(99, 131);
            this.lbPIN.Name = "lbPIN";
            this.lbPIN.Size = new System.Drawing.Size(78, 13);
            this.lbPIN.TabIndex = 4;
            this.lbPIN.Text = "Palavra-Passe:";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(29, 405);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(164, 13);
            this.lbText.TabIndex = 5;
            this.lbText.Text = "Deseja associar-se a uma conta?";
            // 
            // lbPINConfirm
            // 
            this.lbPINConfirm.AutoSize = true;
            this.lbPINConfirm.Location = new System.Drawing.Point(74, 228);
            this.lbPINConfirm.Name = "lbPINConfirm";
            this.lbPINConfirm.Size = new System.Drawing.Size(125, 13);
            this.lbPINConfirm.TabIndex = 7;
            this.lbPINConfirm.Text = "Confirmar Palavra-Passe:";
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(48, 258);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '*';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(178, 20);
            this.tbPasswordConfirm.TabIndex = 6;
            // 
            // btnCreateBankAccount
            // 
            this.btnCreateBankAccount.Location = new System.Drawing.Point(86, 318);
            this.btnCreateBankAccount.Name = "btnCreateBankAccount";
            this.btnCreateBankAccount.Size = new System.Drawing.Size(90, 41);
            this.btnCreateBankAccount.TabIndex = 8;
            this.btnCreateBankAccount.Text = "Criar";
            this.btnCreateBankAccount.UseVisualStyleBackColor = true;
            this.btnCreateBankAccount.Click += new System.EventHandler(this.BtnCreate_BankAccount_Click);
            // 
            // checkBoxPasswordConfirm
            // 
            this.checkBoxPasswordConfirm.AutoSize = true;
            this.checkBoxPasswordConfirm.Location = new System.Drawing.Point(234, 263);
            this.checkBoxPasswordConfirm.Name = "checkBoxPasswordConfirm";
            this.checkBoxPasswordConfirm.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPasswordConfirm.TabIndex = 9;
            this.checkBoxPasswordConfirm.UseVisualStyleBackColor = true;
            this.checkBoxPasswordConfirm.CheckedChanged += new System.EventHandler(this.CheckBoxPasswordConfirm_CheckedChanged);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(234, 166);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 10;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.CheckBoxPassword_CheckedChanged);
            // 
            // Create_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 450);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.checkBoxPasswordConfirm);
            this.Controls.Add(this.btnCreateBankAccount);
            this.Controls.Add(this.lbPINConfirm);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbPIN);
            this.Controls.Add(this.linkLabelAssociateBankAccount);
            this.Controls.Add(this.cbAccountType);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.tbPassword);
            this.Name = "Create_BankAccount";
            this.Text = "Criar Conta Bancaria";
            this.Load += new System.EventHandler(this.Create_BankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.ComboBox cbAccountType;
        private System.Windows.Forms.LinkLabel linkLabelAssociateBankAccount;
        private System.Windows.Forms.Label lbPIN;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbPINConfirm;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Button btnCreateBankAccount;
        private System.Windows.Forms.CheckBox checkBoxPasswordConfirm;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}