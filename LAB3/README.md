# HƯỚNG DẪN ĐÁNH GIÁ VÀ VẬN HÀNH BÀI BÁO CÁO LAB 03

**HỆ THỐNG QUẢN LÝ KHÁCH SẠN**

---

## THÔNG TIN CHUNG

- **Họ và tên:** Bùi Ngô Quang Lý
- **Mã số sinh viên:** 1250080112
- **Lớp:** 12_ĐH_CNPM2
- **Học phần:** Phương pháp Phát triển Phần mềm Hướng đối tượng

---

## TỔNG QUAN HỆ THỐNG

Dự án được xây dựng trên nền tảng .NET Windows Forms (C#) kết hợp Cơ sở dữ liệu SQL Server. Hệ thống áp dụng mô hình kiến trúc phân lớp nhằm tách biệt logic xử lý nghiệp vụ và thao tác dữ liệu:
`WinForms UI -> Service / Business Logic -> Data Layer (Database.cs) -> SQL Server`.

---

## CẤU TRÚC CƠ SỞ DỮ LIỆU

Cơ sở dữ liệu `QuanLyKhachSan` bao gồm 18 bảng nghiệp vụ:

| Bảng                     | Khóa chính                   | Vai trò nghiệp vụ                                         |
| :----------------------- | :--------------------------- | :-------------------------------------------------------- |
| **NhanVien**             | `MaNV`                       | Quản lý thông tin nhân viên hệ thống.                     |
| **KhuVuc**               | `MaKhuVuc`                   | Khai báo các khu vực phòng trong khách sạn.               |
| **Phong**                | `SoPhong`                    | Thông tin phòng, sức chứa, đơn giá ngày và trạng thái.    |
| **LoaiTienNghi**         | `MaLoaiTN`                   | Phân loại các nhóm thiết bị tiện nghi.                    |
| **TienNghi**             | `MaTienNghi`                 | Danh mục thiết bị tiện nghi cụ thể.                       |
| **PhieuLapDat**          | `SoPhieuLapDat`              | Theo dõi lịch sử lắp đặt thiết bị vào phòng.              |
| **KhachHang**            | `MaKhach`                    | Quản lý thông tin khách hàng đăng ký.                     |
| **PhieuDatPhong**        | `SoPhieuDat`                 | Quản lý thông tin đặt phòng, nhận phòng và trả phòng.     |
| **ChiTietDatPhong**      | `SoPhieuDat`, `SoPhong`      | Chi tiết phòng chọn và số lượng khách.                    |
| **NguoiLuuTru**          | `MaNguoiLT`                  | Thông tin cá nhân người ở thực tế.                        |
| **DichVu**               | `MaDV`                       | Danh mục dịch vụ cung cấp.                                |
| **PhieuSuDungDV**        | `SoPhieuSDDV`                | Phiếu ghi nhận dịch vụ theo phòng và ngày.                |
| **ChiTietPhieuSuDungDV** | `SoPhieuSDDV`, `MaDV`        | Chi tiết số lượng và thành tiền dịch vụ.                  |
| **QuyDinhDenBu**         | `MaQuyDinh`                  | Định mức bồi thường theo loại thiết bị và mức độ hư hỏng. |
| **PhieuDenBu**           | `SoPhieuDenBu`               | Thông tin phiếu bồi thường vi phạm/hư hại.                |
| **ChiTietPhieuDenBu**    | `SoPhieuDenBu`, `MaTienNghi` | Chi tiết danh mục thiết bị hư hỏng.                       |
| **HoaDon**               | `SoHoaDon`                   | Hóa đơn tổng hợp tiền phòng và tiền dịch vụ.              |
| **ThanhToan**            | `MaThanhToan`                | Ghi nhận thông tin giao dịch thanh toán.                  |

---

## BẢNG CHỨC NĂNG VÀ GIAO DIỆN

Hệ thống gồm 7 màn hình chức năng chính với luồng điều hướng như sau:

- **FrmMain**: Màn hình điều hướng trung tâm dành cho nhân viên vận hành, kết nối trực tiếp đến các chức năng chính:
  - **FrmDanhMuc**: Quản lý các danh mục nền bao gồm Khu vực, Nhân viên, Loại tiện nghi, Dịch vụ và Quy định đền bù.
  - **FrmPhongTienNghi**: Quản lý danh sách phòng, thiết bị tiện nghi và các phiếu lắp đặt/luân chuyển thiết bị.
  - **FrmDatPhong**: Thực hiện quy trình lập phiếu đặt phòng, nhận thông tin khách hàng và check-in.
  - **FrmDichVu**: Ghi nhận chi tiết các dịch vụ phát sinh trong quá trình lưu trú.Từ màn hình dịch vụ tiếp tục chuyển sang:
    - **FrmTraPhong**: Kiểm tra thiết bị, lập phiếu đền bù (nếu có), tính toán hóa đơn và thanh toán trả phòng. Sau đó điều hướng đến:
      - **FrmThongKe**: Tổng hợp báo cáo doanh thu, lượt phòng và thống kê tần suất sử dụng dịch vụ.

---

## HƯỚNG DẪN CÀI ĐẶT VÀ KHỞI CHẠY

### 1. Chuẩn bị môi trường

- Microsoft Visual Studio (phiên bản hỗ trợ .NET 8.0 / .NET 9.0 trở lên).
- Microsoft SQL Server Management Studio (SSMS) hoặc SQL Server Express.

### 2. Thiết lập CSDL

1. Mở file `Database/QuanLyKhachSan.sql` trong SQL Server Management Studio.
2. Thực thi toàn bộ script để khởi tạo Database, các bảng, ràng buộc khóa ngoại và dữ liệu mẫu.

### 3. Khai báo chuỗi kết nối

Mở file `Database.cs` trong project C# và cập nhật chuỗi kết nối phù hợp với Server Name của máy:

```csharp
private static string connectionString = @"Data Source=YOUR_SERVER_NAME;Initial Catalog=QuanLyKhachSan;Integrated Security=True;TrustServerCertificate=True;";

### 4. Biên dịch và thực thi
1. Mở solution QLKhachsan.sln bằng Visual Studio.
2. Chọn Rebuild Solution để khôi phục các gói dependency.
3. Nhấn F5 hoặc chọn Start để chạy ứng dụng.
