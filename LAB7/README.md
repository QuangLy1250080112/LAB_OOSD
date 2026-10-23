# Hướng Dẫn Cấu Hình Và Vận Hành Dự Án Quản Lý Nhân Sự
---

## 1. Tóm Tắt Nội Dung Tài Liệu Nghiệp Vụ (`Bai_7_Quan_ly_nhan_su_2.docx`)

Tài liệu nghiệp vụ định nghĩa đầy đủ quy trình vận hành và các quy tắc nghiệp vụ (Business Rules) của hệ thống:

### 1.1. Luồng Nghiệp Vụ Chính

- **Tuyển dụng & Hợp đồng:** Nhân viên mới nhận Quyết định tuyển dụng thử việc ghi rõ thời gian và mức lương thử việc. Hết thời gian thử việc sẽ được ký Hợp đồng lao động (ngắn hạn hoặc dài hạn). Đối với hợp đồng dài hạn, hệ thống khởi tạo và đồng bộ hồ sơ BHYT/BHXH để trích trừ trong bảng lương.
- **Phân công & Chấm công:** Trưởng phòng/phân xưởng lập kế hoạch phân công ca làm việc và kế hoạch phụ trội hằng tuần. Ban chấm công theo dõi chấm công hằng ngày và lập Phiếu ghi nhận giờ phụ trội (tăng ca, ngày lễ, ngày nghỉ) với hệ số x1.5.
- **Quản lý Quyết định:** Quản lý các quyết định điều chỉnh Mức lương cơ bản, Phụ cấp chức vụ/độc hại, Quyết định bổ nhiệm chức vụ, và Quyết định khen thưởng/kỷ luật cho cá nhân hoặc tập thể phòng ban.
- **Tính & Trả lương:** Bộ phận Kế toán tính lương hằng tháng dựa trên ngày công thường, giờ phụ trội (x1.5), phụ cấp, tiền thưởng/phạt và mức trích đóng BHXH/BHYT để ra số tiền Thực lãnh.

### 1.2. Danh Sách Các Thực Thể Dữ Liệu

Hệ thống bao gồm 16 thực thể chính:

1. `PhongBan`: Danh mục các phòng ban, phân xưởng.
2. `ChucVu`: Danh mục chức vụ và phụ cấp chức vụ.
3. `NhanVien`: Quản lý thông tin hồ sơ nhân viên.
4. `QuyetDinhTuyenDung`: Quản lý quyết định tuyển dụng thử việc.
5. `HopDongLaoDong`: Quản lý hợp đồng lao động (Ngắn hạn / Dài hạn).
6. `HoSoBaoHiem`: Hồ sơ trích đóng BHYT/BHXH cho nhân viên hợp đồng dài hạn.
7. `QuyetDinhLuong`: Quản lý mức lương cơ bản và các khoản phụ cấp.
8. `QuyetDinhChucVu`: Quản lý việc bổ nhiệm chức vụ mới.
9. `KeHoachPhanCong`: Lịch phân công ca làm việc hằng tuần theo phòng ban.
10. `ChiTietPhanCong`: Chi tiết ca làm việc hằng ngày của từng nhân viên.
11. `BangChamCong`: Bảng tổng hợp số ngày công thường hằng tháng.
12. `PhieuPhuTroi`: Phiếu ghi nhận phụ trội (Tăng ca, Ngày lễ, Ngày nghỉ) với hệ số x1.5.
13. `ChiTietPhuTroi`: Chi tiết số giờ phụ trội của từng nhân viên.
14. `QuyetDinhKhenThuongKyLuat`: Quyết định thưởng/phạt cá nhân hoặc phòng ban.
15. `PhieuChiThuong_PhieuThuPhat`: Phiếu chi thưởng hoặc thu phạt trực tiếp.
16. `BangLuong`: Bảng tính và tổng hợp lương thực lãnh hằng tháng.

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
2. Mở file kịch bản SQL khởi tạo CSDL (`QuanLyNhanSu_DongA_database.txt`).
3. Thực thi toàn bộ đoạn mã SQL để tạo CSDL `QuanLyNhanSu_DongA`, tạo đầy đủ 16 bảng dữ liệu, các ràng buộc khóa chính/khóa ngoại, ràng buộc CHECK (ví dụ: `heSoPhuTroi = 1.5`, `thucLanh >= 0`) và chèn dữ liệu mẫu.
4. Kiểm tra đảm bảo CSDL `QuanLyNhanSu_DongA` đã tạo thành công với đầy đủ dữ liệu mẫu.

---

## 4. Hướng Dẫn Cấu Hình Và Chạy Dự Án C#

### Bước 1: Mở Solution Trong Visual Studio

- Mở tệp solution `.sln` / `.slnx` hoặc `.csproj` của dự án bằng Visual Studio 2022.

### Bước 2: Cài Đặt Gói Thư Viện Kết Nối CSDL

1. Nhấp chuột phải vào dự án **QuanLyNhanSu_DongA** trong cửa sổ **Solution Explorer**.
2. Chọn **Manage NuGet Packages...**
3. Chuyển sang tab **Browse**, tìm kiếm từ khóa `Microsoft.Data.SqlClient`.
4. Nhấn **Install** để cài đặt thư viện vào dự án.

### Bước 3: Cấu Hình Chuỗi Kết Nối CSDL (`Database.cs`)

Mở file `Database.cs` trong dự án và điều chỉnh thuộc tính `connectionString` khớp với cấu hình SQL Server trên máy tính:

```csharp
private static string connectionString = @"Data Source=.;Initial Catalog=QuanLyNhanSu_DongA;Integrated Security=True;TrustServerCertificate=True";
```

*Trong đó:*

- `Data Source=.`: Tên SQL Server Instance (sử dụng `.` cho Server local, hoặc `.\SQLEXPRESS` đối với bản SQL Express).
- `Initial Catalog=QuanLyNhanSu_DongA`: Tên Cơ sở dữ liệu.
- `Integrated Security=True`: Sử dụng chế độ xác thực Windows.
- `TrustServerCertificate=True`: Cho phép bỏ qua xác thực chứng chỉ SSL.

### Bước 4: Biên Dịch Và Chạy Ứng Dụng

1. Nhấn tổ hợp phím `Ctrl + Shift + B` để Rebuild Solution và kiểm tra lỗi biên dịch.
2. Nhấn `F5` hoặc chọn nút **Start** trên thanh công cụ để khởi chạy ứng dụng.
3. Giao diện chính `FrmMain` cho phép điều hướng trực tiếp đến phân hệ `FrmTiepNhanVaHopDong` để tiếp nhận nhân viên mới và ký hợp đồng.

---

## 5. Cấu Trúc Source Code

```text
QuanLyNhanSu_DongA/
│
├── QuanLyNhanSu_DongA.sln            # File cấu hình Solution
├── QuanLyNhanSu_DongA.csproj         # File cấu hình C# Project
├── Database.cs                       # Class kết nối và thực thi truy vấn SQL Server (Microsoft.Data.SqlClient)
├── FrmMain.cs                        # Form giao diện chính
├── FrmMain.Designer.cs               # Mã thiết kế giao diện Form chính
├── FrmTiepNhanVaHopDong.cs           # Form nghiệp vụ Tiếp nhận Nhân viên & Ký Hợp đồng
└── FrmTiepNhanVaHopDong.Designer.cs  # Mã thiết kế giao diện Form Tiếp nhận & Hợp đồng
```