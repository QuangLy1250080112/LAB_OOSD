# HƯỚNG DẪN CẤU HÌNH VÀ VẬN HÀNH HỆ THỐNG QUẢN LÝ CÔNG TY DU LỊCH VĂN HÓA VIỆT

Hệ thống Quản lý Tour Du lịch Văn Hóa Việt được xây dựng trên nền tảng .NET Windows Forms Desktop Application kết hợp với Hệ quản trị cơ sở dữ liệu Microsoft SQL Server, hỗ trợ toàn bộ quy trình nghiệp vụ từ Đăng ký tour, Phân công Điều hành, Quyết toán kinh phí cho đến Khảo sát chất lượng dịch vụ.

---

## 1. DỰ ÁN VÀ TỆP TIN BÀI BÁO CÁO

### 1.1 Tệp tin báo cáo Word

Tệp tin báo cáo phân tích thiết kế hệ thống bao gồm đầy đủ mô tả nghiệp vụ, biểu đồ lớp (Class Diagram), biểu đồ Use Case tổng quát và chi tiết, biểu đồ hoạt động (Activity Diagram) và biểu đồ tuần tự (Sequence Diagram):

### 1.2 Cấu trúc dự án nguồn (.NET C# WinForms)

- Tệp Solution: QLCtyDuLich.slnx (Mở trực tiếp bằng Microsoft Visual Studio 2022).
- Tệp Project: QLCtyDuLich.csproj.
- Các tệp mã nguồn chính:
  - Database.cs: Lớp xử lý truy vấn dữ liệu SQL Server (sử dụng thư viện Microsoft.Data.SqlClient).
  - FrmMain.cs & FrmMain.Designer.cs: Màn hình chính dạng Dashboard điều hướng hệ thống.
  - FrmDangKyTour.cs & FrmDangKyTour.Designer.cs: Màn hình Đăng ký Tour lẻ (<12 người) và Tour đoàn (≥12 người).
  - FrmDieuHanhVaQuyetToan.cs & FrmDieuHanhVaQuyetToan.Designer.cs: Màn hình Phân công Hướng dẫn viên và Quyết toán Tour đoàn.
  - FrmKhaoSatTour.cs & FrmKhaoSatTour.Designer.cs: Màn hình Khách hàng gửi khảo sát và Nhân viên tổng hợp đánh giá.

---

## 2. CÔNG NGHỆ VÀ YÊU CẦU MÔI TRƯỜNG

- Hệ điều hành: Microsoft Windows 10/11 (64-bit).
- Môi trường phát triển: Microsoft Visual Studio 2022 (cài đặt workload .NET Desktop Development).
- Hệ quản trị cơ sở dữ liệu: Microsoft SQL Server 2022 (SQL Server Express hoặc Developer Edition).
- Thư viện kết nối CSDL: Microsoft.Data.SqlClient (Phiên bản hỗ trợ TrustServerCertificate=True).
- Target Framework: .NET 8.0 / .NET Framework 4.8 Desktop Application.

---

## 3. HƯỚNG DẪN CẤU HÌNH CƠ SỞ DỮ LIỆU SQL SERVER

### Bước 1: Khởi tạo Cơ sở dữ liệu và Các Bảng

1. Mở phần mềm Microsoft SQL Server Management Studio (SSMS).
2. Kết nối tới SQL Server Instance local (ví dụ: . hoặc localhost hoặc .\SQLEXPRESS).
3. Mở tệp kịch bản SQL có tên QLCtyDuLich.sql.
4. Nhấn Execute (hoặc phím F5) để khởi tạo database QLCtyDuLich cùng 10 bảng dữ liệu chính:
   - User: Lưu thông tin tài khoản chung (userID, username, passwordHash, fullName, role).
   - Customer: Khách hàng kế thừa từ User (userID, identityCard).
   - Staff: Nhân viên kế thừa từ User (userID, position).
   - Tour: Danh mục tour du lịch (tourID, tourName, standardPrice).
   - ChuyenDiLe: Lịch khởi hành tour lẻ (chuyenID, tourID, departureDate, availableSlots).
   - VeTourLe: Thông tin vé bán lẻ (veID, customerID, chuyenID, staffID, pickupPoint, totalPrice).
   - PhieuDangKyDoan: Thông tin phiếu tour đoàn (phieuID, customerID, tourID, staffID, departureDateReq, groupSize, depositAmount).
   - DanhSachBaoHiem: Danh sách thành viên tham gia bảo hiểm đoàn (danhSachID, phieuID, memberName, insuranceCode).
   - PhanCongHDV: Lịch phân công hướng dẫn viên (phanCongID, staffID, assignedDate, chuyenID, phieuID).
   - PhieuKhaoSat: Dữ liệu đánh giá chất lượng tour (khaoSatID, customerID, tourID, ratingScore, comment).

### Bước 2: Cấu hình Chuỗi kết nối (Connection String) trong C#

1. Mở dự án trong Visual Studio 2022.
2. Mở tệp mã nguồn Database.cs.
3. Chỉnh sửa tham số Data Source trong chuỗi kết nối connectionString phù hợp với tên Server thực tế:

```csharp
private static string connectionString = @"Data Source=.;Initial Catalog=QLCtyDuLich;Integrated Security=True;TrustServerCertificate=True";
```

_Lưu ý: Nếu dùng SQL Server Express, thay Data Source=. thành Data Source=.\SQLEXPRESS._

---

## 4. HƯỚNG DẪN BIÊN DỊCH VÀ CHẠY ỨNG DỤNG WINDOWS FORMS

1. Khởi động Visual Studio 2022 và chọn Open a project or solution, mở tệp QLCtyDuLich.slnx.
2. Nhấn tổ hợp phím Ctrl + Shift + B để tiến hành Biên dịch dự án (Build Solution).
3. Nhấn phím F5 (hoặc nút Start) để khởi chạy ứng dụng.
4. Màn hình điều hướng FrmMain xuất hiện với các nút chức năng chính trên Sidebar bên trái:
   - 1. Đăng ký Tour: Thao tác bán vé tour lẻ và lập phiếu đăng ký tour đoàn.
   - 2. Điều hành & Quyết toán: Thực hiện phân công Hướng dẫn viên (kiểm tra trùng lịch) và quyết toán kinh phí tour đoàn.
   - 3. Khảo sát chất lượng: Khách hàng nhập đánh giá và Nhân viên xem báo cáo tổng hợp điểm trung bình chất lượng tour.

---

## 5. MÔ TẢ NỘI DUNG FILE WORD

Nội dung bài báo cáo chi tiết bao gồm:

1. Mô tả bài toán nghiệp vụ: Tin học hóa quản lý đăng ký tour du lịch xuất phát từ TP.HCM cho Công ty Văn Hóa Việt (Xử lý tour lẻ <12 người, tour đoàn ≥12 người, tiền cọc, bảo hiểm, phân công HDV, quyết toán kinh phí và gửi phiếu khảo sát).
2. Thiết kế Biểu đồ Lớp (Class Diagram): Xác định thuộc tính, phương thức và mối quan hệ giữa các lớp User, Customer, Staff, Tour, ChuyenDiLe, VeTourLe, PhieuDangKyDoan, DanhSachBaoHiem, PhanCongHDV, PhieuKhaoSat.
3. Thiết kế Biểu đồ Use Case (Use Case Diagram): Xác định 3 Actor (Khách hàng, Nhân viên, Admin) và vẽ Use Case tổng quát cũng như phân rã chi tiết toàn bộ quy trình nghiệp vụ.
4. Thiết kế Biểu đồ Hoạt động (Activity Diagram): Mô tả chi tiết luồng xử lý song song giữa Khách hàng/Nhân viên và Hệ thống từ bước đăng ký đến khảo sát chất lượng.
5. Thiết kế Biểu đồ Tuần tự (Sequence Diagram): Mô tả tương tác chi tiết cho nghiệp vụ "Lập phiếu đăng ký Tour đoàn".
6. Thiết kế Giao diện WinForms: Bảng mô tả thuộc tính và danh sách các Control cho các Form FrmMain, FrmDangKyTour, FrmDieuHanhVaQuyetToan, FrmKhaoSatTour.
