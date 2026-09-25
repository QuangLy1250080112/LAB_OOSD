namespace QLKhachsan.Forms
{
    partial class FrmDatPhong
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhach, tabPhieu, tabQLPhieu;

        // Controls Khach
        private System.Windows.Forms.DataGridView dgvKhach;
        private System.Windows.Forms.TextBox txtMaKH, txtTenKH, txtCMND, txtQT, txtSDT;
        private System.Windows.Forms.Button btnThemKhach;

        // Controls Phieu Dat
        private System.Windows.Forms.TextBox txtSoPhieu;
        private System.Windows.Forms.ComboBox cboKhach, cboNV, cboKenh;
        private System.Windows.Forms.DateTimePicker dtLap, dtNhan, dtTra;
        private System.Windows.Forms.NumericUpDown numCoc, numSoNguoi;
        private System.Windows.Forms.DataGridView dgvPhong, dgvChon;
        private System.Windows.Forms.Button btnThemPhong, btnBoPhong, btnLapPhieu;

        // Controls QL Phieu
        private System.Windows.Forms.DataGridView dgvPhieu, dgvCT, dgvNguoi;
        private System.Windows.Forms.TextBox txtPhieuChon, txtNguoiPhong, txtNguoiTen, txtNguoiCMND, txtNguoiQT;
        private System.Windows.Forms.Button btnThemNguoi, btnNhanPhong, btnNoShow, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKhach = new System.Windows.Forms.TabPage();
            this.tabPhieu = new System.Windows.Forms.TabPage();
            this.tabQLPhieu = new System.Windows.Forms.TabPage();

            this.dgvKhach = new System.Windows.Forms.DataGridView();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtQT = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThemKhach = new System.Windows.Forms.Button();

            this.txtSoPhieu = new System.Windows.Forms.TextBox();
            this.cboKhach = new System.Windows.Forms.ComboBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.cboKenh = new System.Windows.Forms.ComboBox();
            this.dtLap = new System.Windows.Forms.DateTimePicker();
            this.dtNhan = new System.Windows.Forms.DateTimePicker();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.numCoc = new System.Windows.Forms.NumericUpDown();
            this.numSoNguoi = new System.Windows.Forms.NumericUpDown();
            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.dgvChon = new System.Windows.Forms.DataGridView();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnBoPhong = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();

            this.dgvPhieu = new System.Windows.Forms.DataGridView();
            this.dgvCT = new System.Windows.Forms.DataGridView();
            this.dgvNguoi = new System.Windows.Forms.DataGridView();
            this.txtPhieuChon = new System.Windows.Forms.TextBox();
            this.txtNguoiPhong = new System.Windows.Forms.TextBox();
            this.txtNguoiTen = new System.Windows.Forms.TextBox();
            this.txtNguoiCMND = new System.Windows.Forms.TextBox();
            this.txtNguoiQT = new System.Windows.Forms.TextBox();
            this.btnThemNguoi = new System.Windows.Forms.Button();
            this.btnNhanPhong = new System.Windows.Forms.Button();
            this.btnNoShow = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            this.tabKhach.SuspendLayout();
            this.tabPhieu.SuspendLayout();
            this.tabQLPhieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.Add(this.tabKhach);
            this.tabMain.Controls.Add(this.tabPhieu);
            this.tabMain.Controls.Add(this.tabQLPhieu);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Size = new System.Drawing.Size(850, 430);

            // Tab Khach Hang
            this.tabKhach.Text = "Khách Hàng";
            this.dgvKhach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhach.Height = 280;
            this.txtMaKH.Location = new System.Drawing.Point(20, 300); this.txtMaKH.Size = new System.Drawing.Size(100, 23);
            this.txtTenKH.Location = new System.Drawing.Point(130, 300); this.txtTenKH.Size = new System.Drawing.Size(150, 23);
            this.txtCMND.Location = new System.Drawing.Point(290, 300); this.txtCMND.Size = new System.Drawing.Size(120, 23);
            this.txtQT.Location = new System.Drawing.Point(420, 300); this.txtQT.Size = new System.Drawing.Size(100, 23);
            this.txtSDT.Location = new System.Drawing.Point(530, 300); this.txtSDT.Size = new System.Drawing.Size(110, 23);
            this.btnThemKhach.Location = new System.Drawing.Point(660, 298); this.btnThemKhach.Text = "Thêm Khách";
            this.tabKhach.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvKhach, this.txtMaKH, this.txtTenKH, this.txtCMND, this.txtQT, this.txtSDT, this.btnThemKhach });

            // Tab Lap Phieu Dat
            this.tabPhieu.Text = "Lập Phiếu Đặt";
            this.txtSoPhieu.Location = new System.Drawing.Point(20, 15); this.txtSoPhieu.Size = new System.Drawing.Size(100, 23);
            this.cboKhach.Location = new System.Drawing.Point(130, 15); this.cboKhach.Size = new System.Drawing.Size(140, 23);
            this.cboNV.Location = new System.Drawing.Point(280, 15); this.cboNV.Size = new System.Drawing.Size(120, 23);
            this.dtLap.Location = new System.Drawing.Point(410, 15); this.dtLap.Size = new System.Drawing.Size(130, 23);
            this.dtNhan.Location = new System.Drawing.Point(20, 50); this.dtNhan.Size = new System.Drawing.Size(130, 23);
            this.dtTra.Location = new System.Drawing.Point(160, 50); this.dtTra.Size = new System.Drawing.Size(130, 23);
            this.numCoc.Location = new System.Drawing.Point(300, 50); this.numCoc.Maximum = 100000000; this.numCoc.Size = new System.Drawing.Size(100, 23);
            this.cboKenh.Location = new System.Drawing.Point(410, 50); this.cboKenh.Size = new System.Drawing.Size(130, 23);

            this.dgvPhong.Location = new System.Drawing.Point(20, 90); this.dgvPhong.Size = new System.Drawing.Size(380, 230);
            this.dgvChon.Location = new System.Drawing.Point(440, 90); this.dgvChon.Size = new System.Drawing.Size(380, 230);
            this.numSoNguoi.Location = new System.Drawing.Point(20, 335); this.numSoNguoi.Value = 1; this.numSoNguoi.Size = new System.Drawing.Size(60, 23);
            this.btnThemPhong.Location = new System.Drawing.Point(90, 333); this.btnThemPhong.Text = "Chọn Phòng >>";
            this.btnBoPhong.Location = new System.Drawing.Point(440, 333); this.btnBoPhong.Text = "Bỏ Chọn";
            this.btnLapPhieu.Location = new System.Drawing.Point(700, 333); this.btnLapPhieu.Text = "Lập Phiếu";
            this.tabPhieu.Controls.AddRange(new System.Windows.Forms.Control[] { this.txtSoPhieu, this.cboKhach, this.cboNV, this.dtLap, this.dtNhan, this.dtTra, this.numCoc, this.cboKenh, this.dgvPhong, this.dgvChon, this.numSoNguoi, this.btnThemPhong, this.btnBoPhong, this.btnLapPhieu });

            // Tab QL Phieu & Nhan Phong
            this.tabQLPhieu.Text = "Quản Lý & Nhận Phòng";
            this.dgvPhieu.Location = new System.Drawing.Point(10, 10); this.dgvPhieu.Size = new System.Drawing.Size(810, 150);
            this.dgvCT.Location = new System.Drawing.Point(10, 170); this.dgvCT.Size = new System.Drawing.Size(390, 130);
            this.dgvNguoi.Location = new System.Drawing.Point(410, 170); this.dgvNguoi.Size = new System.Drawing.Size(410, 130);
            this.txtPhieuChon.Location = new System.Drawing.Point(10, 315); this.txtPhieuChon.Size = new System.Drawing.Size(80, 23); this.txtPhieuChon.ReadOnly = true;
            this.txtNguoiPhong.Location = new System.Drawing.Point(100, 315); this.txtNguoiPhong.Size = new System.Drawing.Size(70, 23);
            this.txtNguoiTen.Location = new System.Drawing.Point(180, 315); this.txtNguoiTen.Size = new System.Drawing.Size(110, 23);
            this.txtNguoiCMND.Location = new System.Drawing.Point(300, 315); this.txtNguoiCMND.Size = new System.Drawing.Size(100, 23);
            this.txtNguoiQT.Location = new System.Drawing.Point(410, 315); this.txtNguoiQT.Size = new System.Drawing.Size(90, 23);
            this.btnThemNguoi.Location = new System.Drawing.Point(510, 313); this.btnThemNguoi.Text = "Thêm Người LT";
            this.btnNhanPhong.Location = new System.Drawing.Point(620, 313); this.btnNhanPhong.Text = "Nhận Phòng";
            this.btnNoShow.Location = new System.Drawing.Point(720, 313); this.btnNoShow.Text = "No-Show";
            this.tabQLPhieu.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvPhieu, this.dgvCT, this.dgvNguoi, this.txtPhieuChon, this.txtNguoiPhong, this.txtNguoiTen, this.txtNguoiCMND, this.txtNguoiQT, this.btnThemNguoi, this.btnNhanPhong, this.btnNoShow });

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(740, 440);
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.Text = "Đóng";

            // FrmDatPhong
            this.ClientSize = new System.Drawing.Size(850, 480);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Đặt Phòng & Nhận Phòng";

            this.tabMain.ResumeLayout(false);
            this.tabKhach.ResumeLayout(false); this.tabKhach.PerformLayout();
            this.tabPhieu.ResumeLayout(false); this.tabPhieu.PerformLayout();
            this.tabQLPhieu.ResumeLayout(false); this.tabQLPhieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoNguoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoi)).EndInit();
            this.ResumeLayout(false);
        }
    }
}