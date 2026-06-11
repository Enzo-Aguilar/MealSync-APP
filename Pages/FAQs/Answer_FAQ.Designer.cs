namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Answer_Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Answer_Faq));
            this.dgvFAQs = new System.Windows.Forms.DataGridView();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnAnswerQuestion = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDeactivate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQs
            // 
            this.dgvFAQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQs.Location = new System.Drawing.Point(77, 109);
            this.dgvFAQs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFAQs.Name = "dgvFAQs";
            this.dgvFAQs.ReadOnly = true;
            this.dgvFAQs.RowHeadersWidth = 51;
            this.dgvFAQs.RowTemplate.Height = 24;
            this.dgvFAQs.Size = new System.Drawing.Size(397, 438);
            this.dgvFAQs.TabIndex = 0;
            this.dgvFAQs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFAQs_CellContentClick);
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.tbQuestion.Location = new System.Drawing.Point(556, 214);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(523, 43);
            this.tbQuestion.TabIndex = 1;
            // 
            // tbAnswer
            // 
            this.tbAnswer.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbAnswer.ForeColor = System.Drawing.SystemColors.Window;
            this.tbAnswer.Location = new System.Drawing.Point(556, 324);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(2);
            this.tbAnswer.Multiline = true;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.Size = new System.Drawing.Size(523, 136);
            this.tbAnswer.TabIndex = 4;
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(556, 119);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(523, 31);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // btnAnswerQuestion
            // 
            this.btnAnswerQuestion.BackColor = System.Drawing.Color.Sienna;
            this.btnAnswerQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnswerQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAnswerQuestion.Location = new System.Drawing.Point(919, 497);
            this.btnAnswerQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.btnAnswerQuestion.Name = "btnAnswerQuestion";
            this.btnAnswerQuestion.Size = new System.Drawing.Size(160, 58);
            this.btnAnswerQuestion.TabIndex = 8;
            this.btnAnswerQuestion.Text = "Responder";
            this.btnAnswerQuestion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAnswerQuestion.UseVisualStyleBackColor = false;
            this.btnAnswerQuestion.Click += new System.EventHandler(this.BtnAnswerQuestion_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(737, 497);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(160, 58);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDeactivate
            // 
            this.btnDeactivate.BackColor = System.Drawing.Color.Sienna;
            this.btnDeactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeactivate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDeactivate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivate.Location = new System.Drawing.Point(556, 497);
            this.btnDeactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeactivate.Name = "btnDeactivate";
            this.btnDeactivate.Size = new System.Drawing.Size(160, 58);
            this.btnDeactivate.TabIndex = 11;
            this.btnDeactivate.Text = "Invalidar pergunta";
            this.btnDeactivate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeactivate.UseVisualStyleBackColor = false;
            this.btnDeactivate.Click += new System.EventHandler(this.BtnDeactivate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(611, 503);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "🚫";
            this.label1.Click += new System.EventHandler(this.BtnDeactivate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(793, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 13;
            this.label2.Text = "🔄";
            this.label2.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(975, 501);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 31);
            this.label3.TabIndex = 14;
            this.label3.Text = "📨";
            this.label3.Click += new System.EventHandler(this.BtnAnswerQuestion_Click);
            // 
            // Answer_Faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1194, 649);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeactivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAnswerQuestion);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.tbAnswer);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.dgvFAQs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Answer_Faq";
            this.Text = "Responder Perguntas";
            this.Load += new System.EventHandler(this.Answer_Faq_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFAQs;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnAnswerQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDeactivate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}