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
            this.lbNome = new System.Windows.Forms.Label();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbConfirmar_Password = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPassword_Confirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.lbLink_Index = new System.Windows.Forms.LinkLabel();
            this.tbIDNumber = new System.Windows.Forms.TextBox();
            this.lbIDNumber = new System.Windows.Forms.Label();
            this.lbPostcode = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.lbPhoneNumber = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.checkBoxPasswordConfirm = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(89, 25);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Location = new System.Drawing.Point(86, 127);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(35, 13);
            this.lbNome.TabIndex = 2;
            this.lbNome.Text = "Nome";
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(86, 224);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 3;
            this.lbPassword.Text = "Password";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(12, 65);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(201, 20);
            this.tbEmail.TabIndex = 5;
            // 
            // lbConfirmar_Password
            // 
            this.lbConfirmar_Password.AutoSize = true;
            this.lbConfirmar_Password.Location = new System.Drawing.Point(294, 224);
            this.lbConfirmar_Password.Name = "lbConfirmar_Password";
            this.lbConfirmar_Password.Size = new System.Drawing.Size(100, 13);
            this.lbConfirmar_Password.TabIndex = 6;
            this.lbConfirmar_Password.Text = "Confirmar Password";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(12, 161);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 20);
            this.tbName.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(12, 254);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(201, 20);
            this.tbPassword.TabIndex = 8;
            // 
            // tbPassword_Confirm
            // 
            this.tbPassword_Confirm.Location = new System.Drawing.Point(244, 254);
            this.tbPassword_Confirm.Name = "tbPassword_Confirm";
            this.tbPassword_Confirm.Size = new System.Drawing.Size(201, 20);
            this.tbPassword_Confirm.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(507, 143);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(141, 54);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Criar Conta";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(161, 319);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(74, 13);
            this.lbText.TabIndex = 12;
            this.lbText.Text = "Já tem conta?";
            // 
            // lbLink_Index
            // 
            this.lbLink_Index.AutoSize = true;
            this.lbLink_Index.Location = new System.Drawing.Point(241, 319);
            this.lbLink_Index.Name = "lbLink_Index";
            this.lbLink_Index.Size = new System.Drawing.Size(73, 13);
            this.lbLink_Index.TabIndex = 13;
            this.lbLink_Index.TabStop = true;
            this.lbLink_Index.Text = "Iniciar Sessão";
            this.lbLink_Index.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLink_Index_LinkClicked);
            // 
            // tbIDNumber
            // 
            this.tbIDNumber.Location = new System.Drawing.Point(244, 161);
            this.tbIDNumber.Name = "tbIDNumber";
            this.tbIDNumber.Size = new System.Drawing.Size(201, 20);
            this.tbIDNumber.TabIndex = 14;
            // 
            // lbIDNumber
            // 
            this.lbIDNumber.AutoSize = true;
            this.lbIDNumber.Location = new System.Drawing.Point(275, 127);
            this.lbIDNumber.Name = "lbIDNumber";
            this.lbIDNumber.Size = new System.Drawing.Size(126, 13);
            this.lbIDNumber.TabIndex = 15;
            this.lbIDNumber.Text = "Numero de Identificação:";
            // 
            // lbPostcode
            // 
            this.lbPostcode.AutoSize = true;
            this.lbPostcode.Location = new System.Drawing.Point(541, 21);
            this.lbPostcode.Name = "lbPostcode";
            this.lbPostcode.Size = new System.Drawing.Size(75, 13);
            this.lbPostcode.TabIndex = 21;
            this.lbPostcode.Text = "Codigo-Postal:";
            // 
            // tbPostcode
            // 
            this.tbPostcode.Location = new System.Drawing.Point(511, 64);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(137, 20);
            this.tbPostcode.TabIndex = 22;
            // 
            // lbPhoneNumber
            // 
            this.lbPhoneNumber.AutoSize = true;
            this.lbPhoneNumber.Location = new System.Drawing.Point(294, 25);
            this.lbPhoneNumber.Name = "lbPhoneNumber";
            this.lbPhoneNumber.Size = new System.Drawing.Size(107, 13);
            this.lbPhoneNumber.TabIndex = 28;
            this.lbPhoneNumber.Text = "Numero de Telefone:";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(244, 64);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(201, 20);
            this.tbPhoneNum.TabIndex = 27;
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(219, 257);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 29;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // checkBoxPasswordConfirm
            // 
            this.checkBoxPasswordConfirm.AutoSize = true;
            this.checkBoxPasswordConfirm.Location = new System.Drawing.Point(451, 259);
            this.checkBoxPasswordConfirm.Name = "checkBoxPasswordConfirm";
            this.checkBoxPasswordConfirm.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPasswordConfirm.TabIndex = 30;
            this.checkBoxPasswordConfirm.UseVisualStyleBackColor = true;
            this.checkBoxPasswordConfirm.CheckedChanged += new System.EventHandler(this.checkBoxPasswordConfirm_CheckedChanged);
            // 
            // Register
            // 
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 363);
            this.Controls.Add(this.checkBoxPasswordConfirm);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.lbPhoneNumber);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.lbPostcode);
            this.Controls.Add(this.lbIDNumber);
            this.Controls.Add(this.tbIDNumber);
            this.Controls.Add(this.lbLink_Index);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPassword_Confirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lbConfirmar_Password);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.lbEmail);
            this.Name = "Register";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbConfirmar_Password;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPassword_Confirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.LinkLabel lbLink_Index;
        private System.Windows.Forms.TextBox tbIDNumber;
        private System.Windows.Forms.Label lbIDNumber;
        private System.Windows.Forms.Label lbPostcode;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.Label lbPhoneNumber;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.CheckBox checkBoxPassword;
        private System.Windows.Forms.CheckBox checkBoxPasswordConfirm;
    }
}