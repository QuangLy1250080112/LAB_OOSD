# Hướng Dẫn Cấu Hình Và Vận Hành Dự Án Quản Lý Hồ Sơ Bệnh Án

Dự án **Quản Lý Hồ Sơ Bệnh Án** là hệ thống phần mềm quản lý thông tin bệnh nhân, lịch hẹn khám định kỳ, quá trình khám bệnh, xét nghiệm, kê toa thuốc và thanh toán viện phí dành cho bệnh viện đa khoa. Hệ thống được phát triển trên nền tảng **C# Windows Forms** và lưu trữ dữ liệu tập trung trên **Microsoft SQL Server**.

---

## 1. Tóm Tắt Nội Dung Tài Liệu Nghiệp Vụ (`LAB06_BùiNgôQuangLý_1250080112_CNPM2_PPPTPMHDTn.docx`)

Tài liệu nghiệp vụ định nghĩa đầy đủ quy trình vận hành và các yêu cầu kỹ thuật của hệ thống:

### 1.1. Luồng Nghiệp Vụ Chính

- **Đăng ký & Cấp Hồ sơ:** Bệnh nhân lần đầu đến khám được lập Phiếu đăng ký, đóng lệ phí hằng năm và cấp Hồ sơ bệnh án với mã định danh duy nhất (`maHoSo`).
- **Đặt lịch hẹn:** Bệnh nhân đã cấp hồ sơ có quyền lợi đặt lịch hẹn khám sức khỏe định kỳ theo quý.
- **Khám bệnh & Điều trị:** Bác sĩ tra cứu lịch sử bệnh án, ghi nhận triệu chứng lâm sàng, chỉ định xét nghiệm, chẩn đoán bệnh lý và lập toa thuốc điều trị.
- **Thanh toán & Xuất viện:** Bộ phận thu ngân tính toán chi phí viện phí, cập nhật trạng thái hóa đơn trước khi lưu trữ dữ liệu chính thức.

### 1.2. Danh Sách Các Thực Thể Dữ Liệu

Hệ thống bao gồm 11 thực thể chính:

1. `PhieuDangKy`: Lưu thông tin hành chính của bệnh nhân.
2. `HoSoBenhAn`: Lưu thông tin hồ sơ và trạng thái hạn lệ phí năm.
3. `LichHenKham`: Quản lý các cuộc hẹn khám định kỳ.
4. `BacSi`: Danh mục bác sĩ điều trị.
5. `KhoaDieuTri`: Danh mục các khoa phòng trong bệnh viện.
6. `PhieuKhamBenh`: Ghi nhận nhật ký từng đợt khám.
7. `XetNghiem`: Chỉ định và kết quả xét nghiệm cận lâm sàng.
8. `ToaThuoc`: Thông tin đơn thuốc đính kèm phiếu khám.
9. `Thuoc`: Danh mục thuốc khả dụng.
10. `ChiTietToaThuoc`: Chi tiết số lượng và liều dùng từng loại thuốc.
11. `HoaDonVienPhi`: Tính toán và ghi nhận thanh toán viện phí.

---

## 2. Yêu Cầu Môi Trường Phát Triển

Để biên dịch và vận hành dự án, máy tính phát triển cần cài đặt các công cụ sau:

- **Hệ điều hành:** Microsoft Windows 10 / Windows 11 (64-bit).
- **Môi trường tích hợp (IDE):** Microsoft Visual Studio 2022 (phiên bản Community, Professional hoặc Enterprise) có cài đặt khối công việc **.NET desktop development**.
- **Hệ quản trị Cơ sở Dữ liệu:** Microsoft SQL Server 2019 / 2022 (phiên bản Developer, Express hoặc Enterprise).
- **Công cụ quản lý CSDL:** SQL Server Management Studio (SSMS) hoặc Azure Data Studio.
- **Thư viện kết nối CSDL:** Gói NuGet `Microsoft.Data.SqlClient` (phiên bản 5.0.0 trở lên).

---

## 3. Hướng Dẫn Khởi Tạo Cơ Sở Dữ Liệu SQL Server

1. Mở công cụ **SQL Server Management Studio (SSMS)** và kết nối tới SQL Server Instance địa phương.
2. Mở file kịch bản SQL khởi tạo CSDL (`QuanLyHoSoBenhAn.sql`).
3. Thực thi toàn bộ đoạn mã SQL để tạo CSDL `QuanLyHoSoBenhAn`, tạo toàn bộ 11 bảng dữ liệu, các ràng buộc khóa chính/khóa ngoại, ràng buộc CHECK và chèn dữ liệu mẫu.
4. Kiểm tra đảm bảo CSDL `QuanLyHoSoBenhAn` đã tạo thành công với đầy đủ dữ liệu mẫu.

---

## 4. Hướng Dẫn Cấu Hình Và Chạy Dự Án C#

### Bước 1: Mở Solution Trong Visual Studio

- Mở tệp solution `QuanLyHoSoBenhAn.slnx` hoặc `QuanLyHoSoBenhAn.csproj` bằng Visual Studio 2022.

### Bước 2: Cài Đặt Gói Thư Viện Kết Nối CSDL

1. Nhấp chuột phải vào dự án **QuanLyHoSoBenhAn** trong cửa sổ **Solution Explorer**.
2. Chọn **Manage NuGet Packages...**
3. Chuyển sang tab **Browse**, tìm kiếm từ khóa `Microsoft.Data.SqlClient`.
4. Nhấn **Install** để cài đặt thư viện vào dự án.

### Bước 3: Cấu Hình Chuỗi Kết Nối CSDL (`Database.cs`)

Mở file `Database.cs` trong dự án và điều chỉnh thuộc tính `connectionString` khớp với cấu hình SQL Server trên máy tính:

```csharp
private static string connectionString = @"Data Source=.;Initial Catalog=QuanLyHoSoBenhAn;Integrated Security=True;TrustServerCertificate=True";
```

_Trong đó:_

- `Data Source=.`: Tên SQL Server Instance (sử dụng `.` cho Server local, hoặc `.\SQLEXPRESS` đối với bản SQL Express).
- `Initial Catalog=QuanLyHoSoBenhAn`: Tên Cơ sở dữ liệu.
- `Integrated Security=True`: Sử dụng chế độ xác thực Windows.
- `TrustServerCertificate=True`: Cho phép bỏ qua xác thực chứng chỉ SSL.

### Bước 4: Biên Dịch Và Chạy Ứng Dụng

1. Nhấn tổ hợp phím `Ctrl + Shift + B` để Rebuild Solution và kiểm tra lỗi biên dịch.
2. Nhấn `F5` hoặc chọn nút **Start** trên thanh công cụ để khởi chạy ứng dụng.
3. Giao diện chính `FrmMain` hiển thị, cho phép điều hướng truy cập phân hệ `FrmTiepNhanDangKy` để đăng ký bệnh nhân mới và đặt lịch hẹn khám.

---

## 5. Cấu Trúc Source Code

```text
QuanLyHoSoBenhAn/
│
├── QuanLyHoSoBenhAn.slnx             # File cấu hình Solution
├── QuanLyHoSoBenhAn.csproj           # File cấu hình C# Project
├── Database.cs                        # Class kết nối và thực thi truy vấn SQL Server
├── FrmMain.cs                         # Form giao diện chính (Ribbon Tab tối giản)
├── FrmMain.Designer.cs                # Mã thiết kế giao diện Form chính
├── FrmTiepNhanDangKy.cs              # Form nghiệp vụ Đăng ký Bệnh nhân & Đặt lịch hẹn
├── FrmTiepNhanDangKy.Designer.cs     # Mã thiết kế giao diện Form Tiếp nhận
```
