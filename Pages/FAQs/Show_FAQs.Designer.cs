namespace MealSync_APP.Pages.FAQs
{
    partial class Show_FAQs
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
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.lbFAQs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswers
            // 
            this.tbAnswers.Enabled = false;
            this.tbAnswers.Location = new System.Drawing.Point(486, 165);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.ReadOnly = true;
            this.tbAnswers.Size = new System.Drawing.Size(346, 253);
            this.tbAnswers.TabIndex = 1;
            // 
            // lbFAQs
            // 
            this.lbFAQs.AutoSize = true;
            this.lbFAQs.Location = new System.Drawing.Point(194, 103);
            this.lbFAQs.Name = "lbFAQs";
            this.lbFAQs.Size = new System.Drawing.Size(137, 16);
            this.lbFAQs.TabIndex = 2;
            this.lbFAQs.Text = "Perguntas frequentes:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Resposta:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(592, 453);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 73);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(91, 138);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(362, 388);
            this.dgvQuestions.TabIndex = 4;
            this.dgvQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuestions_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(728, 22);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(179, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(653, 25);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 16);
            this.lbSearch.TabIndex = 7;
            this.lbSearch.Text = "Procurar:";
            // 
            // Show_FAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 603);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFAQs);
            this.Controls.Add(this.tbAnswers);
            this.Name = "Show_FAQs";
            this.Text = "Show_FAQs";
            this.Load += new System.EventHandler(this.Show_FAQs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.Label lbFAQs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
    }
}