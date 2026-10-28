namespace QLCuaHangNGK
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
            this.btnDanhMuc_NGK = new System.Windows.Forms.Button();
            this.btnNhapHang_NCC = new System.Windows.Forms.Button();
            this.btnGhiNo_CongNo = new System.Windows.Forms.Button();
            this.btnBanHang_GiaoHang = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblUserStatus = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelTopNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopNav
            // 
            this.panelTopNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelTopNav.Controls.Add(this.btnDanhMuc_NGK);
            this.panelTopNav.Controls.Add(this.btnNhapHang_NCC);
            this.panelTopNav.Controls.Add(this.btnGhiNo_CongNo);
            this.panelTopNav.Controls.Add(this.btnBanHang_GiaoHang);
            this.panelTopNav.Controls.Add(this.lblTitle);
            this.panelTopNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopNav.Location = new System.Drawing.Point(0, 0);
            this.panelTopNav.Name = "panelTopNav";
            this.panelTopNav.Size = new System.Drawing.Size(760, 40);
            this.panelTopNav.TabIndex = 0;
            // 
            // btnDanhMuc_NGK
            // 
            this.btnDanhMuc_NGK.BackColor = System.Drawing.Color.White;
            this.btnDanhMuc_NGK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDanhMuc_NGK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhMuc_NGK.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhMuc_NGK.ForeColor = System.Drawing.Color.Black;
            this.btnDanhMuc_NGK.Location = new System.Drawing.Point(630, 6);
            this.btnDanhMuc_NGK.Name = "btnDanhMuc_NGK";
            this.btnDanhMuc_NGK.Size = new System.Drawing.Size(120, 28);
            this.btnDanhMuc_NGK.TabIndex = 4;
            this.btnDanhMuc_NGK.Text = "Danh Mục NGK";
            this.btnDanhMuc_NGK.UseVisualStyleBackColor = false;
            this.btnDanhMuc_NGK.Click += new System.EventHandler(this.btnDanhMuc_NGK_Click);
            // 
            // btnNhapHang_NCC
            // 
            this.btnNhapHang_NCC.BackColor = System.Drawing.Color.White;
            this.btnNhapHang_NCC.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNhapHang_NCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang_NCC.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhapHang_NCC.ForeColor = System.Drawing.Color.Black;
            this.btnNhapHang_NCC.Location = new System.Drawing.Point(505, 6);
            this.btnNhapHang_NCC.Name = "btnNhapHang_NCC";
            this.btnNhapHang_NCC.Size = new System.Drawing.Size(120, 28);
            this.btnNhapHang_NCC.TabIndex = 3;
            this.btnNhapHang_NCC.Text = "Nhập Hàng NCC";
            this.btnNhapHang_NCC.UseVisualStyleBackColor = false;
            this.btnNhapHang_NCC.Click += new System.EventHandler(this.btnNhapHang_NCC_Click);
            // 
            // btnGhiNo_CongNo
            // 
            this.btnGhiNo_CongNo.BackColor = System.Drawing.Color.White;
            this.btnGhiNo_CongNo.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGhiNo_CongNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGhiNo_CongNo.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGhiNo_CongNo.ForeColor = System.Drawing.Color.Black;
            this.btnGhiNo_CongNo.Location = new System.Drawing.Point(380, 6);
            this.btnGhiNo_CongNo.Name = "btnGhiNo_CongNo";
            this.btnGhiNo_CongNo.Size = new System.Drawing.Size(120, 28);
            this.btnGhiNo_CongNo.TabIndex = 2;
            this.btnGhiNo_CongNo.Text = "Quản Lý Công Nợ";
            this.btnGhiNo_CongNo.UseVisualStyleBackColor = false;
            this.btnGhiNo_CongNo.Click += new System.EventHandler(this.btnGhiNo_CongNo_Click);
            // 
            // btnBanHang_GiaoHang
            // 
            this.btnBanHang_GiaoHang.BackColor = System.Drawing.Color.White;
            this.btnBanHang_GiaoHang.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnBanHang_GiaoHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanHang_GiaoHang.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang_GiaoHang.ForeColor = System.Drawing.Color.Black;
            this.btnBanHang_GiaoHang.Location = new System.Drawing.Point(245, 6);
            this.btnBanHang_GiaoHang.Name = "btnBanHang_GiaoHang";
            this.btnBanHang_GiaoHang.Size = new System.Drawing.Size(130, 28);
            this.btnBanHang_GiaoHang.TabIndex = 1;
            this.btnBanHang_GiaoHang.Text = "Bán Hàng & Giao Hàng";
            this.btnBanHang_GiaoHang.UseVisualStyleBackColor = false;
            this.btnBanHang_GiaoHang.Click += new System.EventHandler(this.btnBanHang_GiaoHang_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(8, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(188, 17);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HỆ THỐNG QUẢN LÝ NGK";
            // 
            // lblUserStatus
            // 
            this.lblUserStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.lblUserStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblUserStatus.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserStatus.ForeColor = System.Drawing.Color.Black;
            this.lblUserStatus.Location = new System.Drawing.Point(0, 320);
            this.lblUserStatus.Name = "lblUserStatus";
            this.lblUserStatus.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.lblUserStatus.Size = new System.Drawing.Size(760, 20);
            this.lblUserStatus.TabIndex = 1;
            this.lblUserStatus.Text = "Nhân viên: NV02 - Trần Thị Mai | Ca: Sáng";
            this.lblUserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 40);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(760, 280);
            this.panelContent.TabIndex = 2;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 340);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.lblUserStatus);
            this.Controls.Add(this.panelTopNav);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Cửa Hàng Nước Giải Khát (Excel Style)";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panelTopNav.ResumeLayout(false);
            this.panelTopNav.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelTopNav;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBanHang_GiaoHang;
        private System.Windows.Forms.Button btnGhiNo_CongNo;
        private System.Windows.Forms.Button btnNhapHang_NCC;
        private System.Windows.Forms.Button btnDanhMuc_NGK;
        private System.Windows.Forms.Label lblUserStatus;
        private System.Windows.Forms.Panel panelContent;
    }
}