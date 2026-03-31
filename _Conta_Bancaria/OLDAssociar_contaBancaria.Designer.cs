namespace MealSync_APP
{
    partial class OLDAssociar_contaBancaria
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
            this.tabela_contasBancarias = new System.Windows.Forms.DataGridView();
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbData = new System.Windows.Forms.TextBox();
            this.tbIBAN = new System.Windows.Forms.TextBox();
            this.lbID_contaBancaria = new System.Windows.Forms.Label();
            this.lbData = new System.Windows.Forms.Label();
            this.lbIBAN = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnAssociar = new System.Windows.Forms.Button();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_contasBancarias)).BeginInit();
            this.SuspendLayout();
            // 
            // tabela_contasBancarias
            // 
            this.tabela_contasBancarias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_contasBancarias.Location = new System.Drawing.Point(12, 12);
            this.tabela_contasBancarias.Name = "tabela_contasBancarias";
            this.tabela_contasBancarias.ReadOnly = true;
            this.tabela_contasBancarias.Size = new System.Drawing.Size(332, 301);
            this.tabela_contasBancarias.TabIndex = 0;
            this.tabela_contasBancarias.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_contasBancarias_CellContentClick);
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(381, 49);
            this.tbID.Name = "tbID";
            this.tbID.Size = new System.Drawing.Size(173, 20);
            this.tbID.TabIndex = 1;
            // 
            // tbData
            // 
            this.tbData.Location = new System.Drawing.Point(381, 114);
            this.tbData.Name = "tbData";
            this.tbData.Size = new System.Drawing.Size(173, 20);
            this.tbData.TabIndex = 2;
            // 
            // tbIBAN
            // 
            this.tbIBAN.Location = new System.Drawing.Point(381, 183);
            this.tbIBAN.Name = "tbIBAN";
            this.tbIBAN.Size = new System.Drawing.Size(173, 20);
            this.tbIBAN.TabIndex = 3;
            // 
            // lbID_contaBancaria
            // 
            this.lbID_contaBancaria.AutoSize = true;
            this.lbID_contaBancaria.Location = new System.Drawing.Point(415, 23);
            this.lbID_contaBancaria.Name = "lbID_contaBancaria";
            this.lbID_contaBancaria.Size = new System.Drawing.Size(107, 13);
            this.lbID_contaBancaria.TabIndex = 4;
            this.lbID_contaBancaria.Text = "ID da conta bancaria";
            // 
            // lbData
            // 
            this.lbData.AutoSize = true;
            this.lbData.Location = new System.Drawing.Point(424, 83);
            this.lbData.Name = "lbData";
            this.lbData.Size = new System.Drawing.Size(84, 13);
            this.lbData.TabIndex = 5;
            this.lbData.Text = "Data de Criação";
            // 
            // lbIBAN
            // 
            this.lbIBAN.AutoSize = true;
            this.lbIBAN.Location = new System.Drawing.Point(451, 149);
            this.lbIBAN.Name = "lbIBAN";
            this.lbIBAN.Size = new System.Drawing.Size(32, 13);
            this.lbIBAN.TabIndex = 6;
            this.lbIBAN.Text = "IBAN";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(107, 344);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(90, 55);
            this.btnAtualizar.TabIndex = 7;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnAssociar
            // 
            this.btnAssociar.Location = new System.Drawing.Point(418, 344);
            this.btnAssociar.Name = "btnAssociar";
            this.btnAssociar.Size = new System.Drawing.Size(90, 55);
            this.btnAssociar.TabIndex = 8;
            this.btnAssociar.Text = "Associar";
            this.btnAssociar.UseVisualStyleBackColor = true;
            this.btnAssociar.Click += new System.EventHandler(this.btnAssociar_Click);
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(439, 233);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 10;
            this.lbPassword.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(381, 264);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(173, 20);
            this.tbPassword.TabIndex = 9;
            // 
            // Associar_contaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 428);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnAssociar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.lbIBAN);
            this.Controls.Add(this.lbData);
            this.Controls.Add(this.lbID_contaBancaria);
            this.Controls.Add(this.tbIBAN);
            this.Controls.Add(this.tbData);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.tabela_contasBancarias);
            this.Name = "Associar_contaBancaria";
            this.Text = "Associar_ContaBancaria";
            this.Load += new System.EventHandler(this.Associar_contaBancaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela_contasBancarias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela_contasBancarias;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbData;
        private System.Windows.Forms.TextBox tbIBAN;
        private System.Windows.Forms.Label lbID_contaBancaria;
        private System.Windows.Forms.Label lbData;
        private System.Windows.Forms.Label lbIBAN;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnAssociar;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword;
    }
}