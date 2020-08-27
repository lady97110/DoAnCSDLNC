namespace DoAnCSDLNC.Views.Manage
{
    partial class FRefund
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
            this.btnAddRefund = new System.Windows.Forms.Button();
            this.btnDeleteRefund = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxRefundRate = new System.Windows.Forms.TextBox();
            this.dtgListRefund = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMinday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxMaxDay = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListRefund)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddRefund);
            this.panel1.Controls.Add(this.btnDeleteRefund);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Location = new System.Drawing.Point(1009, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 78);
            this.panel1.TabIndex = 88;
            // 
            // btnAddRefund
            // 
            this.btnAddRefund.BackColor = System.Drawing.Color.Salmon;
            this.btnAddRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRefund.Location = new System.Drawing.Point(14, 3);
            this.btnAddRefund.Name = "btnAddRefund";
            this.btnAddRefund.Size = new System.Drawing.Size(70, 70);
            this.btnAddRefund.TabIndex = 4;
            this.btnAddRefund.Text = "Thêm";
            this.btnAddRefund.UseVisualStyleBackColor = false;
            this.btnAddRefund.Click += new System.EventHandler(this.btnAddRefund_Click);
            // 
            // btnDeleteRefund
            // 
            this.btnDeleteRefund.BackColor = System.Drawing.Color.Salmon;
            this.btnDeleteRefund.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRefund.Location = new System.Drawing.Point(132, 3);
            this.btnDeleteRefund.Name = "btnDeleteRefund";
            this.btnDeleteRefund.Size = new System.Drawing.Size(70, 70);
            this.btnDeleteRefund.TabIndex = 5;
            this.btnDeleteRefund.Text = "Xóa";
            this.btnDeleteRefund.UseVisualStyleBackColor = false;
            this.btnDeleteRefund.Click += new System.EventHandler(this.btnDeleteRefund_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Salmon;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(242, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(70, 70);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxRefundRate
            // 
            this.tbxRefundRate.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRefundRate.Location = new System.Drawing.Point(727, 206);
            this.tbxRefundRate.Name = "tbxRefundRate";
            this.tbxRefundRate.Size = new System.Drawing.Size(100, 32);
            this.tbxRefundRate.TabIndex = 87;
            // 
            // dtgListRefund
            // 
            this.dtgListRefund.AllowUserToAddRows = false;
            this.dtgListRefund.AllowUserToDeleteRows = false;
            this.dtgListRefund.AllowUserToResizeColumns = false;
            this.dtgListRefund.AllowUserToResizeRows = false;
            this.dtgListRefund.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListRefund.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListRefund.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListRefund.ColumnHeadersHeight = 30;
            this.dtgListRefund.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListRefund.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListRefund.Location = new System.Drawing.Point(12, 262);
            this.dtgListRefund.Name = "dtgListRefund";
            this.dtgListRefund.ReadOnly = true;
            this.dtgListRefund.RowHeadersVisible = false;
            this.dtgListRefund.RowHeadersWidth = 100;
            this.dtgListRefund.Size = new System.Drawing.Size(1323, 428);
            this.dtgListRefund.TabIndex = 89;
            this.dtgListRefund.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListRefund_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(327, 39);
            this.label3.TabIndex = 93;
            this.label3.Text = "Thông tin hoàn cọc";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxMinday
            // 
            this.tbxMinday.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMinday.Location = new System.Drawing.Point(162, 206);
            this.tbxMinday.Name = "tbxMinday";
            this.tbxMinday.Size = new System.Drawing.Size(100, 32);
            this.tbxMinday.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 90;
            this.label7.Text = "Số ngày từ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 25);
            this.label4.TabIndex = 91;
            this.label4.Text = "Hoàn cọc(%) :";
            // 
            // tbxMaxDay
            // 
            this.tbxMaxDay.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaxDay.Location = new System.Drawing.Point(402, 206);
            this.tbxMaxDay.Name = "tbxMaxDay";
            this.tbxMaxDay.Size = new System.Drawing.Size(100, 32);
            this.tbxMaxDay.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 25);
            this.label2.TabIndex = 92;
            this.label2.Text = "Đến :";
            // 
            // FRefund
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxRefundRate);
            this.Controls.Add(this.dtgListRefund);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxMinday);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxMaxDay);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FRefund";
            this.Text = "FRefund";
            this.Load += new System.EventHandler(this.FRefund_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListRefund)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddRefund;
        private System.Windows.Forms.Button btnDeleteRefund;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxRefundRate;
        private System.Windows.Forms.DataGridView dtgListRefund;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMinday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxMaxDay;
        private System.Windows.Forms.Label label2;
    }
}