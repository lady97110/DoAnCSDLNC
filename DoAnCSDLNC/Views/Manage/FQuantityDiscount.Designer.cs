namespace DoAnCSDLNC.Views.Manage
{
    partial class FQuantityDiscount
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddDiscount = new System.Windows.Forms.Button();
            this.btnDeleteDiscount = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.dtgListDiscount = new System.Windows.Forms.DataGridView();
            this.tbxDiscountRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMinQuantity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMaxQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListDiscount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddDiscount);
            this.panel1.Controls.Add(this.btnDeleteDiscount);
            this.panel1.Controls.Add(this.btnSaveDiscount);
            this.panel1.Location = new System.Drawing.Point(1009, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 78);
            this.panel1.TabIndex = 85;
            // 
            // btnAddDiscount
            // 
            this.btnAddDiscount.BackColor = System.Drawing.Color.Salmon;
            this.btnAddDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDiscount.Location = new System.Drawing.Point(14, 3);
            this.btnAddDiscount.Name = "btnAddDiscount";
            this.btnAddDiscount.Size = new System.Drawing.Size(70, 70);
            this.btnAddDiscount.TabIndex = 4;
            this.btnAddDiscount.Text = "Thêm";
            this.btnAddDiscount.UseVisualStyleBackColor = false;
            this.btnAddDiscount.Click += new System.EventHandler(this.btnAddDiscount_Click);
            // 
            // btnDeleteDiscount
            // 
            this.btnDeleteDiscount.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDiscount.Location = new System.Drawing.Point(132, 3);
            this.btnDeleteDiscount.Name = "btnDeleteDiscount";
            this.btnDeleteDiscount.Size = new System.Drawing.Size(70, 70);
            this.btnDeleteDiscount.TabIndex = 5;
            this.btnDeleteDiscount.Text = "Xóa";
            this.btnDeleteDiscount.UseVisualStyleBackColor = false;
            this.btnDeleteDiscount.Click += new System.EventHandler(this.btnDeleteDiscount_Click);
            // 
            // btnSaveDiscount
            // 
            this.btnSaveDiscount.BackColor = System.Drawing.Color.Salmon;
            this.btnSaveDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveDiscount.Location = new System.Drawing.Point(242, 3);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(70, 70);
            this.btnSaveDiscount.TabIndex = 3;
            this.btnSaveDiscount.Text = "Lưu";
            this.btnSaveDiscount.UseVisualStyleBackColor = false;
            this.btnSaveDiscount.Click += new System.EventHandler(this.btnSaveDiscount_Click);
            // 
            // dtgListDiscount
            // 
            this.dtgListDiscount.AllowUserToAddRows = false;
            this.dtgListDiscount.AllowUserToDeleteRows = false;
            this.dtgListDiscount.AllowUserToResizeColumns = false;
            this.dtgListDiscount.AllowUserToResizeRows = false;
            this.dtgListDiscount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListDiscount.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListDiscount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListDiscount.ColumnHeadersHeight = 30;
            this.dtgListDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListDiscount.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListDiscount.Location = new System.Drawing.Point(12, 268);
            this.dtgListDiscount.Name = "dtgListDiscount";
            this.dtgListDiscount.ReadOnly = true;
            this.dtgListDiscount.RowHeadersVisible = false;
            this.dtgListDiscount.RowHeadersWidth = 100;
            this.dtgListDiscount.Size = new System.Drawing.Size(1323, 422);
            this.dtgListDiscount.TabIndex = 80;
            this.dtgListDiscount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListDiscount_CellClick);
            // 
            // tbxDiscountRate
            // 
            this.tbxDiscountRate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDiscountRate.Location = new System.Drawing.Point(722, 209);
            this.tbxDiscountRate.Name = "tbxDiscountRate";
            this.tbxDiscountRate.Size = new System.Drawing.Size(100, 32);
            this.tbxDiscountRate.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(421, 39);
            this.label3.TabIndex = 84;
            this.label3.Text = "Chiết khấu theo số lượng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMinQuantity
            // 
            this.tbxMinQuantity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMinQuantity.Location = new System.Drawing.Point(157, 209);
            this.tbxMinQuantity.Name = "tbxMinQuantity";
            this.tbxMinQuantity.Size = new System.Drawing.Size(100, 32);
            this.tbxMinQuantity.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "Số lượng từ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(557, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Chiết khấu(%) :";
            // 
            // tbxMaxQuantity
            // 
            this.tbxMaxQuantity.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaxQuantity.Location = new System.Drawing.Point(397, 209);
            this.tbxMaxQuantity.Name = "tbxMaxQuantity";
            this.tbxMaxQuantity.Size = new System.Drawing.Size(100, 32);
            this.tbxMaxQuantity.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 83;
            this.label2.Text = "Đến :";
            // 
            // FQuantityDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtgListDiscount);
            this.Controls.Add(this.tbxDiscountRate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMinQuantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMaxQuantity);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FQuantityDiscount";
            this.Text = "FQuantityDiscount";
            this.Load += new System.EventHandler(this.FQuantityDiscount_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListDiscount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddDiscount;
        private System.Windows.Forms.Button btnDeleteDiscount;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.DataGridView dtgListDiscount;
        private System.Windows.Forms.TextBox tbxDiscountRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMinQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaxQuantity;
        private System.Windows.Forms.Label label2;
    }
}