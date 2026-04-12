namespace MealSync_APP
{
    partial class Choose_BankAccountType
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
            this.cbTipo_contaBancaria = new System.Windows.Forms.ComboBox();
            this.lbTexto = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbTipo_contaBancaria
            // 
            this.cbTipo_contaBancaria.FormattingEnabled = true;
            this.cbTipo_contaBancaria.Items.AddRange(new object[] {
            "Prazo",
            "Ordem",
            "Vencimento"});
            this.cbTipo_contaBancaria.Location = new System.Drawing.Point(72, 87);
            this.cbTipo_contaBancaria.Name = "cbTipo_contaBancaria";
            this.cbTipo_contaBancaria.Size = new System.Drawing.Size(119, 21);
            this.cbTipo_contaBancaria.TabIndex = 0;
            // 
            // lbTexto
            // 
            this.lbTexto.AutoSize = true;
            this.lbTexto.Location = new System.Drawing.Point(53, 32);
            this.lbTexto.Name = "lbTexto";
            this.lbTexto.Size = new System.Drawing.Size(172, 13);
            this.lbTexto.TabIndex = 2;
            this.lbTexto.Text = "Selecione o tipo de conta bancaria";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(100, 143);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(64, 39);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(73, 114);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(117, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(97, 59);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(53, 13);
            this.lbPassword.TabIndex = 5;
            this.lbPassword.Text = "Password";
            // 
            // Escolher_tipoContaBancaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 194);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbTexto);
            this.Controls.Add(this.cbTipo_contaBancaria);
            this.Name = "Escolher_tipoContaBancaria";
            this.Text = "7";
            this.Load += new System.EventHandler(this.Escolher_TipoContaBancaria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipo_contaBancaria;
        private System.Windows.Forms.Label lbTexto;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
    }
}