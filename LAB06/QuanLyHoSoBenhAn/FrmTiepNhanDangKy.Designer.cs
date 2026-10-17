namespace QuanLyHoSoBenhAn
{
    partial class FrmTiepNhanDangKy
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.lblTitleLeft = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblSdt = new System.Windows.Forms.Label();
            this.txtSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.chkDongLePhiNam = new System.Windows.Forms.CheckBox();
            this.picAnh3x4 = new System.Windows.Forms.PictureBox();
            this.btnChonAnh = new System.Windows.Forms.Button();
            this.btnTaoHoSo = new System.Windows.Forms.Button();

            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblTitleRight = new System.Windows.Forms.Label();
            this.lblMaHoSo = new System.Windows.Forms.Label();
            this.txtMaHoSo = new System.Windows.Forms.TextBox();
            this.lblNgayGioHen = new System.Windows.Forms.Label();
            this.dtpNgayGioHen = new System.Windows.Forms.DateTimePicker();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.cboTrangThai = new System.Windows.Forms.ComboBox();
            this.btnDatLich = new System.Windows.Forms.Button();
            this.btnHuyLich = new System.Windows.Forms.Button();

            this.pnlBottom = new System.Windows.Forms.Panel();
            this.dgvDanhSach = new System.Windows.Forms.DataGridView();

            this.pnlLeft.SuspendLayout();

            ((System.ComponentModel.ISupportInitialize)(this.picAnh3x4)).BeginInit();
            this.pnlRight.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).BeginInit();
            this.SuspendLayout();

            // 
            // pnlLeft (Đăng ký Bệnh nhân mới)
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.White;
            this.pnlLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeft.Controls.Add(this.lblTitleLeft);
            this.pnlLeft.Controls.Add(this.lblHoTen);
            this.pnlLeft.Controls.Add(this.txtHoTen);
            this.pnlLeft.Controls.Add(this.lblSdt);
            this.pnlLeft.Controls.Add(this.txtSoDienThoai);
            this.pnlLeft.Controls.Add(this.lblDiaChi);
            this.pnlLeft.Controls.Add(this.txtDiaChi);
            this.pnlLeft.Controls.Add(this.lblNgaySinh);
            this.pnlLeft.Controls.Add(this.dtpNgaySinh);
            this.pnlLeft.Controls.Add(this.chkDongLePhiNam);
            this.pnlLeft.Controls.Add(this.picAnh3x4);
            this.pnlLeft.Controls.Add(this.btnChonAnh);
            this.pnlLeft.Controls.Add(this.btnTaoHoSo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(430, 150);
            this.pnlLeft.TabIndex = 0;

            // 
            // lblTitleLeft
            // 
            this.lblTitleLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitleLeft.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleLeft.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleLeft.Location = new System.Drawing.Point(0, 0);
            this.lblTitleLeft.Name = "lblTitleLeft";
            this.lblTitleLeft.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitleLeft.Size = new System.Drawing.Size(428, 20);
            this.lblTitleLeft.TabIndex = 0;
            this.lblTitleLeft.Text = "ĐĂNG KÝ BỆNH NHÂN MỚI";
            this.lblTitleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblHoTen.Location = new System.Drawing.Point(5, 26);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(45, 13);
            this.lblHoTen.Text = "Họ tên:";

            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtHoTen.Location = new System.Drawing.Point(50, 23);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(120, 22);
            this.txtHoTen.TabIndex = 1;

            // 
            // lblSdt
            // 
            this.lblSdt.AutoSize = true;
            this.lblSdt.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblSdt.Location = new System.Drawing.Point(175, 26);
            this.lblSdt.Name = "lblSdt";
            this.lblSdt.Size = new System.Drawing.Size(29, 13);
            this.lblSdt.Text = "SĐT:";

            // 
            // txtSoDienThoai
            // 
            this.txtSoDienThoai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtSoDienThoai.Location = new System.Drawing.Point(205, 23);
            this.txtSoDienThoai.Name = "txtSoDienThoai";
            this.txtSoDienThoai.Size = new System.Drawing.Size(120, 22);
            this.txtSoDienThoai.TabIndex = 2;

            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblDiaChi.Location = new System.Drawing.Point(5, 52);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(45, 13);
            this.lblDiaChi.Text = "Địa chỉ:";

            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtDiaChi.Location = new System.Drawing.Point(50, 49);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(275, 22);
            this.txtDiaChi.TabIndex = 3;

            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNgaySinh.Location = new System.Drawing.Point(5, 78);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(61, 13);
            this.lblNgaySinh.Text = "Ngày sinh:";

            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(70, 75);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(100, 22);
            this.dtpNgaySinh.TabIndex = 4;

            // 
            // chkDongLePhiNam
            // 
            this.chkDongLePhiNam.AutoSize = true;
            this.chkDongLePhiNam.Checked = true;
            this.chkDongLePhiNam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDongLePhiNam.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.chkDongLePhiNam.Location = new System.Drawing.Point(180, 77);
            this.chkDongLePhiNam.Name = "chkDongLePhiNam";
            this.chkDongLePhiNam.Size = new System.Drawing.Size(145, 17);
            this.chkDongLePhiNam.TabIndex = 5;
            this.chkDongLePhiNam.Text = "Đã đóng lệ phí năm (1)";

            // 
            // picAnh3x4
            // 
            this.picAnh3x4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnh3x4.Location = new System.Drawing.Point(335, 23);
            this.picAnh3x4.Name = "picAnh3x4";
            this.picAnh3x4.Size = new System.Drawing.Size(85, 95);
            this.picAnh3x4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnh3x4.TabIndex = 6;
            this.picAnh3x4.TabStop = false;

            // 
            // btnChonAnh
            // 
            this.btnChonAnh.BackColor = System.Drawing.Color.White;
            this.btnChonAnh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnChonAnh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonAnh.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.btnChonAnh.Location = new System.Drawing.Point(335, 121);
            this.btnChonAnh.Name = "btnChonAnh";
            this.btnChonAnh.Size = new System.Drawing.Size(85, 22);
            this.btnChonAnh.TabIndex = 7;
            this.btnChonAnh.Text = "Chọn ảnh...";
            this.btnChonAnh.UseVisualStyleBackColor = false;
            this.btnChonAnh.Click += new System.EventHandler(this.btnChonAnh_Click);

            // 
            // btnTaoHoSo
            // 
            this.btnTaoHoSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnTaoHoSo.FlatAppearance.BorderSize = 0;
            this.btnTaoHoSo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoHoSo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoHoSo.ForeColor = System.Drawing.Color.White;
            this.btnTaoHoSo.Location = new System.Drawing.Point(5, 110);
            this.btnTaoHoSo.Name = "btnTaoHoSo";
            this.btnTaoHoSo.Size = new System.Drawing.Size(320, 30);
            this.btnTaoHoSo.TabIndex = 8;
            this.btnTaoHoSo.Text = "+ TẠO MỚI HỒ SƠ BỆNH ÁN";
            this.btnTaoHoSo.UseVisualStyleBackColor = false;
            this.btnTaoHoSo.Click += new System.EventHandler(this.btnTaoHoSo_Click);

            // 
            // pnlRight (Đặt Lịch Hẹn Khám)
            // 
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.Controls.Add(this.lblTitleRight);
            this.pnlRight.Controls.Add(this.lblMaHoSo);
            this.pnlRight.Controls.Add(this.txtMaHoSo);
            this.pnlRight.Controls.Add(this.lblNgayGioHen);
            this.pnlRight.Controls.Add(this.dtpNgayGioHen);
            this.pnlRight.Controls.Add(this.lblTrangThai);
            this.pnlRight.Controls.Add(this.cboTrangThai);
            this.pnlRight.Controls.Add(this.btnDatLich);
            this.pnlRight.Controls.Add(this.btnHuyLich);
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRight.Location = new System.Drawing.Point(430, 0);
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(330, 150);
            this.pnlRight.TabIndex = 1;

            // 
            // lblTitleRight
            // 
            this.lblTitleRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblTitleRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitleRight.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleRight.Location = new System.Drawing.Point(0, 0);
            this.lblTitleRight.Name = "lblTitleRight";
            this.lblTitleRight.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblTitleRight.Size = new System.Drawing.Size(328, 20);
            this.lblTitleRight.TabIndex = 0;
            this.lblTitleRight.Text = "ĐẶT LỊCH HẸN KHÁM ĐỊNH KỲ";
            this.lblTitleRight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // lblMaHoSo
            // 
            this.lblMaHoSo.AutoSize = true;
            this.lblMaHoSo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblMaHoSo.Location = new System.Drawing.Point(5, 26);
            this.lblMaHoSo.Name = "lblMaHoSo";
            this.lblMaHoSo.Size = new System.Drawing.Size(58, 13);
            this.lblMaHoSo.Text = "Mã Hồ sơ:";

            // 
            // txtMaHoSo
            // 
            this.txtMaHoSo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.txtMaHoSo.Location = new System.Drawing.Point(85, 23);
            this.txtMaHoSo.Name = "txtMaHoSo";
            this.txtMaHoSo.Size = new System.Drawing.Size(235, 22);
            this.txtMaHoSo.TabIndex = 1;

            // 
            // lblNgayGioHen
            // 
            this.lblNgayGioHen.AutoSize = true;
            this.lblNgayGioHen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblNgayGioHen.Location = new System.Drawing.Point(5, 52);
            this.lblNgayGioHen.Name = "lblNgayGioHen";
            this.lblNgayGioHen.Size = new System.Drawing.Size(77, 13);
            this.lblNgayGioHen.Text = "Ngày giờ hẹn:";

            // 
            // dtpNgayGioHen
            // 
            this.dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpNgayGioHen.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.dtpNgayGioHen.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayGioHen.Location = new System.Drawing.Point(85, 49);
            this.dtpNgayGioHen.Name = "dtpNgayGioHen";
            this.dtpNgayGioHen.Size = new System.Drawing.Size(235, 22);
            this.dtpNgayGioHen.TabIndex = 2;

            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblTrangThai.Location = new System.Drawing.Point(5, 78);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(61, 13);
            this.lblTrangThai.Text = "Trạng thái:";

            // 
            // cboTrangThai
            // 
            this.cboTrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrangThai.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.cboTrangThai.FormattingEnabled = true;
            this.cboTrangThai.Items.AddRange(new object[] {
            "Đã xác nhận",
            "Đã khám",
            "Đã hủy"});
            this.cboTrangThai.Location = new System.Drawing.Point(85, 75);
            this.cboTrangThai.Name = "cboTrangThai";
            this.cboTrangThai.Size = new System.Drawing.Size(235, 21);
            this.cboTrangThai.TabIndex = 3;

            // 
            // btnDatLich
            // 
            this.btnDatLich.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnDatLich.FlatAppearance.BorderSize = 0;
            this.btnDatLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatLich.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnDatLich.ForeColor = System.Drawing.Color.White;
            this.btnDatLich.Location = new System.Drawing.Point(85, 110);
            this.btnDatLich.Name = "btnDatLich";
            this.btnDatLich.Size = new System.Drawing.Size(112, 30);
            this.btnDatLich.TabIndex = 4;
            this.btnDatLich.Text = "LƯU LỊCH HẸN";
            this.btnDatLich.UseVisualStyleBackColor = false;
            this.btnDatLich.Click += new System.EventHandler(this.btnDatLich_Click);

            // 
            // btnHuyLich
            // 
            this.btnHuyLich.BackColor = System.Drawing.Color.White;
            this.btnHuyLich.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnHuyLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyLich.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnHuyLich.ForeColor = System.Drawing.Color.Black;
            this.btnHuyLich.Location = new System.Drawing.Point(203, 110);
            this.btnHuyLich.Name = "btnHuyLich";
            this.btnHuyLich.Size = new System.Drawing.Size(117, 30);
            this.btnHuyLich.TabIndex = 5;
            this.btnHuyLich.Text = "HỦY LỊCH";
            this.btnHuyLich.UseVisualStyleBackColor = false;
            this.btnHuyLich.Click += new System.EventHandler(this.btnHuyLich_Click);

            // 
            // pnlBottom (Lịch sử danh sách)
            // 
            this.pnlBottom.Controls.Add(this.dgvDanhSach);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 150);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(760, 106);
            this.pnlBottom.TabIndex = 2;

            // 
            // dgvDanhSach
            // 
            this.dgvDanhSach.AllowUserToAddRows = false;
            this.dgvDanhSach.AllowUserToDeleteRows = false;
            this.dgvDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSach.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSach.ColumnHeadersHeight = 22;
            this.dgvDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSach.Location = new System.Drawing.Point(0, 0);
            this.dgvDanhSach.MultiSelect = false;
            this.dgvDanhSach.Name = "dgvDanhSach";
            this.dgvDanhSach.ReadOnly = true;
            this.dgvDanhSach.RowHeadersVisible = false;
            this.dgvDanhSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSach.Size = new System.Drawing.Size(760, 106);
            this.dgvDanhSach.TabIndex = 0;
            this.dgvDanhSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSach_CellClick);

            // 
            // FrmTiepNhanDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 256);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTiepNhanDangKy";
            this.Text = "FrmTiepNhanDangKy";
            this.Load += new System.EventHandler(this.FrmTiepNhanDangKy_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh3x4)).EndInit();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSach)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Label lblTitleLeft;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSdt;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.CheckBox chkDongLePhiNam;
        private System.Windows.Forms.PictureBox picAnh3x4;
        private System.Windows.Forms.Button btnChonAnh;
        private System.Windows.Forms.Button btnTaoHoSo;

        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblTitleRight;
        private System.Windows.Forms.Label lblMaHoSo;
        private System.Windows.Forms.TextBox txtMaHoSo;
        private System.Windows.Forms.Label lblNgayGioHen;
        private System.Windows.Forms.DateTimePicker dtpNgayGioHen;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Button btnDatLich;
        private System.Windows.Forms.Button btnHuyLich;

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.DataGridView dgvDanhSach;
    }
}