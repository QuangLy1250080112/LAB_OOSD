using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace QLKhachsan.Services
{
    public class ThongKeService
    {
        public DataTable TongHop(DateTime tu, DateTime den)
        {
            string sql = @"SELECT 
                (SELECT COUNT(*) FROM PhieuDatPhong WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS SoPhieuDat,
                (SELECT COUNT(*) FROM PhieuDatPhong WHERE TrangThai=N'Đang ở') AS DangO,
                (SELECT COUNT(*) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS SoHoaDon,
                (SELECT ISNULL(SUM(TienPhong + TienDichVu),0) FROM HoaDon WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS DoanhThuHoaDon,
                (SELECT ISNULL(SUM(TongTien),0) FROM PhieuDenBu WHERE CAST(NgayLap AS date) BETWEEN @tu AND @den) AS TongDenBu";

            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@tu", tu.Date),
                new SqlParameter("@den", den.Date)
            };

            return Database.ExecuteQuery(sql, pars);
        }

        public DataTable DichVu(DateTime tu, DateTime den)
        {
            string sql = @"SELECT 
                d.MaDV, d.TenDV, SUM(c.SoLuong) AS TongSoLuong, SUM(c.SoLuong * c.DonGia) AS TongTien 
                FROM PhieuSuDungDV p 
                JOIN ChiTietPhieuSuDungDV c ON p.SoPhieuSDDV=c.SoPhieuSDDV 
                JOIN DichVu d ON c.MaDV=d.MaDV 
                WHERE CAST(p.NgaySuDung AS date) BETWEEN @tu AND @den 
                GROUP BY d.MaDV, d.TenDV 
                ORDER BY TongTien DESC";

            SqlParameter[] pars = new SqlParameter[]
            {
                new SqlParameter("@tu", tu.Date),
                new SqlParameter("@den", den.Date)
            };

            return Database.ExecuteQuery(sql, pars);
        }
    }
}