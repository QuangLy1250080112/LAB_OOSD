namespace QLCtyDuLich
{
    partial class FrmDieuHanhVaQuyetToan
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
            this.tabPhanCong = new System.Windows.Forms.TabPage();
            this.lblErrorPhanCong = new System.Windows.Forms.Label();
            this.btnPhanCong = new System.Windows.Forms.Button();
            this.dtpNgayPhanCong = new System.Windows.Forms.DateTimePicker();
            this.lblNgayPhanCong = new System.Windows.Forms.Label();
            this.cboHDV = new System.Windows.Forms.ComboBox();
            this.lblHDV = new System.Windows.Forms.Label();
            this.cboDoiTuongPC = new System.Windows.Forms.ComboBox();
            this.lblDoiTuongPC = new System.Windows.Forms.Label();
            this.rdoTourDoan = new System.Windows.Forms.RadioButton();
            this.rdoChuyenLe = new System.Windows.Forms.RadioButton();
            this.tabQuyetToan = new System.Windows.Forms.TabPage();
            this.lblStatusQuyetToan = new System.Windows.Forms.Label();
            this.btnQuyetToan = new System.Windows.Forms.Button();
            this.txtTienConLai = new System.Windows.Forms.TextBox();
            this.lblTienConLai = new System.Windows.Forms.Label();
            this.txtTienCocDaNop = new System.Windows.Forms.TextBox();
            this.lblTienCocDaNop = new System.Windows.Forms.Label();
            this.txtTongTienTour = new System.Windows.Forms.TextBox();
            this.lblTongTienTour = new System.Windows.Forms.Label();
            this.cboPhieuDoanQuyetToan = new System.Windows.Forms.ComboBox();
            this.lblPhieuDoanQuyetToan = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPhanCong.SuspendLayout();
            this.tabQuyetToan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPhanCong);
            this.tabControlMain.Controls.Add(this.tabQuyetToan);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 335);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPhanCong
            // 
            this.tabPhanCong.BackColor = System.Drawing.Color.White;
            this.tabPhanCong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPhanCong.Controls.Add(this.lblErrorPhanCong);
            this.tabPhanCong.Controls.Add(this.btnPhanCong);
            this.tabPhanCong.Controls.Add(this.dtpNgayPhanCong);
            this.tabPhanCong.Controls.Add(this.lblNgayPhanCong);
            this.tabPhanCong.Controls.Add(this.cboHDV);
            this.tabPhanCong.Controls.Add(this.lblHDV);
            this.tabPhanCong.Controls.Add(this.cboDoiTuongPC);
            this.tabPhanCong.Controls.Add(this.lblDoiTuongPC);
            this.tabPhanCong.Controls.Add(this.rdoTourDoan);
            this.tabPhanCong.Controls.Add(this.rdoChuyenLe);
            this.tabPhanCong.Location = new System.Drawing.Point(4, 24);
            this.tabPhanCong.Name = "tabPhanCong";
            this.tabPhanCong.Padding = new System.Windows.Forms.Padding(10);
            this.tabPhanCong.Size = new System.Drawing.Size(562, 307);
            this.tabPhanCong.TabIndex = 0;
            this.tabPhanCong.Text = "PHÂN CÔNG HƯỚNG DẪN VIÊN";
            // 
            // lblErrorPhanCong
            // 
            this.lblErrorPhanCong.AutoSize = true;
            this.lblErrorPhanCong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblErrorPhanCong.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPhanCong.Location = new System.Drawing.Point(15, 268);
            this.lblErrorPhanCong.Name = "lblErrorPhanCong";
            this.lblErrorPhanCong.Size = new System.Drawing.Size(0, 15);
            this.lblErrorPhanCong.TabIndex = 9;
            // 
            // btnPhanCong
            // 
            this.btnPhanCong.BackColor = System.Drawing.Color.Black;
            this.btnPhanCong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhanCong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPhanCong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhanCong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPhanCong.ForeColor = System.Drawing.Color.White;
            this.btnPhanCong.Location = new System.Drawing.Point(395, 258);
            this.btnPhanCong.Name = "btnPhanCong";
            this.btnPhanCong.Size = new System.Drawing.Size(150, 32);
            this.btnPhanCong.TabIndex = 8;
            this.btnPhanCong.Text = "Xác Nhận Phân Công";
            this.btnPhanCong.UseVisualStyleBackColor = false;
            this.btnPhanCong.Click += new System.EventHandler(this.btnPhanCong_Click);
            // 
            // dtpNgayPhanCong
            // 
            this.dtpNgayPhanCong.Enabled = false;
            this.dtpNgayPhanCong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayPhanCong.Location = new System.Drawing.Point(150, 175);
            this.dtpNgayPhanCong.Name = "dtpNgayPhanCong";
            this.dtpNgayPhanCong.Size = new System.Drawing.Size(395, 23);
            this.dtpNgayPhanCong.TabIndex = 7;
            // 
            // lblNgayPhanCong
            // 
            this.lblNgayPhanCong.AutoSize = true;
            this.lblNgayPhanCong.Location = new System.Drawing.Point(15, 180);
            this.lblNgayPhanCong.Name = "lblNgayPhanCong";
            this.lblNgayPhanCong.Size = new System.Drawing.Size(98, 15);
            this.lblNgayPhanCong.TabIndex = 6;
            this.lblNgayPhanCong.Text = "Ngày Phân Công:";
            // 
            // cboHDV
            // 
            this.cboHDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHDV.FormattingEnabled = true;
            this.cboHDV.Location = new System.Drawing.Point(150, 122);
            this.cboHDV.Name = "cboHDV";
            this.cboHDV.Size = new System.Drawing.Size(395, 23);
            this.cboHDV.TabIndex = 5;
            // 
            // lblHDV
            // 
            this.lblHDV.AutoSize = true;
            this.lblHDV.Location = new System.Drawing.Point(15, 125);
            this.lblHDV.Name = "lblHDV";
            this.lblHDV.Size = new System.Drawing.Size(124, 15);
            this.lblHDV.TabIndex = 4;
            this.lblHDV.Text = "Chọn Hướng Dẫn Viên:";
            // 
            // cboDoiTuongPC
            // 
            this.cboDoiTuongPC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDoiTuongPC.FormattingEnabled = true;
            this.cboDoiTuongPC.Location = new System.Drawing.Point(150, 68);
            this.cboDoiTuongPC.Name = "cboDoiTuongPC";
            this.cboDoiTuongPC.Size = new System.Drawing.Size(395, 23);
            this.cboDoiTuongPC.TabIndex = 3;
            this.cboDoiTuongPC.SelectedIndexChanged += new System.EventHandler(this.cboDoiTuongPC_SelectedIndexChanged);
            // 
            // lblDoiTuongPC
            // 
            this.lblDoiTuongPC.AutoSize = true;
            this.lblDoiTuongPC.Location = new System.Drawing.Point(15, 71);
            this.lblDoiTuongPC.Name = "lblDoiTuongPC";
            this.lblDoiTuongPC.Size = new System.Drawing.Size(126, 15);
            this.lblDoiTuongPC.TabIndex = 2;
            this.lblDoiTuongPC.Text = "Chọn Chuyến / Đoàn:";
            // 
            // rdoTourDoan
            // 
            this.rdoTourDoan.AutoSize = true;
            this.rdoTourDoan.Location = new System.Drawing.Point(220, 20);
            this.rdoTourDoan.Name = "rdoTourDoan";
            this.rdoTourDoan.Size = new System.Drawing.Size(142, 19);
            this.rdoTourDoan.TabIndex = 1;
            this.rdoTourDoan.Text = "Phân Công Tour Đoàn";
            this.rdoTourDoan.UseVisualStyleBackColor = true;
            this.rdoTourDoan.CheckedChanged += new System.EventHandler(this.rdoOption_CheckedChanged);
            // 
            // rdoChuyenLe
            // 
            this.rdoChuyenLe.AutoSize = true;
            this.rdoChuyenLe.Checked = true;
            this.rdoChuyenLe.Location = new System.Drawing.Point(15, 20);
            this.rdoChuyenLe.Name = "rdoChuyenLe";
            this.rdoChuyenLe.Size = new System.Drawing.Size(155, 19);
            this.rdoChuyenLe.TabIndex = 0;
            this.rdoChuyenLe.TabStop = true;
            this.rdoChuyenLe.Text = "Phân Công Chuyến Đi Lẻ";
            this.rdoChuyenLe.UseVisualStyleBackColor = true;
            this.rdoChuyenLe.CheckedChanged += new System.EventHandler(this.rdoOption_CheckedChanged);
            // 
            // tabQuyetToan
            // 
            this.tabQuyetToan.BackColor = System.Drawing.Color.White;
            this.tabQuyetToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabQuyetToan.Controls.Add(this.lblStatusQuyetToan);
            this.tabQuyetToan.Controls.Add(this.btnQuyetToan);
            this.tabQuyetToan.Controls.Add(this.txtTienConLai);
            this.tabQuyetToan.Controls.Add(this.lblTienConLai);
            this.tabQuyetToan.Controls.Add(this.txtTienCocDaNop);
            this.tabQuyetToan.Controls.Add(this.lblTienCocDaNop);
            this.tabQuyetToan.Controls.Add(this.txtTongTienTour);
            this.tabQuyetToan.Controls.Add(this.lblTongTienTour);
            this.tabQuyetToan.Controls.Add(this.cboPhieuDoanQuyetToan);
            this.tabQuyetToan.Controls.Add(this.lblPhieuDoanQuyetToan);
            this.tabQuyetToan.Location = new System.Drawing.Point(4, 24);
            this.tabQuyetToan.Name = "tabQuyetToan";
            this.tabQuyetToan.Padding = new System.Windows.Forms.Padding(10);
            this.tabQuyetToan.Size = new System.Drawing.Size(562, 307);
            this.tabQuyetToan.TabIndex = 1;
            this.tabQuyetToan.Text = "QUYẾT TOÁN KINH PHÍ TOUR ĐOÀN";
            // 
            // lblStatusQuyetToan
            // 
            this.lblStatusQuyetToan.AutoSize = true;
            this.lblStatusQuyetToan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusQuyetToan.ForeColor = System.Drawing.Color.Red;
            this.lblStatusQuyetToan.Location = new System.Drawing.Point(15, 268);
            this.lblStatusQuyetToan.Name = "lblStatusQuyetToan";
            this.lblStatusQuyetToan.Size = new System.Drawing.Size(0, 15);
            this.lblStatusQuyetToan.TabIndex = 9;
            // 
            // btnQuyetToan
            // 
            this.btnQuyetToan.BackColor = System.Drawing.Color.Black;
            this.btnQuyetToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuyetToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuyetToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetToan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnQuyetToan.ForeColor = System.Drawing.Color.White;
            this.btnQuyetToan.Location = new System.Drawing.Point(375, 258);
            this.btnQuyetToan.Name = "btnQuyetToan";
            this.btnQuyetToan.Size = new System.Drawing.Size(170, 32);
            this.btnQuyetToan.TabIndex = 8;
            this.btnQuyetToan.Text = "Thanh Toán & Quyết Toán";
            this.btnQuyetToan.UseVisualStyleBackColor = false;
            this.btnQuyetToan.Click += new System.EventHandler(this.btnQuyetToan_Click);
            // 
            // txtTienConLai
            // 
            this.txtTienConLai.BackColor = System.Drawing.Color.White;
            this.txtTienConLai.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienConLai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtTienConLai.ForeColor = System.Drawing.Color.Red;
            this.txtTienConLai.Location = new System.Drawing.Point(170, 182);
            this.txtTienConLai.Name = "txtTienConLai";
            this.txtTienConLai.ReadOnly = true;
            this.txtTienConLai.Size = new System.Drawing.Size(375, 23);
            this.txtTienConLai.TabIndex = 7;
            // 
            // lblTienConLai
            // 
            this.lblTienConLai.AutoSize = true;
            this.lblTienConLai.Location = new System.Drawing.Point(15, 185);
            this.lblTienConLai.Name = "lblTienConLai";
            this.lblTienConLai.Size = new System.Drawing.Size(135, 15);
            this.lblTienConLai.TabIndex = 6;
            this.lblTienConLai.Text = "Số Tiền Còn Lại Phải Thu:";
            // 
            // txtTienCocDaNop
            // 
            this.txtTienCocDaNop.BackColor = System.Drawing.Color.White;
            this.txtTienCocDaNop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienCocDaNop.Location = new System.Drawing.Point(170, 127);
            this.txtTienCocDaNop.Name = "txtTienCocDaNop";
            this.txtTienCocDaNop.ReadOnly = true;
            this.txtTienCocDaNop.Size = new System.Drawing.Size(375, 23);
            this.txtTienCocDaNop.TabIndex = 5;
            // 
            // lblTienCocDaNop
            // 
            this.lblTienCocDaNop.AutoSize = true;
            this.lblTienCocDaNop.Location = new System.Drawing.Point(15, 130);
            this.lblTienCocDaNop.Name = "lblTienCocDaNop";
            this.lblTienCocDaNop.Size = new System.Drawing.Size(126, 15);
            this.lblTienCocDaNop.TabIndex = 4;
            this.lblTienCocDaNop.Text = "Tiền Đặt Cọc Đã Nộp:";
            // 
            // txtTongTienTour
            // 
            this.txtTongTienTour.BackColor = System.Drawing.Color.White;
            this.txtTongTienTour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTongTienTour.Location = new System.Drawing.Point(170, 72);
            this.txtTongTienTour.Name = "txtTongTienTour";
            this.txtTongTienTour.ReadOnly = true;
            this.txtTongTienTour.Size = new System.Drawing.Size(375, 23);
            this.txtTongTienTour.TabIndex = 3;
            // 
            // lblTongTienTour
            // 
            this.lblTongTienTour.AutoSize = true;
            this.lblTongTienTour.Location = new System.Drawing.Point(15, 75);
            this.lblTongTienTour.Name = "lblTongTienTour";
            this.lblTongTienTour.Size = new System.Drawing.Size(149, 15);
            this.lblTongTienTour.TabIndex = 2;
            this.lblTongTienTour.Text = "Tổng Giá Trị Hợp Đồng Tour:";
            // 
            // cboPhieuDoanQuyetToan
            // 
            this.cboPhieuDoanQuyetToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPhieuDoanQuyetToan.FormattingEnabled = true;
            this.cboPhieuDoanQuyetToan.Location = new System.Drawing.Point(170, 18);
            this.cboPhieuDoanQuyetToan.Name = "cboPhieuDoanQuyetToan";
            this.cboPhieuDoanQuyetToan.Size = new System.Drawing.Size(375, 23);
            this.cboPhieuDoanQuyetToan.TabIndex = 1;
            this.cboPhieuDoanQuyetToan.SelectedIndexChanged += new System.EventHandler(this.cboPhieuDoanQuyetToan_SelectedIndexChanged);
            // 
            // lblPhieuDoanQuyetToan
            // 
            this.lblPhieuDoanQuyetToan.AutoSize = true;
            this.lblPhieuDoanQuyetToan.Location = new System.Drawing.Point(15, 21);
            this.lblPhieuDoanQuyetToan.Name = "lblPhieuDoanQuyetToan";
            this.lblPhieuDoanQuyetToan.Size = new System.Drawing.Size(135, 15);
            this.lblPhieuDoanQuyetToan.TabIndex = 0;
            this.lblPhieuDoanQuyetToan.Text = "Chọn Tour Đoàn Cần QT:";
            // 
            // FrmDieuHanhVaQuyetToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 335);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDieuHanhVaQuyetToan";
            this.Text = "FrmDieuHanhVaQuyetToan";
            this.Load += new System.EventHandler(this.FrmDieuHanhVaQuyetToan_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPhanCong.ResumeLayout(false);
            this.tabPhanCong.PerformLayout();
            this.tabQuyetToan.ResumeLayout(false);
            this.tabQuyetToan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPhanCong;
        private System.Windows.Forms.TabPage tabQuyetToan;
        private System.Windows.Forms.RadioButton rdoTourDoan;
        private System.Windows.Forms.RadioButton rdoChuyenLe;
        private System.Windows.Forms.Label lblDoiTuongPC;
        private System.Windows.Forms.ComboBox cboDoiTuongPC;
        private System.Windows.Forms.Label lblHDV;
        private System.Windows.Forms.ComboBox cboHDV;
        private System.Windows.Forms.Label lblNgayPhanCong;
        private System.Windows.Forms.DateTimePicker dtpNgayPhanCong;
        private System.Windows.Forms.Button btnPhanCong;
        private System.Windows.Forms.Label lblErrorPhanCong;
        private System.Windows.Forms.Label lblPhieuDoanQuyetToan;
        private System.Windows.Forms.ComboBox cboPhieuDoanQuyetToan;
        private System.Windows.Forms.Label lblTongTienTour;
        private System.Windows.Forms.TextBox txtTongTienTour;
        private System.Windows.Forms.Label lblTienCocDaNop;
        private System.Windows.Forms.TextBox txtTienCocDaNop;
        private System.Windows.Forms.Label lblTienConLai;
        private System.Windows.Forms.TextBox txtTienConLai;
        private System.Windows.Forms.Button btnQuyetToan;
        private System.Windows.Forms.Label lblStatusQuyetToan;
    }
}