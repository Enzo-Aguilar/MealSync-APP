namespace MealSync_APP.Pages.BankAccountFolder
{
    partial class Transactions_BankAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions_BankAccount));
            this.dgvBankAccounts = new System.Windows.Forms.DataGridView();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCleanSelection = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBankAccounts
            // 
            this.dgvBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBankAccounts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvBankAccounts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dgvBankAccounts.Location = new System.Drawing.Point(286, 118);
            this.dgvBankAccounts.Name = "dgvBankAccounts";
            this.dgvBankAccounts.ReadOnly = true;
            this.dgvBankAccounts.Size = new System.Drawing.Size(311, 319);
            this.dgvBankAccounts.TabIndex = 0;
            this.dgvBankAccounts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvBankAccounts_CellContentClick);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Location = new System.Drawing.Point(614, 118);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.Size = new System.Drawing.Size(309, 319);
            this.dgvTransaction.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdate.Location = new System.Drawing.Point(369, 470);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(196, 51);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCleanSelection
            // 
            this.btnCleanSelection.BackColor = System.Drawing.Color.Sienna;
            this.btnCleanSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleanSelection.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCleanSelection.Location = new System.Drawing.Point(639, 470);
            this.btnCleanSelection.Name = "btnCleanSelection";
            this.btnCleanSelection.Size = new System.Drawing.Size(196, 51);
            this.btnCleanSelection.TabIndex = 6;
            this.btnCleanSelection.Text = "Limpar seleção";
            this.btnCleanSelection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCleanSelection.UseVisualStyleBackColor = false;
            this.btnCleanSelection.Click += new System.EventHandler(this.BtnCleanSelection_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(390, 476);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 37);
            this.label1.TabIndex = 7;
            this.label1.Text = "🔄";
            this.label1.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(648, 477);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 33);
            this.label2.TabIndex = 8;
            this.label2.Text = "🗑️";
            this.label2.Click += new System.EventHandler(this.BtnCleanSelection_Click);
            // 
            // Transactions_BankAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCleanSelection);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.dgvBankAccounts);
            this.Name = "Transactions_BankAccount";
            this.Text = "Transactions_BankAccount";
            this.Load += new System.EventHandler(this.Transactions_BankAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBankAccounts;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCleanSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}