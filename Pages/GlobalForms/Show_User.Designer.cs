namespace MealSync_APP.Pages.GlobalForms
{
    partial class Show_User
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_User));
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.btnAlphabeticOrder = new System.Windows.Forms.Button();
            this.btnIdOrder = new System.Windows.Forms.Button();
            this.btnCreatedAtOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbLetterA = new System.Windows.Forms.Label();
            this.lbLetterZ = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAllUsers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(288, 67);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.Size = new System.Drawing.Size(707, 404);
            this.dgvUsers.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Sienna;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.Location = new System.Drawing.Point(76, 471);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(154, 76);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.BackColor = System.Drawing.Color.Transparent;
            this.lbText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbText.ForeColor = System.Drawing.Color.White;
            this.lbText.Location = new System.Drawing.Point(284, 500);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(74, 24);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Ordem:";
            // 
            // btnAlphabeticOrder
            // 
            this.btnAlphabeticOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnAlphabeticOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlphabeticOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAlphabeticOrder.Location = new System.Drawing.Point(393, 488);
            this.btnAlphabeticOrder.Name = "btnAlphabeticOrder";
            this.btnAlphabeticOrder.Size = new System.Drawing.Size(194, 50);
            this.btnAlphabeticOrder.TabIndex = 4;
            this.btnAlphabeticOrder.Text = "Alfabetica";
            this.btnAlphabeticOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlphabeticOrder.UseVisualStyleBackColor = false;
            this.btnAlphabeticOrder.Click += new System.EventHandler(this.BtnAlphabeticOrder_Click);
            // 
            // btnIdOrder
            // 
            this.btnIdOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnIdOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIdOrder.ForeColor = System.Drawing.Color.White;
            this.btnIdOrder.Location = new System.Drawing.Point(593, 488);
            this.btnIdOrder.Name = "btnIdOrder";
            this.btnIdOrder.Size = new System.Drawing.Size(199, 50);
            this.btnIdOrder.TabIndex = 5;
            this.btnIdOrder.Text = "              ID";
            this.btnIdOrder.UseVisualStyleBackColor = false;
            this.btnIdOrder.Click += new System.EventHandler(this.BtnIdOrder_Click);
            // 
            // btnCreatedAtOrder
            // 
            this.btnCreatedAtOrder.BackColor = System.Drawing.Color.Sienna;
            this.btnCreatedAtOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreatedAtOrder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCreatedAtOrder.Location = new System.Drawing.Point(798, 488);
            this.btnCreatedAtOrder.Name = "btnCreatedAtOrder";
            this.btnCreatedAtOrder.Size = new System.Drawing.Size(188, 50);
            this.btnCreatedAtOrder.TabIndex = 6;
            this.btnCreatedAtOrder.Text = "Data de Criação";
            this.btnCreatedAtOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreatedAtOrder.UseVisualStyleBackColor = false;
            this.btnCreatedAtOrder.Click += new System.EventHandler(this.BtnCreatedAtOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Sienna;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(127, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "🔄";
            this.label1.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Sienna;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(414, 492);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "⬇️";
            this.label2.Click += new System.EventHandler(this.BtnAlphabeticOrder_Click);
            // 
            // lbLetterA
            // 
            this.lbLetterA.AutoSize = true;
            this.lbLetterA.BackColor = System.Drawing.Color.Sienna;
            this.lbLetterA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetterA.ForeColor = System.Drawing.Color.Snow;
            this.lbLetterA.Location = new System.Drawing.Point(441, 492);
            this.lbLetterA.Name = "lbLetterA";
            this.lbLetterA.Size = new System.Drawing.Size(20, 24);
            this.lbLetterA.TabIndex = 10;
            this.lbLetterA.Text = "𝐀";
            this.lbLetterA.Click += new System.EventHandler(this.BtnAlphabeticOrder_Click);
            // 
            // lbLetterZ
            // 
            this.lbLetterZ.AutoSize = true;
            this.lbLetterZ.BackColor = System.Drawing.Color.Sienna;
            this.lbLetterZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLetterZ.ForeColor = System.Drawing.Color.Snow;
            this.lbLetterZ.Location = new System.Drawing.Point(442, 510);
            this.lbLetterZ.Name = "lbLetterZ";
            this.lbLetterZ.Size = new System.Drawing.Size(19, 24);
            this.lbLetterZ.TabIndex = 11;
            this.lbLetterZ.Text = "𝐙";
            this.lbLetterZ.Click += new System.EventHandler(this.BtnAlphabeticOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Sienna;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Snow;
            this.label5.Location = new System.Drawing.Point(654, 492);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 37);
            this.label5.TabIndex = 12;
            this.label5.Text = "🪪";
            this.label5.Click += new System.EventHandler(this.BtnIdOrder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Sienna;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Snow;
            this.label7.Location = new System.Drawing.Point(809, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 33);
            this.label7.TabIndex = 14;
            this.label7.Text = "📝";
            this.label7.Click += new System.EventHandler(this.BtnCreatedAtOrder_Click);
            // 
            // btnAllUsers
            // 
            this.btnAllUsers.BackColor = System.Drawing.Color.Sienna;
            this.btnAllUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAllUsers.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAllUsers.Location = new System.Drawing.Point(68, 278);
            this.btnAllUsers.Name = "btnAllUsers";
            this.btnAllUsers.Size = new System.Drawing.Size(162, 76);
            this.btnAllUsers.TabIndex = 15;
            this.btnAllUsers.Text = "Todos Utilizadores";
            this.btnAllUsers.UseVisualStyleBackColor = false;
            this.btnAllUsers.Click += new System.EventHandler(this.BtnAllUsers_Click);
            // 
            // Show_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1029, 587);
            this.Controls.Add(this.btnAllUsers);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbLetterZ);
            this.Controls.Add(this.lbLetterA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreatedAtOrder);
            this.Controls.Add(this.btnIdOrder);
            this.Controls.Add(this.btnAlphabeticOrder);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvUsers);
            this.MaximizeBox = false;
            this.Name = "Show_User";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Show_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnAlphabeticOrder;
        private System.Windows.Forms.Button btnIdOrder;
        private System.Windows.Forms.Button btnCreatedAtOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbLetterA;
        private System.Windows.Forms.Label lbLetterZ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAllUsers;
    }
}