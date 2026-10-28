namespace QLCuaHangNGK
{
    partial class FrmBanHang_GhiNo
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
            this.grpKhachHang = new System.Windows.Forms.GroupBox();
            this.txtLoaiKhach = new System.Windows.Forms.TextBox();
            this.lblLoaiKhach = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.grpSanPham = new System.Windows.Forms.GroupBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.txtSoLuongMua = new System.Windows.Forms.TextBox();
            this.lblSoLuongMua = new System.Windows.Forms.Label();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.cboNuocGiaiKhat = new System.Windows.Forms.ComboBox();
            this.lblNuocGiaiKhat = new System.Windows.Forms.Label();
            this.dgvChiTietHoaDon = new System.Windows.Forms.DataGridView();
            this.grpThanhToan = new System.Windows.Forms.GroupBox();
            this.txtLyDoNo = new System.Windows.Forms.TextBox();
            this.lblLyDoNo = new System.Windows.Forms.Label();
            this.dtpNgayDuKienTra = new System.Windows.Forms.DateTimePicker();
            this.lblNgayDuKienTra = new System.Windows.Forms.Label();
            this.txtSoTienNo = new System.Windows.Forms.TextBox();
            this.lblSoTienNo = new System.Windows.Forms.Label();
            this.radTraCham_GhiNo = new System.Windows.Forms.RadioButton();
            this.radThanhToanNgay = new System.Windows.Forms.RadioButton();
            this.dtpNgayHenGiao = new System.Windows.Forms.DateTimePicker();
            this.chkLapPhieuHen = new System.Windows.Forms.CheckBox();
            this.btnLapHoaDon_GhiNo = new System.Windows.Forms.Button();
            this.grpKhachHang.SuspendLayout();
            this.grpSanPham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).BeginInit();
            this.grpThanhToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpKhachHang
            // 
            this.grpKhachHang.Controls.Add(this.txtLoaiKhach);
            this.grpKhachHang.Controls.Add(this.lblLoaiKhach);
            this.grpKhachHang.Controls.Add(this.cboKhachHang);
            this.grpKhachHang.Controls.Add(this.lblKhachHang);
            this.grpKhachHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKhachHang.Location = new System.Drawing.Point(5, 5);
            this.grpKhachHang.Name = "grpKhachHang";
            this.grpKhachHang.Size = new System.Drawing.Size(260, 75);
            this.grpKhachHang.TabIndex = 0;
            this.grpKhachHang.TabStop = false;
            this.grpKhachHang.Text = "Khách hàng";
            // 
            // txtLoaiKhach
            // 
            this.txtLoaiKhach.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLoaiKhach.Location = new System.Drawing.Point(75, 43);
            this.txtLoaiKhach.Name = "txtLoaiKhach";
            this.txtLoaiKhach.ReadOnly = true;
            this.txtLoaiKhach.Size = new System.Drawing.Size(175, 22);
            this.txtLoaiKhach.TabIndex = 3;
            // 
            // lblLoaiKhach
            // 
            this.lblLoaiKhach.AutoSize = true;
            this.lblLoaiKhach.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiKhach.Location = new System.Drawing.Point(6, 46);
            this.lblLoaiKhach.Name = "lblLoaiKhach";
            this.lblLoaiKhach.Size = new System.Drawing.Size(64, 13);
            this.lblLoaiKhach.TabIndex = 2;
            this.lblLoaiKhach.Text = "Loại khách:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(75, 17);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(175, 21);
            this.cboKhachHang.TabIndex = 1;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Location = new System.Drawing.Point(6, 20);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(41, 13);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Tên KH:";
            // 
            // grpSanPham
            // 
            this.grpSanPham.Controls.Add(this.btnThemMon);
            this.grpSanPham.Controls.Add(this.txtSoLuongMua);
            this.grpSanPham.Controls.Add(this.lblSoLuongMua);
            this.grpSanPham.Controls.Add(this.txtSoLuongTon);
            this.grpSanPham.Controls.Add(this.lblSoLuongTon);
            this.grpSanPham.Controls.Add(this.cboNuocGiaiKhat);
            this.grpSanPham.Controls.Add(this.lblNuocGiaiKhat);
            this.grpSanPham.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSanPham.Location = new System.Drawing.Point(270, 5);
            this.grpSanPham.Name = "grpSanPham";
            this.grpSanPham.Size = new System.Drawing.Size(485, 75);
            this.grpSanPham.TabIndex = 1;
            this.grpSanPham.TabStop = false;
            this.grpSanPham.Text = "Chọn sản phẩm";
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.White;
            this.btnThemMon.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnThemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemMon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMon.Location = new System.Drawing.Point(400, 16);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(78, 49);
            this.btnThemMon.TabIndex = 6;
            this.btnThemMon.Text = "+ THÊM";
            this.btnThemMon.UseVisualStyleBackColor = false;
            this.btnThemMon.Click += new System.EventHandler(this.btnThemMon_Click);
            // 
            // txtSoLuongMua
            // 
            this.txtSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongMua.Location = new System.Drawing.Point(335, 43);
            this.txtSoLuongMua.Name = "txtSoLuongMua";
            this.txtSoLuongMua.Size = new System.Drawing.Size(55, 22);
            this.txtSoLuongMua.TabIndex = 5;
            this.txtSoLuongMua.Text = "1";
            // 
            // lblSoLuongMua
            // 
            this.lblSoLuongMua.AutoSize = true;
            this.lblSoLuongMua.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongMua.Location = new System.Drawing.Point(285, 46);
            this.lblSoLuongMua.Name = "lblSoLuongMua";
            this.lblSoLuongMua.Size = new System.Drawing.Size(45, 13);
            this.lblSoLuongMua.TabIndex = 4;
            this.lblSoLuongMua.Text = "SL mua:";
            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuongTon.Location = new System.Drawing.Point(335, 17);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.ReadOnly = true;
            this.txtSoLuongTon.Size = new System.Drawing.Size(55, 22);
            this.txtSoLuongTon.TabIndex = 3;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongTon.Location = new System.Drawing.Point(285, 20);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(43, 13);
            this.lblSoLuongTon.TabIndex = 2;
            this.lblSoLuongTon.Text = "Tồn kho:";
            // 
            // cboNuocGiaiKhat
            // 
            this.cboNuocGiaiKhat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNuocGiaiKhat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNuocGiaiKhat.FormattingEnabled = true;
            this.cboNuocGiaiKhat.Location = new System.Drawing.Point(65, 17);
            this.cboNuocGiaiKhat.Name = "cboNuocGiaiKhat";
            this.cboNuocGiaiKhat.Size = new System.Drawing.Size(210, 21);
            this.cboNuocGiaiKhat.TabIndex = 1;
            this.cboNuocGiaiKhat.SelectedIndexChanged += new System.EventHandler(this.cboNuocGiaiKhat_SelectedIndexChanged);
            // 
            // lblNuocGiaiKhat
            // 
            this.lblNuocGiaiKhat.AutoSize = true;
            this.lblNuocGiaiKhat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuocGiaiKhat.Location = new System.Drawing.Point(6, 20);
            this.lblNuocGiaiKhat.Name = "lblNuocGiaiKhat";
            this.lblNuocGiaiKhat.Size = new System.Drawing.Size(56, 13);
            this.lblNuocGiaiKhat.TabIndex = 0;
            this.lblNuocGiaiKhat.Text = "Tên NGK:";
            // 
            // dgvChiTietHoaDon
            // 
            this.dgvChiTietHoaDon.AllowUserToAddRows = false;
            this.dgvChiTietHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChiTietHoaDon.BackgroundColor = System.Drawing.Color.White;
            this.dgvChiTietHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvChiTietHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTietHoaDon.GridColor = System.Drawing.Color.DarkGray;
            this.dgvChiTietHoaDon.Location = new System.Drawing.Point(5, 85);
            this.dgvChiTietHoaDon.Name = "dgvChiTietHoaDon";
            this.dgvChiTietHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvChiTietHoaDon.Size = new System.Drawing.Size(750, 110);
            this.dgvChiTietHoaDon.TabIndex = 2;
            // 
            // grpThanhToan
            // 
            this.grpThanhToan.Controls.Add(this.txtLyDoNo);
            this.grpThanhToan.Controls.Add(this.lblLyDoNo);
            this.grpThanhToan.Controls.Add(this.dtpNgayDuKienTra);
            this.grpThanhToan.Controls.Add(this.lblNgayDuKienTra);
            this.grpThanhToan.Controls.Add(this.txtSoTienNo);
            this.grpThanhToan.Controls.Add(this.lblSoTienNo);
            this.grpThanhToan.Controls.Add(this.radTraCham_GhiNo);
            this.grpThanhToan.Controls.Add(this.radThanhToanNgay);
            this.grpThanhToan.Controls.Add(this.dtpNgayHenGiao);
            this.grpThanhToan.Controls.Add(this.chkLapPhieuHen);
            this.grpThanhToan.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpThanhToan.Location = new System.Drawing.Point(5, 198);
            this.grpThanhToan.Name = "grpThanhToan";
            this.grpThanhToan.Size = new System.Drawing.Size(595, 75);
            this.grpThanhToan.TabIndex = 3;
            this.grpThanhToan.TabStop = false;
            this.grpThanhToan.Text = "Hẹn giao & Ghi nợ";
            // 
            // txtLyDoNo
            // 
            this.txtLyDoNo.Enabled = false;
            this.txtLyDoNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyDoNo.Location = new System.Drawing.Point(340, 43);
            this.txtLyDoNo.Name = "txtLyDoNo";
            this.txtLyDoNo.Size = new System.Drawing.Size(248, 22);
            this.txtLyDoNo.TabIndex = 9;
            // 
            // lblLyDoNo
            // 
            this.lblLyDoNo.AutoSize = true;
            this.lblLyDoNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLyDoNo.Location = new System.Drawing.Point(280, 46);
            this.lblLyDoNo.Name = "lblLyDoNo";
            this.lblLyDoNo.Size = new System.Drawing.Size(53, 13);
            this.lblLyDoNo.TabIndex = 8;
            this.lblLyDoNo.Text = "Lý do nợ:";
            // 
            // dtpNgayDuKienTra
            // 
            this.dtpNgayDuKienTra.Enabled = false;
            this.dtpNgayDuKienTra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayDuKienTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDuKienTra.Location = new System.Drawing.Point(488, 17);
            this.dtpNgayDuKienTra.Name = "dtpNgayDuKienTra";
            this.dtpNgayDuKienTra.Size = new System.Drawing.Size(100, 22);
            this.dtpNgayDuKienTra.TabIndex = 7;
            // 
            // lblNgayDuKienTra
            // 
            this.lblNgayDuKienTra.AutoSize = true;
            this.lblNgayDuKienTra.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayDuKienTra.Location = new System.Drawing.Point(435, 20);
            this.lblNgayDuKienTra.Name = "lblNgayDuKienTra";
            this.lblNgayDuKienTra.Size = new System.Drawing.Size(53, 13);
            this.lblNgayDuKienTra.TabIndex = 6;
            this.lblNgayDuKienTra.Text = "Hẹn trả:";
            // 
            // txtSoTienNo
            // 
            this.txtSoTienNo.Enabled = false;
            this.txtSoTienNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoTienNo.Location = new System.Drawing.Point(340, 17);
            this.txtSoTienNo.Name = "txtSoTienNo";
            this.txtSoTienNo.Size = new System.Drawing.Size(90, 22);
            this.txtSoTienNo.TabIndex = 5;
            // 
            // lblSoTienNo
            // 
            this.lblSoTienNo.AutoSize = true;
            this.lblSoTienNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTienNo.Location = new System.Drawing.Point(280, 20);
            this.lblSoTienNo.Name = "lblSoTienNo";
            this.lblSoTienNo.Size = new System.Drawing.Size(60, 13);
            this.lblSoTienNo.TabIndex = 4;
            this.lblSoTienNo.Text = "Số tiền nợ:";
            // 
            // radTraCham_GhiNo
            // 
            this.radTraCham_GhiNo.AutoSize = true;
            this.radTraCham_GhiNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTraCham_GhiNo.Location = new System.Drawing.Point(145, 44);
            this.radTraCham_GhiNo.Name = "radTraCham_GhiNo";
            this.radTraCham_GhiNo.Size = new System.Drawing.Size(125, 17);
            this.radTraCham_GhiNo.TabIndex = 3;
            this.radTraCham_GhiNo.Text = "Trả chậm (Ghi nợ)";
            this.radTraCham_GhiNo.UseVisualStyleBackColor = true;
            this.radTraCham_GhiNo.CheckedChanged += new System.EventHandler(this.radTraCham_GhiNo_CheckedChanged);
            // 
            // radThanhToanNgay
            // 
            this.radThanhToanNgay.AutoSize = true;
            this.radThanhToanNgay.Checked = true;
            this.radThanhToanNgay.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radThanhToanNgay.Location = new System.Drawing.Point(6, 44);
            this.radThanhToanNgay.Name = "radThanhToanNgay";
            this.radThanhToanNgay.Size = new System.Drawing.Size(133, 17);
            this.radThanhToanNgay.TabIndex = 2;
            this.radThanhToanNgay.TabStop = true;
            this.radThanhToanNgay.Text = "Thanh toán ngay 100%";
            this.radThanhToanNgay.UseVisualStyleBackColor = true;
            // 
            // dtpNgayHenGiao
            // 
            this.dtpNgayHenGiao.Enabled = false;
            this.dtpNgayHenGiao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayHenGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHenGiao.Location = new System.Drawing.Point(145, 17);
            this.dtpNgayHenGiao.Name = "dtpNgayHenGiao";
            this.dtpNgayHenGiao.Size = new System.Drawing.Size(120, 22);
            this.dtpNgayHenGiao.TabIndex = 1;
            // 
            // chkLapPhieuHen
            // 
            this.chkLapPhieuHen.AutoSize = true;
            this.chkLapPhieuHen.Enabled = false;
            this.chkLapPhieuHen.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLapPhieuHen.Location = new System.Drawing.Point(6, 19);
            this.chkLapPhieuHen.Name = "chkLapPhieuHen";
            this.chkLapPhieuHen.Size = new System.Drawing.Size(130, 17);
            this.chkLapPhieuHen.TabIndex = 0;
            this.chkLapPhieuHen.Text = "Hẹn giao đợt sau:";
            this.chkLapPhieuHen.UseVisualStyleBackColor = true;
            // 
            // btnLapHoaDon_GhiNo
            // 
            this.btnLapHoaDon_GhiNo.BackColor = System.Drawing.Color.White;
            this.btnLapHoaDon_GhiNo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLapHoaDon_GhiNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLapHoaDon_GhiNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLapHoaDon_GhiNo.ForeColor = System.Drawing.Color.Black;
            this.btnLapHoaDon_GhiNo.Location = new System.Drawing.Point(605, 206);
            this.btnLapHoaDon_GhiNo.Name = "btnLapHoaDon_GhiNo";
            this.btnLapHoaDon_GhiNo.Size = new System.Drawing.Size(150, 67);
            this.btnLapHoaDon_GhiNo.TabIndex = 4;
            this.btnLapHoaDon_GhiNo.Text = "LẬP HÓA ĐƠN\r\n&&\r\nXỬ LÝ NỢ";
            this.btnLapHoaDon_GhiNo.UseVisualStyleBackColor = false;
            this.btnLapHoaDon_GhiNo.Click += new System.EventHandler(this.btnLapHoaDon_GhiNo_Click);
            // 
            // FrmBanHang_GhiNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 280);
            this.Controls.Add(this.btnLapHoaDon_GhiNo);
            this.Controls.Add(this.grpThanhToan);
            this.Controls.Add(this.dgvChiTietHoaDon);
            this.Controls.Add(this.grpSanPham);
            this.Controls.Add(this.grpKhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanHang_GhiNo";
            this.Text = "Bán Hàng & Ghi Nợ";
            this.Load += new System.EventHandler(this.FrmBanHang_GhiNo_Load);
            this.grpKhachHang.ResumeLayout(false);
            this.grpKhachHang.PerformLayout();
            this.grpSanPham.ResumeLayout(false);
            this.grpSanPham.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTietHoaDon)).EndInit();
            this.grpThanhToan.ResumeLayout(false);
            this.grpThanhToan.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpKhachHang;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblLoaiKhach;
        private System.Windows.Forms.TextBox txtLoaiKhach;
        private System.Windows.Forms.GroupBox grpSanPham;
        private System.Windows.Forms.Label lblNuocGiaiKhat;
        private System.Windows.Forms.ComboBox cboNuocGiaiKhat;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Label lblSoLuongMua;
        private System.Windows.Forms.TextBox txtSoLuongMua;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.DataGridView dgvChiTietHoaDon;
        private System.Windows.Forms.GroupBox grpThanhToan;
        private System.Windows.Forms.CheckBox chkLapPhieuHen;
        private System.Windows.Forms.DateTimePicker dtpNgayHenGiao;
        private System.Windows.Forms.RadioButton radThanhToanNgay;
        private System.Windows.Forms.RadioButton radTraCham_GhiNo;
        private System.Windows.Forms.Label lblSoTienNo;
        private System.Windows.Forms.TextBox txtSoTienNo;
        private System.Windows.Forms.Label lblNgayDuKienTra;
        private System.Windows.Forms.DateTimePicker dtpNgayDuKienTra;
        private System.Windows.Forms.Label lblLyDoNo;
        private System.Windows.Forms.TextBox txtLyDoNo;
        private System.Windows.Forms.Button btnLapHoaDon_GhiNo;
    }
}