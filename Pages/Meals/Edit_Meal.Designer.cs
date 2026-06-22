namespace MealSync_APP.MealFolder
{
    partial class Edit_Meal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Meal));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.panelSelectedMeal = new System.Windows.Forms.Panel();
            this.tbMealPrice = new System.Windows.Forms.TextBox();
            this.cbMealType = new System.Windows.Forms.ComboBox();
            this.tbMealDescription = new System.Windows.Forms.TextBox();
            this.tbMealName = new System.Windows.Forms.TextBox();
            this.mealTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lbMealDatetime = new System.Windows.Forms.Label();
            this.lbMealPrice = new System.Windows.Forms.Label();
            this.lbMealType = new System.Windows.Forms.Label();
            this.lbDescription = new System.Windows.Forms.Label();
            this.lbMealName = new System.Windows.Forms.Label();
            this.pictureBoxMealImage = new System.Windows.Forms.PictureBox();
            this.panelMealCards = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelectedMeal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(5, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.BackColor = System.Drawing.Color.Transparent;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSearch.ForeColor = System.Drawing.Color.Snow;
            this.lbSearch.Location = new System.Drawing.Point(754, 11);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(57, 15);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Procurar:";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(815, 8);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(182, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.TextChanged += new System.EventHandler(this.TbSearch_TextChanged);
            // 
            // panelSelectedMeal
            // 
            this.panelSelectedMeal.BackColor = System.Drawing.Color.Transparent;
            this.panelSelectedMeal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSelectedMeal.Controls.Add(this.tbMealPrice);
            this.panelSelectedMeal.Controls.Add(this.cbMealType);
            this.panelSelectedMeal.Controls.Add(this.tbMealDescription);
            this.panelSelectedMeal.Controls.Add(this.tbMealName);
            this.panelSelectedMeal.Controls.Add(this.mealTimePicker);
            this.panelSelectedMeal.Controls.Add(this.lbMealDatetime);
            this.panelSelectedMeal.Controls.Add(this.lbMealPrice);
            this.panelSelectedMeal.Controls.Add(this.lbMealType);
            this.panelSelectedMeal.Controls.Add(this.lbDescription);
            this.panelSelectedMeal.Controls.Add(this.lbMealName);
            this.panelSelectedMeal.Controls.Add(this.pictureBoxMealImage);
            this.panelSelectedMeal.Location = new System.Drawing.Point(574, 49);
            this.panelSelectedMeal.Name = "panelSelectedMeal";
            this.panelSelectedMeal.Size = new System.Drawing.Size(423, 549);
            this.panelSelectedMeal.TabIndex = 17;
            // 
            // tbMealPrice
            // 
            this.tbMealPrice.Location = new System.Drawing.Point(142, 460);
            this.tbMealPrice.Name = "tbMealPrice";
            this.tbMealPrice.Size = new System.Drawing.Size(207, 20);
            this.tbMealPrice.TabIndex = 15;
            // 
            // cbMealType
            // 
            this.cbMealType.FormattingEnabled = true;
            this.cbMealType.Items.AddRange(new object[] {
            "Vegetariano",
            "Peixe",
            "Carne"});
            this.cbMealType.Location = new System.Drawing.Point(142, 402);
            this.cbMealType.Name = "cbMealType";
            this.cbMealType.Size = new System.Drawing.Size(214, 21);
            this.cbMealType.TabIndex = 14;
            // 
            // tbMealDescription
            // 
            this.tbMealDescription.Location = new System.Drawing.Point(142, 347);
            this.tbMealDescription.Multiline = true;
            this.tbMealDescription.Name = "tbMealDescription";
            this.tbMealDescription.Size = new System.Drawing.Size(193, 20);
            this.tbMealDescription.TabIndex = 13;
            // 
            // tbMealName
            // 
            this.tbMealName.Location = new System.Drawing.Point(142, 295);
            this.tbMealName.Name = "tbMealName";
            this.tbMealName.Size = new System.Drawing.Size(207, 20);
            this.tbMealName.TabIndex = 12;
            // 
            // mealTimePicker
            // 
            this.mealTimePicker.Location = new System.Drawing.Point(142, 247);
            this.mealTimePicker.Name = "mealTimePicker";
            this.mealTimePicker.Size = new System.Drawing.Size(193, 20);
            this.mealTimePicker.TabIndex = 11;
            // 
            // lbMealDatetime
            // 
            this.lbMealDatetime.AutoSize = true;
            this.lbMealDatetime.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbMealDatetime.Location = new System.Drawing.Point(98, 247);
            this.lbMealDatetime.Name = "lbMealDatetime";
            this.lbMealDatetime.Size = new System.Drawing.Size(33, 13);
            this.lbMealDatetime.TabIndex = 10;
            this.lbMealDatetime.Text = "Data:";
            // 
            // lbMealPrice
            // 
            this.lbMealPrice.AutoSize = true;
            this.lbMealPrice.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbMealPrice.Location = new System.Drawing.Point(98, 463);
            this.lbMealPrice.Name = "lbMealPrice";
            this.lbMealPrice.Size = new System.Drawing.Size(38, 13);
            this.lbMealPrice.TabIndex = 9;
            this.lbMealPrice.Text = "Preço:";
            // 
            // lbMealType
            // 
            this.lbMealType.AutoSize = true;
            this.lbMealType.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbMealType.Location = new System.Drawing.Point(105, 405);
            this.lbMealType.Name = "lbMealType";
            this.lbMealType.Size = new System.Drawing.Size(31, 13);
            this.lbMealType.TabIndex = 8;
            this.lbMealType.Text = "Tipo:";
            // 
            // lbDescription
            // 
            this.lbDescription.AutoSize = true;
            this.lbDescription.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbDescription.Location = new System.Drawing.Point(78, 350);
            this.lbDescription.Name = "lbDescription";
            this.lbDescription.Size = new System.Drawing.Size(58, 13);
            this.lbDescription.TabIndex = 7;
            this.lbDescription.Text = "Descrição:";
            // 
            // lbMealName
            // 
            this.lbMealName.AutoSize = true;
            this.lbMealName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lbMealName.Location = new System.Drawing.Point(98, 298);
            this.lbMealName.Name = "lbMealName";
            this.lbMealName.Size = new System.Drawing.Size(38, 13);
            this.lbMealName.TabIndex = 6;
            this.lbMealName.Text = "Nome:";
            // 
            // pictureBoxMealImage
            // 
            this.pictureBoxMealImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxMealImage.Location = new System.Drawing.Point(101, 27);
            this.pictureBoxMealImage.Name = "pictureBoxMealImage";
            this.pictureBoxMealImage.Size = new System.Drawing.Size(251, 174);
            this.pictureBoxMealImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMealImage.TabIndex = 5;
            this.pictureBoxMealImage.TabStop = false;
            this.pictureBoxMealImage.Click += new System.EventHandler(this.PictureBoxMealImage_Click);
            // 
            // panelMealCards
            // 
            this.panelMealCards.AutoScroll = true;
            this.panelMealCards.BackColor = System.Drawing.Color.Transparent;
            this.panelMealCards.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMealCards.Location = new System.Drawing.Point(12, 49);
            this.panelMealCards.Name = "panelMealCards";
            this.panelMealCards.Size = new System.Drawing.Size(546, 548);
            this.panelMealCards.TabIndex = 18;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Sienna;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(318, 626);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 84);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Editar";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(507, 626);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(183, 84);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Sienna;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(570, 634);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 39);
            this.label3.TabIndex = 30;
            this.label3.Text = "🔄";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(381, 634);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 39);
            this.label1.TabIndex = 31;
            this.label1.Text = "✍";
            // 
            // Edit_Meal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1051, 738);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelMealCards);
            this.Controls.Add(this.panelSelectedMeal);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "Edit_Meal";
            this.Text = "Editar_Refeicoes";
            this.Load += new System.EventHandler(this.Edit_Meal_Load);
            this.panelSelectedMeal.ResumeLayout(false);
            this.panelSelectedMeal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMealImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Panel panelSelectedMeal;
        private System.Windows.Forms.TextBox tbMealPrice;
        private System.Windows.Forms.ComboBox cbMealType;
        private System.Windows.Forms.TextBox tbMealDescription;
        private System.Windows.Forms.TextBox tbMealName;
        private System.Windows.Forms.DateTimePicker mealTimePicker;
        private System.Windows.Forms.Label lbMealDatetime;
        private System.Windows.Forms.Label lbMealPrice;
        private System.Windows.Forms.Label lbMealType;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Label lbMealName;
        private System.Windows.Forms.PictureBox pictureBoxMealImage;
        private System.Windows.Forms.Panel panelMealCards;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}