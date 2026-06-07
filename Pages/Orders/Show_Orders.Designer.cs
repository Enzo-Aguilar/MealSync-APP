namespace MealSync_APP.OrderFolder
{
    partial class Show_Orders
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
            this.OrderDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelMeals = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // OrderDateTime
            // 
            this.OrderDateTime.CustomFormat = "dd/mm/yyyy";
            this.OrderDateTime.Location = new System.Drawing.Point(110, 21);
            this.OrderDateTime.Name = "OrderDateTime";
            this.OrderDateTime.Size = new System.Drawing.Size(186, 20);
            this.OrderDateTime.TabIndex = 23;
            this.OrderDateTime.Value = new System.DateTime(2026, 5, 30, 0, 0, 0, 0);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(20, 21);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(84, 13);
            this.lbText.TabIndex = 22;
            this.lbText.Text = "Marcar para dia:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(329, 589);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 64);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // panelMeals
            // 
            this.panelMeals.AutoScroll = true;
            this.panelMeals.BackColor = System.Drawing.Color.White;
            this.panelMeals.Location = new System.Drawing.Point(50, 46);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(744, 534);
            this.panelMeals.TabIndex = 18;
            // 
            // Show_Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 665);
            this.Controls.Add(this.OrderDateTime);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panelMeals);
            this.Name = "Show_Orders";
            this.Text = "Ver_Marcações";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker OrderDateTime;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panelMeals;
    }
}