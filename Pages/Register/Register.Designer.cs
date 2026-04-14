namespace MealSync_APP
{
    partial class Register
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbFuncao = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbConfirmar_Password = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPassword_Confirm = new System.Windows.Forms.TextBox();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.btnCriar_Conta = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.lbLink_Index = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(127, 39);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbFuncao
            // 
            this.lbFuncao.AutoSize = true;
            this.lbFuncao.Location = new System.Drawing.Point(108, 132);
            this.lbFuncao.Name = "lbFuncao";
            this.lbFuncao.Size = new System.Drawing.Size(74, 13);
            this.lbFuncao.TabIndex = 1;
            this.lbFuncao.Text = "Tipo de Conta";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(124, 223);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(363, 39);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(46, 79);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(201, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // lbConfirmar_Password
            // 
            this.lbConfirmar_Password.AutoSize = true;
            this.lbConfirmar_Password.Location = new System.Drawing.Point(342, 132);
            this.lbConfirmar_Password.Name = "lbConfirmar_Password";
            this.lbConfirmar_Password.Size = new System.Drawing.Size(100, 13);
            this.lbConfirmar_Password.TabIndex = 6;
            this.lbConfirmar_Password.Text = "Confirmar Password";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(46, 254);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(292, 79);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(201, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbPassword_Confirm
            // 
            this.tbPassword_Confirm.Location = new System.Drawing.Point(292, 172);
            this.tbPassword_Confirm.Name = "tbPassword_Confirm";
            this.tbPassword_Confirm.Size = new System.Drawing.Size(201, 20);
            this.tbPassword_Confirm.TabIndex = 9;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Aluno",
            "Funcionario",
            "Administrador"});
            this.cbRole.Location = new System.Drawing.Point(46, 172);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(201, 21);
            this.cbRole.TabIndex = 10;
            // 
            // btnCriar_Conta
            // 
            this.btnCriar_Conta.Location = new System.Drawing.Point(230, 317);
            this.btnCriar_Conta.Name = "btnCriar_Conta";
            this.btnCriar_Conta.Size = new System.Drawing.Size(141, 54);
            this.btnCriar_Conta.TabIndex = 11;
            this.btnCriar_Conta.Text = "Criar Conta";
            this.btnCriar_Conta.UseVisualStyleBackColor = true;
            this.btnCriar_Conta.Click += new System.EventHandler(this.btnCriar_Conta_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(85, 396);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(74, 13);
            this.lbText.TabIndex = 12;
            this.lbText.Text = "Já tem conta?";
            // 
            // lbLink_Index
            // 
            this.lbLink_Index.AutoSize = true;
            this.lbLink_Index.Location = new System.Drawing.Point(165, 396);
            this.lbLink_Index.Name = "lbLink_Index";
            this.lbLink_Index.Size = new System.Drawing.Size(73, 13);
            this.lbLink_Index.TabIndex = 13;
            this.lbLink_Index.TabStop = true;
            this.lbLink_Index.Text = "Iniciar Sessão";
            this.lbLink_Index.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbLink_Index_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbLink_Index);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnCriar_Conta);
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
            this.Name = "Register";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbFuncao;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbConfirmar_Password;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPassword_Confirm;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Button btnCriar_Conta;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.LinkLabel lbLink_Index;
    }
}