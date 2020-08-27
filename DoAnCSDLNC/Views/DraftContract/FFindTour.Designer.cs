namespace DoAnCSDLNC.Views.DraftContract
{
    partial class FFindTour
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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxMaxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxMinPrice = new System.Windows.Forms.TextBox();
            this.tbxStartLocation = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListTour = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbx_ChiTieu = new System.Windows.Forms.GroupBox();
            this.chbxPrice = new System.Windows.Forms.CheckBox();
            this.chbxDate = new System.Windows.Forms.CheckBox();
            this.chbxLocation = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxDestination = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).BeginInit();
            this.gbx_ChiTieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CustomFormat = "dd/MM/yyyy";
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEndDate.Location = new System.Drawing.Point(689, 99);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(216, 31);
            this.dtpEndDate.TabIndex = 3;
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(213, 99);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(216, 31);
            this.dtpFromDate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "Đến :";
            // 
            // tbxMaxPrice
            // 
            this.tbxMaxPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMaxPrice.Location = new System.Drawing.Point(689, 164);
            this.tbxMaxPrice.Name = "tbxMaxPrice";
            this.tbxMaxPrice.Size = new System.Drawing.Size(216, 32);
            this.tbxMaxPrice.TabIndex = 5;
            this.tbxMaxPrice.TextChanged += new System.EventHandler(this.tbxPriceChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 46;
            this.label2.Text = "Đến ngày :";
            // 
            // tbxMinPrice
            // 
            this.tbxMinPrice.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxMinPrice.Location = new System.Drawing.Point(213, 164);
            this.tbxMinPrice.Name = "tbxMinPrice";
            this.tbxMinPrice.Size = new System.Drawing.Size(216, 32);
            this.tbxMinPrice.TabIndex = 4;
            this.tbxMinPrice.TextChanged += new System.EventHandler(this.tbxPriceChanged);
            // 
            // tbxStartLocation
            // 
            this.tbxStartLocation.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxStartLocation.Location = new System.Drawing.Point(213, 40);
            this.tbxStartLocation.Name = "tbxStartLocation";
            this.tbxStartLocation.Size = new System.Drawing.Size(216, 32);
            this.tbxStartLocation.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 89;
            this.label5.Text = "Danh sách Tour :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(599, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 87;
            // 
            // dtgListTour
            // 
            this.dtgListTour.AllowUserToAddRows = false;
            this.dtgListTour.AllowUserToDeleteRows = false;
            this.dtgListTour.AllowUserToResizeColumns = false;
            this.dtgListTour.AllowUserToResizeRows = false;
            this.dtgListTour.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListTour.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListTour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListTour.ColumnHeadersHeight = 30;
            this.dtgListTour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListTour.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListTour.Location = new System.Drawing.Point(12, 308);
            this.dtgListTour.Name = "dtgListTour";
            this.dtgListTour.ReadOnly = true;
            this.dtgListTour.RowHeadersVisible = false;
            this.dtgListTour.RowHeadersWidth = 100;
            this.dtgListTour.Size = new System.Drawing.Size(1322, 382);
            this.dtgListTour.TabIndex = 83;
            this.dtgListTour.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListTour_CellClick);
            this.dtgListTour.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListTour_CellDoubleClick);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Salmon;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(1216, 128);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(118, 53);
            this.btnNext.TabIndex = 84;
            this.btnNext.Text = "Tiếp theo";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Salmon;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1216, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 53);
            this.btnSearch.TabIndex = 81;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbx_ChiTieu
            // 
            this.gbx_ChiTieu.Controls.Add(this.chbxPrice);
            this.gbx_ChiTieu.Controls.Add(this.chbxDate);
            this.gbx_ChiTieu.Controls.Add(this.chbxLocation);
            this.gbx_ChiTieu.Controls.Add(this.dtpEndDate);
            this.gbx_ChiTieu.Controls.Add(this.dtpFromDate);
            this.gbx_ChiTieu.Controls.Add(this.label4);
            this.gbx_ChiTieu.Controls.Add(this.tbxDestination);
            this.gbx_ChiTieu.Controls.Add(this.label3);
            this.gbx_ChiTieu.Controls.Add(this.tbxMaxPrice);
            this.gbx_ChiTieu.Controls.Add(this.label2);
            this.gbx_ChiTieu.Controls.Add(this.tbxMinPrice);
            this.gbx_ChiTieu.Controls.Add(this.tbxStartLocation);
            this.gbx_ChiTieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_ChiTieu.Location = new System.Drawing.Point(159, 36);
            this.gbx_ChiTieu.Name = "gbx_ChiTieu";
            this.gbx_ChiTieu.Size = new System.Drawing.Size(983, 211);
            this.gbx_ChiTieu.TabIndex = 85;
            this.gbx_ChiTieu.TabStop = false;
            this.gbx_ChiTieu.Text = "Chọn tiêu chí";
            // 
            // chbxPrice
            // 
            this.chbxPrice.AutoSize = true;
            this.chbxPrice.Location = new System.Drawing.Point(44, 164);
            this.chbxPrice.Name = "chbxPrice";
            this.chbxPrice.Size = new System.Drawing.Size(100, 29);
            this.chbxPrice.TabIndex = 47;
            this.chbxPrice.Text = "Giá từ: ";
            this.chbxPrice.UseVisualStyleBackColor = true;
            // 
            // chbxDate
            // 
            this.chbxDate.AutoSize = true;
            this.chbxDate.Location = new System.Drawing.Point(44, 103);
            this.chbxDate.Name = "chbxDate";
            this.chbxDate.Size = new System.Drawing.Size(121, 29);
            this.chbxDate.TabIndex = 47;
            this.chbxDate.Text = "Từ ngày: ";
            this.chbxDate.UseVisualStyleBackColor = true;
            // 
            // chbxLocation
            // 
            this.chbxLocation.AutoSize = true;
            this.chbxLocation.Location = new System.Drawing.Point(44, 40);
            this.chbxLocation.Name = "chbxLocation";
            this.chbxLocation.Size = new System.Drawing.Size(115, 29);
            this.chbxLocation.TabIndex = 47;
            this.chbxLocation.Text = "Điểm đi: ";
            this.chbxLocation.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(510, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "Đến :";
            // 
            // tbxDestination
            // 
            this.tbxDestination.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDestination.Location = new System.Drawing.Point(689, 40);
            this.tbxDestination.Name = "tbxDestination";
            this.tbxDestination.Size = new System.Drawing.Size(216, 32);
            this.tbxDestination.TabIndex = 5;
            // 
            // FFindTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgListTour);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbx_ChiTieu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FFindTour";
            this.Text = "fFindingTour";
            this.Load += new System.EventHandler(this.FFindingTour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListTour)).EndInit();
            this.gbx_ChiTieu.ResumeLayout(false);
            this.gbx_ChiTieu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxMaxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxMinPrice;
        private System.Windows.Forms.TextBox tbxStartLocation;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgListTour;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbx_ChiTieu;
        private System.Windows.Forms.CheckBox chbxPrice;
        private System.Windows.Forms.CheckBox chbxDate;
        private System.Windows.Forms.CheckBox chbxLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxDestination;
    }
}