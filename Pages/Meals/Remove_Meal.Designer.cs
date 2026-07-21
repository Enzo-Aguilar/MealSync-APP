namespace MealSync_APP.MealFolder
{
    partial class Remove_Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Remove_Meal));
            this.label3 = new System.Windows.Forms.Label();
            this.lbUpdate = new System.Windows.Forms.Label();
            this.lbRemoveMeal = new System.Windows.Forms.Label();
            this.MealDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbText = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnMakeOrder = new System.Windows.Forms.Button();
            this.panelMeals = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(936, 807);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 36);
            this.label3.TabIndex = 29;
            this.label3.Text = "✖️";
            this.label3.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lbUpdate
            // 
            this.lbUpdate.AutoSize = true;
            this.lbUpdate.BackColor = System.Drawing.Color.Sienna;
            this.lbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbUpdate.Location = new System.Drawing.Point(616, 802);
            this.lbUpdate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUpdate.Name = "lbUpdate";
            this.lbUpdate.Size = new System.Drawing.Size(61, 42);
            this.lbUpdate.TabIndex = 28;
            this.lbUpdate.Text = "🔄";
            this.lbUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbRemoveMeal
            // 
            this.lbRemoveMeal.AutoSize = true;
            this.lbRemoveMeal.BackColor = System.Drawing.Color.Sienna;
            this.lbRemoveMeal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemoveMeal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbRemoveMeal.Location = new System.Drawing.Point(311, 804);
            this.lbRemoveMeal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRemoveMeal.Name = "lbRemoveMeal";
            this.lbRemoveMeal.Size = new System.Drawing.Size(55, 39);
            this.lbRemoveMeal.TabIndex = 27;
            this.lbRemoveMeal.Text = "🗑️";
            this.lbRemoveMeal.Click += new System.EventHandler(this.BtnDeativatMeal_Click);
            // 
            // MealDateTime
            // 
            this.MealDateTime.CustomFormat = "dd/mm/yyyy";
            this.MealDateTime.Location = new System.Drawing.Point(58, 1);
            this.MealDateTime.Margin = new System.Windows.Forms.Padding(4);
            this.MealDateTime.Name = "MealDateTime";
            this.MealDateTime.Size = new System.Drawing.Size(247, 22);
            this.MealDateTime.TabIndex = 26;
            this.MealDateTime.Value = new System.DateTime(2026, 7, 21, 0, 0, 0, 0);
            this.MealDateTime.ValueChanged += new System.EventHandler(this.MealDateTime_ValueChanged);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbText.Location = new System.Drawing.Point(16, 1);
            this.lbText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(34, 18);
            this.lbText.TabIndex = 25;
            this.lbText.Text = "Dia:";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(603, 786);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(176, 79);
            this.btnUpdate.TabIndex = 24;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Sienna;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(917, 786);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(176, 79);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnMakeOrder
            // 
            this.btnMakeOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnMakeOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMakeOrder.Location = new System.Drawing.Point(303, 786);
            this.btnMakeOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeOrder.Name = "btnMakeOrder";
            this.btnMakeOrder.Size = new System.Drawing.Size(176, 79);
            this.btnMakeOrder.TabIndex = 22;
            this.btnMakeOrder.Text = "Remover";
            this.btnMakeOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMakeOrder.UseVisualStyleBackColor = false;
            this.btnMakeOrder.Click += new System.EventHandler(this.BtnDeativatMeal_Click);
            // 
            // panelMeals
            // 
            this.panelMeals.AutoScroll = true;
            this.panelMeals.BackColor = System.Drawing.Color.Transparent;
            this.panelMeals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMeals.Location = new System.Drawing.Point(184, 50);
            this.panelMeals.Margin = new System.Windows.Forms.Padding(4);
            this.panelMeals.Name = "panelMeals";
            this.panelMeals.Size = new System.Drawing.Size(992, 674);
            this.panelMeals.TabIndex = 21;
            // 
            // Remove_Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1303, 919);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbUpdate);
            this.Controls.Add(this.lbRemoveMeal);
            this.Controls.Add(this.MealDateTime);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnMakeOrder);
            this.Controls.Add(this.panelMeals);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Remove_Meal";
            this.Text = "Remover_Refeicoes";
            this.Load += new System.EventHandler(this.Remove_Meal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbUpdate;
        private System.Windows.Forms.Label lbRemoveMeal;
        private System.Windows.Forms.DateTimePicker MealDateTime;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnMakeOrder;
        private System.Windows.Forms.Panel panelMeals;
    }
}