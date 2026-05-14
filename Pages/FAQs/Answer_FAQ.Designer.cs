namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Answer_FAQ
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
            this.lbSelectedAnswer = new System.Windows.Forms.Label();
            this.lbText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnAnswerQuestion = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQs
            // 
            this.dgvFAQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQs.Location = new System.Drawing.Point(38, 80);
            this.dgvFAQs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvFAQs.Name = "dgvFAQs";
            this.dgvFAQs.ReadOnly = true;
            this.dgvFAQs.RowHeadersWidth = 51;
            this.dgvFAQs.RowTemplate.Height = 24;
            this.dgvFAQs.Size = new System.Drawing.Size(301, 313);
            this.dgvFAQs.TabIndex = 0;
            this.dgvFAQs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFAQs_CellContentClick);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(429, 113);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(309, 61);
            this.tbQuestion.TabIndex = 1;
            // 
            // lbSelectedAnswer
            // 
            this.lbSelectedAnswer.AutoSize = true;
            this.lbSelectedAnswer.Location = new System.Drawing.Point(507, 80);
            this.lbSelectedAnswer.Name = "lbSelectedAnswer";
            this.lbSelectedAnswer.Size = new System.Drawing.Size(144, 16);
            this.lbSelectedAnswer.TabIndex = 2;
            this.lbSelectedAnswer.Text = "Pergunta Selecionada:";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(142, 41);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(68, 16);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Perguntas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resposta:";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(429, 251);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(309, 61);
            this.tbAnswer.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(641, 26);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(159, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(573, 32);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 16);
            this.lbSearch.TabIndex = 7;
            this.lbSearch.Text = "Procurar:";
            // 
            // btnAnswerQuestion
            // 
            this.btnAnswerQuestion.Location = new System.Drawing.Point(641, 360);
            this.btnAnswerQuestion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnswerQuestion.Name = "btnAnswerQuestion";
            this.btnAnswerQuestion.Size = new System.Drawing.Size(126, 65);
            this.btnAnswerQuestion.TabIndex = 8;
            this.btnAnswerQuestion.Text = "Responder";
            this.btnAnswerQuestion.UseVisualStyleBackColor = true;
            this.btnAnswerQuestion.Click += new System.EventHandler(this.BtnAnswerQuestion_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(506, 363);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 62);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.Location = new System.Drawing.Point(372, 363);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(128, 62);
            this.btnDeactivate.TabIndex = 11;
            this.btnDeactivate.Text = "Invalidar Pergunta";
            this.btnDeactivate.UseVisualStyleBackColor = true;
            this.btnDeactivate.Click += new System.EventHandler(this.BtnDeactivate_Click);
            // 
            // Answer_FAQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnswerQuestion);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbSelectedAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.dgvFAQs);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Answer_FAQ";
            this.Text = "Responder Perguntas";
            this.Load += new System.EventHandler(this.Answer_FAQs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFAQs;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Label lbSelectedAnswer;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnAnswerQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeactivate;
    }
}