using System;
using System.Windows.Forms;

namespace QLCuaHangNGK
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            // Mặc định nạp Form Bán hàng vào vùng đệm panelContent khi khởi động
            OpenChildForm(new FrmBanHang_GhiNo());
        }

        private void OpenChildForm(Form childForm)
        {
            if (panelContent.Controls.Count > 0)
                panelContent.Controls.RemoveAt(0);

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(childForm);
            panelContent.Tag = childForm;
            childForm.Show();
        }

        private void btnBanHang_GiaoHang_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FrmBanHang_GhiNo());
        }

        private void btnGhiNo_CongNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý Công nợ đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapHang_NCC_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý Nhập hàng NCC đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDanhMuc_NGK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng Quản lý Danh mục đang được phát triển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}