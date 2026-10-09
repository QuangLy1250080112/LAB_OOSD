namespace QLCtyDuLich
{
    partial class FrmKhaoSatTour
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
            this.tabGuiKhaoSat = new System.Windows.Forms.TabPage();
            this.lblStatusGui = new System.Windows.Forms.Label();
            this.btnGuiKhaoSat = new System.Windows.Forms.Button();
            this.txtNhanXet = new System.Windows.Forms.TextBox();
            this.lblNhanXet = new System.Windows.Forms.Label();
            this.numDiemDanhGia = new System.Windows.Forms.NumericUpDown();
            this.lblDiemDanhGia = new System.Windows.Forms.Label();
            this.cboTourDaDi = new System.Windows.Forms.ComboBox();
            this.lblTourDaDi = new System.Windows.Forms.Label();
            this.cboKhachHang = new System.Windows.Forms.ComboBox();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.tabTongHop = new System.Windows.Forms.TabPage();
            this.dgvDanhSachKhaoSat = new System.Windows.Forms.DataGridView();
            this.pnlTopTongHop = new System.Windows.Forms.Panel();
            this.lblDiemTrungBinh = new System.Windows.Forms.Label();
            this.cboFilterTour = new System.Windows.Forms.ComboBox();
            this.lblFilterTour = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabGuiKhaoSat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemDanhGia)).BeginInit();
            this.tabTongHop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhaoSat)).BeginInit();
            this.pnlTopTongHop.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabGuiKhaoSat);
            this.tabControlMain.Controls.Add(this.tabTongHop);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(570, 335);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabGuiKhaoSat
            // 
            this.tabGuiKhaoSat.BackColor = System.Drawing.Color.White;
            this.tabGuiKhaoSat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabGuiKhaoSat.Controls.Add(this.lblStatusGui);
            this.tabGuiKhaoSat.Controls.Add(this.btnGuiKhaoSat);
            this.tabGuiKhaoSat.Controls.Add(this.txtNhanXet);
            this.tabGuiKhaoSat.Controls.Add(this.lblNhanXet);
            this.tabGuiKhaoSat.Controls.Add(this.numDiemDanhGia);
            this.tabGuiKhaoSat.Controls.Add(this.lblDiemDanhGia);
            this.tabGuiKhaoSat.Controls.Add(this.cboTourDaDi);
            this.tabGuiKhaoSat.Controls.Add(this.lblTourDaDi);
            this.tabGuiKhaoSat.Controls.Add(this.cboKhachHang);
            this.tabGuiKhaoSat.Controls.Add(this.lblKhachHang);
            this.tabGuiKhaoSat.Location = new System.Drawing.Point(4, 24);
            this.tabGuiKhaoSat.Name = "tabGuiKhaoSat";
            this.tabGuiKhaoSat.Padding = new System.Windows.Forms.Padding(10);
            this.tabGuiKhaoSat.Size = new System.Drawing.Size(562, 307);
            this.tabGuiKhaoSat.TabIndex = 0;
            this.tabGuiKhaoSat.Text = "KHÁCH HÀNG GỬI ĐÁNH GIÁ";
            // 
            // lblStatusGui
            // 
            this.lblStatusGui.AutoSize = true;
            this.lblStatusGui.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblStatusGui.ForeColor = System.Drawing.Color.Red;
            this.lblStatusGui.Location = new System.Drawing.Point(15, 268);
            this.lblStatusGui.Name = "lblStatusGui";
            this.lblStatusGui.Size = new System.Drawing.Size(0, 15);
            this.lblStatusGui.TabIndex = 9;
            // 
            // btnGuiKhaoSat
            // 
            this.btnGuiKhaoSat.BackColor = System.Drawing.Color.Black;
            this.btnGuiKhaoSat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuiKhaoSat.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGuiKhaoSat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuiKhaoSat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnGuiKhaoSat.ForeColor = System.Drawing.Color.White;
            this.btnGuiKhaoSat.Location = new System.Drawing.Point(405, 258);
            this.btnGuiKhaoSat.Name = "btnGuiKhaoSat";
            this.btnGuiKhaoSat.Size = new System.Drawing.Size(140, 32);
            this.btnGuiKhaoSat.TabIndex = 8;
            this.btnGuiKhaoSat.Text = "Gửi Đánh Giá";
            this.btnGuiKhaoSat.UseVisualStyleBackColor = false;
            this.btnGuiKhaoSat.Click += new System.EventHandler(this.btnGuiKhaoSat_Click);
            // 
            // txtNhanXet
            // 
            this.txtNhanXet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNhanXet.Location = new System.Drawing.Point(140, 140);
            this.txtNhanXet.Multiline = true;
            this.txtNhanXet.Name = "txtNhanXet";
            this.txtNhanXet.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNhanXet.Size = new System.Drawing.Size(405, 100);
            this.txtNhanXet.TabIndex = 7;
            // 
            // lblNhanXet
            // 
            this.lblNhanXet.AutoSize = true;
            this.lblNhanXet.Location = new System.Drawing.Point(15, 143);
            this.lblNhanXet.Name = "lblNhanXet";
            this.lblNhanXet.Size = new System.Drawing.Size(113, 15);
            this.lblNhanXet.TabIndex = 6;
            this.lblNhanXet.Text = "Nhận Xét / Ý Kiến:";
            // 
            // numDiemDanhGia
            // 
            this.numDiemDanhGia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numDiemDanhGia.Location = new System.Drawing.Point(140, 98);
            this.numDiemDanhGia.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numDiemDanhGia.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDiemDanhGia.Name = "numDiemDanhGia";
            this.numDiemDanhGia.Size = new System.Drawing.Size(120, 23);
            this.numDiemDanhGia.TabIndex = 5;
            this.numDiemDanhGia.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblDiemDanhGia
            // 
            this.lblDiemDanhGia.AutoSize = true;
            this.lblDiemDanhGia.Location = new System.Drawing.Point(15, 101);
            this.lblDiemDanhGia.Name = "lblDiemDanhGia";
            this.lblDiemDanhGia.Size = new System.Drawing.Size(113, 15);
            this.lblDiemDanhGia.TabIndex = 4;
            this.lblDiemDanhGia.Text = "Điểm Đánh Giá (1-5):";
            // 
            // cboTourDaDi
            // 
            this.cboTourDaDi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTourDaDi.FormattingEnabled = true;
            this.cboTourDaDi.Location = new System.Drawing.Point(140, 56);
            this.cboTourDaDi.Name = "cboTourDaDi";
            this.cboTourDaDi.Size = new System.Drawing.Size(405, 23);
            this.cboTourDaDi.TabIndex = 3;
            this.cboTourDaDi.SelectedIndexChanged += new System.EventHandler(this.cboTourDaDi_SelectedIndexChanged);
            // 
            // lblTourDaDi
            // 
            this.lblTourDaDi.AutoSize = true;
            this.lblTourDaDi.Location = new System.Drawing.Point(15, 59);
            this.lblTourDaDi.Name = "lblTourDaDi";
            this.lblTourDaDi.Size = new System.Drawing.Size(102, 15);
            this.lblTourDaDi.TabIndex = 2;
            this.lblTourDaDi.Text = "Chọn Tour Đã Đi:";
            // 
            // cboKhachHang
            // 
            this.cboKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhachHang.FormattingEnabled = true;
            this.cboKhachHang.Location = new System.Drawing.Point(140, 15);
            this.cboKhachHang.Name = "cboKhachHang";
            this.cboKhachHang.Size = new System.Drawing.Size(405, 23);
            this.cboKhachHang.TabIndex = 1;
            this.cboKhachHang.SelectedIndexChanged += new System.EventHandler(this.cboKhachHang_SelectedIndexChanged);
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.Location = new System.Drawing.Point(15, 18);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(105, 15);
            this.lblKhachHang.TabIndex = 0;
            this.lblKhachHang.Text = "Khách Hàng Đánh Giá:";
            // 
            // tabTongHop
            // 
            this.tabTongHop.BackColor = System.Drawing.Color.White;
            this.tabTongHop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabTongHop.Controls.Add(this.dgvDanhSachKhaoSat);
            this.tabTongHop.Controls.Add(this.pnlTopTongHop);
            this.tabTongHop.Location = new System.Drawing.Point(4, 24);
            this.tabTongHop.Name = "tabTongHop";
            this.tabTongHop.Padding = new System.Windows.Forms.Padding(10);
            this.tabTongHop.Size = new System.Drawing.Size(562, 307);
            this.tabTongHop.TabIndex = 1;
            this.tabTongHop.Text = "TỔNG HỢP Ý KIẾN KHẢO SÁT";
            // 
            // dgvDanhSachKhaoSat
            // 
            this.dgvDanhSachKhaoSat.AllowUserToAddRows = false;
            this.dgvDanhSachKhaoSat.AllowUserToDeleteRows = false;
            this.dgvDanhSachKhaoSat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachKhaoSat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachKhaoSat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDanhSachKhaoSat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachKhaoSat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachKhaoSat.Location = new System.Drawing.Point(10, 50);
            this.dgvDanhSachKhaoSat.Name = "dgvDanhSachKhaoSat";
            this.dgvDanhSachKhaoSat.ReadOnly = true;
            this.dgvDanhSachKhaoSat.RowHeadersWidth = 25;
            this.dgvDanhSachKhaoSat.Size = new System.Drawing.Size(540, 245);
            this.dgvDanhSachKhaoSat.TabIndex = 1;
            // 
            // pnlTopTongHop
            // 
            this.pnlTopTongHop.Controls.Add(this.lblDiemTrungBinh);
            this.pnlTopTongHop.Controls.Add(this.cboFilterTour);
            this.pnlTopTongHop.Controls.Add(this.lblFilterTour);
            this.pnlTopTongHop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTopTongHop.Location = new System.Drawing.Point(10, 10);
            this.pnlTopTongHop.Name = "pnlTopTongHop";
            this.pnlTopTongHop.Size = new System.Drawing.Size(540, 40);
            this.pnlTopTongHop.TabIndex = 0;
            // 
            // lblDiemTrungBinh
            // 
            this.lblDiemTrungBinh.AutoSize = true;
            this.lblDiemTrungBinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDiemTrungBinh.Location = new System.Drawing.Point(360, 12);
            this.lblDiemTrungBinh.Name = "lblDiemTrungBinh";
            this.lblDiemTrungBinh.Size = new System.Drawing.Size(126, 15);
            this.lblDiemTrungBinh.TabIndex = 2;
            this.lblDiemTrungBinh.Text = "Điểm TB: 0.0 / 5.0 ⭐";
            // 
            // cboFilterTour
            // 
            this.cboFilterTour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilterTour.FormattingEnabled = true;
            this.cboFilterTour.Location = new System.Drawing.Point(110, 8);
            this.cboFilterTour.Name = "cboFilterTour";
            this.cboFilterTour.Size = new System.Drawing.Size(230, 23);
            this.cboFilterTour.TabIndex = 1;
            this.cboFilterTour.SelectedIndexChanged += new System.EventHandler(this.cboFilterTour_SelectedIndexChanged);
            // 
            // lblFilterTour
            // 
            this.lblFilterTour.AutoSize = true;
            this.lblFilterTour.Location = new System.Drawing.Point(5, 12);
            this.lblFilterTour.Name = "lblFilterTour";
            this.lblFilterTour.Size = new System.Drawing.Size(94, 15);
            this.lblFilterTour.TabIndex = 0;
            this.lblFilterTour.Text = "Lọc Theo Tour:";
            // 
            // FrmKhaoSatTour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 335);
            this.Controls.Add(this.tabControlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKhaoSatTour";
            this.Text = "FrmKhaoSatTour";
            this.Load += new System.EventHandler(this.FrmKhaoSatTour_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabGuiKhaoSat.ResumeLayout(false);
            this.tabGuiKhaoSat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDiemDanhGia)).EndInit();
            this.tabTongHop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachKhaoSat)).EndInit();
            this.pnlTopTongHop.ResumeLayout(false);
            this.pnlTopTongHop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabGuiKhaoSat;
        private System.Windows.Forms.TabPage tabTongHop;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.ComboBox cboKhachHang;
        private System.Windows.Forms.Label lblTourDaDi;
        private System.Windows.Forms.ComboBox cboTourDaDi;
        private System.Windows.Forms.Label lblDiemDanhGia;
        private System.Windows.Forms.NumericUpDown numDiemDanhGia;
        private System.Windows.Forms.Label lblNhanXet;
        private System.Windows.Forms.TextBox txtNhanXet;
        private System.Windows.Forms.Button btnGuiKhaoSat;
        private System.Windows.Forms.Label lblStatusGui;
        private System.Windows.Forms.Panel pnlTopTongHop;
        private System.Windows.Forms.Label lblFilterTour;
        private System.Windows.Forms.ComboBox cboFilterTour;
        private System.Windows.Forms.Label lblDiemTrungBinh;
        private System.Windows.Forms.DataGridView dgvDanhSachKhaoSat;
    }
}