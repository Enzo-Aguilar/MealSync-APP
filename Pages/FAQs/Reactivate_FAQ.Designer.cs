namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Reactivate_FAQ
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
            this.dgvFAQs = new System.Windows.Forms.DataGridView();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQs
            // 
            this.dgvFAQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQs.Location = new System.Drawing.Point(36, 54);
            this.dgvFAQs.Name = "dgvFAQs";
            this.dgvFAQs.ReadOnly = true;
            this.dgvFAQs.RowTemplate.Height = 24;
            this.dgvFAQs.Size = new System.Drawing.Size(392, 318);
            this.dgvFAQs.TabIndex = 0;
            this.dgvFAQs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFAQ_CellContentClick);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(491, 170);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(280, 55);
            this.tbQuestion.TabIndex = 1;
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(558, 132);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(144, 16);
            this.lbQuestion.TabIndex = 2;
            this.lbQuestion.Text = "Pergunta Selecionada:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(467, 319);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnReactivate
            // 
            this.btnReactivate.Location = new System.Drawing.Point(655, 319);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(116, 53);
            this.btnReactivate.TabIndex = 4;
            this.btnReactivate.Text = "Reativar pergunta";
            this.btnReactivate.UseVisualStyleBackColor = true;
            this.btnReactivate.Click += new System.EventHandler(this.BtnReactivate_Click);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(542, 25);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 16);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Procurar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(609, 19);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(190, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // Reactivate_FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.btnReactivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.dgvFAQs);
            this.Name = "Reactivate_FAQ";
            this.Text = "Reativar Perguntas";
            this.Load += new System.EventHandler(this.Reactivate_FAQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFAQs;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label lbQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
    }
}