namespace MealSync_APP
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.lbLink_Register = new System.Windows.Forms.LinkLabel();
            this.checkBoxPassword = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(466, 312);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(154, 20);
            this.tbName.TabIndex = 2;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(466, 346);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(154, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Location = new System.Drawing.Point(432, 407);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(201, 37);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Location = new System.Drawing.Point(463, 381);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(104, 13);
            this.lbText.TabIndex = 5;
            this.lbText.Text = "Novo no MealSync?";
            // 
            // lbLink_Register
            // 
            this.lbLink_Register.AutoSize = true;
            this.lbLink_Register.BackColor = System.Drawing.Color.Green;
            this.lbLink_Register.LinkColor = System.Drawing.Color.White;
            this.lbLink_Register.Location = new System.Drawing.Point(573, 381);
            this.lbLink_Register.Name = "lbLink_Register";
            this.lbLink_Register.Size = new System.Drawing.Size(60, 13);
            this.lbLink_Register.TabIndex = 6;
            this.lbLink_Register.TabStop = true;
            this.lbLink_Register.Text = "Registre-se";
            this.lbLink_Register.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLink_Register_LinkClicked);
            // 
            // checkBoxPassword
            // 
            this.checkBoxPassword.AutoSize = true;
            this.checkBoxPassword.Location = new System.Drawing.Point(626, 349);
            this.checkBoxPassword.Name = "checkBoxPassword";
            this.checkBoxPassword.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPassword.TabIndex = 7;
            this.checkBoxPassword.UseVisualStyleBackColor = true;
            this.checkBoxPassword.CheckedChanged += new System.EventHandler(this.checkBoxPassword_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(811, 713);
            this.Controls.Add(this.checkBoxPassword);
            this.Controls.Add(this.lbLink_Register);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Index_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.LinkLabel lbLink_Register;
        private System.Windows.Forms.CheckBox checkBoxPassword;
    }
}