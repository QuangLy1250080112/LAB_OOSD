namespace QLCtyDuLich
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnKhaoSat = new System.Windows.Forms.Button();
            this.btnDieuHanhQuyetToan = new System.Windows.Forms.Button();
            this.btnDangKyTour = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pnlSidebar.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.White;
            this.pnlSidebar.Controls.Add(this.btnKhaoSat);
            this.pnlSidebar.Controls.Add(this.btnDieuHanhQuyetToan);
            this.pnlSidebar.Controls.Add(this.btnDangKyTour);
            this.pnlSidebar.Controls.Add(this.pnlLogo);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(190, 380);
            this.pnlSidebar.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.Black;
            this.pnlLogo.Controls.Add(this.lblBrandName);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(190, 45);
            this.pnlLogo.TabIndex = 0;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblBrandName.ForeColor = System.Drawing.Color.White;
            this.lblBrandName.Location = new System.Drawing.Point(12, 14);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(145, 17);
            this.lblBrandName.TabIndex = 0;
            this.lblBrandName.Text = "VĂN HÓA VIỆT TRAVEL";
            // 
            // btnDangKyTour
            // 
            this.btnDangKyTour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangKyTour.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDangKyTour.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDangKyTour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKyTour.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDangKyTour.ForeColor = System.Drawing.Color.Black;
            this.btnDangKyTour.Location = new System.Drawing.Point(0, 45);
            this.btnDangKyTour.Name = "btnDangKyTour";
            this.btnDangKyTour.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDangKyTour.Size = new System.Drawing.Size(190, 40);
            this.btnDangKyTour.TabIndex = 1;
            this.btnDangKyTour.Text = "1. Đăng ký Tour";
            this.btnDangKyTour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDangKyTour.UseVisualStyleBackColor = true;
            this.btnDangKyTour.Click += new System.EventHandler(this.btnDangKyTour_Click);
            // 
            // btnDieuHanhQuyetToan
            // 
            this.btnDieuHanhQuyetToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDieuHanhQuyetToan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDieuHanhQuyetToan.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDieuHanhQuyetToan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDieuHanhQuyetToan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDieuHanhQuyetToan.ForeColor = System.Drawing.Color.Black;
            this.btnDieuHanhQuyetToan.Location = new System.Drawing.Point(0, 85);
            this.btnDieuHanhQuyetToan.Name = "btnDieuHanhQuyetToan";
            this.btnDieuHanhQuyetToan.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDieuHanhQuyetToan.Size = new System.Drawing.Size(190, 40);
            this.btnDieuHanhQuyetToan.TabIndex = 2;
            this.btnDieuHanhQuyetToan.Text = "2. Điều hành & Quyết toán";
            this.btnDieuHanhQuyetToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDieuHanhQuyetToan.UseVisualStyleBackColor = true;
            this.btnDieuHanhQuyetToan.Click += new System.EventHandler(this.btnDieuHanhQuyetToan_Click);
            // 
            // btnKhaoSat
            // 
            this.btnKhaoSat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhaoSat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhaoSat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnKhaoSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKhaoSat.ForeColor = System.Drawing.Color.Black;
            this.btnKhaoSat.Location = new System.Drawing.Point(0, 125);
            this.btnKhaoSat.Name = "btnKhaoSat";
            this.btnKhaoSat.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnKhaoSat.Size = new System.Drawing.Size(190, 40);
            this.btnKhaoSat.TabIndex = 3;
            this.btnKhaoSat.Text = "3. Khảo sát chất lượng";
            this.btnKhaoSat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhaoSat.UseVisualStyleBackColor = true;
            this.btnKhaoSat.Click += new System.EventHandler(this.btnKhaoSat_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(190, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(570, 45);
            this.pnlHeader.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(15, 12);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(95, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TRANG CHỦ";
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDesktop.Controls.Add(this.lblWelcome);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(190, 45);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(570, 335);
            this.pnlDesktop.TabIndex = 2;
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Italic);
            this.lblWelcome.ForeColor = System.Drawing.Color.Gray;
            this.lblWelcome.Location = new System.Drawing.Point(140, 150);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(280, 17);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Chọn chức năng từ danh mục bên trái để làm việc";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(760, 380);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSidebar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ thống Quản lý Tour Du lịch";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.Button btnDangKyTour;
        private System.Windows.Forms.Button btnDieuHanhQuyetToan;
        private System.Windows.Forms.Button btnKhaoSat;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Label lblWelcome;
    }
}