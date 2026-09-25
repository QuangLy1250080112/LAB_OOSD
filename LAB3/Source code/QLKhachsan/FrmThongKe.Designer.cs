namespace QLKhachsan.Forms
{
    partial class FrmThongKe
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DateTimePicker dtTu, dtDen;
        private System.Windows.Forms.Button btnTK, btnDong;
        private System.Windows.Forms.DataGridView dgvTongHop, dgvDV;
        private System.Windows.Forms.Label lblTu, lblDen, lblTongHop, lblDV;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTu = new System.Windows.Forms.Label();
            this.lblDen = new System.Windows.Forms.Label();
            this.dtTu = new System.Windows.Forms.DateTimePicker();
            this.dtDen = new System.Windows.Forms.DateTimePicker();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblTongHop = new System.Windows.Forms.Label();
            this.dgvTongHop = new System.Windows.Forms.DataGridView();
            this.lblDV = new System.Windows.Forms.Label();
            this.dgvDV = new System.Windows.Forms.DataGridView();

            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).BeginInit();
            this.SuspendLayout();

            // Label Từ ngày
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(20, 20);
            this.lblTu.Text = "Từ ngày:";

            // DateTimePicker Từ ngày
            this.dtTu.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTu.Location = new System.Drawing.Point(80, 16);
            this.dtTu.Size = new System.Drawing.Size(120, 23);

            // Label Đến ngày
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(220, 20);
            this.lblDen.Text = "Đến ngày:";

            // DateTimePicker Đến ngày
            this.dtDen.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDen.Location = new System.Drawing.Point(290, 16);
            this.dtDen.Size = new System.Drawing.Size(120, 23);

            // Button Thống Kê
            this.btnTK.Location = new System.Drawing.Point(430, 14);
            this.btnTK.Size = new System.Drawing.Size(100, 28);
            this.btnTK.Text = "Thống Kê";

            // Label Tổng Hợp
            this.lblTongHop.AutoSize = true;
            this.lblTongHop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTongHop.Location = new System.Drawing.Point(20, 60);
            this.lblTongHop.Text = "I. Tổng Quan Doanh Thu & Hoạt Động";

            // DataGridView Tổng Hợp
            this.dgvTongHop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTongHop.Location = new System.Drawing.Point(20, 85);
            this.dgvTongHop.Size = new System.Drawing.Size(740, 90);
            this.dgvTongHop.ReadOnly = true;

            // Label Dịch Vụ
            this.lblDV.AutoSize = true;
            this.lblDV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDV.Location = new System.Drawing.Point(20, 195);
            this.lblDV.Text = "II. Thống Kê Sử Dụng Dịch Vụ";

            // DataGridView Dịch Vụ
            this.dgvDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDV.Location = new System.Drawing.Point(20, 220);
            this.dgvDV.Size = new System.Drawing.Size(740, 180);
            this.dgvDV.ReadOnly = true;

            // Button Đóng
            this.btnDong.Location = new System.Drawing.Point(660, 415);
            this.btnDong.Size = new System.Drawing.Size(100, 30);
            this.btnDong.Text = "Đóng";

            // FrmThongKe
            this.ClientSize = new System.Drawing.Size(780, 460);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblTu, this.dtTu, this.lblDen, this.dtDen, this.btnTK,
                this.lblTongHop, this.dgvTongHop, this.lblDV, this.dgvDV, this.btnDong
            });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Báo Cáo Thống Kê Doanh Thu & Dịch Vụ";

            ((System.ComponentModel.ISupportInitialize)(this.dgvTongHop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}