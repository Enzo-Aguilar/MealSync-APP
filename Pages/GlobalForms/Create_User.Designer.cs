namespace MealSync_APP.Pages.GlobalForms
{
    partial class Create_User
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbPassword_Confirm = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lbConfirmar_Password = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(330, 336);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 54);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "Criar Conta";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Funcionario",
            "Aluno"});
            this.cbRole.Location = new System.Drawing.Point(159, 164);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(201, 21);
            this.cbRole.TabIndex = 36;
            // 
            // tbPassword_Confirm
            // 
            this.tbPassword_Confirm.Location = new System.Drawing.Point(405, 164);
            this.tbPassword_Confirm.Name = "tbPassword_Confirm";
            this.tbPassword_Confirm.Size = new System.Drawing.Size(201, 20);
            this.tbPassword_Confirm.TabIndex = 35;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(405, 71);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(201, 20);
            this.tbPassword.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(159, 246);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 20);
            this.tbName.TabIndex = 33;
            // 
            // lbConfirmar_Password
            // 
            this.lbConfirmar_Password.AutoSize = true;
            this.lbConfirmar_Password.Location = new System.Drawing.Point(455, 124);
            this.lbConfirmar_Password.Name = "lbConfirmar_Password";
            this.lbConfirmar_Password.Size = new System.Drawing.Size(100, 13);
            this.lbConfirmar_Password.TabIndex = 32;
            this.lbConfirmar_Password.Text = "Confirmar Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(159, 71);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(201, 20);
            this.tbEmail.TabIndex = 31;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(476, 31);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 30;
            this.lbPassword.Text = "Password";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(237, 215);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 29;
            this.lbNome.Text = "Nome";
            // 
            // lbFuncao
            // 
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Location = new System.Drawing.Point(221, 124);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(74, 13);
            this.lbFuncao.TabIndex = 28;
            this.lbFuncao.Text = "Tipo de Conta";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(240, 31);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 27;
            this.lbEmail.Text = "Email";
            // 
            // Create_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPassword_Confirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbConfirmar_Password);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbFuncao);
            this.Controls.Add(this.lbEmail);
            this.Name = "Create_User";
            this.Text = "Criar";
            this.Load += new System.EventHandler(this.Create_User_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbPassword_Confirm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lbConfirmar_Password;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbFuncao;
        private System.Windows.Forms.Label lbEmail;
    }
}