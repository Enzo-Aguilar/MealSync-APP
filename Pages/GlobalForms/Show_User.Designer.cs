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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.btnTableOrder = new System.Windows.Forms.Button();
            this.btnTableOrder1 = new System.Windows.Forms.Button();
            this.btnTableOrder2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(720, 360);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(112, 435);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 55);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Atualizar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(298, 456);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(41, 13);
            this.lbText.TabIndex = 3;
            this.lbText.Text = "Ordem:";
            // 
            // btnTableOrder
            // 
            this.btnTableOrder.Location = new System.Drawing.Point(360, 435);
            this.btnTableOrder.Name = "btnTableOrder";
            this.btnTableOrder.Size = new System.Drawing.Size(96, 55);
            this.btnTableOrder.TabIndex = 4;
            this.btnTableOrder.Text = "Alfabetica";
            this.btnTableOrder.UseVisualStyleBackColor = true;
            this.btnTableOrder.Click += new System.EventHandler(this.BtnTableOrder_Click);
            // 
            // btnTableOrder1
            // 
            this.btnTableOrder1.Location = new System.Drawing.Point(462, 435);
            this.btnTableOrder1.Name = "btnTableOrder1";
            this.btnTableOrder1.Size = new System.Drawing.Size(96, 55);
            this.btnTableOrder1.TabIndex = 5;
            this.btnTableOrder1.Text = "ID";
            this.btnTableOrder1.UseVisualStyleBackColor = true;
            this.btnTableOrder1.Click += new System.EventHandler(this.BtnTableOrder1_Click);
            // 
            // btnTableOrder2
            // 
            this.btnTableOrder2.Location = new System.Drawing.Point(564, 435);
            this.btnTableOrder2.Name = "btnTableOrder2";
            this.btnTableOrder2.Size = new System.Drawing.Size(96, 55);
            this.btnTableOrder2.TabIndex = 6;
            this.btnTableOrder2.Text = "Numero de Aluno";
            this.btnTableOrder2.UseVisualStyleBackColor = true;
            this.btnTableOrder2.Click += new System.EventHandler(this.BtnTableOrder2_Click);
            // 
            // Show_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btnTableOrder2);
            this.Controls.Add(this.btnTableOrder1);
            this.Controls.Add(this.btnTableOrder);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Show_User";
            this.Text = "Mostrar";
            this.Load += new System.EventHandler(this.Show_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnTableOrder;
        private System.Windows.Forms.Button btnTableOrder1;
        private System.Windows.Forms.Button btnTableOrder2;
    }
}