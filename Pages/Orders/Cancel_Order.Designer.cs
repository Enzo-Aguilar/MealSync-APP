namespace MealSync_APP.OrderFolder
{
    partial class Cancel_Order
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
            this.MealDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panelMeals = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MealDateTime
            // 
            this.MealDateTime.CustomFormat = "dd/mm/yyyy";
            this.MealDateTime.Location = new System.Drawing.Point(129, 18);
            this.MealDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.MealDateTime.Name = "MealDateTime";
            this.MealDateTime.Size = new System.Drawing.Size(247, 22);
            this.MealDateTime.TabIndex = 23;
            this.MealDateTime.Value = new System.DateTime(2026, 5, 30, 0, 0, 0, 0);
            this.MealDateTime.ValueChanged += new System.EventHandler(this.MealDateTime_ValueChanged);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(9, 18);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(105, 16);
            this.lbText.TabIndex = 22;
            this.lbText.Text = "Marcar para dia:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(471, 713);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 79);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(781, 713);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.Location = new System.Drawing.Point(167, 713);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(176, 79);
            this.btnMakeOrder.TabIndex = 19;
            this.btnMakeOrder.Text = "Desmarcar";
            this.btnMakeOrder.UseVisualStyleBackColor = true;
            // 
            // panelMeals
            // 
            this.panelMeals.AutoScroll = true;
            this.panelMeals.BackColor = System.Drawing.Color.White;
            this.panelMeals.Location = new System.Drawing.Point(49, 49);
            this.panelMeals.Margin = new System.Windows.Forms.Padding(4);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(992, 657);
            this.panelMeals.TabIndex = 18;
            // 
            // Cancel_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1275, 863);
            this.Controls.Add(this.MealDateTime);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.panelMeals);
            this.Name = "Cancel_Order";
            this.Text = "Desmarcar_Pedido";
            this.Load += new System.EventHandler(this.Cancel_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker MealDateTime;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Panel panelMeals;
    }
}