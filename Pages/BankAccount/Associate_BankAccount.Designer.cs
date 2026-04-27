namespace MealSync_APP._Começo
{
    partial class Associate_BankAccount
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbAccountOwner = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btnAssociateAccount = new System.Windows.Forms.Button();
            this.lbOwner = new System.Windows.Forms.Label();
            this.lbAccountType = new System.Windows.Forms.Label();
            this.lbPIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 324);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbAccountOwner
            // 
            this.tbAccountOwner.Location = new System.Drawing.Point(482, 60);
            this.tbAccountOwner.Name = "tbAccountOwner";
            this.tbAccountOwner.Size = new System.Drawing.Size(272, 20);
            this.tbAccountOwner.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(482, 182);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(272, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(482, 297);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(272, 20);
            this.textBox3.TabIndex = 3;
            // 
            // btnAssociateAccount
            // 
            this.btnAssociateAccount.Location = new System.Drawing.Point(297, 363);
            this.btnAssociateAccount.Name = "btnAssociateAccount";
            this.btnAssociateAccount.Size = new System.Drawing.Size(170, 64);
            this.btnAssociateAccount.TabIndex = 4;
            this.btnAssociateAccount.Text = "Associar";
            this.btnAssociateAccount.UseVisualStyleBackColor = true;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(570, 32);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(82, 13);
            this.lbOwner.TabIndex = 5;
            this.lbOwner.Text = "Dono da Conta:";
            // 
            // lbAccountType
            // 
            this.lbAccountType.AutoSize = true;
            this.lbAccountType.Location = new System.Drawing.Point(570, 148);
            this.lbAccountType.Name = "lbAccountType";
            this.lbAccountType.Size = new System.Drawing.Size(77, 13);
            this.lbAccountType.TabIndex = 6;
            this.lbAccountType.Text = "Tipo de Conta:";
            // 
            // lbPIN
            // 
            this.lbPIN.AutoSize = true;
            this.lbPIN.Location = new System.Drawing.Point(575, 262);
            this.lbPIN.Name = "lbPIN";
            this.lbPIN.Size = new System.Drawing.Size(25, 13);
            this.lbPIN.TabIndex = 7;
            this.lbPIN.Text = "PIN";
            // 
            // Associate_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbPIN);
            this.Controls.Add(this.lbAccountType);
            this.Controls.Add(this.lbOwner);
            this.Controls.Add(this.btnAssociateAccount);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbAccountOwner);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Associate_BankAccount";
            this.Text = "Associar_ContaBancaria";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbAccountOwner;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnAssociateAccount;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Label lbAccountType;
        private System.Windows.Forms.Label lbPIN;
    }
}