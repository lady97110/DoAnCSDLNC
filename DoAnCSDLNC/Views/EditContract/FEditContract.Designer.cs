namespace DoAnCSDLNC.Views.EditContract
{
    partial class FEditContract
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbxNote = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.dtpTerminalDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelContract = new System.Windows.Forms.Button();
            this.btnSaveContract = new System.Windows.Forms.Button();
            this.tbxDeposit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbxPayedMoney = new System.Windows.Forms.TextBox();
            this.tbxTotalMoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbxQuantityDiscount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxContractId = new System.Windows.Forms.ComboBox();
            this.lb_MaHD = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxAddedDeposit = new System.Windows.Forms.TextBox();
            this.dtgListMember = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListMember)).BeginInit();
            this.SuspendLayout();
            // 
            // tbxNote
            // 
            this.tbxNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNote.Location = new System.Drawing.Point(161, 255);
            this.tbxNote.Name = "tbxNote";
            this.tbxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbxNote.Size = new System.Drawing.Size(1176, 31);
            this.tbxNote.TabIndex = 131;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 260);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 25);
            this.label11.TabIndex = 146;
            this.label11.Text = "Ghi chú :";
            // 
            // dtpStartTime
            // 
            this.dtpStartTime.CustomFormat = "dd/MM/yyyy hh:mm tt";
            this.dtpStartTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartTime.Location = new System.Drawing.Point(665, 135);
            this.dtpStartTime.Name = "dtpStartTime";
            this.dtpStartTime.Size = new System.Drawing.Size(244, 31);
            this.dtpStartTime.TabIndex = 145;
            // 
            // dtpTerminalDate
            // 
            this.dtpTerminalDate.CustomFormat = "dd/MM/yyyy";
            this.dtpTerminalDate.Enabled = false;
            this.dtpTerminalDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTerminalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTerminalDate.Location = new System.Drawing.Point(188, 135);
            this.dtpTerminalDate.Name = "dtpTerminalDate";
            this.dtpTerminalDate.Size = new System.Drawing.Size(244, 31);
            this.dtpTerminalDate.TabIndex = 129;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 25);
            this.label9.TabIndex = 144;
            this.label9.Text = "Ngày thanh lý :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelContract);
            this.panel1.Controls.Add(this.btnSaveContract);
            this.panel1.Location = new System.Drawing.Point(1066, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 78);
            this.panel1.TabIndex = 143;
            // 
            // btnCancelContract
            // 
            this.btnCancelContract.BackColor = System.Drawing.Color.Salmon;
            this.btnCancelContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelContract.Location = new System.Drawing.Point(195, 5);
            this.btnCancelContract.Name = "btnCancelContract";
            this.btnCancelContract.Size = new System.Drawing.Size(70, 70);
            this.btnCancelContract.TabIndex = 38;
            this.btnCancelContract.Text = "Huỷ HĐ";
            this.btnCancelContract.UseVisualStyleBackColor = false;
            this.btnCancelContract.Click += new System.EventHandler(this.btnCancelContract_Click);
            // 
            // btnSaveContract
            // 
            this.btnSaveContract.BackColor = System.Drawing.Color.Salmon;
            this.btnSaveContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveContract.Location = new System.Drawing.Point(4, 5);
            this.btnSaveContract.Name = "btnSaveContract";
            this.btnSaveContract.Size = new System.Drawing.Size(70, 70);
            this.btnSaveContract.TabIndex = 38;
            this.btnSaveContract.Text = "Lưu HĐ";
            this.btnSaveContract.UseVisualStyleBackColor = false;
            this.btnSaveContract.Click += new System.EventHandler(this.btnSaveContract_Click);
            // 
            // tbxDeposit
            // 
            this.tbxDeposit.BackColor = System.Drawing.Color.White;
            this.tbxDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxDeposit.Location = new System.Drawing.Point(853, 310);
            this.tbxDeposit.Name = "tbxDeposit";
            this.tbxDeposit.ReadOnly = true;
            this.tbxDeposit.Size = new System.Drawing.Size(140, 31);
            this.tbxDeposit.TabIndex = 139;
            this.tbxDeposit.Text = "0";
            this.tbxDeposit.TextChanged += new System.EventHandler(this.tbxMoneyChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(725, 313);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 25);
            this.label10.TabIndex = 135;
            this.label10.Text = "Tiền cọc  :";
            // 
            // tbxPayedMoney
            // 
            this.tbxPayedMoney.BackColor = System.Drawing.Color.White;
            this.tbxPayedMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPayedMoney.Location = new System.Drawing.Point(534, 310);
            this.tbxPayedMoney.Name = "tbxPayedMoney";
            this.tbxPayedMoney.ReadOnly = true;
            this.tbxPayedMoney.Size = new System.Drawing.Size(160, 31);
            this.tbxPayedMoney.TabIndex = 140;
            this.tbxPayedMoney.Text = "0";
            this.tbxPayedMoney.TextChanged += new System.EventHandler(this.tbxMoneyChanged);
            // 
            // tbxTotalMoney
            // 
            this.tbxTotalMoney.BackColor = System.Drawing.Color.White;
            this.tbxTotalMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalMoney.Location = new System.Drawing.Point(878, 196);
            this.tbxTotalMoney.Name = "tbxTotalMoney";
            this.tbxTotalMoney.ReadOnly = true;
            this.tbxTotalMoney.Size = new System.Drawing.Size(160, 31);
            this.tbxTotalMoney.TabIndex = 141;
            this.tbxTotalMoney.Text = "0";
            this.tbxTotalMoney.TextChanged += new System.EventHandler(this.tbxMoneyChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 136;
            this.label1.Text = "Thanh toán :";
            // 
            // tbxQuantity
            // 
            this.tbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantity.Location = new System.Drawing.Point(161, 196);
            this.tbxQuantity.Name = "tbxQuantity";
            this.tbxQuantity.Size = new System.Drawing.Size(140, 31);
            this.tbxQuantity.TabIndex = 130;
            this.tbxQuantity.Text = "0";
            this.tbxQuantity.Leave += new System.EventHandler(this.tbxQuantity_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(746, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 25);
            this.label12.TabIndex = 137;
            this.label12.Text = "Tổng tiền :";
            // 
            // tbxQuantityDiscount
            // 
            this.tbxQuantityDiscount.BackColor = System.Drawing.Color.White;
            this.tbxQuantityDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxQuantityDiscount.Location = new System.Drawing.Point(501, 196);
            this.tbxQuantityDiscount.Name = "tbxQuantityDiscount";
            this.tbxQuantityDiscount.ReadOnly = true;
            this.tbxQuantityDiscount.Size = new System.Drawing.Size(140, 31);
            this.tbxQuantityDiscount.TabIndex = 142;
            this.tbxQuantityDiscount.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(367, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 25);
            this.label13.TabIndex = 138;
            this.label13.Text = "Chiết khấu :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 25);
            this.label5.TabIndex = 133;
            this.label5.Text = "Số lượng :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(482, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 25);
            this.label7.TabIndex = 134;
            this.label7.Text = "T.g đón khách:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(154, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 39);
            this.label3.TabIndex = 132;
            this.label3.Text = "Chỉnh sửa hợp đồng";
            // 
            // cbxContractId
            // 
            this.cbxContractId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxContractId.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxContractId.FormattingEnabled = true;
            this.cbxContractId.Location = new System.Drawing.Point(705, 62);
            this.cbxContractId.Name = "cbxContractId";
            this.cbxContractId.Size = new System.Drawing.Size(300, 33);
            this.cbxContractId.TabIndex = 182;
            this.cbxContractId.SelectionChangeCommitted += new System.EventHandler(this.cbxContractId_SelectionChangeCommitted);
            // 
            // lb_MaHD
            // 
            this.lb_MaHD.AutoSize = true;
            this.lb_MaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHD.Location = new System.Drawing.Point(549, 65);
            this.lb_MaHD.Name = "lb_MaHD";
            this.lb_MaHD.Size = new System.Drawing.Size(144, 25);
            this.lb_MaHD.TabIndex = 181;
            this.lb_MaHD.Text = "Mã hợp đồng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1047, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 135;
            this.label2.Text = "Đóng thêm  :";
            // 
            // tbxAddedDeposit
            // 
            this.tbxAddedDeposit.BackColor = System.Drawing.Color.White;
            this.tbxAddedDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddedDeposit.Location = new System.Drawing.Point(1197, 310);
            this.tbxAddedDeposit.Name = "tbxAddedDeposit";
            this.tbxAddedDeposit.Size = new System.Drawing.Size(140, 31);
            this.tbxAddedDeposit.TabIndex = 139;
            this.tbxAddedDeposit.Text = "0";
            this.tbxAddedDeposit.TextChanged += new System.EventHandler(this.tbxMoneyChanged);
            // 
            // dtgListMember
            // 
            this.dtgListMember.AllowUserToAddRows = false;
            this.dtgListMember.AllowUserToDeleteRows = false;
            this.dtgListMember.AllowUserToResizeColumns = false;
            this.dtgListMember.AllowUserToResizeRows = false;
            this.dtgListMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListMember.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgListMember.BackgroundColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgListMember.ColumnHeadersHeight = 30;
            this.dtgListMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListMember.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgListMember.Location = new System.Drawing.Point(15, 365);
            this.dtgListMember.Name = "dtgListMember";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListMember.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgListMember.RowHeadersVisible = false;
            this.dtgListMember.RowHeadersWidth = 100;
            this.dtgListMember.Size = new System.Drawing.Size(1322, 325);
            this.dtgListMember.TabIndex = 128;
            this.dtgListMember.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListMember_CellEndEdit);
            // 
            // FEditContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 702);
            this.Controls.Add(this.dtgListMember);
            this.Controls.Add(this.cbxContractId);
            this.Controls.Add(this.lb_MaHD);
            this.Controls.Add(this.tbxNote);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpStartTime);
            this.Controls.Add(this.dtpTerminalDate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbxAddedDeposit);
            this.Controls.Add(this.tbxDeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbxPayedMoney);
            this.Controls.Add(this.tbxTotalMoney);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxQuantity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbxQuantityDiscount);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FEditContract";
            this.Text = "FEditContract";
            this.Load += new System.EventHandler(this.FEditContract_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbxNote;
        private System.Windows.Forms.Label label11;
        public System.Windows.Forms.DateTimePicker dtpStartTime;
        public System.Windows.Forms.DateTimePicker dtpTerminalDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelContract;
        private System.Windows.Forms.Button btnSaveContract;
        public System.Windows.Forms.TextBox tbxDeposit;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox tbxPayedMoney;
        public System.Windows.Forms.TextBox tbxTotalMoney;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tbxQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbxQuantityDiscount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxContractId;
        private System.Windows.Forms.Label lb_MaHD;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbxAddedDeposit;
        private System.Windows.Forms.DataGridView dtgListMember;
    }
}