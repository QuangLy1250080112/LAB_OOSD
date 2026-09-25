namespace QLKhachsan.Forms
{
    partial class FrmTraPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabDenBu, tabHoaDon;

        // Control Tab Đền Bù
        private System.Windows.Forms.ComboBox cboDat, cboNV;
        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvDBChon;
        private System.Windows.Forms.TextBox txtPhong, txtSoDB, txtMucDo;
        private System.Windows.Forms.NumericUpDown numDenBu;
        private System.Windows.Forms.Button btnThemDB, btnLapDB;

        // Control Tab Hóa Đơn & Thanh Toán
        private System.Windows.Forms.TextBox txtSoHD, txtHDChon, txtMaTT;
        private System.Windows.Forms.ComboBox cboNV2, cboHT;
        private System.Windows.Forms.NumericUpDown numSoNgay, numTienTT;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.Button btnLapHD, btnThanhToan, btnTraPhong, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabDenBu = new System.Windows.Forms.TabPage();
            this.tabHoaDon = new System.Windows.Forms.TabPage();

            this.cboDat = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.dgvDBChon = new System.Windows.Forms.DataGridView();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.txtSoDB = new System.Windows.Forms.TextBox();
            this.txtMucDo = new System.Windows.Forms.TextBox();
            this.numDenBu = new System.Windows.Forms.NumericUpDown();
            this.btnThemDB = new System.Windows.Forms.Button();
            this.btnLapDB = new System.Windows.Forms.Button();

            this.txtSoHD = new System.Windows.Forms.TextBox();
            this.txtHDChon = new System.Windows.Forms.TextBox();
            this.txtMaTT = new System.Windows.Forms.TextBox();
            this.cboNV2 = new System.Windows.Forms.ComboBox();
            this.cboHT = new System.Windows.Forms.ComboBox();
            this.numSoNgay = new System.Windows.Forms.NumericUpDown();
            this.numTienTT = new System.Windows.Forms.NumericUpDown();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.btnLapHD = new System.Windows.Forms.Button();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTraPhong = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            this.tabDenBu.SuspendLayout();
            this.tabHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.Add(this.tabDenBu);
            this.tabMain.Controls.Add(this.tabHoaDon);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Size = new System.Drawing.Size(860, 420);

            // Tab 1: Đền Bù
            this.tabDenBu.Text = "Kiểm Tra & Đền Bù";
            this.cboDat.Location = new System.Drawing.Point(15, 15); this.cboDat.Size = new System.Drawing.Size(150, 23);
            this.cboNV.Location = new System.Drawing.Point(180, 15); this.cboNV.Size = new System.Drawing.Size(150, 23);
            this.txtSoDB.Location = new System.Drawing.Point(345, 15); this.txtSoDB.Size = new System.Drawing.Size(120, 23);

            this.dgvPhong.Location = new System.Drawing.Point(15, 50); this.dgvPhong.Size = new System.Drawing.Size(200, 290);
            this.dgvTN.Location = new System.Drawing.Point(225, 50); this.dgvTN.Size = new System.Drawing.Size(300, 290);
            this.dgvDBChon.Location = new System.Drawing.Point(535, 50); this.dgvDBChon.Size = new System.Drawing.Size(300, 290);

            this.txtPhong.Location = new System.Drawing.Point(15, 350); this.txtPhong.Size = new System.Drawing.Size(80, 23); this.txtPhong.ReadOnly = true;
            this.txtMucDo.Location = new System.Drawing.Point(105, 350); this.txtMucDo.Size = new System.Drawing.Size(110, 23);
            this.numDenBu.Location = new System.Drawing.Point(225, 350); this.numDenBu.Maximum = 50000000; this.numDenBu.Size = new System.Drawing.Size(100, 23);
            this.btnThemDB.Location = new System.Drawing.Point(335, 348); this.btnThemDB.Text = "Thêm Vi Phạm";
            this.btnLapDB.Location = new System.Drawing.Point(725, 348); this.btnLapDB.Text = "Lập Phiếu Đền Bù";
            this.tabDenBu.Controls.AddRange(new System.Windows.Forms.Control[] { this.cboDat, this.cboNV, this.txtSoDB, this.dgvPhong, this.dgvTN, this.dgvDBChon, this.txtPhong, this.txtMucDo, this.numDenBu, this.btnThemDB, this.btnLapDB });

            // Tab 2: Hóa Đơn & Thanh Toán
            this.tabHoaDon.Text = "Lập Hóa Đơn & Trả Phòng";
            this.txtSoHD.Location = new System.Drawing.Point(15, 15); this.txtSoHD.Size = new System.Drawing.Size(110, 23);
            this.cboNV2.Location = new System.Drawing.Point(135, 15); this.cboNV2.Size = new System.Drawing.Size(130, 23);
            this.numSoNgay.Location = new System.Drawing.Point(275, 15); this.numSoNgay.Value = 1; this.numSoNgay.Size = new System.Drawing.Size(60, 23);
            this.btnLapHD.Location = new System.Drawing.Point(345, 13); this.btnLapHD.Text = "1. Lập Hóa Đơn";

            this.dgvHD.Location = new System.Drawing.Point(15, 55); this.dgvHD.Size = new System.Drawing.Size(820, 260);

            this.txtHDChon.Location = new System.Drawing.Point(15, 330); this.txtHDChon.Size = new System.Drawing.Size(100, 23); this.txtHDChon.ReadOnly = true;
            this.txtMaTT.Location = new System.Drawing.Point(125, 330); this.txtMaTT.Size = new System.Drawing.Size(100, 23);
            this.cboHT.Location = new System.Drawing.Point(235, 330); this.cboHT.Size = new System.Drawing.Size(110, 23);
            this.numTienTT.Location = new System.Drawing.Point(355, 330); this.numTienTT.Maximum = 100000000; this.numTienTT.Size = new System.Drawing.Size(110, 23);
            this.btnThanhToan.Location = new System.Drawing.Point(475, 328); this.btnThanhToan.Text = "2. Thanh Toán";
            this.btnTraPhong.Location = new System.Drawing.Point(715, 328); this.btnTraPhong.Size = new System.Drawing.Size(120, 30); this.btnTraPhong.Text = "3. Hoàn Tất Trả Phòng";
            this.tabHoaDon.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtSoHD, this.cboNV2, this.numSoNgay, this.btnLapHD, this.dgvHD, this.txtHDChon, this.txtMaTT, this.cboHT, this.numTienTT, this.btnThanhToan, this.btnTraPhong });

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(750, 430);
            this.btnDong.Size = new System.Drawing.Size(95, 30);
            this.btnDong.Text = "Đóng";

            // FrmTraPhong
            this.ClientSize = new System.Drawing.Size(860, 470);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Trả Phòng & Thanh Toán Hóa Đơn";

            this.tabMain.ResumeLayout(false);
            this.tabDenBu.ResumeLayout(false); this.tabDenBu.PerformLayout();
            this.tabHoaDon.ResumeLayout(false); this.tabHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDBChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDenBu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNgay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTienTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);
        }
    }
}