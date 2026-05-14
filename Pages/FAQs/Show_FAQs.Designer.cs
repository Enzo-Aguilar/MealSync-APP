namespace MealSync_APP.Pages.FAQsFolder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_FAQs));
            this.tbAnswers = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dgvQuestions = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).BeginInit();
            this.SuspendLayout();
            // 
            // tbAnswers
            // 
            this.tbAnswers.Enabled = false;
            this.tbAnswers.Location = new System.Drawing.Point(873, 281);
            this.tbAnswers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAnswers.Multiline = true;
            this.tbAnswers.Name = "tbAnswers";
            this.tbAnswers.ReadOnly = true;
            this.tbAnswers.Size = new System.Drawing.Size(555, 269);
            this.tbAnswers.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(1000, 602);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(236, 66);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "🔄   Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // dgvQuestions
            // 
            this.dgvQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuestions.Location = new System.Drawing.Point(143, 316);
            this.dgvQuestions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvQuestions.Name = "dgvQuestions";
            this.dgvQuestions.ReadOnly = true;
            this.dgvQuestions.RowHeadersWidth = 51;
            this.dgvQuestions.RowTemplate.Height = 24;
            this.dgvQuestions.Size = new System.Drawing.Size(591, 377);
            this.dgvQuestions.TabIndex = 4;
            this.dgvQuestions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvQuestions_CellClick);
            // 
            // tbSearch
            // 
            this.tbSearch.BackColor = System.Drawing.SystemColors.InfoText;
            this.tbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSearch.Location = new System.Drawing.Point(873, 133);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(555, 45);
            this.tbSearch.TabIndex = 6;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // Show_FAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1573, 798);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvQuestions);
            this.Controls.Add(this.tbAnswers);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Show_FAQs";
            this.Text = "Show_FAQs";
            this.Load += new System.EventHandler(this.Show_FAQs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuestions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbAnswers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridView dgvQuestions;
        private System.Windows.Forms.TextBox tbSearch;
    }
}