namespace QLCtyDuLich
{
    partial class FrmDangKyTour
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabTourLe = new System.Windows.Forms.TabPage();
            this.lblStatusLe = new System.Windows.Forms.Label();
            this.btnXuatVeLe = new System.Windows.Forms.Button();
            this.lblTongTienLe = new System.Windows.Forms.Label();
            this.txtTongTienLe = new System.Windows.Forms.TextBox();
            this.lblDiemDonLe = new System.Windows.Forms.Label();
            this.txtDiemDonLe = new System.Windows.Forms.TextBox();
            this.lblChuyenLe = new System.Windows.Forms.Label();
            this.cboChuyenLe = new System.Windows.Forms.ComboBox();
            this.lblTourLe = new System.Windows.Forms.Label();
            this.cboTourLe = new System.Windows.Forms.ComboBox();
            this.lblCMNDLe = new System.Windows.Forms.Label();
            this.txtCMNDLe = new System.Windows.Forms.TextBox();
            this.lblTenKhachLe = new System.Windows.Forms.Label();
            this.txtTenKhachLe = new System.Windows.Forms.TextBox();
            this.tabTourDoan = new System.Windows.Forms.TabPage();
            this.lblErrorDoan = new System.Windows.Forms.Label();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.btnTaoPhieuDoan = new System.Windows.Forms.Button();
            this.dgvBaoHiem = new System.Windows.Forms.DataGridView();
            this.colThanhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTienCoc = new System.Windows.Forms.Label();
            this.txtTienCoc = new System.Windows.Forms.TextBox();
            this.lblDiemDonDoan = new System.Windows.Forms.Label();
            this.txtDiemDonDoan = new System.Windows.Forms.TextBox();
            this.lblNgayDi = new System.Windows.Forms.Label();
            this.dtpNgayDiDoan = new System.Windows.Forms.DateTimePicker();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.numSoLuongDoan = new System.Windows.Forms.NumericUpDown();
            this.lblTourDoan = new System.Windows.Forms.Label();
            this.cboTourDoan = new System.Windows.Forms.ComboBox();
            this.lblKhachDoan = new System.Windows.Forms.Label();
            this.cboKhachDoan = new System.Windows.Forms.ComboBox();
            this.tabControlMain.SuspendLayout();
            this.tabTourLe.SuspendLayout();
            this.tabTourDoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDoan)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabTourLe);
            this.tabControlMain.Controls.Add(this.tabTourDoan);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 335);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabTourLe
            // 
            this.tabTourLe.BackColor = System.Drawing.Color.White;
            this.tabTourLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTourLe.Controls.Add(this.lblStatusLe);
            this.tabTourLe.Controls.Add(this.btnXuatVeLe);
            this.tabTourLe.Controls.Add(this.lblTongTienLe);
            this.tabTourLe.Controls.Add(this.txtTongTienLe);
            this.tabTourLe.Controls.Add(this.lblDiemDonLe);
            this.tabTourLe.Controls.Add(this.txtDiemDonLe);
            this.tabTourLe.Controls.Add(this.lblChuyenLe);
            this.tabTourLe.Controls.Add(this.cboChuyenLe);
            this.tabTourLe.Controls.Add(this.lblTourLe);
            this.tabTourLe.Controls.Add(this.cboTourLe);
            this.tabTourLe.Controls.Add(this.lblCMNDLe);
            this.tabTourLe.Controls.Add(this.txtCMNDLe);
            this.tabTourLe.Controls.Add(this.lblTenKhachLe);
            this.tabTourLe.Controls.Add(this.txtTenKhachLe);
            this.tabTourLe.Location = new System.Drawing.Point(4, 24);
            this.tabTourLe.Name = "tabTourLe";
            this.tabTourLe.Padding = new System.Windows.Forms.Padding(10);
            this.tabTourLe.Size = new System.Drawing.Size(562, 307);
            this.tabTourLe.TabIndex = 0;
            this.tabTourLe.Text = "ĐĂNG KÝ TOUR LẺ (<12 Người)";
            // 
            // lblTenKhachLe
            // 
            this.lblTenKhachLe.AutoSize = true;
            this.lblTenKhachLe.Location = new System.Drawing.Point(15, 15);
            this.lblTenKhachLe.Name = "lblTenKhachLe";
            this.lblTenKhachLe.Size = new System.Drawing.Size(96, 15);
            this.lblTenKhachLe.TabIndex = 0;
            this.lblTenKhachLe.Text = "Tên Khách Hàng:";
            // 
            // txtTenKhachLe
            // 
            this.txtTenKhachLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenKhachLe.Location = new System.Drawing.Point(150, 12);
            this.txtTenKhachLe.Name = "txtTenKhachLe";
            this.txtTenKhachLe.Size = new System.Drawing.Size(150, 23);
            this.txtTenKhachLe.TabIndex = 1;
            // 
            // lblCMNDLe
            // 
            this.lblCMNDLe.AutoSize = true;
            this.lblCMNDLe.Location = new System.Drawing.Point(315, 15);
            this.lblCMNDLe.Name = "lblCMNDLe";
            this.lblCMNDLe.Size = new System.Drawing.Size(79, 15);
            this.lblCMNDLe.TabIndex = 2;
            this.lblCMNDLe.Text = "Số CMND/CCCD:";
            // 
            // txtCMNDLe
            // 
            this.txtCMNDLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCMNDLe.Location = new System.Drawing.Point(395, 12);
            this.txtCMNDLe.Name = "txtCMNDLe";
            this.txtCMNDLe.Size = new System.Drawing.Size(150, 23);
            this.txtCMNDLe.TabIndex = 3;
            // 
            // lblTourLe
            // 
            this.lblTourLe.AutoSize = true;
            this.lblTourLe.Location = new System.Drawing.Point(15, 55);
            this.lblTourLe.Name = "lblTourLe";
            this.lblTourLe.Size = new System.Drawing.Size(65, 15);
            this.lblTourLe.TabIndex = 4;
            this.lblTourLe.Text = "Chọn Tour:";
            // 
            // cboTourLe
            // 
            this.cboTourLe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourLe.FormattingEnabled = true;
            this.cboTourLe.Location = new System.Drawing.Point(150, 52);
            this.cboTourLe.Name = "cboTourLe";
            this.cboTourLe.Size = new System.Drawing.Size(395, 23);
            this.cboTourLe.TabIndex = 5;
            this.cboTourLe.SelectedIndexChanged += new System.EventHandler(this.cboTourLe_SelectedIndexChanged);
            // 
            // lblChuyenLe
            // 
            this.lblChuyenLe.AutoSize = true;
            this.lblChuyenLe.Location = new System.Drawing.Point(15, 95);
            this.lblChuyenLe.Name = "lblChuyenLe";
            this.lblChuyenLe.Size = new System.Drawing.Size(124, 15);
            this.lblChuyenLe.TabIndex = 6;
            this.lblChuyenLe.Text = "Chọn Chuyến Đi Lẻ:";
            // 
            // cboChuyenLe
            // 
            this.cboChuyenLe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChuyenLe.FormattingEnabled = true;
            this.cboChuyenLe.Location = new System.Drawing.Point(150, 92);
            this.cboChuyenLe.Name = "cboChuyenLe";
            this.cboChuyenLe.Size = new System.Drawing.Size(395, 23);
            this.cboChuyenLe.TabIndex = 7;
            // 
            // lblDiemDonLe
            // 
            this.lblDiemDonLe.AutoSize = true;
            this.lblDiemDonLe.Location = new System.Drawing.Point(15, 135);
            this.lblDiemDonLe.Name = "lblDiemDonLe";
            this.lblDiemDonLe.Size = new System.Drawing.Size(110, 15);
            this.lblDiemDonLe.TabIndex = 8;
            this.lblDiemDonLe.Text = "Điểm Đón Quy Định:";
            // 
            // txtDiemDonLe
            // 
            this.txtDiemDonLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemDonLe.Location = new System.Drawing.Point(150, 132);
            this.txtDiemDonLe.Name = "txtDiemDonLe";
            this.txtDiemDonLe.Size = new System.Drawing.Size(395, 23);
            this.txtDiemDonLe.TabIndex = 9;
            // 
            // lblTongTienLe
            // 
            this.lblTongTienLe.AutoSize = true;
            this.lblTongTienLe.Location = new System.Drawing.Point(15, 175);
            this.lblTongTienLe.Name = "lblTongTienLe";
            this.lblTongTienLe.Size = new System.Drawing.Size(130, 15);
            this.lblTongTienLe.TabIndex = 10;
            this.lblTongTienLe.Text = "Tổng Tiền (100% Tiền Vé):";
            // 
            // txtTongTienLe
            // 
            this.txtTongTienLe.BackColor = System.Drawing.Color.White;
            this.txtTongTienLe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTienLe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTongTienLe.Location = new System.Drawing.Point(150, 172);
            this.txtTongTienLe.Name = "txtTongTienLe";
            this.txtTongTienLe.ReadOnly = true;
            this.txtTongTienLe.Size = new System.Drawing.Size(395, 23);
            this.txtTongTienLe.TabIndex = 11;
            // 
            // btnXuatVeLe
            // 
            this.btnXuatVeLe.BackColor = System.Drawing.Color.Black;
            this.btnXuatVeLe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatVeLe.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnXuatVeLe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatVeLe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnXuatVeLe.ForeColor = System.Drawing.Color.White;
            this.btnXuatVeLe.Location = new System.Drawing.Point(395, 258);
            this.btnXuatVeLe.Name = "btnXuatVeLe";
            this.btnXuatVeLe.Size = new System.Drawing.Size(150, 32);
            this.btnXuatVeLe.TabIndex = 12;
            this.btnXuatVeLe.Text = "Xuất Vé Lẻ";
            this.btnXuatVeLe.UseVisualStyleBackColor = false;
            this.btnXuatVeLe.Click += new System.EventHandler(this.btnXuatVeLe_Click);
            // 
            // lblStatusLe
            // 
            this.lblStatusLe.AutoSize = true;
            this.lblStatusLe.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusLe.ForeColor = System.Drawing.Color.Red;
            this.lblStatusLe.Location = new System.Drawing.Point(15, 268);
            this.lblStatusLe.Name = "lblStatusLe";
            this.lblStatusLe.Size = new System.Drawing.Size(0, 15);
            this.lblStatusLe.TabIndex = 13;
            // 
            // tabTourDoan
            // 
            this.tabTourDoan.BackColor = System.Drawing.Color.White;
            this.tabTourDoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTourDoan.Controls.Add(this.lblErrorDoan);
            this.tabTourDoan.Controls.Add(this.btnHuyDangKy);
            this.tabTourDoan.Controls.Add(this.btnTaoPhieuDoan);
            this.tabTourDoan.Controls.Add(this.dgvBaoHiem);
            this.tabTourDoan.Controls.Add(this.lblTienCoc);
            this.tabTourDoan.Controls.Add(this.txtTienCoc);
            this.tabTourDoan.Controls.Add(this.lblDiemDonDoan);
            this.tabTourDoan.Controls.Add(this.txtDiemDonDoan);
            this.tabTourDoan.Controls.Add(this.lblNgayDi);
            this.tabTourDoan.Controls.Add(this.dtpNgayDiDoan);
            this.tabTourDoan.Controls.Add(this.lblSoLuong);
            this.tabTourDoan.Controls.Add(this.numSoLuongDoan);
            this.tabTourDoan.Controls.Add(this.lblTourDoan);
            this.tabTourDoan.Controls.Add(this.cboTourDoan);
            this.tabTourDoan.Controls.Add(this.lblKhachDoan);
            this.tabTourDoan.Controls.Add(this.cboKhachDoan);
            this.tabTourDoan.Location = new System.Drawing.Point(4, 24);
            this.tabTourDoan.Name = "tabTourDoan";
            this.tabTourDoan.Padding = new System.Windows.Forms.Padding(10);
            this.tabTourDoan.Size = new System.Drawing.Size(562, 307);
            this.tabTourDoan.TabIndex = 1;
            this.tabTourDoan.Text = "LẬP PHIẾU TOUR ĐOÀN (≥12 Người)";
            // 
            // lblErrorDoan
            // 
            this.lblErrorDoan.AutoSize = true;
            this.lblErrorDoan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblErrorDoan.ForeColor = System.Drawing.Color.Red;
            this.lblErrorDoan.Location = new System.Drawing.Point(10, 275);
            this.lblErrorDoan.Name = "lblErrorDoan";
            this.lblErrorDoan.Size = new System.Drawing.Size(0, 15);
            this.lblErrorDoan.TabIndex = 15;
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.BackColor = System.Drawing.Color.White;
            this.btnHuyDangKy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHuyDangKy.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHuyDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDangKy.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.btnHuyDangKy.ForeColor = System.Drawing.Color.Black;
            this.btnHuyDangKy.Location = new System.Drawing.Point(295, 268);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(100, 28);
            this.btnHuyDangKy.TabIndex = 14;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = false;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click);
            // 
            // btnTaoPhieuDoan
            // 
            this.btnTaoPhieuDoan.BackColor = System.Drawing.Color.Black;
            this.btnTaoPhieuDoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoPhieuDoan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTaoPhieuDoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoPhieuDoan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnTaoPhieuDoan.ForeColor = System.Drawing.Color.White;
            this.btnTaoPhieuDoan.Location = new System.Drawing.Point(401, 268);
            this.btnTaoPhieuDoan.Name = "btnTaoPhieuDoan";
            this.btnTaoPhieuDoan.Size = new System.Drawing.Size(150, 28);
            this.btnTaoPhieuDoan.TabIndex = 13;
            this.btnTaoPhieuDoan.Text = "Tạo Phiếu & In Biên Nhận";
            this.btnTaoPhieuDoan.UseVisualStyleBackColor = false;
            this.btnTaoPhieuDoan.Click += new System.EventHandler(this.btnTaoPhieuDoan_Click);
            // 
            // dgvBaoHiem
            // 
            this.dgvBaoHiem.AllowUserToAddRows = true;
            this.dgvBaoHiem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoHiem.BackgroundColor = System.Drawing.Color.White;
            this.dgvBaoHiem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvBaoHiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoHiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colThanhVien,
            this.colMaBH});
            this.dgvBaoHiem.Location = new System.Drawing.Point(10, 150);
            this.dgvBaoHiem.Name = "dgvBaoHiem";
            this.dgvBaoHiem.RowHeadersWidth = 25;
            this.dgvBaoHiem.Size = new System.Drawing.Size(541, 108);
            this.dgvBaoHiem.TabIndex = 12;
            // 
            // colThanhVien
            // 
            this.colThanhVien.HeaderText = "Họ Tên Thành Viên Đoàn (Bảo Hiểm)";
            this.colThanhVien.Name = "colThanhVien";
            // 
            // colMaBH
            // 
            this.colMaBH.HeaderText = "Mã Mã Bảo Hiểm Du Lịch";
            this.colMaBH.Name = "colMaBH";
            // 
            // lblTienCoc
            // 
            this.lblTienCoc.AutoSize = true;
            this.lblTienCoc.Location = new System.Drawing.Point(325, 115);
            this.lblTienCoc.Name = "lblTienCoc";
            this.lblTienCoc.Size = new System.Drawing.Size(76, 15);
            this.lblTienCoc.TabIndex = 11;
            this.lblTienCoc.Text = "Tiền Cọc (Đ):";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienCoc.Location = new System.Drawing.Point(407, 112);
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Size = new System.Drawing.Size(144, 23);
            this.txtTienCoc.TabIndex = 10;
            // 
            // lblDiemDonDoan
            // 
            this.lblDiemDonDoan.AutoSize = true;
            this.lblDiemDonDoan.Location = new System.Drawing.Point(10, 115);
            this.lblDiemDonDoan.Name = "lblDiemDonDoan";
            this.lblDiemDonDoan.Size = new System.Drawing.Size(107, 15);
            this.lblDiemDonDoan.TabIndex = 9;
            this.lblDiemDonDoan.Text = "Yêu Cầu Điểm Đón:";
            // 
            // txtDiemDonDoan
            // 
            this.txtDiemDonDoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiemDonDoan.Location = new System.Drawing.Point(125, 112);
            this.txtDiemDonDoan.Name = "txtDiemDonDoan";
            this.txtDiemDonDoan.Size = new System.Drawing.Size(185, 23);
            this.txtDiemDonDoan.TabIndex = 8;
            // 
            // lblNgayDi
            // 
            this.lblNgayDi.AutoSize = true;
            this.lblNgayDi.Location = new System.Drawing.Point(325, 80);
            this.lblNgayDi.Name = "lblNgayDi";
            this.lblNgayDi.Size = new System.Drawing.Size(79, 15);
            this.lblNgayDi.TabIndex = 7;
            this.lblNgayDi.Text = "Ngày Đi Tùy Ý:";
            // 
            // dtpNgayDiDoan
            // 
            this.dtpNgayDiDoan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDiDoan.Location = new System.Drawing.Point(407, 76);
            this.dtpNgayDiDoan.Name = "dtpNgayDiDoan";
            this.dtpNgayDiDoan.Size = new System.Drawing.Size(144, 23);
            this.dtpNgayDiDoan.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(10, 80);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(91, 15);
            this.lblSoLuong.TabIndex = 5;
            this.lblSoLuong.Text = "Số Lượng (≥12):";
            // 
            // numSoLuongDoan
            // 
            this.numSoLuongDoan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSoLuongDoan.Location = new System.Drawing.Point(125, 76);
            this.numSoLuongDoan.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSoLuongDoan.Name = "numSoLuongDoan";
            this.numSoLuongDoan.Size = new System.Drawing.Size(185, 23);
            this.numSoLuongDoan.TabIndex = 4;
            this.numSoLuongDoan.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // lblTourDoan
            // 
            this.lblTourDoan.AutoSize = true;
            this.lblTourDoan.Location = new System.Drawing.Point(10, 45);
            this.lblTourDoan.Name = "lblTourDoan";
            this.lblTourDoan.Size = new System.Drawing.Size(65, 15);
            this.lblTourDoan.TabIndex = 3;
            this.lblTourDoan.Text = "Chọn Tour:";
            // 
            // cboTourDoan
            // 
            this.cboTourDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourDoan.FormattingEnabled = true;
            this.cboTourDoan.Location = new System.Drawing.Point(125, 42);
            this.cboTourDoan.Name = "cboTourDoan";
            this.cboTourDoan.Size = new System.Drawing.Size(426, 23);
            this.cboTourDoan.TabIndex = 2;
            // 
            // lblKhachDoan
            // 
            this.lblKhachDoan.AutoSize = true;
            this.lblKhachDoan.Location = new System.Drawing.Point(10, 13);
            this.lblKhachDoan.Name = "lblKhachDoan";
            this.lblKhachDoan.Size = new System.Drawing.Size(89, 15);
            this.lblKhachDoan.TabIndex = 1;
            this.lblKhachDoan.Text = "Đại Diện Đoàn:";
            // 
            // cboKhachDoan
            // 
            this.cboKhachDoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachDoan.FormattingEnabled = true;
            this.cboKhachDoan.Location = new System.Drawing.Point(125, 10);
            this.cboKhachDoan.Name = "cboKhachDoan";
            this.cboKhachDoan.Size = new System.Drawing.Size(426, 23);
            this.cboKhachDoan.TabIndex = 0;
            // 
            // FrmDangKyTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 335);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDangKyTour";
            this.Text = "FrmDangKyTour";
            this.Load += new System.EventHandler(this.FrmDangKyTour_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabTourLe.ResumeLayout(false);
            this.tabTourLe.PerformLayout();
            this.tabTourDoan.ResumeLayout(false);
            this.tabTourDoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoHiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSoLuongDoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabTourLe;
        private System.Windows.Forms.TabPage tabTourDoan;
        private System.Windows.Forms.Label lblTenKhachLe;
        private System.Windows.Forms.TextBox txtTenKhachLe;
        private System.Windows.Forms.Label lblCMNDLe;
        private System.Windows.Forms.TextBox txtCMNDLe;
        private System.Windows.Forms.Label lblTourLe;
        private System.Windows.Forms.ComboBox cboTourLe;
        private System.Windows.Forms.Label lblChuyenLe;
        private System.Windows.Forms.ComboBox cboChuyenLe;
        private System.Windows.Forms.Label lblDiemDonLe;
        private System.Windows.Forms.TextBox txtDiemDonLe;
        private System.Windows.Forms.Label lblTongTienLe;
        private System.Windows.Forms.TextBox txtTongTienLe;
        private System.Windows.Forms.Button btnXuatVeLe;
        private System.Windows.Forms.Label lblKhachDoan;
        private System.Windows.Forms.ComboBox cboKhachDoan;
        private System.Windows.Forms.Label lblTourDoan;
        private System.Windows.Forms.ComboBox cboTourDoan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown numSoLuongDoan;
        private System.Windows.Forms.Label lblNgayDi;
        private System.Windows.Forms.DateTimePicker dtpNgayDiDoan;
        private System.Windows.Forms.Label lblDiemDonDoan;
        private System.Windows.Forms.TextBox txtDiemDonDoan;
        private System.Windows.Forms.Label lblTienCoc;
        private System.Windows.Forms.TextBox txtTienCoc;
        private System.Windows.Forms.DataGridView dgvBaoHiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaBH;
        private System.Windows.Forms.Button btnTaoPhieuDoan;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.Label lblStatusLe;
        private System.Windows.Forms.Label lblErrorDoan;
    }
}