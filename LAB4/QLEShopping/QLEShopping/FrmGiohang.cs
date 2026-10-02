using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLEShopping
{
    public partial class FrmGiohang : Form
    {
        private const int MaKH = 1;
        private int maGioHang;

        public FrmGiohang() => InitializeComponent();

        private void FrmGiohang_Load(object sender, EventArgs e)
        {
            LayMaGioHang();
            LoadDataGioHang();
        }

        private void LayMaGioHang()
        {
            var query = "IF NOT EXISTS (SELECT 1 FROM GIO_HANG WHERE MaKH = @MaKH) " +
                        "INSERT INTO GIO_HANG (MaKH) VALUES (@MaKH); " +
                        "SELECT MaGioHang FROM GIO_HANG WHERE MaKH = @MaKH;";

            var dt = Database.ExecuteQuery(query, new[] { new SqlParameter("@MaKH", MaKH) });
            maGioHang = Convert.ToInt32(dt.Rows[0]["MaGioHang"]);
        }

        private void LoadDataGioHang()
        {
            var query = @"
                SELECT c.MaSP, sp.TenSP AS [Tên sản phẩm], sp.GiaBan AS [Đơn giá], 
                       c.SoLuong AS [Số lượng], (sp.GiaBan * c.SoLuong) AS [Thành tiền]
                FROM CHI_TIET_GIO_HANG c
                JOIN SAN_PHAM sp ON c.MaSP = sp.MaSP
                WHERE c.MaGioHang = @MaGioHang";

            var dt = Database.ExecuteQuery(query, new[] { new SqlParameter("@MaGioHang", maGioHang) });
            dgvGioHang.DataSource = dt;

            // Căn chỉnh giao diện cột chuyên nghiệp
            if (dgvGioHang.Columns["MaSP"] != null) dgvGioHang.Columns["MaSP"].Visible = false;

            if (dgvGioHang.Columns["Đơn giá"] != null)
            {
                dgvGioHang.Columns["Đơn giá"].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvGioHang.Columns["Đơn giá"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGioHang.Columns["Đơn giá"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            if (dgvGioHang.Columns["Số lượng"] != null)
            {
                dgvGioHang.Columns["Số lượng"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvGioHang.Columns["Số lượng"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (dgvGioHang.Columns["Thành tiền"] != null)
            {
                dgvGioHang.Columns["Thành tiền"].DefaultCellStyle.Format = "#,##0 VNĐ";
                dgvGioHang.Columns["Thành tiền"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgvGioHang.Columns["Thành tiền"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            TinhTongTien(dt);
        }

        private void TinhTongTien(DataTable dt)
        {
            var tongTien = dt.Compute("SUM([Thành tiền])", string.Empty);
            lblTongTien.Text = (tongTien != DBNull.Value ? Convert.ToDecimal(tongTien) : 0).ToString("#,##0 VNĐ");
        }

        private void CapNhatSoLuong(int maSP, int delta)
        {
            var query = @"
                UPDATE CHI_TIET_GIO_HANG 
                SET SoLuong = SoLuong + @Delta 
                WHERE MaGioHang = @MaGioHang AND MaSP = @MaSP;
                
                DELETE FROM CHI_TIET_GIO_HANG 
                WHERE MaGioHang = @MaGioHang AND MaSP = @MaSP AND SoLuong <= 0;";

            SqlParameter[] p = {
                new("@MaGioHang", maGioHang),
                new("@MaSP", maSP),
                new("@Delta", delta)
            };

            Database.ExecuteNonQuery(query, p);
            LoadDataGioHang();
        }

        private void btnTang_Click(object sender, EventArgs e) => ThucHienKhiCoDongChon(maSP => CapNhatSoLuong(maSP, 1));

        private void btnGiam_Click(object sender, EventArgs e) => ThucHienKhiCoDongChon(maSP => CapNhatSoLuong(maSP, -1));

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ThucHienKhiCoDongChon(maSP => {
                if (MessageBox.Show("Xóa sản phẩm này khỏi giỏ hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    CapNhatSoLuong(maSP, -999999);
                }
            });
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (dgvGioHang.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng của bạn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var query = "DELETE FROM CHI_TIET_GIO_HANG WHERE MaGioHang = @MaGioHang";
            Database.ExecuteNonQuery(query, new[] { new SqlParameter("@MaGioHang", maGioHang) });

            MessageBox.Show("Đặt hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadDataGioHang();
        }

        private void ThucHienKhiCoDongChon(Action<int> action)
        {
            if (dgvGioHang.CurrentRow?.Cells["MaSP"].Value is int maSP)
            {
                action(maSP);
            }
        }
    }
}