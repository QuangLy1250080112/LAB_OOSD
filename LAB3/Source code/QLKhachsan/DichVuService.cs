using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLKhachsan.Services
{
    public class DichVuService
    {
        public DataTable LayPhieuDangO()
            => Database.ExecuteQuery("SELECT d.SoPhieuDat, k.HoTen, c.SoPhong FROM PhieuDatPhong d JOIN KhachHang k ON d.MaKhach=k.MaKhach JOIN ChiTietDatPhong c ON d.SoPhieuDat=c.SoPhieuDat WHERE d.TrangThai=N'Đang ở' ORDER BY d.SoPhieuDat, c.SoPhong");

        public DataTable LayDichVu()
            => Database.ExecuteQuery("SELECT * FROM DichVu ORDER BY MaDV");

        public DataTable LayLichSu(string so)
            => Database.ExecuteQuery(
                "SELECT p.SoPhieuSDDV, p.SoPhong, p.NgaySuDung, d.TenDV, c.SoLuong, c.DonGia, (c.SoLuong * c.DonGia) AS ThanhTien FROM PhieuSuDungDV p JOIN ChiTietPhieuSuDungDV c ON p.SoPhieuSDDV=c.SoPhieuSDDV JOIN DichVu d ON c.MaDV=d.MaDV WHERE p.SoPhieuDat=@s ORDER BY p.NgaySuDung, p.SoPhong, d.TenDV",
                new[] { new SqlParameter("@s", so) });

        public KetQuaXuLy GhiNhan(string soPhieuDat, string soPhong, DateTime ngay, string maNV, string maDV, int soLuong)
        {
            if (string.IsNullOrWhiteSpace(soPhieuDat) || string.IsNullOrWhiteSpace(soPhong) || string.IsNullOrWhiteSpace(maNV) || string.IsNullOrWhiteSpace(maDV) || soLuong <= 0)
                return KetQuaXuLy.Fail("Thông tin sử dụng dịch vụ không hợp lệ.");

            string connStr = @"Data Source=localhost;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True;";
            using (var cn = new SqlConnection(connStr))
            {
                cn.Open();
                using (var tx = cn.BeginTransaction())
                {
                    try
                    {
                        // Kiểm tra phiếu có đang trong trạng thái 'Đang ở'
                        using (var st = new SqlCommand("SELECT TrangThai FROM PhieuDatPhong WHERE SoPhieuDat=@s", cn, tx))
                        {
                            st.Parameters.AddWithValue("@s", soPhieuDat);
                            if (Convert.ToString(st.ExecuteScalar()) != "Đang ở")
                                return KetQuaXuLy.Fail("Chỉ ghi nhận dịch vụ cho phiếu đang lưu trú.");
                        }

                        // Lấy đơn giá dịch vụ
                        decimal gia = 0;
                        using (var g = new SqlCommand("SELECT DonGia FROM DichVu WHERE MaDV=@d", cn, tx))
                        {
                            g.Parameters.AddWithValue("@d", maDV);
                            object og = g.ExecuteScalar();
                            if (og == null) return KetQuaXuLy.Fail("Không tìm thấy dịch vụ.");
                            gia = Convert.ToDecimal(og);
                        }

                        // Kiểm tra xem đã có PhieuSuDungDV cho ngày và phòng này chưa
                        string so = "";
                        using (var f = new SqlCommand("SELECT SoPhieuSDDV FROM PhieuSuDungDV WHERE SoPhieuDat=@s AND SoPhong=@p AND NgaySuDung=@n", cn, tx))
                        {
                            f.Parameters.AddWithValue("@s", soPhieuDat);
                            f.Parameters.AddWithValue("@p", soPhong);
                            f.Parameters.AddWithValue("@n", ngay.Date);
                            so = Convert.ToString(f.ExecuteScalar()) ?? "";
                        }

                        // Nếu chưa có thì tạo phiếu mới
                        if (string.IsNullOrWhiteSpace(so))
                        {
                            so = "SD" + DateTime.Now.ToString("yyyyMMddHHmmssfff");
                            using (var h = new SqlCommand("INSERT INTO PhieuSuDungDV VALUES(@so, @s, @p, @n, @nv)", cn, tx))
                            {
                                h.Parameters.AddWithValue("@so", so);
                                h.Parameters.AddWithValue("@s", soPhieuDat);
                                h.Parameters.AddWithValue("@p", soPhong);
                                h.Parameters.AddWithValue("@n", ngay.Date);
                                h.Parameters.AddWithValue("@nv", maNV);
                                h.ExecuteNonQuery();
                            }
                        }

                        // Kiểm tra dịch vụ đã có trong ChiTietPhieuSuDungDV chưa
                        using (var chk = new SqlCommand("SELECT COUNT(*) FROM ChiTietPhieuSuDungDV WHERE SoPhieuSDDV=@so AND MaDV=@d", cn, tx))
                        {
                            chk.Parameters.AddWithValue("@so", so);
                            chk.Parameters.AddWithValue("@d", maDV);

                            if (Convert.ToInt32(chk.ExecuteScalar()) > 0)
                            {
                                // Đã có: cộng dồn số lượng
                                using (var u = new SqlCommand("UPDATE ChiTietPhieuSuDungDV SET SoLuong=SoLuong+@sl, DonGia=@g WHERE SoPhieuSDDV=@so AND MaDV=@d", cn, tx))
                                {
                                    u.Parameters.AddWithValue("@sl", soLuong);
                                    u.Parameters.AddWithValue("@g", gia);
                                    u.Parameters.AddWithValue("@so", so);
                                    u.Parameters.AddWithValue("@d", maDV);
                                    u.ExecuteNonQuery();
                                }
                            }
                            else
                            {
                                // Chưa có: thêm dòng mới
                                using (var i = new SqlCommand("INSERT INTO ChiTietPhieuSuDungDV VALUES(@so, @d, @sl, @g)", cn, tx))
                                {
                                    i.Parameters.AddWithValue("@so", so);
                                    i.Parameters.AddWithValue("@d", maDV);
                                    i.Parameters.AddWithValue("@sl", soLuong);
                                    i.Parameters.AddWithValue("@g", gia);
                                    i.ExecuteNonQuery();
                                }
                            }
                        }

                        tx.Commit();
                        return KetQuaXuLy.Ok("Đã ghi nhận dịch vụ. Số lượng được cộng dồn nếu cùng sử dụng trong ngày.");
                    }
                    catch (Exception ex)
                    {
                        try { tx.Rollback(); } catch { }
                        return KetQuaXuLy.Fail(ex.Message);
                    }
                }
            }
        }
    }
}