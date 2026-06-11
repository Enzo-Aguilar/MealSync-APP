namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Create_Faq
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create_Faq));
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.btnSendQuestion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(127, 162);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(313, 162);
            this.tbQuestion.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(368, 354);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // btnSendQuestion
            // 
            this.btnSendQuestion.BackColor = System.Drawing.Color.Sienna;
            this.btnSendQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendQuestion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSendQuestion.Location = new System.Drawing.Point(200, 397);
            this.btnSendQuestion.Name = "btnSendQuestion";
            this.btnSendQuestion.Size = new System.Drawing.Size(169, 53);
            this.btnSendQuestion.TabIndex = 5;
            this.btnSendQuestion.Text = "             Enviar";
            this.btnSendQuestion.UseVisualStyleBackColor = false;
            this.btnSendQuestion.Click += new System.EventHandler(this.BtnSendQuestion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "📨";
            this.label1.Click += new System.EventHandler(this.BtnSendQuestion_Click);
            // 
            // Create_Faq
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(570, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSendQuestion);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.tbQuestion);
            this.Name = "Create_Faq";
            this.Text = "Fazer Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button btnSendQuestion;
        private System.Windows.Forms.Label label1;
    }
}