using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLKhachsan.Services
{
    public class DanhMucService
    {
        public DataTable LayKhuVuc() => Database.ExecuteQuery("SELECT * FROM KhuVuc ORDER BY MaKhuVuc");
        public DataTable LayNhanVien() => Database.ExecuteQuery("SELECT * FROM NhanVien ORDER BY MaNV");
        public DataTable LayLoaiTienNghi() => Database.ExecuteQuery("SELECT * FROM LoaiTienNghi ORDER BY MaLoaiTN");
        public DataTable LayDichVu() => Database.ExecuteQuery("SELECT * FROM DichVu ORDER BY MaDV");
        public DataTable LayQuyDinhDenBu() => Database.ExecuteQuery("SELECT q.*, l.TenLoaiTN FROM QuyDinhDenBu q JOIN LoaiTienNghi l ON q.MaLoaiTN=l.MaLoaiTN ORDER BY q.MaQuyDinh");

        public string ThemKhu(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return "Mã khu vực và tên khu vực không được để trống.";
            try
            {
                Database.ExecuteNonQuery("INSERT INTO KhuVuc VALUES(@m,@t)", new[] { new SqlParameter("@m", ma), new SqlParameter("@t", ten) });
                return "OK:Đã thêm khu vực.";
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string ThemNhanVien(string ma, string ten, string vaiTro, string sdt)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(vaiTro))
                return "Thông tin nhân viên chưa đầy đủ.";
            try
            {
                Database.ExecuteNonQuery("INSERT INTO NhanVien VALUES(@m,@t,@v,@s)", new[] {
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@v", vaiTro),
                    new SqlParameter("@s", (object)sdt ?? DBNull.Value)
                });
                return "OK:Đã thêm nhân viên.";
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string ThemLoaiTN(string ma, string ten)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten))
                return "Thông tin loại tiện nghi chưa đủ.";
            try
            {
                Database.ExecuteNonQuery("INSERT INTO LoaiTienNghi VALUES(@m,@t)", new[] { new SqlParameter("@m", ma), new SqlParameter("@t", ten) });
                return "OK:Đã thêm loại tiện nghi.";
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string ThemDichVu(string ma, string ten, string dvt, decimal gia)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(ten) || string.IsNullOrWhiteSpace(dvt) || gia < 0)
                return "Thông tin dịch vụ không hợp lệ.";
            try
            {
                Database.ExecuteNonQuery("INSERT INTO DichVu VALUES(@m,@t,@d,@g)", new[] {
                    new SqlParameter("@m", ma),
                    new SqlParameter("@t", ten),
                    new SqlParameter("@d", dvt),
                    new SqlParameter("@g", gia)
                });
                return "OK:Đã thêm dịch vụ.";
            }
            catch (Exception ex) { return ex.Message; }
        }

        public string ThemQuyDinh(string ma, string loai, string muc, decimal tien)
        {
            if (string.IsNullOrWhiteSpace(ma) || string.IsNullOrWhiteSpace(loai) || string.IsNullOrWhiteSpace(muc) || tien < 0)
                return "Quy định đền bù không hợp lệ.";
            try
            {
                Database.ExecuteNonQuery("INSERT INTO QuyDinhDenBu VALUES(@m,@l,@u,@t)", new[] {
                    new SqlParameter("@m", ma),
                    new SqlParameter("@l", loai),
                    new SqlParameter("@u", muc),
                    new SqlParameter("@t", tien)
                });
                return "OK:Đã thêm quy định đền bù.";
            }
            catch (Exception ex) { return ex.Message; }
        }
    }
}