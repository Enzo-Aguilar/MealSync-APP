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
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.btnAnswerQuestion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQs
            // 
            this.dgvFAQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQs.Location = new System.Drawing.Point(42, 93);
            this.dgvFAQs.Name = "dgvFAQs";
            this.dgvFAQs.RowHeadersWidth = 51;
            this.dgvFAQs.RowTemplate.Height = 24;
            this.dgvFAQs.Size = new System.Drawing.Size(301, 301);
            this.dgvFAQs.TabIndex = 0;
            this.dgvFAQs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFAQs_CellContentClick);
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(430, 113);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(309, 60);
            this.tbQuestion.TabIndex = 1;
            // 
            // lbSelectedAnswer
            // 
            this.lbSelectedAnswer.AutoSize = true;
            this.lbSelectedAnswer.Location = new System.Drawing.Point(506, 80);
            this.lbSelectedAnswer.Name = "lbSelectedAnswer";
            this.lbSelectedAnswer.Size = new System.Drawing.Size(144, 16);
            this.lbSelectedAnswer.TabIndex = 2;
            this.lbSelectedAnswer.Text = "Pergunta Selecionada:";
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(136, 43);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(68, 16);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Perguntas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Resposta:";
            // 
            // tbAnswers
            // 
            this.tbAnswers.Location = new System.Drawing.Point(430, 251);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.Size = new System.Drawing.Size(309, 60);
            this.tbAnswers.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(641, 26);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(158, 22);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(574, 32);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(61, 16);
            this.lbSearch.TabIndex = 7;
            this.lbSearch.Text = "Procurar:";
            // 
            // btnAnswerQuestion
            // 
            this.btnAnswerQuestion.Location = new System.Drawing.Point(509, 347);
            this.btnAnswerQuestion.Name = "btnAnswerQuestion";
            this.btnAnswerQuestion.Size = new System.Drawing.Size(167, 77);
            this.btnAnswerQuestion.TabIndex = 8;
            this.btnAnswerQuestion.Text = "Responder";
            this.btnAnswerQuestion.UseVisualStyleBackColor = true;
            this.btnAnswerQuestion.Click += new System.EventHandler(this.BtnAnswerQuestion_Click);
            // 
            // Answer_FAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnswerQuestion);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAnswers);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.lbSelectedAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.dgvFAQs);
            this.Name = "Answer_FAQs";
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
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Button btnAnswerQuestion;
    }
}