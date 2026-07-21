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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Make_Order));
            this.panelMeals = new System.Windows.Forms.Panel();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.MealDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbMakeOrder = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelMeals
            // 
            this.panelMeals.AutoScroll = true;
            this.panelMeals.BackColor = System.Drawing.Color.Transparent;
            this.panelMeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMeals.Location = new System.Drawing.Point(44, 37);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(744, 534);
            this.panelMeals.TabIndex = 12;
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMakeOrder.Location = new System.Drawing.Point(244, 577);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(132, 64);
            this.btnMakeOrder.TabIndex = 13;
            this.btnMakeOrder.Text = "Marcar";
            this.btnMakeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.BtnMakeOrder_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(472, 577);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(132, 64);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText.Location = new System.Drawing.Point(1, 9);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(123, 20);
            this.lbText.TabIndex = 16;
            this.lbText.Text = "Marcar para dia:";
            // 
            // MealDateTime
            // 
            this.MealDateTime.CustomFormat = "dd/mm/yyyy";
            this.MealDateTime.Location = new System.Drawing.Point(130, 8);
            this.MealDateTime.Name = "MealDateTime";
            this.MealDateTime.Size = new System.Drawing.Size(186, 20);
            this.MealDateTime.TabIndex = 17;
            this.MealDateTime.Value = new System.DateTime(2026, 5, 30, 0, 0, 0, 0);
            this.MealDateTime.ValueChanged += new System.EventHandler(this.MealDateTime_ValueChanged);
            // 
            // lbMakeOrder
            // 
            this.lbMakeOrder.AutoSize = true;
            this.lbMakeOrder.BackColor = System.Drawing.Color.Sienna;
            this.lbMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMakeOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbMakeOrder.Location = new System.Drawing.Point(260, 590);
            this.lbMakeOrder.Name = "lbMakeOrder";
            this.lbMakeOrder.Size = new System.Drawing.Size(49, 31);
            this.lbMakeOrder.TabIndex = 18;
            this.lbMakeOrder.Text = "🗳️ ";
            this.lbMakeOrder.Click += new System.EventHandler(this.BtnMakeOrder_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.BackColor = System.Drawing.Color.Sienna;
            this.lbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUpdate.Location = new System.Drawing.Point(482, 591);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(48, 33);
            this.lbUpdate.TabIndex = 19;
            this.lbUpdate.Text = "🔄";
            this.lbUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // Make_Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(820, 674);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.lbMakeOrder);
            this.Controls.Add(this.MealDateTime);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.panelMeals);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "Make_Order";
            this.Text = "Fazer_Marcacoes";
            this.Load += new System.EventHandler(this.Make_Order_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelMeals;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.DateTimePicker MealDateTime;
        private System.Windows.Forms.Label lbMakeOrder;
        private System.Windows.Forms.Label lbUpdate;
    }
}