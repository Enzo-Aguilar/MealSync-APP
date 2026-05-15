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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPassword_Confirm = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.lbLink_Index = new System.Windows.Forms.LinkLabel();
            this.tbSchoolMemberID = new System.Windows.Forms.TextBox();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.pbUserProfilePicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.tbEmail.Location = new System.Drawing.Point(459, 162);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(207, 38);
            this.tbEmail.TabIndex = 5;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(459, 267);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(207, 38);
            this.tbName.TabIndex = 7;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(459, 373);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(207, 38);
            this.tbPassword.TabIndex = 8;
            // 
            // tbPassword_Confirm
            // 
            this.tbPassword_Confirm.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPassword_Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword_Confirm.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword_Confirm.Location = new System.Drawing.Point(678, 373);
            this.tbPassword_Confirm.Name = "tbPassword_Confirm";
            this.tbPassword_Confirm.PasswordChar = '*';
            this.tbPassword_Confirm.Size = new System.Drawing.Size(207, 38);
            this.tbPassword_Confirm.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.Sienna;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegister.Location = new System.Drawing.Point(659, 446);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(195, 54);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "Criar Conta";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText.Location = new System.Drawing.Point(501, 467);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(74, 13);
            this.lbText.TabIndex = 12;
            this.lbText.Text = "Já tem conta?";
            // 
            // lbLink_Index
            // 
            this.lbLink_Index.AutoSize = true;
            this.lbLink_Index.BackColor = System.Drawing.SystemColors.Desktop;
            this.lbLink_Index.LinkColor = System.Drawing.Color.White;
            this.lbLink_Index.Location = new System.Drawing.Point(574, 467);
            this.lbLink_Index.Name = "lbLink_Index";
            this.lbLink_Index.Size = new System.Drawing.Size(73, 13);
            this.lbLink_Index.TabIndex = 13;
            this.lbLink_Index.TabStop = true;
            this.lbLink_Index.Text = "Iniciar Sessão";
            this.lbLink_Index.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LbLink_Index_LinkClicked);
            // 
            // tbSchoolMemberID
            // 
            this.tbSchoolMemberID.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSchoolMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSchoolMemberID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSchoolMemberID.Location = new System.Drawing.Point(678, 267);
            this.tbSchoolMemberID.Name = "tbSchoolMemberID";
            this.tbSchoolMemberID.Size = new System.Drawing.Size(207, 38);
            this.tbSchoolMemberID.TabIndex = 14;
            // 
            // tbPostcode
            // 
            this.tbPostcode.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPostcode.Location = new System.Drawing.Point(917, 162);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(205, 38);
            this.tbPostcode.TabIndex = 22;
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPhoneNum.Location = new System.Drawing.Point(678, 162);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(207, 38);
            this.tbPhoneNum.TabIndex = 27;
            // 
            // pbUserProfilePicture
            // 
            this.pbUserProfilePicture.BackColor = System.Drawing.Color.Black;
            this.pbUserProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserProfilePicture.BackgroundImage")));
            this.pbUserProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserProfilePicture.Location = new System.Drawing.Point(917, 233);
            this.pbUserProfilePicture.Name = "pbUserProfilePicture";
            this.pbUserProfilePicture.Size = new System.Drawing.Size(226, 197);
            this.pbUserProfilePicture.TabIndex = 31;
            this.pbUserProfilePicture.TabStop = false;
            this.pbUserProfilePicture.Click += new System.EventHandler(this.PbUserProfilePicture_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(638, 382);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "👁️";
            this.label1.Click += new System.EventHandler(this.LbPassword_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(857, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "👁️";
            this.label2.Click += new System.EventHandler(this.LbPassword_Confirm_Click);
            // 
            // Register
            // 
            this.AccessibleDescription = " ";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1155, 630);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbUserProfilePicture);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbSchoolMemberID);
            this.Controls.Add(this.lbLink_Index);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.tbPassword_Confirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.Name = "Register";
            this.Text = "Registo";
            this.Load += new System.EventHandler(this.Registo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPassword_Confirm;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.LinkLabel lbLink_Index;
        private System.Windows.Forms.TextBox tbSchoolMemberID;
        private System.Windows.Forms.TextBox tbPostcode;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.PictureBox pbUserProfilePicture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}