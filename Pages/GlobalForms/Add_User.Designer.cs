namespace MealSync_APP.Pages.GlobalForms
{
    partial class Add_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_User));
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.tbPassword_Confirm = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPostCode = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.pbProfileImage = new System.Windows.Forms.PictureBox();
            this.tbSchoolMemberID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Sienna;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(374, 414);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(212, 41);
            this.btnRegister.TabIndex = 37;
            this.btnRegister.Text = "Criar Conta";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnCreateUser_Click);
            // 
            // cbRole
            // 
            this.cbRole.BackColor = System.Drawing.SystemColors.MenuText;
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRole.ForeColor = System.Drawing.SystemColors.Window;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Items.AddRange(new object[] {
            "Admin",
            "Funcionario",
            "Aluno"});
            this.cbRole.Location = new System.Drawing.Point(293, 189);
            this.cbRole.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(177, 39);
            this.cbRole.TabIndex = 36;
            // 
            // tbPassword_Confirm
            // 
            this.tbPassword_Confirm.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword_Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword_Confirm.Location = new System.Drawing.Point(497, 188);
            this.tbPassword_Confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword_Confirm.Name = "tbPassword_Confirm";
            this.tbPassword_Confirm.Size = new System.Drawing.Size(174, 40);
            this.tbPassword_Confirm.TabIndex = 35;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(497, 106);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(174, 40);
            this.tbPassword.TabIndex = 34;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(293, 274);
            this.tbName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(177, 40);
            this.tbName.TabIndex = 33;
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.tbEmail.Location = new System.Drawing.Point(293, 106);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(177, 40);
            this.tbEmail.TabIndex = 31;
            // 
            // tbPostCode
            // 
            this.tbPostCode.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbPostCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostCode.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPostCode.Location = new System.Drawing.Point(497, 274);
            this.tbPostCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPostCode.Name = "tbPostCode";
            this.tbPostCode.Size = new System.Drawing.Size(174, 40);
            this.tbPostCode.TabIndex = 38;
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNumber.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPhoneNumber.Location = new System.Drawing.Point(293, 359);
            this.tbPhoneNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(177, 40);
            this.tbPhoneNumber.TabIndex = 39;
            // 
            // pbProfileImage
            // 
            this.pbProfileImage.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbProfileImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbProfileImage.BackgroundImage")));
            this.pbProfileImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbProfileImage.Location = new System.Drawing.Point(691, 101);
            this.pbProfileImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbProfileImage.Name = "pbProfileImage";
            this.pbProfileImage.Size = new System.Drawing.Size(146, 151);
            this.pbProfileImage.TabIndex = 42;
            this.pbProfileImage.TabStop = false;
            this.pbProfileImage.Click += new System.EventHandler(this.PbProfileImage_Click);
            // 
            // tbSchoolMemberID
            // 
            this.tbSchoolMemberID.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbSchoolMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSchoolMemberID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSchoolMemberID.Location = new System.Drawing.Point(497, 359);
            this.tbSchoolMemberID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbSchoolMemberID.Name = "tbSchoolMemberID";
            this.tbSchoolMemberID.Size = new System.Drawing.Size(174, 40);
            this.tbSchoolMemberID.TabIndex = 44;
            // 
            // Add_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(869, 512);
            this.Controls.Add(this.tbSchoolMemberID);
            this.Controls.Add(this.pbProfileImage);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbPostCode);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbRole);
            this.Controls.Add(this.tbPassword_Confirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Add_User";
            this.Text = "Criar Utilizador";
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.TextBox tbPassword_Confirm;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPostCode;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.PictureBox pbProfileImage;
        private System.Windows.Forms.TextBox tbSchoolMemberID;
    }
}