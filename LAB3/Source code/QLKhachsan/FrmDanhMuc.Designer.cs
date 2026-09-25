namespace QLKhachsan.Forms
{
    partial class FrmDanhMuc
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabKhu;
        private System.Windows.Forms.TabPage tabNV;
        private System.Windows.Forms.TabPage tabLoaiTN;
        private System.Windows.Forms.TabPage tabDV;
        private System.Windows.Forms.TabPage tabQD;

        // Khu Vuc
        private System.Windows.Forms.DataGridView dgvKhu;
        private System.Windows.Forms.TextBox txtKhuMa;
        private System.Windows.Forms.TextBox txtKhuTen;
        private System.Windows.Forms.Button btnThemKhu;

        // Nhan Vien
        private System.Windows.Forms.DataGridView dgvNV;
        private System.Windows.Forms.TextBox txtNVMa;
        private System.Windows.Forms.TextBox txtNVTen;
        private System.Windows.Forms.TextBox txtNVVaiTro;
        private System.Windows.Forms.TextBox txtNVSDT;
        private System.Windows.Forms.Button btnThemNV;

        // Loai Tien Nghi
        private System.Windows.Forms.DataGridView dgvLoaiTN;
        private System.Windows.Forms.TextBox txtLoaiMa;
        private System.Windows.Forms.TextBox txtLoaiTen;
        private System.Windows.Forms.Button btnThemLoaiTN;

        // Dich Vu
        private System.Windows.Forms.DataGridView dgvDV;
        private System.Windows.Forms.TextBox txtDVMa;
        private System.Windows.Forms.TextBox txtDVTen;
        private System.Windows.Forms.TextBox txtDVDVT;
        private System.Windows.Forms.NumericUpDown numDVGia;
        private System.Windows.Forms.Button btnThemDV;

        // Quy Dinh Den Bu
        private System.Windows.Forms.DataGridView dgvQD;
        private System.Windows.Forms.TextBox txtQDMa;
        private System.Windows.Forms.ComboBox cboQDLoai;
        private System.Windows.Forms.TextBox txtQDMucDo;
        private System.Windows.Forms.NumericUpDown numQDTien;
        private System.Windows.Forms.Button btnThemQD;

        private System.Windows.Forms.Button btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabKhu = new System.Windows.Forms.TabPage();
            this.dgvKhu = new System.Windows.Forms.DataGridView();
            this.txtKhuMa = new System.Windows.Forms.TextBox();
            this.txtKhuTen = new System.Windows.Forms.TextBox();
            this.btnThemKhu = new System.Windows.Forms.Button();

            this.tabNV = new System.Windows.Forms.TabPage();
            this.dgvNV = new System.Windows.Forms.DataGridView();
            this.txtNVMa = new System.Windows.Forms.TextBox();
            this.txtNVTen = new System.Windows.Forms.TextBox();
            this.txtNVVaiTro = new System.Windows.Forms.TextBox();
            this.txtNVSDT = new System.Windows.Forms.TextBox();
            this.btnThemNV = new System.Windows.Forms.Button();

            this.tabLoaiTN = new System.Windows.Forms.TabPage();
            this.dgvLoaiTN = new System.Windows.Forms.DataGridView();
            this.txtLoaiMa = new System.Windows.Forms.TextBox();
            this.txtLoaiTen = new System.Windows.Forms.TextBox();
            this.btnThemLoaiTN = new System.Windows.Forms.Button();

            this.tabDV = new System.Windows.Forms.TabPage();
            this.dgvDV = new System.Windows.Forms.DataGridView();
            this.txtDVMa = new System.Windows.Forms.TextBox();
            this.txtDVTen = new System.Windows.Forms.TextBox();
            this.txtDVDVT = new System.Windows.Forms.TextBox();
            this.numDVGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemDV = new System.Windows.Forms.Button();

            this.tabQD = new System.Windows.Forms.TabPage();
            this.dgvQD = new System.Windows.Forms.DataGridView();
            this.txtQDMa = new System.Windows.Forms.TextBox();
            this.cboQDLoai = new System.Windows.Forms.ComboBox();
            this.txtQDMucDo = new System.Windows.Forms.TextBox();
            this.numQDTien = new System.Windows.Forms.NumericUpDown();
            this.btnThemQD = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            this.tabKhu.SuspendLayout();
            this.tabNV.SuspendLayout();
            this.tabLoaiTN.SuspendLayout();
            this.tabDV.SuspendLayout();
            this.tabQD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.Add(this.tabKhu);
            this.tabMain.Controls.Add(this.tabNV);
            this.tabMain.Controls.Add(this.tabLoaiTN);
            this.tabMain.Controls.Add(this.tabDV);
            this.tabMain.Controls.Add(this.tabQD);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Size = new System.Drawing.Size(780, 400);

            // Tab Khu Vuc
            this.tabKhu.Text = "Khu Vực";
            this.dgvKhu.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvKhu.Height = 250;
            this.txtKhuMa.Location = new System.Drawing.Point(20, 270);
            this.txtKhuMa.Size = new System.Drawing.Size(120, 23);
            this.txtKhuTen.Location = new System.Drawing.Point(160, 270);
            this.txtKhuTen.Size = new System.Drawing.Size(200, 23);
            this.btnThemKhu.Location = new System.Drawing.Point(380, 268);
            this.btnThemKhu.Text = "Thêm Khu";
            this.tabKhu.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvKhu, this.txtKhuMa, this.txtKhuTen, this.btnThemKhu });

            // Tab Nhan Vien
            this.tabNV.Text = "Nhân Viên";
            this.dgvNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvNV.Height = 250;
            this.txtNVMa.Location = new System.Drawing.Point(20, 270);
            this.txtNVMa.Size = new System.Drawing.Size(100, 23);
            this.txtNVTen.Location = new System.Drawing.Point(130, 270);
            this.txtNVTen.Size = new System.Drawing.Size(150, 23);
            this.txtNVVaiTro.Location = new System.Drawing.Point(290, 270);
            this.txtNVVaiTro.Size = new System.Drawing.Size(120, 23);
            this.txtNVSDT.Location = new System.Drawing.Point(420, 270);
            this.txtNVSDT.Size = new System.Drawing.Size(120, 23);
            this.btnThemNV.Location = new System.Drawing.Point(560, 268);
            this.btnThemNV.Text = "Thêm NV";
            this.tabNV.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvNV, this.txtNVMa, this.txtNVTen, this.txtNVVaiTro, this.txtNVSDT, this.btnThemNV });

            // Tab Loai Tien Nghi
            this.tabLoaiTN.Text = "Loại Tiện Nghi";
            this.dgvLoaiTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLoaiTN.Height = 250;
            this.txtLoaiMa.Location = new System.Drawing.Point(20, 270);
            this.txtLoaiMa.Size = new System.Drawing.Size(120, 23);
            this.txtLoaiTen.Location = new System.Drawing.Point(160, 270);
            this.txtLoaiTen.Size = new System.Drawing.Size(200, 23);
            this.btnThemLoaiTN.Location = new System.Drawing.Point(380, 268);
            this.btnThemLoaiTN.Text = "Thêm Loại TN";
            this.tabLoaiTN.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvLoaiTN, this.txtLoaiMa, this.txtLoaiTen, this.btnThemLoaiTN });

            // Tab Dich Vu
            this.tabDV.Text = "Dịch Vụ";
            this.dgvDV.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDV.Height = 250;
            this.txtDVMa.Location = new System.Drawing.Point(20, 270);
            this.txtDVMa.Size = new System.Drawing.Size(100, 23);
            this.txtDVTen.Location = new System.Drawing.Point(130, 270);
            this.txtDVTen.Size = new System.Drawing.Size(150, 23);
            this.txtDVDVT.Location = new System.Drawing.Point(290, 270);
            this.txtDVDVT.Size = new System.Drawing.Size(80, 23);
            this.numDVGia.Location = new System.Drawing.Point(380, 270);
            this.numDVGia.Maximum = 100000000;
            this.numDVGia.Size = new System.Drawing.Size(120, 23);
            this.btnThemDV.Location = new System.Drawing.Point(520, 268);
            this.btnThemDV.Text = "Thêm Dịch Vụ";
            this.tabDV.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvDV, this.txtDVMa, this.txtDVTen, this.txtDVDVT, this.numDVGia, this.btnThemDV });

            // Tab Quy Dinh Den Bu
            this.tabQD.Text = "Quy Định Đền Bù";
            this.dgvQD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvQD.Height = 250;
            this.txtQDMa.Location = new System.Drawing.Point(20, 270);
            this.txtQDMa.Size = new System.Drawing.Size(80, 23);
            this.cboQDLoai.Location = new System.Drawing.Point(110, 270);
            this.cboQDLoai.Size = new System.Drawing.Size(150, 23);
            this.txtQDMucDo.Location = new System.Drawing.Point(270, 270);
            this.txtQDMucDo.Size = new System.Drawing.Size(120, 23);
            this.numQDTien.Location = new System.Drawing.Point(400, 270);
            this.numQDTien.Maximum = 100000000;
            this.numQDTien.Size = new System.Drawing.Size(120, 23);
            this.btnThemQD.Location = new System.Drawing.Point(540, 268);
            this.btnThemQD.Text = "Thêm Quy Định";
            this.tabQD.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvQD, this.txtQDMa, this.cboQDLoai, this.txtQDMucDo, this.numQDTien, this.btnThemQD });

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(670, 410);
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.Text = "Đóng";

            // FrmDanhMuc
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Danh Mục Hệ Thống";

            this.tabMain.ResumeLayout(false);
            this.tabKhu.ResumeLayout(false);
            this.tabKhu.PerformLayout();
            this.tabNV.ResumeLayout(false);
            this.tabNV.PerformLayout();
            this.tabLoaiTN.ResumeLayout(false);
            this.tabLoaiTN.PerformLayout();
            this.tabDV.ResumeLayout(false);
            this.tabDV.PerformLayout();
            this.tabQD.ResumeLayout(false);
            this.tabQD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDVGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQDTien)).EndInit();
            this.ResumeLayout(false);
        }
    }
}