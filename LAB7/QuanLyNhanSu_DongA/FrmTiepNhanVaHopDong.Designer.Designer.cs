namespace QuanLyNhanSu_DongA
{
    partial class FrmTiepNhanVaHopDong
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
            this.pnlLeftInput = new System.Windows.Forms.Panel();
            this.lblSectionHeader = new System.Windows.Forms.Label();
            this.lblMaNV = new System.Windows.Forms.Label();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblPhongBan = new System.Windows.Forms.Label();
            this.cboPhongBan = new System.Windows.Forms.ComboBox();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.lblThoiGianThuViec = new System.Windows.Forms.Label();
            this.txtThoiGianThuViec = new System.Windows.Forms.TextBox();
            this.lblLuongThuViec = new System.Windows.Forms.Label();
            this.txtLuongThuViec = new System.Windows.Forms.TextBox();
            this.btnTaoQDTD = new System.Windows.Forms.Button();
            this.pnlContractType = new System.Windows.Forms.Panel();
            this.lblLoaiHD = new System.Windows.Forms.Label();
            this.radNganHan = new System.Windows.Forms.RadioButton();
            this.radDaiHan = new System.Windows.Forms.RadioButton();
            this.chkBaoHiem = new System.Windows.Forms.CheckBox();
            this.btnKyHopDong = new System.Windows.Forms.Button();
            this.pnlRightData = new System.Windows.Forms.Panel();
            this.lblGridHeader = new System.Windows.Forms.Label();
            this.dgvNhanVien = new System.Windows.Forms.DataGridView();
            this.pnlLeftInput.SuspendLayout();
            this.pnlContractType.SuspendLayout();
            this.pnlRightData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlLeftInput
            // 
            this.pnlLeftInput.BackColor = System.Drawing.Color.White;
            this.pnlLeftInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLeftInput.Controls.Add(this.lblSectionHeader);
            this.pnlLeftInput.Controls.Add(this.lblMaNV);
            this.pnlLeftInput.Controls.Add(this.txtMaNV);
            this.pnlLeftInput.Controls.Add(this.lblHoTen);
            this.pnlLeftInput.Controls.Add(this.txtHoTen);
            this.pnlLeftInput.Controls.Add(this.lblNgaySinh);
            this.pnlLeftInput.Controls.Add(this.dtpNgaySinh);
            this.pnlLeftInput.Controls.Add(this.lblPhongBan);
            this.pnlLeftInput.Controls.Add(this.cboPhongBan);
            this.pnlLeftInput.Controls.Add(this.lblChucVu);
            this.pnlLeftInput.Controls.Add(this.cboChucVu);
            this.pnlLeftInput.Controls.Add(this.lblThoiGianThuViec);
            this.pnlLeftInput.Controls.Add(this.txtThoiGianThuViec);
            this.pnlLeftInput.Controls.Add(this.lblLuongThuViec);
            this.pnlLeftInput.Controls.Add(this.txtLuongThuViec);
            this.pnlLeftInput.Controls.Add(this.btnTaoQDTD);
            this.pnlLeftInput.Controls.Add(this.pnlContractType);
            this.pnlLeftInput.Controls.Add(this.btnKyHopDong);
            this.pnlLeftInput.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftInput.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftInput.Name = "pnlLeftInput";
            this.pnlLeftInput.Size = new System.Drawing.Size(320, 255);
            this.pnlLeftInput.TabIndex = 0;
            // 
            // lblSectionHeader
            // 
            this.lblSectionHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblSectionHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSectionHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSectionHeader.Location = new System.Drawing.Point(-1, -1);
            this.lblSectionHeader.Name = "lblSectionHeader";
            this.lblSectionHeader.Size = new System.Drawing.Size(320, 22);
            this.lblSectionHeader.TabIndex = 0;
            this.lblSectionHeader.Text = "[ FORM NHẬP HỒ SƠ & HỢP ĐỒNG ]";
            this.lblSectionHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMaNV
            // 
            this.lblMaNV.AutoSize = true;
            this.lblMaNV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMaNV.Location = new System.Drawing.Point(5, 27);
            this.lblMaNV.Name = "lblMaNV";
            this.lblMaNV.Size = new System.Drawing.Size(43, 13);
            this.lblMaNV.TabIndex = 1;
            this.lblMaNV.Text = "Mã NV:";
            // 
            // txtMaNV
            // 
            this.txtMaNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMaNV.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaNV.Location = new System.Drawing.Point(55, 25);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(95, 22);
            this.txtMaNV.TabIndex = 2;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(155, 27);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(45, 13);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Họ Tên:";
            // 
            // txtHoTen
            // 
            this.txtHoTen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(202, 25);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(110, 22);
            this.txtHoTen.TabIndex = 4;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNgaySinh.Location = new System.Drawing.Point(5, 53);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(61, 13);
            this.lblNgaySinh.TabIndex = 5;
            this.lblNgaySinh.Text = "Ngày Sinh:";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(70, 50);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(242, 22);
            this.dtpNgaySinh.TabIndex = 6;
            // 
            // lblPhongBan
            // 
            this.lblPhongBan.AutoSize = true;
            this.lblPhongBan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhongBan.Location = new System.Drawing.Point(5, 78);
            this.lblPhongBan.Name = "lblPhongBan";
            this.lblPhongBan.Size = new System.Drawing.Size(66, 13);
            this.lblPhongBan.TabIndex = 7;
            this.lblPhongBan.Text = "Phòng Ban:";
            // 
            // cboPhongBan
            // 
            this.cboPhongBan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhongBan.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboPhongBan.FormattingEnabled = true;
            this.cboPhongBan.Location = new System.Drawing.Point(70, 75);
            this.cboPhongBan.Name = "cboPhongBan";
            this.cboPhongBan.Size = new System.Drawing.Size(242, 21);
            this.cboPhongBan.TabIndex = 8;
            // 
            // lblChucVu
            // 
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblChucVu.Location = new System.Drawing.Point(5, 103);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(52, 13);
            this.lblChucVu.TabIndex = 9;
            this.lblChucVu.Text = "Chức Vụ:";
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(70, 100);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(242, 21);
            this.cboChucVu.TabIndex = 10;
            // 
            // lblThoiGianThuViec
            // 
            this.lblThoiGianThuViec.AutoSize = true;
            this.lblThoiGianThuViec.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblThoiGianThuViec.Location = new System.Drawing.Point(5, 128);
            this.lblThoiGianThuViec.Name = "lblThoiGianThuViec";
            this.lblThoiGianThuViec.Size = new System.Drawing.Size(78, 13);
            this.lblThoiGianThuViec.TabIndex = 11;
            this.lblThoiGianThuViec.Text = "Thử Việc (Th):";
            // 
            // txtThoiGianThuViec
            // 
            this.txtThoiGianThuViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThoiGianThuViec.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtThoiGianThuViec.Location = new System.Drawing.Point(85, 125);
            this.txtThoiGianThuViec.Name = "txtThoiGianThuViec";
            this.txtThoiGianThuViec.Size = new System.Drawing.Size(40, 22);
            this.txtThoiGianThuViec.TabIndex = 12;
            this.txtThoiGianThuViec.Text = "2";
            // 
            // lblLuongThuViec
            // 
            this.lblLuongThuViec.AutoSize = true;
            this.lblLuongThuViec.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLuongThuViec.Location = new System.Drawing.Point(130, 128);
            this.lblLuongThuViec.Name = "lblLuongThuViec";
            this.lblLuongThuViec.Size = new System.Drawing.Size(65, 13);
            this.lblLuongThuViec.TabIndex = 13;
            this.lblLuongThuViec.Text = "Lương TV:";
            // 
            // txtLuongThuViec
            // 
            this.txtLuongThuViec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuongThuViec.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtLuongThuViec.Location = new System.Drawing.Point(195, 125);
            this.txtLuongThuViec.Name = "txtLuongThuViec";
            this.txtLuongThuViec.Size = new System.Drawing.Size(117, 22);
            this.txtLuongThuViec.TabIndex = 14;
            this.txtLuongThuViec.Text = "6000000";
            // 
            // btnTaoQDTD
            // 
            this.btnTaoQDTD.BackColor = System.Drawing.Color.White;
            this.btnTaoQDTD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaoQDTD.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTaoQDTD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoQDTD.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaoQDTD.Location = new System.Drawing.Point(5, 151);
            this.btnTaoQDTD.Name = "btnTaoQDTD";
            this.btnTaoQDTD.Size = new System.Drawing.Size(307, 23);
            this.btnTaoQDTD.TabIndex = 15;
            this.btnTaoQDTD.Text = "1. TẠO QĐ TUYỂN DỤNG THỬ VIỆC";
            this.btnTaoQDTD.UseVisualStyleBackColor = false;
            this.btnTaoQDTD.Click += new System.EventHandler(this.btnTaoQDTD_Click);
            // 
            // pnlContractType
            // 
            this.pnlContractType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlContractType.Controls.Add(this.lblLoaiHD);
            this.pnlContractType.Controls.Add(this.radNganHan);
            this.pnlContractType.Controls.Add(this.radDaiHan);
            this.pnlContractType.Controls.Add(this.chkBaoHiem);
            this.pnlContractType.Location = new System.Drawing.Point(5, 178);
            this.pnlContractType.Name = "pnlContractType";
            this.pnlContractType.Size = new System.Drawing.Size(307, 45);
            this.pnlContractType.TabIndex = 16;
            // 
            // lblLoaiHD
            // 
            this.lblLoaiHD.AutoSize = true;
            this.lblLoaiHD.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoaiHD.Location = new System.Drawing.Point(3, 3);
            this.lblLoaiHD.Name = "lblLoaiHD";
            this.lblLoaiHD.Size = new System.Drawing.Size(89, 12);
            this.lblLoaiHD.TabIndex = 0;
            this.lblLoaiHD.Text = "Loại Hợp Đồng:";
            // 
            // radNganHan
            // 
            this.radNganHan.AutoSize = true;
            this.radNganHan.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radNganHan.Location = new System.Drawing.Point(95, 1);
            this.radNganHan.Name = "radNganHan";
            this.radNganHan.Size = new System.Drawing.Size(71, 16);
            this.radNganHan.TabIndex = 1;
            this.radNganHan.Text = "Ngắn hạn";
            this.radNganHan.UseVisualStyleBackColor = true;
            this.radNganHan.CheckedChanged += new System.EventHandler(this.radNganHan_CheckedChanged);
            // 
            // radDaiHan
            // 
            this.radDaiHan.AutoSize = true;
            this.radDaiHan.Checked = true;
            this.radDaiHan.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.radDaiHan.Location = new System.Drawing.Point(170, 1);
            this.radDaiHan.Name = "radDaiHan";
            this.radDaiHan.Size = new System.Drawing.Size(61, 16);
            this.radDaiHan.TabIndex = 2;
            this.radDaiHan.TabStop = true;
            this.radDaiHan.Text = "Dài hạn";
            this.radDaiHan.UseVisualStyleBackColor = true;
            this.radDaiHan.CheckedChanged += new System.EventHandler(this.radDaiHan_CheckedChanged);
            // 
            // chkBaoHiem
            // 
            this.chkBaoHiem.AutoSize = true;
            this.chkBaoHiem.Checked = true;
            this.chkBaoHiem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBaoHiem.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.chkBaoHiem.Location = new System.Drawing.Point(5, 22);
            this.chkBaoHiem.Name = "chkBaoHiem";
            this.chkBaoHiem.Size = new System.Drawing.Size(201, 16);
            this.chkBaoHiem.TabIndex = 3;
            this.chkBaoHiem.Text = "Đồng bộ Hồ sơ BHXH / BHYT (HĐ Dài hạn)";
            this.chkBaoHiem.UseVisualStyleBackColor = true;
            // 
            // btnKyHopDong
            // 
            this.btnKyHopDong.BackColor = System.Drawing.Color.Black;
            this.btnKyHopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyHopDong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKyHopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKyHopDong.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKyHopDong.ForeColor = System.Drawing.Color.White;
            this.btnKyHopDong.Location = new System.Drawing.Point(5, 226);
            this.btnKyHopDong.Name = "btnKyHopDong";
            this.btnKyHopDong.Size = new System.Drawing.Size(307, 24);
            this.btnKyHopDong.TabIndex = 17;
            this.btnKyHopDong.Text = "2. KÝ HỢP ĐỒNG CHÍNH THỨC & ĐỒNG BỘ BHXH";
            this.btnKyHopDong.UseVisualStyleBackColor = false;
            this.btnKyHopDong.Click += new System.EventHandler(this.btnKyHopDong_Click);
            // 
            // pnlRightData
            // 
            this.pnlRightData.Controls.Add(this.lblGridHeader);
            this.pnlRightData.Controls.Add(this.dgvNhanVien);
            this.pnlRightData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightData.Location = new System.Drawing.Point(320, 0);
            this.pnlRightData.Name = "pnlRightData";
            this.pnlRightData.Size = new System.Drawing.Size(420, 255);
            this.pnlRightData.TabIndex = 1;
            // 
            // lblGridHeader
            // 
            this.lblGridHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblGridHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGridHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblGridHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGridHeader.Location = new System.Drawing.Point(0, 0);
            this.lblGridHeader.Name = "lblGridHeader";
            this.lblGridHeader.Size = new System.Drawing.Size(420, 22);
            this.lblGridHeader.TabIndex = 0;
            this.lblGridHeader.Text = "[ DANH SÁCH NHÂN VIÊN & TRẠNG THÁI HỢP ĐỒNG ]";
            this.lblGridHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvNhanVien
            // 
            this.dgvNhanVien.AllowUserToAddRows = false;
            this.dgvNhanVien.AllowUserToDeleteRows = false;
            this.dgvNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNhanVien.BackgroundColor = System.Drawing.Color.White;
            this.dgvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNhanVien.Location = new System.Drawing.Point(0, 0);
            this.dgvNhanVien.MultiSelect = false;
            this.dgvNhanVien.Name = "dgvNhanVien";
            this.dgvNhanVien.ReadOnly = true;
            this.dgvNhanVien.RowHeadersWidth = 25;
            this.dgvNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNhanVien.Size = new System.Drawing.Size(420, 255);
            this.dgvNhanVien.TabIndex = 1;
            this.dgvNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhanVien_CellClick);
            // 
            // FrmTiepNhanVaHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 255);
            this.Controls.Add(this.pnlRightData);
            this.Controls.Add(this.pnlLeftInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTiepNhanVaHopDong";
            this.Text = "Tiếp nhận Nhân viên và Ký Hợp đồng";
            this.Load += new System.EventHandler(this.FrmTiepNhanVaHopDong_Load);
            this.pnlLeftInput.ResumeLayout(false);
            this.pnlLeftInput.PerformLayout();
            this.pnlContractType.ResumeLayout(false);
            this.pnlContractType.PerformLayout();
            this.pnlRightData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhanVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeftInput;
        private System.Windows.Forms.Label lblSectionHeader;
        private System.Windows.Forms.Label lblMaNV;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label lblPhongBan;
        private System.Windows.Forms.ComboBox cboPhongBan;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.Label lblThoiGianThuViec;
        private System.Windows.Forms.TextBox txtThoiGianThuViec;
        private System.Windows.Forms.Label lblLuongThuViec;
        private System.Windows.Forms.TextBox txtLuongThuViec;
        private System.Windows.Forms.Button btnTaoQDTD;
        private System.Windows.Forms.Panel pnlContractType;
        private System.Windows.Forms.Label lblLoaiHD;
        private System.Windows.Forms.RadioButton radNganHan;
        private System.Windows.Forms.RadioButton radDaiHan;
        private System.Windows.Forms.CheckBox chkBaoHiem;
        private System.Windows.Forms.Button btnKyHopDong;
        private System.Windows.Forms.Panel pnlRightData;
        private System.Windows.Forms.Label lblGridHeader;
        private System.Windows.Forms.DataGridView dgvNhanVien;
    }
}