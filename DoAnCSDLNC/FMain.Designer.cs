namespace DoAnCSDLNC
{
    partial class FMain
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
            this.mStrpMain = new System.Windows.Forms.MenuStrip();
            this.menuItemFindTour = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditContract = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAccdent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemManagment = new System.Windows.Forms.ToolStripMenuItem();
            this.chiếtKhấuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemQuantityDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAgeDiscount = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRefund = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTour = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            pnlMain = new System.Windows.Forms.Panel();
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mStrpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mStrpMain
            // 
            this.mStrpMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mStrpMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemFindTour,
            this.menuItemEditContract,
            this.menuItemAccdent,
            this.menuItemManagment,
            this.menuItemLogin});
            this.mStrpMain.Location = new System.Drawing.Point(0, 0);
            this.mStrpMain.Name = "mStrpMain";
            this.mStrpMain.Size = new System.Drawing.Size(1370, 32);
            this.mStrpMain.TabIndex = 1;
            this.mStrpMain.Text = "menuStrip1";
            // 
            // menuItemFindTour
            // 
            this.menuItemFindTour.Enabled = false;
            this.menuItemFindTour.Name = "menuItemFindTour";
            this.menuItemFindTour.Size = new System.Drawing.Size(157, 28);
            this.menuItemFindTour.Text = "Tìm kiếm Tour";
            this.menuItemFindTour.Click += new System.EventHandler(this.menuItemFindTour_Click);
            // 
            // menuItemEditContract
            // 
            this.menuItemEditContract.Enabled = false;
            this.menuItemEditContract.Name = "menuItemEditContract";
            this.menuItemEditContract.Size = new System.Drawing.Size(151, 28);
            this.menuItemEditContract.Text = "Chỉnh sửa HĐ";
            this.menuItemEditContract.Click += new System.EventHandler(this.menuItemEditContract_Click);
            // 
            // menuItemAccdent
            // 
            this.menuItemAccdent.Enabled = false;
            this.menuItemAccdent.Name = "menuItemAccdent";
            this.menuItemAccdent.Size = new System.Drawing.Size(76, 28);
            this.menuItemAccdent.Text = "Sự cố";
            this.menuItemAccdent.Click += new System.EventHandler(this.menuItemAccdent_Click);
            // 
            // menuItemManagment
            // 
            this.menuItemManagment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chiếtKhấuToolStripMenuItem,
            this.menuItemRefund,
            this.menuItemTour,
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem});
            this.menuItemManagment.Enabled = false;
            this.menuItemManagment.Name = "menuItemManagment";
            this.menuItemManagment.Size = new System.Drawing.Size(94, 28);
            this.menuItemManagment.Text = "Quản lý";
            // 
            // chiếtKhấuToolStripMenuItem
            // 
            this.chiếtKhấuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemQuantityDiscount,
            this.menuItemAgeDiscount});
            this.chiếtKhấuToolStripMenuItem.Name = "chiếtKhấuToolStripMenuItem";
            this.chiếtKhấuToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.chiếtKhấuToolStripMenuItem.Text = "Chiết khấu";
            // 
            // menuItemQuantityDiscount
            // 
            this.menuItemQuantityDiscount.Name = "menuItemQuantityDiscount";
            this.menuItemQuantityDiscount.Size = new System.Drawing.Size(319, 28);
            this.menuItemQuantityDiscount.Text = "Theo số lượng thành viên";
            this.menuItemQuantityDiscount.Click += new System.EventHandler(this.menuItemQuantityDiscount_Click);
            // 
            // menuItemAgeDiscount
            // 
            this.menuItemAgeDiscount.Name = "menuItemAgeDiscount";
            this.menuItemAgeDiscount.Size = new System.Drawing.Size(319, 28);
            this.menuItemAgeDiscount.Text = "Theo tuổi";
            this.menuItemAgeDiscount.Click += new System.EventHandler(this.menuItemAgeDiscount_Click);
            // 
            // menuItemRefund
            // 
            this.menuItemRefund.Name = "menuItemRefund";
            this.menuItemRefund.Size = new System.Drawing.Size(282, 28);
            this.menuItemRefund.Text = "Hoàn cọc";
            this.menuItemRefund.Click += new System.EventHandler(this.menuItemRefund_Click);
            // 
            // menuItemTour
            // 
            this.menuItemTour.Name = "menuItemTour";
            this.menuItemTour.Size = new System.Drawing.Size(282, 28);
            this.menuItemTour.Text = "Tour";
            this.menuItemTour.Click += new System.EventHandler(this.menuItemTour_Click);
            // 
            // menuItemLogin
            // 
            this.menuItemLogin.Enabled = false;
            this.menuItemLogin.Name = "menuItemLogin";
            this.menuItemLogin.Size = new System.Drawing.Size(124, 28);
            this.menuItemLogin.Text = "Đăng nhập";
            this.menuItemLogin.Click += new System.EventHandler(this.menuItemLogin_Click);
            // 
            // pnlMain
            // 
            pnlMain.Location = new System.Drawing.Point(12, 35);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(1346, 702);
            pnlMain.TabIndex = 2;
            // 
            // tạoTàiKhoánQuảnTrịToolStripMenuItem
            // 
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem.Name = "tạoTàiKhoánQuảnTrịToolStripMenuItem";
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem.Size = new System.Drawing.Size(282, 28);
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem.Text = "Tạo tài khoán quản trị";
            this.tạoTàiKhoánQuảnTrịToolStripMenuItem.Click += new System.EventHandler(this.tạoTàiKhoánQuảnTrịToolStripMenuItem_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(pnlMain);
            this.Controls.Add(this.mStrpMain);
            this.MainMenuStrip = this.mStrpMain;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.FMain_Activated);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.Shown += new System.EventHandler(this.FMain_Shown);
            this.mStrpMain.ResumeLayout(false);
            this.mStrpMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mStrpMain;
        private System.Windows.Forms.ToolStripMenuItem menuItemFindTour;
        private System.Windows.Forms.ToolStripMenuItem menuItemAccdent;
        private System.Windows.Forms.ToolStripMenuItem menuItemManagment;
        private System.Windows.Forms.ToolStripMenuItem chiếtKhấuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemQuantityDiscount;
        private System.Windows.Forms.ToolStripMenuItem menuItemAgeDiscount;
        private System.Windows.Forms.ToolStripMenuItem menuItemRefund;
        private System.Windows.Forms.ToolStripMenuItem menuItemTour;
        public System.Windows.Forms.ToolStripMenuItem menuItemLogin;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditContract;
        private System.Windows.Forms.ToolStripMenuItem tạoTàiKhoánQuảnTrịToolStripMenuItem;
        public static System.Windows.Forms.Panel pnlMain;
    }
}

