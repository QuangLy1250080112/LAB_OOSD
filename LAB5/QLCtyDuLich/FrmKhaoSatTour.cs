using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace QLCtyDuLich
{
    public partial class FrmKhaoSatTour : Form
    {
        public FrmKhaoSatTour()
        {
            InitializeComponent();
        }

        private void FrmKhaoSatTour_Load(object sender, EventArgs e)
        {
            LoadDataControls();
            LoadTongHopKhaoSat();
        }

        private void LoadDataControls()
        {
            // Nạp danh sách Khách hàng
            string queryKhach = "SELECT c.userID, u.fullName + ' (' + c.identityCard + ')' AS DisplayName FROM Customer c JOIN [User] u ON c.userID = u.userID";
            DataTable dtKhach = Database.ExecuteQuery(queryKhach);

            cboKhachHang.DataSource = dtKhach;
            cboKhachHang.DisplayMember = "DisplayName";
            cboKhachHang.ValueMember = "userID";

            // Nạp ComboBox lọc Tour cho Tab Tổng hợp
            string queryTour = "SELECT 'ALL' AS tourID, N'-- Tất cả Tour --' AS tourName UNION ALL SELECT tourID, tourName FROM Tour";
            DataTable dtFilter = Database.ExecuteQuery(queryTour);

            cboFilterTour.DataSource = dtFilter;
            cboFilterTour.DisplayMember = "tourName";
            cboFilterTour.ValueMember = "tourID";
        }

        // Khi chọn Khách hàng -> Load danh sách các Tour mà khách hàng đó ĐÃ ĐI
        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedValue == null) return;
            string customerID = cboKhachHang.SelectedValue.ToString();

            string queryTourDaDi = @"
                SELECT t.tourID, t.tourName + ' (Đi ngày: ' + CONVERT(VARCHAR, cdl.departureDate, 103) + ')' AS DisplayName, cdl.departureDate
                FROM VeTourLe v
                JOIN ChuyenDiLe cdl ON v.chuyenID = cdl.chuyenID
                JOIN Tour t ON cdl.tourID = t.tourID
                WHERE v.customerID = @customerID
                UNION
                SELECT t.tourID, t.tourName + ' (Đi ngày: ' + CONVERT(VARCHAR, pdk.departureDateReq, 103) + ')' AS DisplayName, pdk.departureDateReq AS departureDate
                FROM PhieuDangKyDoan pdk
                JOIN Tour t ON pdk.tourID = t.tourID
                WHERE pdk.customerID = @customerID";

            SqlParameter[] p = { new SqlParameter("@customerID", customerID) };
            DataTable dt = Database.ExecuteQuery(queryTourDaDi, p);

            cboTourDaDi.DataSource = dt;
            cboTourDaDi.DisplayMember = "DisplayName";
            cboTourDaDi.ValueMember = "tourID";

            if (dt == null || dt.Rows.Count == 0)
            {
                lblStatusGui.Text = "Khách hàng này chưa tham gia chuyến đi nào!";
                btnGuiKhaoSat.Enabled = false;
            }
            else
            {
                lblStatusGui.Text = "";
                btnGuiKhaoSat.Enabled = true;
            }
        }

        // Kiểm tra thời hạn khảo sát (Flow 7a)
        private void cboTourDaDi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTourDaDi.SelectedItem is DataRowView row)
            {
                if (row["departureDate"] != DBNull.Value)
                {
                    DateTime depDate = Convert.ToDateTime(row["departureDate"]);
                    // Quy định: Quá 30 ngày kể từ ngày khởi hành -> Tự động đóng trạng thái khảo sát (Flow 7a)
                    if ((DateTime.Now - depDate).TotalDays > 30)
                    {
                        lblStatusGui.Text = "Hệ thống đã ĐÓNG KHẢO SÁT do tour đã kết thúc quá 30 ngày quy định (Flow 7a)!";
                        btnGuiKhaoSat.Enabled = false;
                    }
                    else
                    {
                        lblStatusGui.Text = "";
                        btnGuiKhaoSat.Enabled = true;
                    }
                }
            }
        }

        // XỬ LÝ GỬI ĐÁNH GIÁ KHẢO SÁT
        private void btnGuiKhaoSat_Click(object sender, EventArgs e)
        {
            lblStatusGui.Text = "";

            if (cboKhachHang.SelectedValue == null || cboTourDaDi.SelectedValue == null)
            {
                lblStatusGui.Text = "Lỗi: Vui lòng chọn Khách hàng và Tour đã đi!";
                return;
            }

            string customerID = cboKhachHang.SelectedValue.ToString();
            string tourID = cboTourDaDi.SelectedValue.ToString();
            int score = (int)numDiemDanhGia.Value;
            string comment = txtNhanXet.Text.Trim();

            // Kiểm tra xem đã gửi khảo sát tour này chưa
            string checkExist = "SELECT COUNT(*) FROM PhieuKhaoSat WHERE customerID = @customerID AND tourID = @tourID";
            SqlParameter[] pCheck = {
                new SqlParameter("@customerID", customerID),
                new SqlParameter("@tourID", tourID)
            };

            int count = Convert.ToInt32(Database.ExecuteScalar(checkExist, pCheck));
            if (count > 0)
            {
                lblStatusGui.Text = "Lỗi: Khách hàng này đã gửi khảo sát cho Tour này rồi!";
                return;
            }

            // Lưu vào CSDL
            string khaoSatID = "KS" + DateTime.Now.ToString("ddHHmmss");
            string insertQuery = "INSERT INTO PhieuKhaoSat (khaoSatID, customerID, tourID, ratingScore, comment) VALUES (@ksID, @custID, @tourID, @score, @comment)";
            SqlParameter[] pInsert = {
                new SqlParameter("@ksID", khaoSatID),
                new SqlParameter("@custID", customerID),
                new SqlParameter("@tourID", tourID),
                new SqlParameter("@score", score),
                new SqlParameter("@comment", comment)
            };

            int res = Database.ExecuteNonQuery(insertQuery, pInsert);
            if (res > 0)
            {
                MessageBox.Show("Gửi đánh giá khảo sát thành công!\nCảm ơn bạn đã đóng góp ý kiến cho Văn Hóa Việt.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNhanXet.Clear();
                numDiemDanhGia.Value = 5;
                LoadTongHopKhaoSat();
            }
        }

        // Load danh sách tổng hợp ý kiến khảo sát cho Nhân viên
        private void LoadTongHopKhaoSat()
        {
            string filterTourID = cboFilterTour.SelectedValue != null ? cboFilterTour.SelectedValue.ToString() : "ALL";

            string query = @"
                SELECT k.khaoSatID AS [Mã KS], u.fullName AS [Khách Hàng], t.tourName AS [Tên Tour], 
                       k.ratingScore AS [Điểm Đánh Giá], k.comment AS [Nhận Xét / Ý Kiến]
                FROM PhieuKhaoSat k
                JOIN Customer c ON k.customerID = c.userID
                JOIN [User] u ON c.userID = u.userID
                JOIN Tour t ON k.tourID = t.tourID";

            if (filterTourID != "ALL")
            {
                query += " WHERE k.tourID = '" + filterTourID + "'";
            }

            DataTable dt = Database.ExecuteQuery(query);
            dgvDanhSachKhaoSat.DataSource = dt;

            // Tính điểm trung bình ⭐
            string queryAvg = "SELECT AVG(CAST(ratingScore AS FLOAT)) FROM PhieuKhaoSat";
            if (filterTourID != "ALL")
            {
                queryAvg += " WHERE tourID = '" + filterTourID + "'";
            }

            object avgObj = Database.ExecuteScalar(queryAvg);
            if (avgObj != null && avgObj != DBNull.Value)
            {
                double avg = Convert.ToDouble(avgObj);
                lblDiemTrungBinh.Text = "Điểm TB: " + avg.ToString("F1") + " / 5.0 ⭐";
            }
            else
            {
                lblDiemTrungBinh.Text = "Điểm TB: 0.0 / 5.0 ⭐";
            }
        }

        private void cboFilterTour_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTongHopKhaoSat();
        }
    }
}