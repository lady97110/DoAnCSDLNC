namespace DoAnCSDLNC.Views
{
    partial class FAccident
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
            this.cbxContractId = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ThemSC = new System.Windows.Forms.Button();
            this.btn_XoaSC = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDraftDate = new System.Windows.Forms.DateTimePicker();
            this.dtgListAccident = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxPayDamage = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAccidentName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListAccident)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxContractId
            // 
            this.cbxContractId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContractId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxContractId.FormattingEnabled = true;
            this.cbxContractId.Location = new System.Drawing.Point(269, 151);
            this.cbxContractId.Name = "cbxContractId";
            this.cbxContractId.Size = new System.Drawing.Size(250, 33);
            this.cbxContractId.TabIndex = 78;
            this.cbxContractId.SelectionChangeCommitted += new System.EventHandler(this.cbxContractId_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(139, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 89;
            this.label8.Text = "Mã HĐ :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ThemSC);
            this.panel1.Controls.Add(this.btn_XoaSC);
            this.panel1.Controls.Add(this.btn_Luu);
            this.panel1.Location = new System.Drawing.Point(1045, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(289, 78);
            this.panel1.TabIndex = 88;
            // 
            // btn_ThemSC
            // 
            this.btn_ThemSC.BackColor = System.Drawing.Color.Salmon;
            this.btn_ThemSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemSC.Location = new System.Drawing.Point(14, 3);
            this.btn_ThemSC.Name = "btn_ThemSC";
            this.btn_ThemSC.Size = new System.Drawing.Size(70, 70);
            this.btn_ThemSC.TabIndex = 41;
            this.btn_ThemSC.Text = "Thêm SC";
            this.btn_ThemSC.UseVisualStyleBackColor = false;
            this.btn_ThemSC.Click += new System.EventHandler(this.btn_ThemSC_Click);
            // 
            // btn_XoaSC
            // 
            this.btn_XoaSC.BackColor = System.Drawing.Color.Salmon;
            this.btn_XoaSC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaSC.Location = new System.Drawing.Point(109, 3);
            this.btn_XoaSC.Name = "btn_XoaSC";
            this.btn_XoaSC.Size = new System.Drawing.Size(70, 70);
            this.btn_XoaSC.TabIndex = 41;
            this.btn_XoaSC.Text = "Xóa SC";
            this.btn_XoaSC.UseVisualStyleBackColor = false;
            this.btn_XoaSC.Click += new System.EventHandler(this.btn_XoaSC_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.Salmon;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(204, 3);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(70, 70);
            this.btn_Luu.TabIndex = 38;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(239, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 39);
            this.label3.TabIndex = 86;
            this.label3.Text = "Biên bản sự cố ";
            // 
            // dtpDraftDate
            // 
            this.dtpDraftDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDraftDate.Enabled = false;
            this.dtpDraftDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDraftDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDraftDate.Location = new System.Drawing.Point(144, 306);
            this.dtpDraftDate.Name = "dtpDraftDate";
            this.dtpDraftDate.Size = new System.Drawing.Size(250, 31);
            this.dtpDraftDate.TabIndex = 85;
            // 
            // dtgListAccident
            // 
            this.dtgListAccident.AllowUserToAddRows = false;
            this.dtgListAccident.AllowUserToDeleteRows = false;
            this.dtgListAccident.AllowUserToResizeColumns = false;
            this.dtgListAccident.AllowUserToResizeRows = false;
            this.dtgListAccident.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListAccident.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListAccident.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListAccident.ColumnHeadersHeight = 30;
            this.dtgListAccident.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListAccident.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListAccident.Location = new System.Drawing.Point(12, 381);
            this.dtgListAccident.Name = "dtgListAccident";
            this.dtgListAccident.ReadOnly = true;
            this.dtgListAccident.RowHeadersVisible = false;
            this.dtgListAccident.RowHeadersWidth = 100;
            this.dtgListAccident.Size = new System.Drawing.Size(1322, 309);
            this.dtgListAccident.TabIndex = 87;
            this.dtgListAccident.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListAccident_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "Ngày lập  :";
            // 
            // tbxPayDamage
            // 
            this.tbxPayDamage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPayDamage.Location = new System.Drawing.Point(596, 306);
            this.tbxPayDamage.Name = "tbxPayDamage";
            this.tbxPayDamage.Size = new System.Drawing.Size(250, 31);
            this.tbxPayDamage.TabIndex = 84;
            this.tbxPayDamage.Text = "0";
            this.tbxPayDamage.TextChanged += new System.EventHandler(this.tbxPayDamage_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 82;
            this.label2.Text = "Bồi thường :";
            // 
            // tbxAccidentName
            // 
            this.tbxAccidentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAccidentName.Location = new System.Drawing.Point(144, 223);
            this.tbxAccidentName.Name = "tbxAccidentName";
            this.tbxAccidentName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxAccidentName.Size = new System.Drawing.Size(1187, 31);
            this.tbxAccidentName.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Sự cố :";
            // 
            // FAccident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.cbxContractId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDraftDate);
            this.Controls.Add(this.dtgListAccident);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbxPayDamage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbxAccidentName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FAccident";
            this.Text = "FAccident";
            this.Load += new System.EventHandler(this.FAccident_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListAccident)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbxContractId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ThemSC;
        private System.Windows.Forms.Button btn_XoaSC;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDraftDate;
        private System.Windows.Forms.DataGridView dtgListAccident;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox tbxPayDamage;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxAccidentName;
        private System.Windows.Forms.Label label1;
    }
}