namespace MealSync_APP.ProfileFolder
{
    partial class Edit_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Profile));
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tbSchoolMemberID = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.pbUserProfilePicture = new System.Windows.Forms.PictureBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbPasswordConfirm = new System.Windows.Forms.Label();
            this.tbPostcode = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.tbEmail.Location = new System.Drawing.Point(414, 169);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(251, 35);
            this.tbEmail.TabIndex = 35;
            // 
            // tbName
            // 
            this.tbName.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.ForeColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(414, 285);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(251, 35);
            this.tbName.TabIndex = 37;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPassword.Location = new System.Drawing.Point(414, 404);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(214, 35);
            this.tbPassword.TabIndex = 38;
            // 
            // tbPasswordConfirm
            // 
            this.tbPasswordConfirm.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPasswordConfirm.ForeColor = System.Drawing.SystemColors.Menu;
            this.tbPasswordConfirm.Location = new System.Drawing.Point(687, 404);
            this.tbPasswordConfirm.Name = "tbPasswordConfirm";
            this.tbPasswordConfirm.PasswordChar = '*';
            this.tbPasswordConfirm.Size = new System.Drawing.Size(215, 35);
            this.tbPasswordConfirm.TabIndex = 39;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Sienna;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEdit.Location = new System.Drawing.Point(484, 484);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(262, 54);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Confirmar";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // tbSchoolMemberID
            // 
            this.tbSchoolMemberID.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbSchoolMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSchoolMemberID.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSchoolMemberID.Location = new System.Drawing.Point(687, 285);
            this.tbSchoolMemberID.Name = "tbSchoolMemberID";
            this.tbSchoolMemberID.Size = new System.Drawing.Size(251, 35);
            this.tbSchoolMemberID.TabIndex = 43;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.BackColor = System.Drawing.Color.Transparent;
            this.lbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPassword.Location = new System.Drawing.Point(637, 407);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(31, 24);
            this.lbPassword.TabIndex = 54;
            this.lbPassword.Text = "🔒";
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbPhoneNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPhoneNum.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPhoneNum.Location = new System.Drawing.Point(687, 169);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(251, 35);
            this.tbPhoneNum.TabIndex = 47;
            // 
            // pbUserProfilePicture
            // 
            this.pbUserProfilePicture.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pbUserProfilePicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbUserProfilePicture.BackgroundImage")));
            this.pbUserProfilePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbUserProfilePicture.ErrorImage = null;
            this.pbUserProfilePicture.InitialImage = null;
            this.pbUserProfilePicture.Location = new System.Drawing.Point(962, 248);
            this.pbUserProfilePicture.Name = "pbUserProfilePicture";
            this.pbUserProfilePicture.Size = new System.Drawing.Size(194, 197);
            this.pbUserProfilePicture.TabIndex = 51;
            this.pbUserProfilePicture.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Sienna;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCancel.Location = new System.Drawing.Point(752, 484);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(262, 54);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Cancelar Alterações";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lbPasswordConfirm
            // 
            this.lbPasswordConfirm.AutoSize = true;
            this.lbPasswordConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lbPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPasswordConfirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbPasswordConfirm.Location = new System.Drawing.Point(910, 407);
            this.lbPasswordConfirm.Name = "lbPasswordConfirm";
            this.lbPasswordConfirm.Size = new System.Drawing.Size(31, 24);
            this.lbPasswordConfirm.TabIndex = 53;
            this.lbPasswordConfirm.Text = "🔒";
            // 
            // tbPostcode
            // 
            this.tbPostcode.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbPostcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPostcode.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPostcode.Location = new System.Drawing.Point(962, 169);
            this.tbPostcode.Name = "tbPostcode";
            this.tbPostcode.Size = new System.Drawing.Size(186, 35);
            this.tbPostcode.TabIndex = 46;
            // 
            // Edit_Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1183, 678);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.lbPasswordConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pbUserProfilePicture);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.tbPostcode);
            this.Controls.Add(this.tbSchoolMemberID);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbPasswordConfirm);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbEmail);
            this.MaximizeBox = false;
            this.Name = "Edit_Profile";
            this.Text = "Editar Perfil";
            this.Load += new System.EventHandler(this.Edit_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbPasswordConfirm;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox tbSchoolMemberID;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.PictureBox pbUserProfilePicture;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbPasswordConfirm;
        private System.Windows.Forms.TextBox tbPostcode;
    }
}