using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace QuanLyHoSoBenhAn
{
    public partial class FrmTiepNhanDangKy : Form
    {
        private string duongDanAnh = "";

        public FrmTiepNhanDangKy()
        {
            InitializeComponent();
        }

        private void FrmTiepNhanDangKy_Load(object sender, EventArgs e)
        {
            cboTrangThai.SelectedIndex = 0; // Mặc định: "Đã xác nhận"
            LoadDanhSach();
        }

        // Tải danh sách hồ sơ bệnh nhân kèm lịch hẹn gần nhất lên DataGridView
        private void LoadDanhSach()
        {
            string query = @"
                SELECT 
                    hs.maHoSo AS [Mã HS],
                    pdk.hoTen AS [Họ và Tên],
                    pdk.soDienThoai AS [SĐT],
                    pdk.diaChi AS [Địa Chỉ],
                    pdk.ngaySinh AS [Ngày Sinh],
                    CASE WHEN hs.trangThaiHan = 1 THEN N'Còn hạn' ELSE N'Hết hạn' END AS [Lệ Phí Năm],
                    lh.maLichHen AS [Mã Lịch Hẹn],
                    lh.ngayGioHen AS [Ngày Giờ Hẹn],
                    lh.trangThai AS [Trạng Thái Hẹn]
                FROM HoSoBenhAn hs
                INNER JOIN PhieuDangKy pdk ON hs.maPhieuDK = pdk.maPhieuDK
                LEFT JOIN LichHenKham lh ON hs.maHoSo = lh.maHoSo
                ORDER BY pdk.ngayLap DESC, lh.ngayGioHen DESC";

            DataTable dt = Database.ExecuteQuery(query);
            dgvDanhSach.DataSource = dt;
        }

        // Chọn ảnh 3x4
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    duongDanAnh = ofd.FileName;
                    picAnh3x4.Image = Image.FromFile(duongDanAnh);
                }
            }
        }

        // 1. NGHIỆP VỤ: Đăng ký Bệnh nhân mới -> Tạo Phiếu Đăng Ký -> Cấp Hồ Sơ Bệnh Án
        private void btnTaoHoSo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text) || string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Họ tên và Số điện thoại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sinh mã tự động
            string timeStamp = DateTime.Now.ToString("yyyyMMddHHmmss");
            string maPhieuDK = "PDK" + timeStamp;
            string maHoSo = "HS" + timeStamp;

            // 1. Thêm vào bảng PhieuDangKy
            string sqlPDK = @"INSERT INTO PhieuDangKy (maPhieuDK, hoTen, diaChi, ngaySinh, soDienThoai, anh3x4, ngayLap) 
                              VALUES (@maPDK, @hoTen, @diaChi, @ngaySinh, @sdt, @anh, GETDATE())";

            SqlParameter[] paramPDK = new SqlParameter[]
            {
                new SqlParameter("@maPDK", maPhieuDK),
                new SqlParameter("@hoTen", txtHoTen.Text.Trim()),
                new SqlParameter("@diaChi", txtDiaChi.Text.Trim()),
                new SqlParameter("@ngaySinh", dtpNgaySinh.Value.Date),
                new SqlParameter("@sdt", txtSoDienThoai.Text.Trim()),
                new SqlParameter("@anh", (object)duongDanAnh ?? DBNull.Value)
            };

            int resPDK = Database.ExecuteNonQuery(sqlPDK, paramPDK);

            if (resPDK > 0)
            {
                // 2. Thêm vào bảng HoSoBenhAn
                string sqlHS = @"INSERT INTO HoSoBenhAn (maHoSo, ngayCap, trangThaiHan, maPhieuDK) 
                                VALUES (@maHoSo, GETDATE(), @trangThaiHan, @maPDK)";

                SqlParameter[] paramHS = new SqlParameter[]
                {
                    new SqlParameter("@maHoSo", maHoSo),
                    new SqlParameter("@trangThaiHan", chkDongLePhiNam.Checked ? 1 : 0),
                    new SqlParameter("@maPDK", maPhieuDK)
                };

                int resHS = Database.ExecuteNonQuery(sqlHS, paramHS);

                if (resHS > 0)
                {
                    MessageBox.Show($"Khởi tạo hồ sơ thành công!\nMã Hồ Sơ Bệnh Án: {maHoSo}", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtMaHoSo.Text = maHoSo;
                    ClearInputLeft();
                    LoadDanhSach();
                }
            }
        }

        // 2. NGHIỆP VỤ: Đặt Lịch Hẹn Khám
        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string maHoSo = txtMaHoSo.Text.Trim();
            if (string.IsNullOrWhiteSpace(maHoSo))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã Hồ Sơ để đặt lịch hẹn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra mã hồ sơ có tồn tại trong CSDL không
            object check = Database.ExecuteScalar("SELECT COUNT(1) FROM HoSoBenhAn WHERE maHoSo = @maHoSo", new SqlParameter[] { new SqlParameter("@maHoSo", maHoSo) });
            if (check == null || Convert.ToInt32(check) == 0)
            {
                MessageBox.Show("Mã Hồ Sơ không tồn tại trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string maLichHen = "LH" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string query = @"INSERT INTO LichHenKham (maLichHen, ngayGioHen, trangThai, maHoSo) 
                            VALUES (@maLH, @ngayGio, @trangThai, @maHoSo)";

            SqlParameter[] paramLH = new SqlParameter[]
            {
                new SqlParameter("@maLH", maLichHen),
                new SqlParameter("@ngayGio", dtpNgayGioHen.Value),
                new SqlParameter("@trangThai", cboTrangThai.SelectedItem.ToString()),
                new SqlParameter("@maHoSo", maHoSo)
            };

            int res = Database.ExecuteNonQuery(query, paramLH);
            if (res > 0)
            {
                MessageBox.Show("Lưu lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSach();
            }
        }

        // 3. NGHIỆP VỤ: Hủy Lịch Hẹn Khám
        private void btnHuyLich_Click(object sender, EventArgs e)
        {
            if (dgvDanhSach.CurrentRow == null) return;

            string maLichHen = dgvDanhSach.CurrentRow.Cells["Mã Lịch Hẹn"].Value?.ToString();
            if (string.IsNullOrEmpty(maLichHen))
            {
                MessageBox.Show("Dòng hiện tại không có Lịch hẹn để hủy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show($"Bạn có chắc chắn muốn HỦY lịch hẹn [{maLichHen}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string query = "UPDATE LichHenKham SET trangThai = N'Đã hủy' WHERE maLichHen = @maLH";
                int res = Database.ExecuteNonQuery(query, new SqlParameter[] { new SqlParameter("@maLH", maLichHen) });

                if (res > 0)
                {
                    MessageBox.Show("Đã hủy lịch hẹn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSach();
                }
            }
        }

        // Chọn dòng trên DataGridView để xem / đặt lịch
        private void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvDanhSach.Rows[e.RowIndex];
                txtMaHoSo.Text = row.Cells["Mã HS"].Value?.ToString();

                if (row.Cells["Ngày Giờ Hẹn"].Value != DBNull.Value && row.Cells["Ngày Giờ Hẹn"].Value != null)
                {
                    dtpNgayGioHen.Value = Convert.ToDateTime(row.Cells["Ngày Giờ Hẹn"].Value);
                }

                if (row.Cells["Trạng Thái Hẹn"].Value != DBNull.Value && row.Cells["Trạng Thái Hẹn"].Value != null)
                {
                    cboTrangThai.SelectedItem = row.Cells["Trạng Thái Hẹn"].Value.ToString();
                }
            }
        }

        private void ClearInputLeft()
        {
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtDiaChi.Clear();
            picAnh3x4.Image = null;
            duongDanAnh = "";
            dtpNgaySinh.Value = DateTime.Now;
        }
    }
}