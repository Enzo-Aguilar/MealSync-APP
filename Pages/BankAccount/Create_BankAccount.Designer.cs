namespace MealSync_APP._Conta_Bancaria
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
            this.btnCreate_BankAccount = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate_BankAccount
            // 
            this.btnCreate_BankAccount.Location = new System.Drawing.Point(298, 356);
            this.btnCreate_BankAccount.Name = "btnCreate_BankAccount";
            this.btnCreate_BankAccount.Size = new System.Drawing.Size(108, 58);
            this.btnCreate_BankAccount.TabIndex = 0;
            this.btnCreate_BankAccount.Text = "Criar";
            this.btnCreate_BankAccount.UseVisualStyleBackColor = true;
            this.btnCreate_BankAccount.Click += new System.EventHandler(this.btnCreate_BankAccount_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(443, 49);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(247, 20);
            this.tbPassword.TabIndex = 1;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.Location = new System.Drawing.Point(443, 144);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.Size = new System.Drawing.Size(247, 20);
            this.tbPasswordConfirm.TabIndex = 2;
            // 
            // Create_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnCreate_BankAccount);
            this.Name = "Create_BankAccount";
            this.Text = "Criar_ContaBancaria";
            this.Load += new System.EventHandler(this.Create_BankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate_BankAccount;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
    }
}