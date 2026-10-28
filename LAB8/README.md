# HƯỚNG DẪN CẤU HÌNH VÀ VẬN HÀNH DỰ ÁN

# HỆ THỐNG QUẢN LÝ CỬA HÀNG NƯỚC GIẢI KHÁT

---

## 1. Tóm Tắt Nội Dung Nghiệp Vụ (`Bai_8_Cua_hang_nuoc_giai_khat_4.docx`)

Tài liệu nghiệp vụ định nghĩa đầy đủ quy trình vận hành và các quy tắc nghiệp vụ (Business Rules - BR) của hệ thống:

### 1.1. Luồng Nghiệp Vụ Chính

- **Quản lý Nhập hàng NCC:**
  - Nhân viên lập Đơn đặt hàng (ĐĐH) gửi Nhà cung ứng.

  - Mỗi ĐĐH có thể được giao tối đa 03 đợt.

  - Mỗi đợt giao kèm một Phiếu giao hàng (PGH) để đối soát và tự động cộng tăng số lượng tồn kho.

- **Bán hàng & Hẹn giao đợt:**
  - Hệ thống tự động kiểm tra số lượng tồn kho khi bán hàng.

  - **Đủ kho:** Giao hàng ngay và lập Hóa đơn thanh toán.

  - **Thiếu kho:**
    - _Khách quen:_ Lập Hóa đơn toàn bộ và tạo Phiếu hẹn giao nhiều đợt.

    - _Khách vãng lai:_ Chỉ bán và thanh toán tối đa theo số lượng tồn kho thực tế.

- **Thanh toán & Công nợ (Ghi nợ):**
  - _Khách vãng lai:_ Bắt buộc thanh toán 100% tiền mặt/chuyển khoản ngay tại cửa hàng.

  - _Khách quen:_ Cho phép trả chậm bằng cách lập Phiếu ghi nợ liên kết trực tiếp với Hóa đơn mua hàng.

### 1.2. Quy Tắc Nghiệp Vụ Trọng Yếu (Business Rules - BR)

- **BR01:** Mỗi mặt hàng Nước giải khát (NGK) thuộc 01 Nhãn hiệu và chỉ do 01 Nhà cung ứng duy nhất cung cấp.

- **BR02:** Mỗi Đơn đặt hàng (ĐĐH) gửi tới NCC có thể được giao tối đa 03 đợt phiếu giao hàng.

- **BR03:** Khi bán hàng bị thiếu kho:
  - Khách quen: Tách giao ngay và lập Phiếu hẹn giao đợt sau.

  - Khách vãng lai: Chỉ bán tối đa theo số lượng tồn kho hiện có.

- **BR04:** Khách vãng lai bắt buộc thanh toán 100% ngay. Khách quen mới được phép trả chậm qua Phiếu ghi nợ.

- **BR05:** Tồn kho tự động cộng tăng khi nhận PGH từ NCC và trừ giảm khi lập Hóa đơn/giao hàng thành công.

### 1.3. Danh Sách Các Bảng Dữ Liệu (14 Bảng)

1. `LoaiNGK`: Danh mục nhãn hiệu / loại nước giải khát.

2. `NhaCungCap`: Thông tin các nhà cung ứng.

3. `NhanVien`: Quản lý thông tin nhân viên cửa hàng.

4. `KhachHang`: Danh sách khách hàng (Phân loại: 'Quen' / 'VangLai').

5. `NuocGiaiKhat`: Danh mục sản phẩm, đơn giá và số lượng tồn kho.

6. `DonDatHang`: Đơn đặt hàng gửi tới Nhà cung ứng.

7. `ChiTietDonDatHang`: Chi tiết mặt hàng và số lượng đặt NCC.

8. `PhieuGiaoHang`: Phiếu giao hàng theo đợt từ NCC (Tối đa 3 đợt).

9. `ChiTietPhieuGiaoHang`: Chi tiết mặt hàng thực giao từng đợt.

10. `HoaDon`: Hóa đơn tính tiền bán hàng cho khách.

11. `ChiTietHoaDon`: Chi tiết các mặt hàng bán, SL yêu cầu và SL thực giao.

12. `PhieuHen`: Phiếu hẹn giao đợt sau cho Khách quen khi thiếu kho.

13. `ChiTietPhieuHen`: Chi tiết các mặt hàng hẹn giao đợt sau.

14. `PhieuGhiNo`: Phiếu ghi nhận công nợ trả chậm cho Khách quen.

---

## 2. Yêu Cầu Môi Trường Phát Triển

Để biên dịch và vận hành dự án, máy tính phát triển cần cài đặt các công cụ:

- **Hệ điều hành:** Microsoft Windows 10 / Windows 11 (64-bit).

- **Môi trường tích hợp (IDE):** Microsoft Visual Studio 2022 (khối công việc **.NET desktop development**).

- **Hệ quản trị CSDL:** Microsoft SQL Server 2019 / 2022 (Express, Developer hoặc Enterprise).

- **Công cụ quản lý CSDL:** SQL Server Management Studio (SSMS) hoặc Azure Data Studio.

- **Thư viện kết nối CSDL:** Gói NuGet `Microsoft.Data.SqlClient` (phiên bản 5.0.0 trở lên).

---

## 3. Hướng Dẫn Khởi Tạo Cơ Sở Dữ Liệu SQL Server

1. Khởi động công cụ **SQL Server Management Studio (SSMS)** và kết nối tới SQL Server Instance địa phương.

2. Mở file kịch bản SQL khởi tạo CSDL (`QLCuaHangNGK.sql` hoặc `QLCuaHangNGK_database.txt`).

3. Thực thi (Execute) toàn bộ đoạn mã SQL để:
   - Khởi tạo Cơ sở dữ liệu `QLCuaHangNGK`.

   - Tạo đầy đủ 14 bảng dữ liệu với các ràng buộc Khóa chính (PK), Khóa ngoại (FK).

   - Thiết lập các ràng buộc CHECK quan trọng:
     - `dotGiao IN (1, 2, 3)`

     - `loaiKhach IN ('Quen', 'VangLai')`

     - `soLuongTon >= 0`

     - `soTienNo > 0`

   - Nạp dữ liệu mẫu thử nghiệm chuẩn nghiệp vụ.

4. Kiểm tra đảm bảo CSDL `QLCuaHangNGK` đã tạo thành công với đầy đủ 14 bảng dữ liệu.

---

## 4. Hướng Dẫn Cấu Hình Và Chạy Dự Án C# WinForms

### Bước 1: Mở Solution Trong Visual Studio

- Nhấp đôi vào tệp solution `QLCuaHangNGK.slnx` hoặc `QLCuaHangNGK.sln` để mở dự án bằng Visual Studio 2022.

### Bước 2: Cài Đặt Gói Thư Viện Kết Nối CSDL

1. Nhấp chuột phải vào dự án **QLCuaHangNGK** trong cửa sổ **Solution Explorer**.

2. Chọn **Manage NuGet Packages...**

3. Chuyển sang tab **Browse**, tìm kiếm từ khóa `Microsoft.Data.SqlClient`.

4. Nhấn **Install** để cài đặt thư viện vào dự án.

### Bước 3: Cấu Hình Chuỗi Kết Nối CSDL (`Database.cs`)

Mở file `Database.cs` trong dự án và điều chỉnh thuộc tính `connectionString` khớp với cấu hình SQL Server trên máy tính:

```csharp

private static string connectionString =

    "Data Source=localhost;" +

    "Initial Catalog=QLCuaHangNGK;" +

    "Integrated Security=True;" +

    "TrustServerCertificate=True;";

```

_Trong đó:_

- `Data Source=localhost`: Tên SQL Server Instance (có thể đổi thành `.\SQLEXPRESS` đối với bản SQL Express).

- `Initial Catalog=QLCuaHangNGK`: Tên Cơ sở dữ liệu.

- `Integrated Security=True`: Sử dụng chế độ xác thực tài khoản Windows.

- `TrustServerCertificate=True`: Cho phép bỏ qua xác thực chứng chỉ SSL.

### Bước 4: Kiểm Tra Đồng Bộ Namespace

Đảm bảo tất cả các file mã nguồn C# đều sử dụng chung một không gian tên:

```csharp

namespace QLCuaHangNGK

```

Danh sách các file cần kiểm tra đồng bộ:

- `Program.cs`

- `Database.cs`

- `FrmMain.cs` & `FrmMain.Designer.cs`

- `FrmBanHang_GhiNo.cs` & `FrmBanHang_GhiNo.Designer.cs`

### Bước 5: Biên Dịch Và Khởi Chạy Ứng Dụng

1. Nhấn tổ hợp phím `Ctrl + Shift + B` để Rebuild Solution và kiểm tra lỗi biên dịch.

2. Nhấn `F5` hoặc chọn nút **Start** trên thanh công cụ để khởi chạy ứng dụng.

3. Giao diện chính `FrmMain` sẽ tự động nhúng màn hình bán hàng `FrmBanHang_GhiNo` để bắt đầu thao tác nghiệp vụ.

---

## 5. Cấu Trúc Source Code Dự Án

```text

QLCuaHangNGK/

│

├── QLCuaHangNGK.slnx             # File cấu hình Solution Visual Studio 2022

├── QLCuaHangNGK.csproj           # File cấu hình C# Project WinForms

├── QLCuaHangNGK.sql              # Script SQL Server xuất từ SSMS

├── QLCuaHangNGK_database.txt     # Script SQL tạo CSDL & dữ liệu mẫu

├── Database.cs                   # Class hỗ trợ kết nối & thực thi SQL Server

├── Program.cs                    # Điểm khởi chạy ứng dụng (Main Entry Point)

├── FrmMain.cs                    # Code xử lý Form giao diện chính

├── FrmMain.Designer.cs           # Code thiết kế giao diện Form chính (Excel Style)

├── FrmBanHang_GhiNo.cs           # Code xử lý Bán hàng, Trừ kho, Hẹn giao & Lập phiếu nợ

└── FrmBanHang_GhiNo.Designer.cs  # Code thiết kế Form Bán hàng & Ghi nợ (Chuẩn 760 x 280)

```
