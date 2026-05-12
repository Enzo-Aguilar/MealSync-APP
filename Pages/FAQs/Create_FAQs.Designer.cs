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
            this.tbQuestion.Location = new System.Drawing.Point(29, 84);
            this.tbQuestion.Multiline = true;
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(196, 34);
            this.tbQuestion.TabIndex = 1;
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Location = new System.Drawing.Point(176, 193);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(15, 14);
            this.checkBox.TabIndex = 2;
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.CheckBox_CheckedChanged);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(42, 194);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(128, 13);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Enviar pergunta anonima:";
            // 
            // lbText1
            // 
            this.lbText1.AutoSize = true;
            this.lbText1.Location = new System.Drawing.Point(101, 58);
            this.lbText1.Name = "lbText1";
            this.lbText1.Size = new System.Drawing.Size(53, 13);
            this.lbText1.TabIndex = 4;
            this.lbText1.Text = "Pergunta:";
            // 
            // btnSendQuestion
            // 
            this.btnSendQuestion.Location = new System.Drawing.Point(56, 272);
            this.btnSendQuestion.Name = "btnSendQuestion";
            this.btnSendQuestion.Size = new System.Drawing.Size(141, 49);
            this.btnSendQuestion.TabIndex = 5;
            this.btnSendQuestion.Text = "Enviar";
            this.btnSendQuestion.UseVisualStyleBackColor = true;
            this.btnSendQuestion.Click += new System.EventHandler(this.BtnSendQuestion_Click);
            // 
            // Create_FAQs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 333);
            this.Controls.Add(this.btnSendQuestion);
            this.Controls.Add(this.lbText1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.tbQuestion);
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