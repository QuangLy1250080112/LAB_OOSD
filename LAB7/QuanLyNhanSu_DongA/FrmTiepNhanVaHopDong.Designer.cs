using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyNhanSu_DongA
{
    public partial class FrmTiepNhanVaHopDong : Form
    {
        public FrmTiepNhanVaHopDong()
        {
            InitializeComponent();
        }

        private void FrmTiepNhanVaHopDong_Load(object sender, EventArgs e)
        {
            LoadComboBoxData();
            LoadNhanVienGrid();
        }

        // Nạp danh sách Phòng Ban và Chức Vụ từ CSDL vào ComboBox
        private void LoadComboBoxData()
        {
            DataTable dtPB = Database.ExecuteQuery("SELECT maPhongBan, tenPhongBan FROM PhongBan");
            cboPhongBan.DataSource = dtPB;
            cboPhongBan.DisplayMember = "tenPhongBan";
            cboPhongBan.ValueMember = "maPhongBan";

            DataTable dtCV = Database.ExecuteQuery("SELECT maChucVu, tenChucVu FROM ChucVu");
            cboChucVu.DataSource = dtCV;
            cboChucVu.DisplayMember = "tenChucVu";
            cboChucVu.ValueMember = "maChucVu";
        }

        // Hiển thị danh sách Nhân viên, Quyết định thử việc và Trạng thái Hợp đồng
        private void LoadNhanVienGrid()
        {
            string query = @"
                SELECT 
                    nv.maNV AS [Mã NV], 
                    nv.hoTen AS [Họ Tên], 
                    pb.tenPhongBan AS [Phòng Ban], 
                    cv.tenChucVu AS [Chức Vụ], 
                    hd.loaiHopDong AS [Loại HĐ],
                    bh.maSoBHXH AS [Mã BHXH]
                FROM NhanVien nv
                LEFT JOIN PhongBan pb ON nv.maPhongBan = pb.maPhongBan
                LEFT JOIN ChucVu cv ON nv.maChucVu = cv.maChucVu
                LEFT JOIN HopDongLaoDong hd ON nv.maNV = hd.maNV
                LEFT JOIN HoSoBaoHiem bh ON nv.maNV = bh.maNV
                ORDER BY nv.maNV DESC";

            DataTable dt = Database.ExecuteQuery(query);
            dgvNhanVien.DataSource = dt;
        }

        // Xử lý nút: 1. TẠO QĐ TUYỂN DỤNG THỬ VIỆC
        private void btnTaoQDTD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text) || string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Mã Nhân viên và Họ tên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtMaNV.Text.Trim();
            string hoTen = txtHoTen.Text.Trim();
            DateTime ngaySinh = dtpNgaySinh.Value;
            string maPB = cboPhongBan.SelectedValue?.ToString();
            string maCV = cboChucVu.SelectedValue?.ToString();

            if (!int.TryParse(txtThoiGianThuViec.Text, out int thoiGianTV) || !decimal.TryParse(txtLuongThuViec.Text, out decimal luongTV))
            {
                MessageBox.Show("Thời gian và Lương thử việc phải là số hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Thêm thông tin sơ bộ vào bảng NhanVien
            string insertNV = @"
                IF NOT EXISTS (SELECT 1 FROM NhanVien WHERE maNV = @maNV)
                BEGIN
                    INSERT INTO NhanVien (maNV, hoTen, ngaySinh, gioiTinh, maPhongBan, maChucVu)
                    VALUES (@maNV, @hoTen, @ngaySinh, N'Nam', @maPB, @maCV)
                END";

            SqlParameter[] pNV = new SqlParameter[]
            {
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@hoTen", hoTen),
                new SqlParameter("@ngaySinh", ngaySinh),
                new SqlParameter("@maPB", maPB),
                new SqlParameter("@maCV", maCV)
            };

            Database.ExecuteNonQuery(insertNV, pNV);

            // 2. Lập Quyết định tuyển dụng thử việc
            string maQDTD = "QDTD_" + maNV;
            string insertQDTD = @"
                INSERT INTO QuyetDinhTuyenDung (maQDTD, ngayKy, thoiGianThuViec, luongThuViec, dieuKhoan, maNV, maPhongBan)
                VALUES (@maQDTD, GETDATE(), @thoiGianTV, @luongTV, N'Quyết định tuyển dụng thử việc chính thức', @maNV, @maPB)";

            SqlParameter[] pQDTD = new SqlParameter[]
            {
                new SqlParameter("@maQDTD", maQDTD),
                new SqlParameter("@thoiGianTV", thoiGianTV),
                new SqlParameter("@luongTV", luongTV),
                new SqlParameter("@maNV", maNV),
                new SqlParameter("@maPB", maPB)
            };

            int rows = Database.ExecuteNonQuery(insertQDTD, pQDTD);
            if (rows > 0)
            {
                MessageBox.Show($"Tạo Quyết định tuyển dụng thử việc ({maQDTD}) cho nhân viên {hoTen} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadNhanVienGrid();
            }
        }

        // Xử lý nút: 2. KÝ HỢP ĐỒNG CHÍNH THỨC & ĐỒNG BỘ BHXH
        private void btnKyHopDong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn hoặc nhập Mã Nhân viên cần ký hợp đồng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maNV = txtMaNV.Text.Trim();
            string loaiHD = radDaiHan.Checked ? "Dài hạn" : "Ngắn hạn";
            string maHD = "HD_" + maNV;

            // 1. Thêm/Cập nhật Hợp đồng lao động
            string insertHD = @"
                IF EXISTS (SELECT 1 FROM HopDongLaoDong WHERE maNV = @maNV)
                    UPDATE HopDongLaoDong SET loaiHopDong = @loaiHD, ngayBatDau = GETDATE() WHERE maNV = @maNV;
                ELSE
                    INSERT INTO HopDongLaoDong (maHopDong, loaiHopDong, ngayBatDau, maNV) VALUES (@maHD, @loaiHD, GETDATE(), @maNV);";

            SqlParameter[] pHD = new SqlParameter[]
            {
                new SqlParameter("@maHD", maHD),
                new SqlParameter("@loaiHD", loaiHD),
                new SqlParameter("@maNV", maNV)
            };

            Database.ExecuteNonQuery(insertHD, pHD);

            // 2. Nếu là Hợp đồng dài hạn và có tích đồng bộ BHXH
            if (radDaiHan.Checked && chkBaoHiem.Checked)
            {
                string maBH = "BH_" + maNV;
                string maSoBHXH = "BHXH_" + maNV;
                string maSoBHYT = "BHYT_" + maNV;

                string insertBH = @"
                    IF NOT EXISTS (SELECT 1 FROM HoSoBaoHiem WHERE maNV = @maNV)
                    BEGIN
                        INSERT INTO HoSoBaoHiem (maHoSoBH, maSoBHXH, maSoBHYT, mucDongBH, maNV)
                        VALUES (@maBH, @maSoBHXH, @maSoBHYT, 0.105, @maNV);
                    END";

                SqlParameter[] pBH = new SqlParameter[]
                {
                    new SqlParameter("@maBH", maBH),
                    new SqlParameter("@maSoBHXH", maSoBHXH),
                    new SqlParameter("@maSoBHYT", maSoBHYT),
                    new SqlParameter("@maNV", maNV)
                };

                Database.ExecuteNonQuery(insertBH, pBH);
            }

            MessageBox.Show($"Ký Hợp đồng lao động ({loaiHD}) & Cập nhật Hồ sơ hoàn tất!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadNhanVienGrid();
        }

        // Tự động thay đổi trạng thái CheckBox Bảo hiểm theo loại Hợp đồng
        private void radDaiHan_CheckedChanged(object sender, EventArgs e)
        {
            if (radDaiHan.Checked)
            {
                chkBaoHiem.Checked = true;
                chkBaoHiem.Enabled = true;
            }
        }

        private void radNganHan_CheckedChanged(object sender, EventArgs e)
        {
            if (radNganHan.Checked)
            {
                chkBaoHiem.Checked = false;
                chkBaoHiem.Enabled = false;
            }
        }

        // Đổ ngược dữ liệu từ GridView lên các điều khiển khi click chọn dòng
        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["Mã NV"].Value?.ToString();
                txtHoTen.Text = row.Cells["Họ Tên"].Value?.ToString();

                string loaiHD = row.Cells["Loại HĐ"].Value?.ToString();
                if (loaiHD == "Ngắn hạn")
                {
                    radNganHan.Checked = true;
                }
                else
                {
                    radDaiHan.Checked = true;
                }
            }
        }
    }
}