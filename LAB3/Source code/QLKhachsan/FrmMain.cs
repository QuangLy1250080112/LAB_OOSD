using System;
using System.Windows.Forms;

namespace QLKhachsan.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            // Đăng ký sự kiện Click cho các nút
            btnDanhMuc.Click += btnDanhMuc_Click;
            btnPhong.Click += btnPhong_Click;
            btnDatPhong.Click += btnDatPhong_Click;
            btnDichVu.Click += btnDichVu_Click;
            btnTraPhong.Click += btnTraPhong_Click;
            btnThongKe.Click += btnThongKe_Click;
            btnThoat.Click += btnThoat_Click;
        }

        #region Điều hướng các Form
        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            using (FrmDanhMuc frm = new FrmDanhMuc())
            {
                frm.ShowDialog();
            }
        }

        private void btnPhong_Click(object sender, EventArgs e)
        {
            using (FrmPhongTienNghi frm = new FrmPhongTienNghi())
            {
                frm.ShowDialog();
            }
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            using (FrmDatPhong frm = new FrmDatPhong())
            {
                frm.ShowDialog();
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            using (FrmDichVu frm = new FrmDichVu())
            {
                frm.ShowDialog();
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            using (FrmTraPhong frm = new FrmTraPhong())
            {
                frm.ShowDialog();
            }
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            using (FrmThongKe frm = new FrmThongKe())
            {
                frm.ShowDialog();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát hệ thống?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }
}