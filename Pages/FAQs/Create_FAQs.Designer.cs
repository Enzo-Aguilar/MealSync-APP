namespace MealSync_APP.Pages.FAQsFolder
{
    partial class Create_FAQs
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.lbText = new System.Windows.Forms.Label();
            this.lbText1 = new System.Windows.Forms.Label();
            this.btnSendQuestion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(39, 103);
            this.tbQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(260, 41);
            this.tbQuestion.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(235, 238);
            this.checkBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(68, 236);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(159, 16);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Enviar pergunta anonima:";
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.Location = new System.Drawing.Point(135, 71);
            this.lbText1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(64, 16);
            this.lbText1.TabIndex = 4;
            this.lbText1.Text = "Pergunta:";
            // 
            // btnSendQuestion
            // 
            this.btnSendQuestion.Location = new System.Drawing.Point(75, 335);
            this.btnSendQuestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSendQuestion.Name = "btnSendQuestion";
            this.btnSendQuestion.Size = new System.Drawing.Size(188, 60);
            this.btnSendQuestion.TabIndex = 5;
            this.btnSendQuestion.Text = "Enviar";
            this.btnSendQuestion.UseVisualStyleBackColor = true;
            this.btnSendQuestion.Click += new System.EventHandler(this.BtnSendQuestion_Click);
            // 
            // Create_FAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 410);
            this.Controls.Add(this.btnSendQuestion);
            this.Controls.Add(this.lbText1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.tbQuestion);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Create_FAQs";
            this.Text = "Fazer Pergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label lbText1;
        private System.Windows.Forms.Button btnSendQuestion;
    }
}