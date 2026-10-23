namespace QuanLyNhanSu_DongA
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
            this.panelTopNav = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnNhanSu_HopDong = new System.Windows.Forms.Button();
            this.btnChamCong_PhuTroi = new System.Windows.Forms.Button();
            this.btnQuyetDinh = new System.Windows.Forms.Button();
            this.btnBangLuong = new System.Windows.Forms.Button();
            this.panelStatus = new System.Windows.Forms.Panel();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTopNav.SuspendLayout();
            this.panelStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopNav
            // 
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTopNav.Controls.Add(this.lblTitle);
            this.panelTopNav.Controls.Add(this.btnNhanSu_HopDong);
            this.panelTopNav.Controls.Add(this.btnChamCong_PhuTroi);
            this.panelTopNav.Controls.Add(this.btnQuyetDinh);
            this.panelTopNav.Controls.Add(this.btnBangLuong);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(740, 40);
            this.panelTopNav.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(10, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "QLNS - ĐÔNG Á";
            // 
            // btnNhanSu_HopDong
            // 
            this.btnNhanSu_HopDong.BackColor = System.Drawing.Color.White;
            this.btnNhanSu_HopDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanSu_HopDong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhanSu_HopDong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanSu_HopDong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNhanSu_HopDong.ForeColor = System.Drawing.Color.Black;
            this.btnNhanSu_HopDong.Location = new System.Drawing.Point(145, 6);
            this.btnNhanSu_HopDong.Name = "btnNhanSu_HopDong";
            this.btnNhanSu_HopDong.Size = new System.Drawing.Size(140, 28);
            this.btnNhanSu_HopDong.TabIndex = 1;
            this.btnNhanSu_HopDong.Text = "Hồ Sơ & Hợp Đồng";
            this.btnNhanSu_HopDong.UseVisualStyleBackColor = false;
            this.btnNhanSu_HopDong.Click += new System.EventHandler(this.btnNhanSu_HopDong_Click);
            // 
            // btnChamCong_PhuTroi
            // 
            this.btnChamCong_PhuTroi.BackColor = System.Drawing.Color.White;
            this.btnChamCong_PhuTroi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChamCong_PhuTroi.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnChamCong_PhuTroi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChamCong_PhuTroi.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChamCong_PhuTroi.ForeColor = System.Drawing.Color.Black;
            this.btnChamCong_PhuTroi.Location = new System.Drawing.Point(290, 6);
            this.btnChamCong_PhuTroi.Name = "btnChamCong_PhuTroi";
            this.btnChamCong_PhuTroi.Size = new System.Drawing.Size(140, 28);
            this.btnChamCong_PhuTroi.TabIndex = 2;
            this.btnChamCong_PhuTroi.Text = "Chấm Công";
            this.btnChamCong_PhuTroi.UseVisualStyleBackColor = false;
            this.btnChamCong_PhuTroi.Click += new System.EventHandler(this.btnChamCong_PhuTroi_Click);
            // 
            // btnQuyetDinh
            // 
            this.btnQuyetDinh.BackColor = System.Drawing.Color.White;
            this.btnQuyetDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuyetDinh.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnQuyetDinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuyetDinh.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnQuyetDinh.ForeColor = System.Drawing.Color.Black;
            this.btnQuyetDinh.Location = new System.Drawing.Point(435, 6);
            this.btnQuyetDinh.Name = "btnQuyetDinh";
            this.btnQuyetDinh.Size = new System.Drawing.Size(140, 28);
            this.btnQuyetDinh.TabIndex = 3;
            this.btnQuyetDinh.Text = "Quyết Định";
            this.btnQuyetDinh.UseVisualStyleBackColor = false;
            this.btnQuyetDinh.Click += new System.EventHandler(this.btnQuyetDinh_Click);
            // 
            // btnBangLuong
            // 
            this.btnBangLuong.BackColor = System.Drawing.Color.White;
            this.btnBangLuong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBangLuong.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBangLuong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBangLuong.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBangLuong.ForeColor = System.Drawing.Color.Black;
            this.btnBangLuong.Location = new System.Drawing.Point(580, 6);
            this.btnBangLuong.Name = "btnBangLuong";
            this.btnBangLuong.Size = new System.Drawing.Size(140, 28);
            this.btnBangLuong.TabIndex = 4;
            this.btnBangLuong.Text = "Tính Bảng Lương";
            this.btnBangLuong.UseVisualStyleBackColor = false;
            this.btnBangLuong.Click += new System.EventHandler(this.btnBangLuong_Click);
            // 
            // panelStatus
            // 
            this.panelStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelStatus.Controls.Add(this.lblUserStatus);
            this.panelStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelStatus.Location = new System.Drawing.Point(0, 295);
            this.panelStatus.Name = "panelStatus";
            this.panelStatus.Size = new System.Drawing.Size(740, 25);
            this.panelStatus.TabIndex = 1;
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.AutoSize = true;
            this.lblUserStatus.Font = new System.Drawing.Font("Consolas", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserStatus.ForeColor = System.Drawing.Color.Black;
            this.lblUserStatus.Location = new System.Drawing.Point(8, 4);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Size = new System.Drawing.Size(430, 18);
            this.lblUserStatus.TabIndex = 0;
            this.lblUserStatus.Text = "USER: Bùi Ngô Quang Lý | ROLE: Ban Giám Đốc / Cán Bộ HR";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(740, 255);
            this.panelContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 320);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelStatus);
            this.Controls.Add(this.panelTopNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Nhân Sự - Công Ty Sơn Đông Á";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            this.panelStatus.ResumeLayout(false);
            this.panelStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnNhanSu_HopDong;
        private System.Windows.Forms.Button btnChamCong_PhuTroi;
        private System.Windows.Forms.Button btnQuyetDinh;
        private System.Windows.Forms.Button btnBangLuong;
        private System.Windows.Forms.Panel panelStatus;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Panel panelContent;
    }
}