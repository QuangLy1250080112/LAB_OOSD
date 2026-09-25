using System;
using System.Windows.Forms;
using QLKhachsan.Services;

namespace QLKhachsan.Forms
{
    public partial class FrmThongKe : Form
    {
        readonly ThongKeService s = new ThongKeService();

        public FrmThongKe()
        {
            InitializeComponent();
            this.Load += FrmThongKe_Load;
            this.btnTK.Click += btnTK_Click;
            this.btnDong.Click += btnDong_Click;
        }

        private void FrmThongKe_Load(object? sender, EventArgs e)
        {
            // Mặc định chọn đầu tháng hiện tại đến ngày hôm nay
            DateTime now = DateTime.Now;
            dtTu.Value = new DateTime(now.Year, now.Month, 1);
            dtDen.Value = now;

            // Tải dữ liệu ban đầu
            TaiThongKe();
        }

        private void TaiThongKe()
        {
            if (dtDen.Value.Date < dtTu.Value.Date)
            {
                MessageBox.Show("Đến ngày không được trước Từ ngày.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dgvTongHop.DataSource = s.TongHop(dtTu.Value, dtDen.Value);
            dgvDV.DataSource = s.DichVu(dtTu.Value, dtDen.Value);

            DinhDangLuoi();
        }

        private void DinhDangLuoi()
        {
            if (dgvTongHop.Columns.Contains("SoPhieuDat")) dgvTongHop.Columns["SoPhieuDat"].HeaderText = "Số Phiếu Đặt";
            if (dgvTongHop.Columns.Contains("DangO")) dgvTongHop.Columns["DangO"].HeaderText = "Số Phòng Đang Ở";
            if (dgvTongHop.Columns.Contains("SoHoaDon")) dgvTongHop.Columns["SoHoaDon"].HeaderText = "Số Hóa Đơn";
            if (dgvTongHop.Columns.Contains("DoanhThuHoaDon"))
            {
                dgvTongHop.Columns["DoanhThuHoaDon"].HeaderText = "Tổng Doanh Thu (VNĐ)";
                dgvTongHop.Columns["DoanhThuHoaDon"].DefaultCellStyle.Format = "N0";
            }
            if (dgvTongHop.Columns.Contains("TongDenBu"))
            {
                dgvTongHop.Columns["TongDenBu"].HeaderText = "Tổng Đền Bù (VNĐ)";
                dgvTongHop.Columns["TongDenBu"].DefaultCellStyle.Format = "N0";
            }

            if (dgvDV.Columns.Contains("MaDV")) dgvDV.Columns["MaDV"].HeaderText = "Mã DV";
            if (dgvDV.Columns.Contains("TenDV")) dgvDV.Columns["TenDV"].HeaderText = "Tên Dịch Vụ";
            if (dgvDV.Columns.Contains("TongSoLuong")) dgvDV.Columns["TongSoLuong"].HeaderText = "Tổng Số Lượng";
            if (dgvDV.Columns.Contains("TongTien"))
            {
                dgvDV.Columns["TongTien"].HeaderText = "Tổng Thành Tiền (VNĐ)";
                dgvDV.Columns["TongTien"].DefaultCellStyle.Format = "N0";
            }
        }

        private void btnTK_Click(object? sender, EventArgs e)
        {
            TaiThongKe();
        }

        private void btnDong_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
    }
}