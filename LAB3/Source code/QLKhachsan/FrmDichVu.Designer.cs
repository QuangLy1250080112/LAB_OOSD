namespace QLKhachsan.Forms
{
    partial class FrmDichVu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblLuot, lblPhong, lblNgay, lblNV, lblDV, lblSL;
        private System.Windows.Forms.ComboBox cboLuot, cboNV, cboDV;
        private System.Windows.Forms.TextBox txtPhong;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.Button btnGhi, btnDong;
        private System.Windows.Forms.DataGridView dgvLichSu;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblLuot = new System.Windows.Forms.Label();
            this.cboLuot = new System.Windows.Forms.ComboBox();
            this.lblPhong = new System.Windows.Forms.Label();
            this.txtPhong = new System.Windows.Forms.TextBox();
            this.lblNgay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.lblNV = new System.Windows.Forms.Label();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.lblDV = new System.Windows.Forms.Label();
            this.cboDV = new System.Windows.Forms.ComboBox();
            this.lblSL = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.btnGhi = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.dgvLichSu = new System.Windows.Forms.DataGridView();

            this.grpThongTin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).BeginInit();
            this.SuspendLayout();

            // grpThongTin
            this.grpThongTin.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblLuot, this.cboLuot, this.lblPhong, this.txtPhong,
                this.lblNgay, this.dtNgay, this.lblNV, this.cboNV,
                this.lblDV, this.cboDV, this.lblSL, this.numSL, this.btnGhi
            });
            this.grpThongTin.Location = new System.Drawing.Point(12, 12);
            this.grpThongTin.Size = new System.Drawing.Size(760, 130);
            this.grpThongTin.Text = "Ghi Nhận Sử Dụng Dịch Vụ";

            // Row 1
            this.lblLuot.Text = "Phiếu Đặt:"; this.lblLuot.Location = new System.Drawing.Point(15, 30); this.lblLuot.AutoSize = true;
            this.cboLuot.Location = new System.Drawing.Point(85, 27); this.cboLuot.Size = new System.Drawing.Size(150, 23);

            this.lblPhong.Text = "Phòng:"; this.lblPhong.Location = new System.Drawing.Point(260, 30); this.lblPhong.AutoSize = true;
            this.txtPhong.Location = new System.Drawing.Point(315, 27); this.txtPhong.Size = new System.Drawing.Size(100, 23); this.txtPhong.ReadOnly = true;

            this.lblNgay.Text = "Ngày SD:"; this.lblNgay.Location = new System.Drawing.Point(440, 30); this.lblNgay.AutoSize = true;
            this.dtNgay.Location = new System.Drawing.Point(510, 27); this.dtNgay.Size = new System.Drawing.Size(220, 23);

            // Row 2
            this.lblNV.Text = "Nhân Viên:"; this.lblNV.Location = new System.Drawing.Point(15, 75); this.lblNV.AutoSize = true;
            this.cboNV.Location = new System.Drawing.Point(85, 72); this.cboNV.Size = new System.Drawing.Size(150, 23);

            this.lblDV.Text = "Dịch Vụ:"; this.lblDV.Location = new System.Drawing.Point(260, 75); this.lblDV.AutoSize = true;
            this.cboDV.Location = new System.Drawing.Point(315, 72); this.cboDV.Size = new System.Drawing.Size(180, 23);

            this.lblSL.Text = "Số Lượng:"; this.lblSL.Location = new System.Drawing.Point(510, 75); this.lblSL.AutoSize = true;
            this.numSL.Location = new System.Drawing.Point(575, 72); this.numSL.Size = new System.Drawing.Size(60, 23); this.numSL.Value = 1; this.numSL.Minimum = 1;

            this.btnGhi.Location = new System.Drawing.Point(650, 68); this.btnGhi.Size = new System.Drawing.Size(80, 30);
            this.btnGhi.Text = "Ghi Nhận";

            // dgvLichSu
            this.dgvLichSu.Location = new System.Drawing.Point(12, 155);
            this.dgvLichSu.Size = new System.Drawing.Size(760, 250);
            this.dgvLichSu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;

            // btnDong
            this.btnDong.Location = new System.Drawing.Point(680, 415);
            this.btnDong.Size = new System.Drawing.Size(90, 30);
            this.btnDong.Text = "Đóng";

            // FrmDichVu
            this.ClientSize = new System.Drawing.Size(784, 455);
            this.Controls.Add(this.grpThongTin);
            this.Controls.Add(this.dgvLichSu);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Sử Dụng Dịch Vụ";

            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSu)).EndInit();
            this.ResumeLayout(false);
        }
    }
}