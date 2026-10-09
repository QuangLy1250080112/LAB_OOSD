using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QLCtyDuLich
{
    public partial class FrmDieuHanhVaQuyetToan : Form
    {
        public FrmDieuHanhVaQuyetToan()
        {
            InitializeComponent();
        }

        private void FrmDieuHanhVaQuyetToan_Load(object sender, EventArgs e)
        {
            LoadDataControls();
        }

        // 1. Load các danh mục cần thiết
        private void LoadDataControls()
        {
            // Nạp danh sách Hướng dẫn viên
            string queryHDV = "SELECT s.userID, u.fullName AS DisplayName FROM Staff s JOIN [User] u ON s.userID = u.userID WHERE s.position = N'Hướng dẫn viên' OR u.role = 'Staff'";
            DataTable dtHDV = Database.ExecuteQuery(queryHDV);

            cboHDV.DataSource = dtHDV;
            cboHDV.DisplayMember = "DisplayName";
            cboHDV.ValueMember = "userID";

            // Nạp danh sách Phân công & Quyết toán
            LoadDoiTuongPhanCong();
            LoadPhieuDoanQuyetToan();
        }

        // Nạp danh sách chuyến lẻ hoặc phiếu đoàn cần phân công HDV
        private void LoadDoiTuongPhanCong()
        {
            if (rdoChuyenLe.Checked)
            {
                lblDoiTuongPC.Text = "Chọn Chuyến Đi Lẻ:";
                string queryChuyen = "SELECT c.chuyenID AS ID, 'Chuyến ' + c.chuyenID + ' - ' + t.tourName + ' (' + CONVERT(VARCHAR, c.departureDate, 103) + ')' AS DisplayName, c.departureDate FROM ChuyenDiLe c JOIN Tour t ON c.tourID = t.tourID";
                DataTable dtChuyen = Database.ExecuteQuery(queryChuyen);

                cboDoiTuongPC.DataSource = dtChuyen;
                cboDoiTuongPC.DisplayMember = "DisplayName";
                cboDoiTuongPC.ValueMember = "ID";
            }
            else
            {
                lblDoiTuongPC.Text = "Chọn Phiếu Tour Đoàn:";
                string queryDoan = "SELECT p.phieuID AS ID, 'Phiếu ' + p.phieuID + ' - ' + t.tourName + ' (' + CONVERT(VARCHAR, p.departureDateReq, 103) + ')' AS DisplayName, p.departureDateReq AS departureDate FROM PhieuDangKyDoan p JOIN Tour t ON p.tourID = t.tourID";
                DataTable dtDoan = Database.ExecuteQuery(queryDoan);

                cboDoiTuongPC.DataSource = dtDoan;
                cboDoiTuongPC.DisplayMember = "DisplayName";
                cboDoiTuongPC.ValueMember = "ID";
            }
        }

        private void rdoOption_CheckedChanged(object sender, EventArgs e)
        {
            LoadDoiTuongPhanCong();
        }

        // Cập nhật ngày phân công tương ứng với chuyến/đoàn được chọn
        private void cboDoiTuongPC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDoiTuongPC.SelectedItem is DataRowView row)
            {
                if (row["departureDate"] != DBNull.Value)
                {
                    dtpNgayPhanCong.Value = Convert.ToDateTime(row["departureDate"]);
                }
            }
        }

        // XỬ LÝ PHÂN CÔNG HDV (KIỂM TRA TRÙNG LỊCH - FLOW 4a)
        private void btnPhanCong_Click(object sender, EventArgs e)
        {
            lblErrorPhanCong.Text = "";

            if (cboDoiTuongPC.SelectedValue == null || cboHDV.SelectedValue == null)
            {
                lblErrorPhanCong.Text = "Lỗi: Vui lòng chọn đầy đủ đối tượng tour và Hướng dẫn viên!";
                return;
            }

            string staffID = cboHDV.SelectedValue.ToString();
            DateTime assignedDate = dtpNgayPhanCong.Value.Date;
            string selectedID = cboDoiTuongPC.SelectedValue.ToString();

            // KIỂM TRA TRÙNG LỊCH (FLOW 4a): Đã có phân công khác cho HDV này vào cùng ngày chưa
            string checkConflictQuery = "SELECT COUNT(*) FROM PhanCongHDV WHERE staffID = @staffID AND assignedDate = @assignedDate";
            SqlParameter[] pCheck = {
                new SqlParameter("@staffID", staffID),
                new SqlParameter("@assignedDate", assignedDate.ToString("yyyy-MM-dd"))
            };

            int conflictCount = Convert.ToInt32(Database.ExecuteScalar(checkConflictQuery, pCheck));
            if (conflictCount > 0)
            {
                lblErrorPhanCong.Text = "CẢNH BÁO ĐỎ: HDV [" + cboHDV.Text + "] ĐÃ BỊ TRÙNG LỊCH TOUR KHÁC NGÀY " + assignedDate.ToString("dd/MM/yyyy") + "! VUI LÒNG CHỌN HDV KHÁC.";
                return;
            }

            // Tiến hành phân công
            string phanCongID = "PC" + DateTime.Now.ToString("ddHHmmss");
            string insertQuery = "";
            SqlParameter[] pInsert;

            if (rdoChuyenLe.Checked)
            {
                insertQuery = "INSERT INTO PhanCongHDV (phanCongID, staffID, assignedDate, chuyenID, phieuID) VALUES (@pcID, @staffID, @assignedDate, @chuyenID, NULL)";
                pInsert = new SqlParameter[] {
                    new SqlParameter("@pcID", phanCongID),
                    new SqlParameter("@staffID", staffID),
                    new SqlParameter("@assignedDate", assignedDate.ToString("yyyy-MM-dd")),
                    new SqlParameter("@chuyenID", selectedID)
                };
            }
            else
            {
                insertQuery = "INSERT INTO PhanCongHDV (phanCongID, staffID, assignedDate, chuyenID, phieuID) VALUES (@pcID, @staffID, @assignedDate, NULL, @phieuID)";
                pInsert = new SqlParameter[] {
                    new SqlParameter("@pcID", phanCongID),
                    new SqlParameter("@staffID", staffID),
                    new SqlParameter("@assignedDate", assignedDate.ToString("yyyy-MM-dd")),
                    new SqlParameter("@phieuID", selectedID)
                };
            }

            int res = Database.ExecuteNonQuery(insertQuery, pInsert);
            if (res > 0)
            {
                MessageBox.Show("Phân công Hướng dẫn viên thành công!\nMã phân công: " + phanCongID + "\nHDV: " + cboHDV.Text + "\nNgày: " + assignedDate.ToString("dd/MM/yyyy"), "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // Nạp danh sách Phiếu tour đoàn cần Quyết toán
        private void LoadPhieuDoanQuyetToan()
        {
            string query = @"SELECT p.phieuID, 'Phiếu ' + p.phieuID + ' - ' + u.fullName + ' (' + t.tourName + ')' AS DisplayName, 
                             (p.groupSize * t.standardPrice) AS TongTien, p.depositAmount 
                             FROM PhieuDangKyDoan p 
                             JOIN Tour t ON p.tourID = t.tourID 
                             JOIN Customer c ON p.customerID = c.userID 
                             JOIN [User] u ON c.userID = u.userID";

            DataTable dt = Database.ExecuteQuery(query);
            cboPhieuDoanQuyetToan.DataSource = dt;
            cboPhieuDoanQuyetToan.DisplayMember = "DisplayName";
            cboPhieuDoanQuyetToan.ValueMember = "phieuID";
        }

        // Tính toán các khoản tiền khi chọn phiếu đoàn
        private void cboPhieuDoanQuyetToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhieuDoanQuyetToan.SelectedItem is DataRowView row)
            {
                decimal tongTien = Convert.ToDecimal(row["TongTien"]);
                decimal tienCoc = Convert.ToDecimal(row["depositAmount"]);
                decimal conLai = tongTien - tienCoc;

                txtTongTienTour.Text = tongTien.ToString("N0") + " VNĐ";
                txtTienCocDaNop.Text = tienCoc.ToString("N0") + " VNĐ";
                txtTienConLai.Text = (conLai > 0 ? conLai.ToString("N0") : "0") + " VNĐ";
            }
        }

        // XỬ LÝ QUYẾT TOÁN TOUR ĐOÀN
        private void btnQuyetToan_Click(object sender, EventArgs e)
        {
            lblStatusQuyetToan.Text = "";

            if (cboPhieuDoanQuyetToan.SelectedValue == null)
            {
                lblStatusQuyetToan.Text = "Lỗi: Vui lòng chọn phiếu tour đoàn cần quyết toán!";
                return;
            }

            string phieuID = cboPhieuDoanQuyetToan.SelectedValue.ToString();
            DialogResult dialog = MessageBox.Show("Xác nhận thu nốt số tiền còn lại (" + txtTienConLai.Text + ") và hoàn tất quyết toán cho phiếu [" + phieuID + "]?", "Xác Nhận Quyết Toán", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                MessageBox.Show("Quyết toán hoàn tất thành công!\nPhiếu đoàn: " + phieuID + "\nĐã thu đủ 100% kinh phí tour.", "Thông Báo Quyết Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblStatusQuyetToan.Text = "Đã quyết toán xong phiếu " + phieuID;
            }
        }
    }
}