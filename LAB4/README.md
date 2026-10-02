# TÀI LIỆU HƯỚNG DẪN MÔN HỌC PHƯƠNG PHÁP PHÁT TRIỂN PHẦN MỀM HƯỚNG ĐỐI TƯỢNG LAB 4

## 1. DÀNH CHO BÀI TẬP LÝ THUYẾT TUẦN 5

Tệp văn bản trình bày chi tiết các bước chuyển đổi từ sơ đồ lớp (**Class Diagram**) sang mô hình cơ sở dữ liệu quan hệ theo đúng quy trình kỹ thuật.

Nội dung chính bao gồm:
- **Danh sách các bảng** được xác định từ các lớp trong sơ đồ.
- **Định nghĩa các mối liên kết** và cấu trúc khóa ngoại (**Foreign Key**) giữa các bảng.
- **Dữ liệu mẫu khởi tạo** cho từng bảng tương ứng.

---

## 2. DÀNH CHO TÀI LIỆU LAB04 (ĐẶC TẢ HỆ THỐNG E-SHOPPING)

Tài liệu đặc tả chi tiết hệ thống thương mại điện tử **e-Shopping**, được trình bày tuần tự theo các nội dung sau:

### 1. Giai đoạn phân tích (Analysis)
#### 1.1. Phân tích yêu cầu
##### 1.1.1. Xác định yêu cầu chức năng của hệ thống
Liệt kê các nhóm chức năng cho người dùng và các hệ thống liên kết bên ngoài.

##### 1.1.2. Mô hình hóa yêu cầu chức năng sử dụng Use Case Model
Định nghĩa các **Actor**, danh sách **Use Case** và đặc tả chi tiết cho Use Case giỏ hàng cũng như thanh toán.

##### 1.1.3. Class diagram
Mô hình hóa các lớp đối tượng và mối quan hệ cấu trúc trong hệ thống.

##### 1.1.4. Activity diagram
Trình bày luồng hoạt động nghiệp vụ cho các chức năng quản lý giỏ hàng và thanh toán.

##### 1.1.5. Sequence diagram
Mô tả trình tự tương tác giữa người dùng, giao diện, xử lý nghiệp vụ và cơ sở dữ liệu.

### 2. Thiết kế CSDL
- **2.1. Danh sách bảng:** Liệt kê các bảng, khóa chính và vai trò dữ liệu trong hệ thống.
- **2.2. Ràng buộc CSDL quan trọng:** Định nghĩa các ràng buộc về tính toàn vẹn, cấu trúc thẻ và quy tắc tính phí giao hàng.

### 3. Thiết kế hệ thống giao diện
- **3.1. FrmGiohang:** Chi tiết thiết kế giao diện giỏ hàng, bảng thuộc tính, danh sách thành phần điều khiển và kịch bản xử lý dữ liệu.

---

## 3. HƯỚNG DẪN VẬN HÀNH VÀ CHẠY ỨNG DỤNG

Để thực thi và kiểm thử chức năng thiết kế giao diện, người thực hiện tiến hành theo quy trình sau:

1. **Thực thi tệp cơ sở dữ liệu:**
   - Mở hệ quản trị cơ sở dữ liệu **SQL Server**.
   - Chạy tệp kịch bản `QLEShopping.sql` để tạo cơ sở dữ liệu và cấu trúc các bảng liên quan.

2. **Khởi chạy mã nguồn:**
   - Mở dự án source code bằng môi trường phát triển (**IDE**) tương ứng.
   - Cấu hình lại chuỗi kết nối cơ sở dữ liệu (**Connection String**) trỏ đến CSDL `QLEShopping` vừa khởi tạo.
   - Tiến hành biên dịch và chạy ứng dụng để trải nghiệm giao diện `FrmGiohang`.