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
            this.tbContribuinte = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbFloor = new System.Windows.Forms.TextBox();
            this.tbPIN = new System.Windows.Forms.TextBox();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbPin = new System.Windows.Forms.Label();
            this.tbPINConfirm = new System.Windows.Forms.TextBox();
            this.lbPINConfirm = new System.Windows.Forms.Label();
            this.lbContribuinte = new System.Windows.Forms.Label();
            this.lbStreet = new System.Windows.Forms.Label();
            this.lbFloor = new System.Windows.Forms.Label();
            this.lbPostalCode = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCreate_BankAccount
            // 
            this.btnCreate_BankAccount.Location = new System.Drawing.Point(260, 355);
            this.btnCreate_BankAccount.Name = "btnCreate_BankAccount";
            this.btnCreate_BankAccount.Size = new System.Drawing.Size(108, 58);
            this.btnCreate_BankAccount.TabIndex = 0;
            this.btnCreate_BankAccount.Text = "Criar";
            this.btnCreate_BankAccount.UseVisualStyleBackColor = true;
            this.btnCreate_BankAccount.Click += new System.EventHandler(this.BtnCreate_BankAccount_Click);
            // 
            // tbContribuinte
            // 
            this.tbContribuinte.Location = new System.Drawing.Point(422, 56);
            this.tbContribuinte.Name = "tbContribuinte";
            this.tbContribuinte.Size = new System.Drawing.Size(247, 20);
            this.tbContribuinte.TabIndex = 1;
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(360, 144);
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(149, 20);
            this.tbStreet.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(247, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tbFloor
            // 
            this.tbFloor.Location = new System.Drawing.Point(594, 144);
            this.tbFloor.Name = "tbFloor";
            this.tbFloor.Size = new System.Drawing.Size(158, 20);
            this.tbFloor.TabIndex = 4;
            // 
            // tbPIN
            // 
            this.tbPIN.Location = new System.Drawing.Point(40, 144);
            this.tbPIN.Name = "tbPIN";
            this.tbPIN.Size = new System.Drawing.Size(247, 20);
            this.tbPIN.TabIndex = 5;
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(129, 26);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(77, 13);
            this.lbAccountType.TabIndex = 6;
            this.lbAccountType.Text = "Tipo de Conta:";
            // 
            // lbPin
            // 
            this.lbPin.AutoSize = true;
            this.lbPin.Location = new System.Drawing.Point(144, 113);
            this.lbPin.Name = "lbPin";
            this.lbPin.Size = new System.Drawing.Size(25, 13);
            this.lbPin.TabIndex = 7;
            this.lbPin.Text = "PIN";
            // 
            // tbPINConfirm
            // 
            this.tbPINConfirm.Location = new System.Drawing.Point(40, 249);
            this.tbPINConfirm.Name = "tbPINConfirm";
            this.tbPINConfirm.Size = new System.Drawing.Size(247, 20);
            this.tbPINConfirm.TabIndex = 8;
            // 
            // lbPINConfirm
            // 
            this.lbPINConfirm.AutoSize = true;
            this.lbPINConfirm.Location = new System.Drawing.Point(120, 204);
            this.lbPINConfirm.Name = "lbPINConfirm";
            this.lbPINConfirm.Size = new System.Drawing.Size(72, 13);
            this.lbPINConfirm.TabIndex = 9;
            this.lbPINConfirm.Text = "Confirmar PIN";
            // 
            // lbContribuinte
            // 
            this.lbContribuinte.AutoSize = true;
            this.lbContribuinte.Location = new System.Drawing.Point(504, 26);
            this.lbContribuinte.Name = "lbContribuinte";
            this.lbContribuinte.Size = new System.Drawing.Size(63, 13);
            this.lbContribuinte.TabIndex = 10;
            this.lbContribuinte.Text = "Contribuinte";
            // 
            // lbStreet
            // 
            this.lbStreet.AutoSize = true;
            this.lbStreet.Location = new System.Drawing.Point(419, 113);
            this.lbStreet.Name = "lbStreet";
            this.lbStreet.Size = new System.Drawing.Size(30, 13);
            this.lbStreet.TabIndex = 11;
            this.lbStreet.Text = "Rua:";
            // 
            // lbFloor
            // 
            this.lbFloor.AutoSize = true;
            this.lbFloor.Location = new System.Drawing.Point(653, 113);
            this.lbFloor.Name = "lbFloor";
            this.lbFloor.Size = new System.Drawing.Size(38, 13);
            this.lbFloor.TabIndex = 12;
            this.lbFloor.Text = "Andar:";
            // 
            // lbPostalCode
            // 
            this.lbPostalCode.AutoSize = true;
            this.lbPostalCode.Location = new System.Drawing.Point(394, 204);
            this.lbPostalCode.Name = "lbPostalCode";
            this.lbPostalCode.Size = new System.Drawing.Size(75, 13);
            this.lbPostalCode.TabIndex = 14;
            this.lbPostalCode.Text = "Codigo-Postal:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(351, 249);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(158, 20);
            this.textBox2.TabIndex = 13;
            // 
            // Create_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPostalCode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lbFloor);
            this.Controls.Add(this.lbStreet);
            this.Controls.Add(this.lbContribuinte);
            this.Controls.Add(this.lbPINConfirm);
            this.Controls.Add(this.tbPINConfirm);
            this.Controls.Add(this.lbPin);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.tbPIN);
            this.Controls.Add(this.tbFloor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.tbContribuinte);
            this.Controls.Add(this.btnCreate_BankAccount);
            this.Name = "Create_BankAccount";
            this.Text = "Criar_ContaBancaria";
            this.Load += new System.EventHandler(this.Create_BankAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate_BankAccount;
        private System.Windows.Forms.TextBox tbContribuinte;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbFloor;
        private System.Windows.Forms.TextBox tbPIN;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbPin;
        private System.Windows.Forms.TextBox tbPINConfirm;
        private System.Windows.Forms.Label lbPINConfirm;
        private System.Windows.Forms.Label lbContribuinte;
        private System.Windows.Forms.Label lbStreet;
        private System.Windows.Forms.Label lbFloor;
        private System.Windows.Forms.Label lbPostalCode;
        private System.Windows.Forms.TextBox textBox2;
    }
}