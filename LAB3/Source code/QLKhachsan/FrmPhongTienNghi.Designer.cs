namespace QLKhachsan.Forms
{
    partial class FrmPhongTienNghi
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPhong, tabTN, tabLD;

        private System.Windows.Forms.DataGridView dgvPhong, dgvTN, dgvLD;
        private System.Windows.Forms.TextBox txtPhong, txtMaTN, txtTinhTrang, txtSoLD, txtTTLD, txtGhiChu;
        private System.Windows.Forms.ComboBox cboKhu, cboLoai, cboTN, cboPhong, cboNV;
        private System.Windows.Forms.NumericUpDown numMax, numGia, numSTT;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Button btnThemPhong, btnThemTienNghi, btnLapDat, btnDong;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPhong = new System.Windows.Forms.TabPage();
            this.tabTN = new System.Windows.Forms.TabPage();
            this.tabLD = new System.Windows.Forms.TabPage();

            this.dgvPhong = new System.Windows.Forms.DataGridView();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.cboKhu = new System.Windows.Forms.ComboBox();
            this.numMax = new System.Windows.Forms.NumericUpDown();
            this.numGia = new System.Windows.Forms.NumericUpDown();
            this.btnThemPhong = new System.Windows.Forms.Button();

            this.dgvTN = new System.Windows.Forms.DataGridView();
            this.txtMaTN = new System.Windows.Forms.TextBox();
            this.cboLoai = new System.Windows.Forms.ComboBox();
            this.numSTT = new System.Windows.Forms.NumericUpDown();
            this.txtTinhTrang = new System.Windows.Forms.TextBox();
            this.btnThemTienNghi = new System.Windows.Forms.Button();

            this.dgvLD = new System.Windows.Forms.DataGridView();
            this.txtSoLD = new System.Windows.Forms.TextBox();
            this.cboTN = new System.Windows.Forms.ComboBox();
            this.cboPhong = new System.Windows.Forms.ComboBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.txtTTLD = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.btnLapDat = new System.Windows.Forms.Button();

            this.btnDong = new System.Windows.Forms.Button();

            this.tabMain.SuspendLayout();
            this.tabPhong.SuspendLayout();
            this.tabTN.SuspendLayout();
            this.tabLD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).BeginInit();
            this.SuspendLayout();

            // tabMain
            this.tabMain.Controls.Add(this.tabPhong);
            this.tabMain.Controls.Add(this.tabTN);
            this.tabMain.Controls.Add(this.tabLD);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 0);
            this.tabMain.Size = new System.Drawing.Size(780, 400);

            // Tab Phong
            this.tabPhong.Text = "Quản Lý Phòng";
            this.dgvPhong.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPhong.Height = 250;
            this.txtPhong.Location = new System.Drawing.Point(20, 270);
            this.txtPhong.Size = new System.Drawing.Size(100, 23);
            this.cboKhu.Location = new System.Drawing.Point(130, 270);
            this.cboKhu.Size = new System.Drawing.Size(120, 23);
            this.numMax.Location = new System.Drawing.Point(260, 270);
            this.numMax.Size = new System.Drawing.Size(80, 23);
            this.numGia.Location = new System.Drawing.Point(350, 270);
            this.numGia.Maximum = 100000000;
            this.numGia.Size = new System.Drawing.Size(120, 23);
            this.btnThemPhong.Location = new System.Drawing.Point(490, 268);
            this.btnThemPhong.Text = "Thêm Phòng";
            this.tabPhong.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvPhong, this.txtPhong, this.cboKhu, this.numMax, this.numGia, this.btnThemPhong });

            // Tab Tien Nghi
            this.tabTN.Text = "Tiện Nghi";
            this.dgvTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvTN.Height = 250;
            this.txtMaTN.Location = new System.Drawing.Point(20, 270);
            this.txtMaTN.Size = new System.Drawing.Size(100, 23);
            this.cboLoai.Location = new System.Drawing.Point(130, 270);
            this.cboLoai.Size = new System.Drawing.Size(140, 23);
            this.numSTT.Location = new System.Drawing.Point(280, 270);
            this.numSTT.Size = new System.Drawing.Size(80, 23);
            this.txtTinhTrang.Location = new System.Drawing.Point(370, 270);
            this.txtTinhTrang.Size = new System.Drawing.Size(120, 23);
            this.btnThemTienNghi.Location = new System.Drawing.Point(500, 268);
            this.btnThemTienNghi.Text = "Thêm Tiện Nghi";
            this.tabTN.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvTN, this.txtMaTN, this.cboLoai, this.numSTT, this.txtTinhTrang, this.btnThemTienNghi });

            // Tab Lap Dat
            this.tabLD.Text = "Lắp Đặt Tiện Nghi";
            this.dgvLD.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvLD.Height = 220;
            this.txtSoLD.Location = new System.Drawing.Point(20, 240);
            this.txtSoLD.Size = new System.Drawing.Size(80, 23);
            this.cboTN.Location = new System.Drawing.Point(110, 240);
            this.cboTN.Size = new System.Drawing.Size(100, 23);
            this.cboPhong.Location = new System.Drawing.Point(220, 240);
            this.cboPhong.Size = new System.Drawing.Size(100, 23);
            this.dtNgay.Location = new System.Drawing.Point(330, 240);
            this.dtNgay.Size = new System.Drawing.Size(140, 23);
            this.txtTTLD.Location = new System.Drawing.Point(480, 240);
            this.txtTTLD.Size = new System.Drawing.Size(100, 23);
            this.cboNV.Location = new System.Drawing.Point(590, 240);
            this.cboNV.Size = new System.Drawing.Size(120, 23);
            this.txtGhiChu.Location = new System.Drawing.Point(20, 280);
            this.txtGhiChu.Size = new System.Drawing.Size(450, 23);
            this.btnLapDat.Location = new System.Drawing.Point(480, 278);
            this.btnLapDat.Text = "Lập Phiếu Lắp Đặt";
            this.tabLD.Controls.AddRange(new System.Windows.Forms.Control[] { this.dgvLD, this.txtSoLD, this.cboTN, this.cboPhong, this.dtNgay, this.txtTTLD, this.cboNV, this.txtGhiChu, this.btnLapDat });

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(670, 410);
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.Text = "Đóng";

            // FrmPhongTienNghi
            this.ClientSize = new System.Drawing.Size(780, 450);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Phòng & Tiện Nghi";

            this.tabMain.ResumeLayout(false);
            this.tabPhong.ResumeLayout(false);
            this.tabPhong.PerformLayout();
            this.tabTN.ResumeLayout(false);
            this.tabTN.PerformLayout();
            this.tabLD.ResumeLayout(false);
            this.tabLD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSTT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLD)).EndInit();
            this.ResumeLayout(false);
        }
    }
}