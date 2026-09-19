# HỆ THỐNG QUẢN LÝ THƯ VIỆN (WINFORMS & C#)

> **Bài tập môn Phương pháp phát triển phần mềm hướng đối tượng**  
> _Phân tích yêu cầu, Thiết kế UML, Cơ sở dữ liệu SQL Server đến Cài đặt giao diện C# WinForms._

---

## 👤 THÔNG TIN SINH VIÊN

- **Họ và tên:** Bùi Ngô Quang Lý
- **Mã số sinh viên (MSSV):** 1250080112
- **Lớp:** 12_ĐH_CNPM2
- **Ngày thực hiện:** 18/09/2026

---

## BÀI BÁO CÁO FILE WORD

Để nắm bắt toàn bộ nội dung tài liệu báo cáo một cách hiệu quả, có thể xem trực tiếp tệp Word trong thư mục hoặc theo dõi lộ trình đọc theo các phần chính dưới đây:

### 1. Tóm tắt nội dung bài tập trong file Word

Tài liệu báo cáo trình bày trọn vẹn chu trình phát triển phần mềm cho **Hệ thống Quản lý Thư viện**, bao gồm:

1. **Khảo sát hiện trạng & Xác định yêu cầu:**
   - Phân loại nghiệp vụ theo dạng Đầu vào - Xử lý - Kết xuất.
   - Bảng danh sách các Quy tắc nghiệp vụ (**Business Rules - BR01 đến BR13**) quy định các điều kiện mượn/trả sách, cấp thẻ, xử lý phạt, v.v.
2. **Phân tích thiết kế hệ thống (UML):**
   - **Use Case Diagram:** Xác định các Actor (_Thủ thư, Nhân viên quản lý sách, Độc giả_) và chức năng hệ thống.
   - **Đặc tả Use Case:** Chi tiết cho các luồng nghiệp vụ chính (đặc biệt là Use Case Mượn sách).
   - **Class Diagram & Activity Diagram:** Biểu diễn mô hình lớp và luồng hoạt động có phân chia làn (swimlane).
   - **Sequence Diagram:** Trình bày chi tiết tương tác giữa Giao diện (Form), Lớp xử lý (Service) và Cơ sở dữ liệu (SQL Server).
3. **Thiết kế Cơ sở dữ liệu (CSDL):**
   - Thiết kế các bảng: `NhanVien`, `TheLoai`, `NhaXuatBan`, `DauSach`, `DocGia`, `TheDocGia`, `PhieuMuon`, `ChiTietPhieuMuon`, `PhieuPhat`.
   - Thiết lập đầy đủ khóa chính, khóa ngoại và các ràng buộc toàn vẹn (`CHECK`, `UNIQUE`, `Transaction Serializable`).
   - Đính kèm mã nguồn script T-SQL khởi tạo CSDL.
4. **Thiết kế & Kết nối Giao diện (WinForms C#):**
   - Sơ đồ điều hướng Form hệ thống.
   - Chi tiết thiết kế các màn hình:
     - `FrmMain`: Trang chủ điều hướng.
     - `FrmSach`: Quản lý danh mục đầu sách.
     - `FrmDocGia`: Quản lý thông tin độc giả và cấp/gia hạn thẻ.
     - `FrmMuonTra`: Lập phiếu mượn, nhận trả sách và tính phí phạt.
   - Đính kèm ảnh chụp phác thảo giao diện và hình ảnh thực tế chạy chương trình đã kết nối dữ liệu thành công.

---

### 2. Cấu trúc gợi ý để theo dõi file Word

- **Phần 1 - 3 (Trang 1 - 3):** Tìm hiểu về đề bài, quy định nghiệp vụ và các bài toán thực tế của thư viện.
- **Phần 4 (Trang 3 - 6):** Xem các mô hình sơ đồ UML để hiểu cấu trúc hệ thống.
- **Phần 5 (Trang 6 - 7):** Xem mô hình CSDL và đoạn mã SQL để cài đặt database.
- **Phần 6 (Trang 7 - 9):** Xem danh sách Control, bảng ánh xạ nút bấm và hình ảnh giao diện WinForms chạy thực tế.

---

## CÁC CÔNG NGHỆ SỬ DỤNG

- **Ngôn ngữ lập trình:** C# / .NET 9.0 (Windows Forms)
- **Hệ quản trị CSDL:** SQL Server / LocalDB
- **Công cụ thiết kế UML:** Visual Paradigm / Draw.io
- **Kiến trúc ứng dụng:** WinForms kết hợp Lớp Service (ADO.NET)

---

_Cảm ơn đã xem báo cáo!_
