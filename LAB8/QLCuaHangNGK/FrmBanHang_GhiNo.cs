using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace QLCuaHangNGK
{
    public partial class FrmBanHang_GhiNo : Form
    {
        private DataTable dtCart = new DataTable();
        private string currentMaNV = "NV02"; // Nhân viên bán hàng lập hóa đơn

        public FrmBanHang_GhiNo()
        {
            InitializeComponent();
        }

        private void FrmBanHang_GhiNo_Load(object sender, EventArgs e)
        {
            InitCartTable();
            LoadKhachHang();
            LoadNuocGiaiKhat();
            dtpNgayHenGiao.Value = DateTime.Now.AddDays(2);
            dtpNgayDuKienTra.Value = DateTime.Now.AddDays(15);
        }

        // Tạo bảng chứa danh sách giỏ hàng tạm thời
        private void InitCartTable()
        {
            dtCart.Columns.Clear();
            dtCart.Columns.Add("maNGK", typeof(string));
            dtCart.Columns.Add("tenNGK", typeof(string));
            dtCart.Columns.Add("donGiaBan", typeof(double));
            dtCart.Columns.Add("soLuongTon", typeof(int));
            dtCart.Columns.Add("soLuongYeuCau", typeof(int));
            dtCart.Columns.Add("soLuongGiaoThucTe", typeof(int));
            dtCart.Columns.Add("soLuongHen", typeof(int));
            dtCart.Columns.Add("thanhTien", typeof(double));

            dgvChiTietHoaDon.DataSource = dtCart;

            dgvChiTietHoaDon.Columns["maNGK"].HeaderText = "Mã NGK";
            dgvChiTietHoaDon.Columns["tenNGK"].HeaderText = "Tên Nước Giải Khát";
            dgvChiTietHoaDon.Columns["donGiaBan"].HeaderText = "Đơn Giá";
            dgvChiTietHoaDon.Columns["soLuongTon"].HeaderText = "Tồn Kho";
            dgvChiTietHoaDon.Columns["soLuongYeuCau"].HeaderText = "SL Đặt";
            dgvChiTietHoaDon.Columns["soLuongGiaoThucTe"].HeaderText = "SL Giao Ngay";
            dgvChiTietHoaDon.Columns["soLuongHen"].HeaderText = "SL Hẹn Giao";
            dgvChiTietHoaDon.Columns["thanhTien"].HeaderText = "Thành Tiền";
        }

        private void LoadKhachHang()
        {
            string query = "SELECT maKH, tenKH, loaiKhach FROM KhachHang";
            DataTable dt = Database.ExecuteQuery(query);
            cboKhachHang.DataSource = dt;
            cboKhachHang.DisplayMember = "tenKH";
            cboKhachHang.ValueMember = "maKH";
        }

        private void LoadNuocGiaiKhat()
        {
            string query = "SELECT maNGK, tenNGK, soLuongTon, donGiaBan FROM NuocGiaiKhat";
            DataTable dt = Database.ExecuteQuery(query);
            cboNuocGiaiKhat.DataSource = dt;
            cboNuocGiaiKhat.DisplayMember = "tenNGK";
            cboNuocGiaiKhat.ValueMember = "maNGK";
        }

        private void cboKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhachHang.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cboKhachHang.SelectedItem;
                string loaiKhach = row["loaiKhach"].ToString() ?? "";

                txtLoaiKhach.Text = loaiKhach == "Quen" ? "Khách quen" : "Khách vãng lai";

                // Quy tắc BR04: Khách vãng lai bắt buộc thanh toán 100%, không được trả chậm/ghi nợ
                if (loaiKhach != "Quen")
                {
                    radThanhToanNgay.Checked = true;
                    radTraCham_GhiNo.Enabled = false;
                }
                else
                {
                    radTraCham_GhiNo.Enabled = true;
                }
            }
        }

        private void cboNuocGiaiKhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNuocGiaiKhat.SelectedItem != null)
            {
                DataRowView row = (DataRowView)cboNuocGiaiKhat.SelectedItem;
                txtSoLuongTon.Text = row["soLuongTon"].ToString();
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (cboNuocGiaiKhat.SelectedItem == null) return;

            if (!int.TryParse(txtSoLuongMua.Text, out int soLuongMua) || soLuongMua <= 0)
            {
                MessageBox.Show("Số lượng mua phải là số nguyên lớn hơn 0!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataRowView row = (DataRowView)cboNuocGiaiKhat.SelectedItem;
            string maNGK = row["maNGK"].ToString() ?? "";
            string tenNGK = row["tenNGK"].ToString() ?? "";
            double donGia = Convert.ToDouble(row["donGiaBan"]);
            int tonKho = Convert.ToInt32(row["soLuongTon"]);

            DataRowView khRow = (DataRowView)cboKhachHang.SelectedItem;
            string loaiKhach = khRow["loaiKhach"].ToString() ?? "";

            int soLuongGiaoThucTe = soLuongMua;
            int soLuongHen = 0;

            // Quy tắc BR03: Kiểm tra tồn kho
            if (soLuongMua > tonKho)
            {
                if (loaiKhach == "Quen")
                {
                    // Khách quen: Tách số lượng giao ngay (= tồn kho) và phần thiếu để lập Phiếu hẹn
                    soLuongGiaoThucTe = tonKho;
                    soLuongHen = soLuongMua - tonKho;
                    chkLapPhieuHen.Checked = true;
                    dtpNgayHenGiao.Enabled = true;

                    MessageBox.Show($"Mặt hàng '{tenNGK}' thiếu kho!\nThực giao ngay: {soLuongGiaoThucTe}\nSẽ lập phiếu hẹn giao đợt sau: {soLuongHen}", "Thông báo thiếu kho (Khách quen)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    // Khách vãng lai: Chỉ bán tối đa theo số lượng hiện có trong kho
                    MessageBox.Show($"Mặt hàng '{tenNGK}' chỉ còn {tonKho} trong kho. Khách vãng lai chỉ được mua tối đa số lượng tồn!", "Cảnh báo thiếu kho (Khách vãng lai)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLuongMua = tonKho;
                    soLuongGiaoThucTe = tonKho;
                    soLuongHen = 0;
                    if (soLuongMua <= 0) return;
                }
            }

            // Thêm vào giỏ hàng
            dtCart.Rows.Add(maNGK, tenNGK, donGia, tonKho, soLuongMua, soLuongGiaoThucTe, soLuongHen, soLuongMua * donGia);
            CalculateTotalAndDebt();
        }

        private void radTraCham_GhiNo_CheckedChanged(object sender, EventArgs e)
        {
            bool isGhiNo = radTraCham_GhiNo.Checked;
            txtSoTienNo.Enabled = isGhiNo;
            dtpNgayDuKienTra.Enabled = isGhiNo;
            txtLyDoNo.Enabled = isGhiNo;

            if (isGhiNo)
            {
                CalculateTotalAndDebt();
            }
            else
            {
                txtSoTienNo.Text = "0";
            }
        }

        private void CalculateTotalAndDebt()
        {
            double tongTien = 0;
            foreach (DataRow r in dtCart.Rows)
            {
                tongTien += Convert.ToDouble(r["thanhTien"]);
            }

            if (radTraCham_GhiNo.Checked)
            {
                txtSoTienNo.Text = tongTien.ToString();
            }
        }

        private void btnLapHoaDon_GhiNo_Click(object sender, EventArgs e)
        {
            if (dtCart.Rows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 mặt hàng vào danh sách!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maKH = cboKhachHang.SelectedValue?.ToString() ?? "";
            string soHD = "HD" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string soPH = "PH" + DateTime.Now.ToString("yyyyMMddHHmmss");
            string soPGN = "PGN" + DateTime.Now.ToString("yyyyMMddHHmmss");

            double tongTien = 0;
            bool coHangHen = false;

            foreach (DataRow r in dtCart.Rows)
            {
                tongTien += Convert.ToDouble(r["thanhTien"]);
                if (Convert.ToInt32(r["soLuongHen"]) > 0) coHangHen = true;
            }

            string trangThaiTT = radTraCham_GhiNo.Checked ? "Ghi nợ" : (coHangHen ? "Còn thiếu hàng" : "Đã thanh toán");

            // Thực hiện Giao dịch Transaction để đảm bảo tính toàn vẹn CSDL
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // 1. Tạo Hóa đơn
                    string sqlHD = "INSERT INTO HoaDon (soHD, ngayLap, tongTien, trangThaiThanhToan, maKH, maNV) VALUES (@soHD, GETDATE(), @tongTien, @trangThaiTT, @maKH, @maNV)";
                    using (SqlCommand cmd = new SqlCommand(sqlHD, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@soHD", soHD);
                        cmd.Parameters.AddWithValue("@tongTien", tongTien);
                        cmd.Parameters.AddWithValue("@trangThaiTT", trangThaiTT);
                        cmd.Parameters.AddWithValue("@maKH", maKH);
                        cmd.Parameters.AddWithValue("@maNV", currentMaNV);
                        cmd.ExecuteNonQuery();
                    }

                    // 2. Tạo Chi tiết hóa đơn & Trừ tồn kho thực tế
                    foreach (DataRow r in dtCart.Rows)
                    {
                        string maNGK = r["maNGK"].ToString() ?? "";
                        int slYeuCau = Convert.ToInt32(r["soLuongYeuCau"]);
                        int slGiaoThucTe = Convert.ToInt32(r["soLuongGiaoThucTe"]);
                        double donGia = Convert.ToDouble(r["donGiaBan"]);
                        double thanhTien = Convert.ToDouble(r["thanhTien"]);

                        string sqlCTHD = "INSERT INTO ChiTietHoaDon (soHD, maNGK, soLuongYeuCau, soLuongGiaoThucTe, donGiaBan, thanhTien) " +
                                         "VALUES (@soHD, @maNGK, @slYeuCau, @slGiao, @donGia, @thanhTien)";
                        using (SqlCommand cmd = new SqlCommand(sqlCTHD, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@soHD", soHD);
                            cmd.Parameters.AddWithValue("@maNGK", maNGK);
                            cmd.Parameters.AddWithValue("@slYeuCau", slYeuCau);
                            cmd.Parameters.AddWithValue("@slGiao", slGiaoThucTe);
                            cmd.Parameters.AddWithValue("@donGia", donGia);
                            cmd.Parameters.AddWithValue("@thanhTien", thanhTien);
                            cmd.ExecuteNonQuery();
                        }

                        // Cập nhật giảm tồn kho
                        string sqlCapNhatKho = "UPDATE NuocGiaiKhat SET soLuongTon = soLuongTon - @slGiao WHERE maNGK = @maNGK";
                        using (SqlCommand cmd = new SqlCommand(sqlCapNhatKho, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@slGiao", slGiaoThucTe);
                            cmd.Parameters.AddWithValue("@maNGK", maNGK);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // 3. Nếu có số lượng hẹn -> Tạo Phiếu hẹn & Chi tiết phiếu hẹn
                    if (coHangHen && chkLapPhieuHen.Checked)
                    {
                        string sqlPH = "INSERT INTO PhieuHen (soPhieuHen, ngayLap, ngayHenGiao, trangThai, soHD) VALUES (@soPH, GETDATE(), @ngayHen, N'Chưa giao', @soHD)";
                        using (SqlCommand cmd = new SqlCommand(sqlPH, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@soPH", soPH);
                            cmd.Parameters.AddWithValue("@ngayHen", dtpNgayHenGiao.Value);
                            cmd.Parameters.AddWithValue("@soHD", soHD);
                            cmd.ExecuteNonQuery();
                        }

                        foreach (DataRow r in dtCart.Rows)
                        {
                            int slHen = Convert.ToInt32(r["soLuongHen"]);
                            if (slHen > 0)
                            {
                                string sqlCTPH = "INSERT INTO ChiTietPhieuHen (soPhieuHen, maNGK, soLuongHen) VALUES (@soPH, @maNGK, @slHen)";
                                using (SqlCommand cmd = new SqlCommand(sqlCTPH, conn, transaction))
                                {
                                    cmd.Parameters.AddWithValue("@soPH", soPH);
                                    cmd.Parameters.AddWithValue("@maNGK", r["maNGK"].ToString() ?? "");
                                    cmd.Parameters.AddWithValue("@slHen", slHen);
                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    // 4. Nếu là Khách quen trả chậm -> Tạo Phiếu ghi nợ (BR04)
                    if (radTraCham_GhiNo.Checked)
                    {
                        if (!double.TryParse(txtSoTienNo.Text, out double soTienNo) || soTienNo <= 0)
                        {
                            throw new Exception("Số tiền nợ phải lớn hơn 0!");
                        }

                        string sqlPGN = "INSERT INTO PhieuGhiNo (soPGN, ngayLap, soTienNo, ngayDuKienTra, lyDoNo, trangThai, soHD, maKH, maNV) " +
                                        "VALUES (@soPGN, GETDATE(), @soTienNo, @ngayHenTra, @lyDoNo, N'Chưa thu', @soHD, @maKH, @maNV)";
                        using (SqlCommand cmd = new SqlCommand(sqlPGN, conn, transaction))
                        {
                            cmd.Parameters.AddWithValue("@soPGN", soPGN);
                            cmd.Parameters.AddWithValue("@soTienNo", soTienNo);
                            cmd.Parameters.AddWithValue("@ngayHenTra", dtpNgayDuKienTra.Value);
                            cmd.Parameters.AddWithValue("@lyDoNo", txtLyDoNo.Text);
                            cmd.Parameters.AddWithValue("@soHD", soHD);
                            cmd.Parameters.AddWithValue("@maKH", maKH);
                            cmd.Parameters.AddWithValue("@maNV", currentMaNV);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    // Commit Transaction nếu tất cả thành công
                    transaction.Commit();
                    MessageBox.Show($"Lập hóa đơn {soHD} thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reset giao diện
                    dtCart.Rows.Clear();
                    LoadNuocGiaiKhat();
                    chkLapPhieuHen.Checked = false;
                    radThanhToanNgay.Checked = true;
                    txtSoTienNo.Text = "";
                    txtLyDoNo.Text = "";
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi trong quá trình xử lý hóa đơn: " + ex.Message, "Lỗi Transaction", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}