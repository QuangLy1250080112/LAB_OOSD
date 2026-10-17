namespace QuanLyHoSoBenhAn
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.panelTopNav = new System.Windows.Forms.Panel();
            this.btnThanhToanVienPhi = new System.Windows.Forms.Button();
            this.btnQuanLyDanhMuc = new System.Windows.Forms.Button();
            this.btnKhamBenh = new System.Windows.Forms.Button();
            this.btnTiepNhan = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblUserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.panelTopNav.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();

            // 
            // panelTopNav
            // 
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panelTopNav.Controls.Add(this.btnThanhToanVienPhi);
            this.panelTopNav.Controls.Add(this.btnQuanLyDanhMuc);
            this.panelTopNav.Controls.Add(this.btnKhamBenh);
            this.panelTopNav.Controls.Add(this.btnTiepNhan);
            this.panelTopNav.Controls.Add(this.lblTitle);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(760, 40);
            this.panelTopNav.TabIndex = 0;

            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTitle.Size = new System.Drawing.Size(160, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QUẢN LÝ HỒ SƠ BỆNH ÁN";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // btnTiepNhan
            // 
            this.btnTiepNhan.BackColor = System.Drawing.Color.White;
            this.btnTiepNhan.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTiepNhan.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnTiepNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepNhan.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTiepNhan.ForeColor = System.Drawing.Color.Black;
            this.btnTiepNhan.Location = new System.Drawing.Point(160, 0);
            this.btnTiepNhan.Name = "btnTiepNhan";
            this.btnTiepNhan.Size = new System.Drawing.Size(145, 40);
            this.btnTiepNhan.TabIndex = 1;
            this.btnTiepNhan.Text = "1. Tiếp Nhận & Lịch Hẹn";
            this.btnTiepNhan.UseVisualStyleBackColor = false;
            this.btnTiepNhan.Click += new System.EventHandler(this.btnTiepNhan_Click);

            // 
            // btnKhamBenh
            // 
            this.btnKhamBenh.BackColor = System.Drawing.Color.White;
            this.btnKhamBenh.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnKhamBenh.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnKhamBenh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhamBenh.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKhamBenh.ForeColor = System.Drawing.Color.Black;
            this.btnKhamBenh.Location = new System.Drawing.Point(305, 0);
            this.btnKhamBenh.Name = "btnKhamBenh";
            this.btnKhamBenh.Size = new System.Drawing.Size(145, 40);
            this.btnKhamBenh.TabIndex = 2;
            this.btnKhamBenh.Text = "2. Khám Bệnh";
            this.btnKhamBenh.UseVisualStyleBackColor = false;
            this.btnKhamBenh.Click += new System.EventHandler(this.btnKhamBenh_Click);

            // 
            // btnQuanLyDanhMuc
            // 
            this.btnQuanLyDanhMuc.BackColor = System.Drawing.Color.White;
            this.btnQuanLyDanhMuc.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnQuanLyDanhMuc.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnQuanLyDanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuanLyDanhMuc.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuanLyDanhMuc.ForeColor = System.Drawing.Color.Black;
            this.btnQuanLyDanhMuc.Location = new System.Drawing.Point(450, 0);
            this.btnQuanLyDanhMuc.Name = "btnQuanLyDanhMuc";
            this.btnQuanLyDanhMuc.Size = new System.Drawing.Size(145, 40);
            this.btnQuanLyDanhMuc.TabIndex = 3;
            this.btnQuanLyDanhMuc.Text = "3. Danh Mục";
            this.btnQuanLyDanhMuc.UseVisualStyleBackColor = false;
            this.btnQuanLyDanhMuc.Click += new System.EventHandler(this.btnQuanLyDanhMuc_Click);

            // 
            // btnThanhToanVienPhi
            // 
            this.btnThanhToanVienPhi.BackColor = System.Drawing.Color.White;
            this.btnThanhToanVienPhi.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnThanhToanVienPhi.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.btnThanhToanVienPhi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToanVienPhi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToanVienPhi.ForeColor = System.Drawing.Color.Black;
            this.btnThanhToanVienPhi.Location = new System.Drawing.Point(595, 0);
            this.btnThanhToanVienPhi.Name = "btnThanhToanVienPhi";
            this.btnThanhToanVienPhi.Size = new System.Drawing.Size(145, 40);
            this.btnThanhToanVienPhi.TabIndex = 4;
            this.btnThanhToanVienPhi.Text = "4. Viện Phí";
            this.btnThanhToanVienPhi.UseVisualStyleBackColor = false;
            this.btnThanhToanVienPhi.Click += new System.EventHandler(this.btnThanhToanVienPhi_Click);

            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(760, 256);
            this.panelContent.TabIndex = 1;

            // 
            // statusStripMain
            // 
            this.statusStripMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.statusStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUserStatus,
            this.lblClock});
            this.statusStripMain.Location = new System.Drawing.Point(0, 296);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(760, 24);
            this.statusStripMain.TabIndex = 2;

            // 
            // lblUserStatus
            // 
            this.lblUserStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(185, 19);
            this.lblUserStatus.Text = "Người dùng: BS. Phạm Minh Tuấn";

            // 
            // lblClock
            // 
            this.lblClock.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblClock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(560, 19);
            this.lblClock.Spring = true;
            this.lblClock.Text = "00/00/0000 00:00:00";
            this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);

            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 320);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTopNav);
            this.Controls.Add(this.statusStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHoSoBenhAn - Enterprise Edition";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTopNav.ResumeLayout(false);
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnTiepNhan;
        private System.Windows.Forms.Button btnKhamBenh;
        private System.Windows.Forms.Button btnQuanLyDanhMuc;
        private System.Windows.Forms.Button btnThanhToanVienPhi;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUserStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblClock;
        private System.Windows.Forms.Timer timerClock;
    }
}