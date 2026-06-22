namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Reactivate_Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reactivate_Faq));
            this.dgvFAQs = new System.Windows.Forms.DataGridView();
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnReactivate = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFAQs
            // 
            this.dgvFAQs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFAQs.Location = new System.Drawing.Point(75, 108);
            this.dgvFAQs.Margin = new System.Windows.Forms.Padding(2);
            this.dgvFAQs.Name = "dgvFAQs";
            this.dgvFAQs.ReadOnly = true;
            this.dgvFAQs.RowTemplate.Height = 24;
            this.dgvFAQs.Size = new System.Drawing.Size(413, 474);
            this.dgvFAQs.TabIndex = 0;
            this.dgvFAQs.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvFAQ_CellContentClick);
            // 
            // tbQuestion
            // 
            this.tbQuestion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbQuestion.ForeColor = System.Drawing.SystemColors.Window;
            this.tbQuestion.Location = new System.Drawing.Point(553, 235);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(2);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.ReadOnly = true;
            this.tbQuestion.Size = new System.Drawing.Size(539, 42);
            this.tbQuestion.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(553, 300);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(186, 61);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnReactivate
            // 
            this.btnReactivate.BackColor = System.Drawing.Color.Sienna;
            this.btnReactivate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReactivate.Location = new System.Drawing.Point(906, 300);
            this.btnReactivate.Margin = new System.Windows.Forms.Padding(2);
            this.btnReactivate.Name = "btnReactivate";
            this.btnReactivate.Size = new System.Drawing.Size(186, 61);
            this.btnReactivate.TabIndex = 4;
            this.btnReactivate.Text = "Reativar pergunta";
            this.btnReactivate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReactivate.UseVisualStyleBackColor = false;
            this.btnReactivate.Click += new System.EventHandler(this.BtnReactivate_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(553, 133);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(2);
            this.tbSearch.Multiline = true;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(539, 34);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(624, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "🔄";
            this.label1.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(976, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "🔓";
            this.label2.Click += new System.EventHandler(this.BtnReactivate_Click);
            // 
            // Reactivate_Faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1186, 636);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnReactivate);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbQuestion);
            this.Controls.Add(this.dgvFAQs);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Reactivate_Faq";
            this.Text = "\\";
            this.Load += new System.EventHandler(this.Reactivate_FAQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFAQs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFAQs;
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnReactivate;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}