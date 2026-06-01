namespace MealSync_APP.OrderFolder
{
    partial class Make_Order
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
            this.panelMeals = new System.Windows.Forms.Panel();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.MealDateTime = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // panelMeals
            // 
            this.panelMeals.AutoScroll = true;
            this.panelMeals.Location = new System.Drawing.Point(44, 37);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(740, 650);
            this.panelMeals.TabIndex = 12;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(184, 693);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(132, 64);
            this.btnMakeOrder.TabIndex = 13;
            this.btnMakeOrder.Text = "Marcar";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            this.btnMakeOrder.Click += new System.EventHandler(this.BtnMakeOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(536, 693);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 64);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(356, 693);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 64);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(14, 12);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(84, 13);
            this.lbText.TabIndex = 16;
            this.lbText.Text = "Marcar para dia:";
            // 
            // MealDateTime
            // 
            this.MealDateTime.CustomFormat = "dd/mm/yyyy";
            this.MealDateTime.Location = new System.Drawing.Point(104, 12);
            this.MealDateTime.Name = "MealDateTime";
            this.MealDateTime.Size = new System.Drawing.Size(186, 20);
            this.MealDateTime.TabIndex = 17;
            this.MealDateTime.Value = new System.DateTime(2026, 5, 30, 0, 0, 0, 0);
            this.MealDateTime.ValueChanged += new System.EventHandler(this.MealDateTime_ValueChanged);
            // 
            // Make_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 769);
            this.Controls.Add(this.MealDateTime);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.panelMeals);
            this.Name = "Make_Order";
            this.Text = "Fazer_Marcacoes";
            this.Load += new System.EventHandler(this.Make_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMeals;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.DateTimePicker MealDateTime;
    }
}