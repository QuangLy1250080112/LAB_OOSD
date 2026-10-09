using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QLCtyDuLich
{
    public partial class FrmDangKyTour : Form
    {
        public FrmDangKyTour()
        {
            InitializeComponent();
        }

        private void FrmDangKyTour_Load(object sender, EventArgs e)
        {
            LoadDataControls();
        }

        private void LoadDataControls()
        {
            // Nạp danh sách Khách hàng cho Tour Đoàn
            string queryKhach = "SELECT c.userID, u.fullName + ' (' + c.identityCard + ')' AS DisplayName FROM Customer c JOIN [User] u ON c.userID = u.userID";
            DataTable dtKhachDoan = Database.ExecuteQuery(queryKhach);

            cboKhachDoan.DataSource = dtKhachDoan;
            cboKhachDoan.DisplayMember = "DisplayName";
            cboKhachDoan.ValueMember = "userID";

            // Nạp danh sách Tour
            string queryTour = "SELECT tourID, tourName, standardPrice FROM Tour";
            DataTable dtTourLe = Database.ExecuteQuery(queryTour);
            DataTable dtTourDoan = dtTourLe.Copy();

            cboTourLe.DataSource = dtTourLe;
            cboTourLe.DisplayMember = "tourName";
            cboTourLe.ValueMember = "tourID";

            cboTourDoan.DataSource = dtTourDoan;
            cboTourDoan.DisplayMember = "tourName";
            cboTourDoan.ValueMember = "tourID";
        }

        private void cboTourLe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTourLe.SelectedValue == null) return;
            string selectedTourID = cboTourLe.SelectedValue.ToString();

            DataRowView row = cboTourLe.SelectedItem as DataRowView;
            if (row != null)
            {
                decimal price = Convert.ToDecimal(row["standardPrice"]);
                txtTongTienLe.Text = price.ToString("N0") + " VNĐ";
            }

            string queryChuyen = "SELECT chuyenID, 'Chuyến ' + chuyenID + ' - Ngày đi: ' + CONVERT(VARCHAR, departureDate, 103) + ' (Còn ' + CAST(availableSlots AS VARCHAR) + ' chỗ)' AS DisplayName FROM ChuyenDiLe WHERE tourID = @tourID AND availableSlots > 0";
            SqlParameter[] p = { new SqlParameter("@tourID", selectedTourID) };
            DataTable dtChuyen = Database.ExecuteQuery(queryChuyen, p);

            cboChuyenLe.DataSource = dtChuyen;
            cboChuyenLe.DisplayMember = "DisplayName";
            cboChuyenLe.ValueMember = "chuyenID";
        }

        // Xử lý XUẤT VÉ LẺ (Tự động lưu/lấy CustomerID theo CMND)
        private void btnXuatVeLe_Click(object sender, EventArgs e)
        {
            lblStatusLe.Text = "";

            if (string.IsNullOrWhiteSpace(txtTenKhachLe.Text) || string.IsNullOrWhiteSpace(txtCMNDLe.Text))
            {
                lblStatusLe.Text = "Lỗi: Vui lòng nhập Tên khách hàng và Số CMND/CCCD!";
                return;
            }

            if (cboTourLe.SelectedValue == null || cboChuyenLe.SelectedValue == null)
            {
                lblStatusLe.Text = "Lỗi: Vui lòng chọn Tour và Chuyến đi!";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiemDonLe.Text))
            {
                lblStatusLe.Text = "Lỗi: Điểm đón quy định không được bỏ trống!";
                return;
            }

            string cmnd = txtCMNDLe.Text.Trim();
            string tenKhach = txtTenKhachLe.Text.Trim();
            string customerID = "";

            // 1. Kiểm tra xem CMND/CCCD đã có trong CSDL chưa
            string checkCustomer = "SELECT userID FROM Customer WHERE identityCard = @cmnd";
            SqlParameter[] pCheck = { new SqlParameter("@cmnd", cmnd) };
            object existID = Database.ExecuteScalar(checkCustomer, pCheck);

            if (existID != null)
            {
                customerID = existID.ToString();
            }
            else
            {
                // Chưa có -> Tạo User & Customer mới
                customerID = "USR" + DateTime.Now.ToString("ddHHmmss");
                string username = "khach_" + DateTime.Now.ToString("ddHHmmss");

                string insertUser = "INSERT INTO [User] (userID, username, passwordHash, fullName, role) VALUES (@userID, @username, '123456', @fullName, 'Customer')";
                SqlParameter[] pUser = {
                    new SqlParameter("@userID", customerID),
                    new SqlParameter("@username", username),
                    new SqlParameter("@fullName", tenKhach)
                };
                Database.ExecuteNonQuery(insertUser, pUser);

                string insertCust = "INSERT INTO Customer (userID, identityCard) VALUES (@userID, @cmnd)";
                SqlParameter[] pCust = {
                    new SqlParameter("@userID", customerID),
                    new SqlParameter("@cmnd", cmnd)
                };
                Database.ExecuteNonQuery(insertCust, pCust);
            }

            // 2. Xuất vé
            string veID = "VE" + DateTime.Now.ToString("ddHHmmss");
            string chuyenID = cboChuyenLe.SelectedValue.ToString();
            string staffID = "USR003"; // NV lập vé mặc định
            string pickupPoint = txtDiemDonLe.Text.Trim();

            DataRowView row = cboTourLe.SelectedItem as DataRowView;
            decimal totalPrice = Convert.ToDecimal(row["standardPrice"]);

            string insertVe = "INSERT INTO VeTourLe (veID, customerID, chuyenID, staffID, pickupPoint, totalPrice) VALUES (@veID, @customerID, @chuyenID, @staffID, @pickupPoint, @totalPrice)";
            SqlParameter[] pVe = {
                new SqlParameter("@veID", veID),
                new SqlParameter("@customerID", customerID),
                new SqlParameter("@chuyenID", chuyenID),
                new SqlParameter("@staffID", staffID),
                new SqlParameter("@pickupPoint", pickupPoint),
                new SqlParameter("@totalPrice", totalPrice)
            };

            int res = Database.ExecuteNonQuery(insertVe, pVe);
            if (res > 0)
            {
                Database.ExecuteNonQuery("UPDATE ChuyenDiLe SET availableSlots = availableSlots - 1 WHERE chuyenID = '" + chuyenID + "'");
                MessageBox.Show("Xuất vé Tour lẻ thành công!\nMã vé: " + veID + "\nKhách hàng: " + tenKhach + "\nSố tiền thu: " + totalPrice.ToString("N0") + " VNĐ", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtTenKhachLe.Clear();
                txtCMNDLe.Clear();
                txtDiemDonLe.Clear();
                cboTourLe_SelectedIndexChanged(null, null);
            }
        }

        private void btnTaoPhieuDoan_Click(object sender, EventArgs e)
        {
            lblErrorDoan.Text = "";

            if (numSoLuongDoan.Value < 12)
            {
                lblErrorDoan.Text = "Lỗi: Tour đoàn yêu cầu số lượng từ 12 người trở lên!";
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDiemDonDoan.Text) || string.IsNullOrWhiteSpace(txtTienCoc.Text))
            {
                lblErrorDoan.Text = "Lỗi: Vui lòng nhập đầy đủ Yêu cầu điểm đón và Tiền cọc!";
                return;
            }

            decimal tienCoc = 0;
            if (!decimal.TryParse(txtTienCoc.Text.Trim(), out tienCoc) || tienCoc <= 0)
            {
                lblErrorDoan.Text = "Lỗi: Số tiền đặt cọc phải là số thực dương!";
                return;
            }

            string phieuID = "PDK" + DateTime.Now.ToString("ddHHmmss");
            string customerID = cboKhachDoan.SelectedValue.ToString();
            string tourID = cboTourDoan.SelectedValue.ToString();
            string staffID = "USR003";
            DateTime departureReq = dtpNgayDiDoan.Value;
            int groupSize = (int)numSoLuongDoan.Value;

            string insertPhieu = "INSERT INTO PhieuDangKyDoan (phieuID, customerID, tourID, staffID, departureDateReq, groupSize, depositAmount) VALUES (@phieuID, @customerID, @tourID, @staffID, @depDate, @groupSize, @deposit)";
            SqlParameter[] p = {
                new SqlParameter("@phieuID", phieuID),
                new SqlParameter("@customerID", customerID),
                new SqlParameter("@tourID", tourID),
                new SqlParameter("@staffID", staffID),
                new SqlParameter("@depDate", departureReq.ToString("yyyy-MM-dd")),
                new SqlParameter("@groupSize", groupSize),
                new SqlParameter("@deposit", tienCoc)
            };

            int res = Database.ExecuteNonQuery(insertPhieu, p);
            if (res > 0)
            {
                int bhCount = 0;
                foreach (DataGridViewRow row in dgvBaoHiem.Rows)
                {
                    if (row.Cells["colThanhVien"].Value != null && row.Cells["colMaBH"].Value != null)
                    {
                        string memberName = row.Cells["colThanhVien"].Value.ToString().Trim();
                        string bhCode = row.Cells["colMaBH"].Value.ToString().Trim();

                        if (!string.IsNullOrEmpty(memberName) && !string.IsNullOrEmpty(bhCode))
                        {
                            bhCount++;
                            string dsID = "BH" + bhCount + DateTime.Now.ToString("mmss");
                            string insertBH = "INSERT INTO DanhSachBaoHiem (danhSachID, phieuID, memberName, insuranceCode) VALUES (@dsID, @phieuID, @memberName, @bhCode)";
                            SqlParameter[] pBH = {
                                new SqlParameter("@dsID", dsID),
                                new SqlParameter("@phieuID", phieuID),
                                new SqlParameter("@memberName", memberName),
                                new SqlParameter("@bhCode", bhCode)
                            };
                            Database.ExecuteNonQuery(insertBH, pBH);
                        }
                    }
                }

                MessageBox.Show("Khởi tạo Phiếu Đăng Ký Tour Đoàn thành công!\nMã phiếu: " + phieuID + "\nSố tiền cọc thu: " + tienCoc.ToString("N0") + " VNĐ\nĐã lưu " + bhCount + " thông tin bảo hiểm.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDiemDonDoan.Clear();
                txtTienCoc.Clear();
                dgvBaoHiem.Rows.Clear();
            }
        }

        private void btnHuyDangKy_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Xác nhận hủy đăng ký đoàn? Theo quy định (Flow 3a), hệ thống sẽ ghi nhận hủy tour và đoàn sẽ bị MẤT TIỀN ĐẶT CỌC.", "Cảnh Báo Hủy Tour", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                txtDiemDonDoan.Clear();
                txtTienCoc.Clear();
                dgvBaoHiem.Rows.Clear();
                lblErrorDoan.Text = "Đã hủy đăng ký. Ghi nhận mất cọc thành công!";
            }
        }
    }
}