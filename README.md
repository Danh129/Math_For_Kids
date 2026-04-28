# 🧮 MATH FOR KIDS _ PHẦN MỀM ÔN TẬP TOÁN CẤP 1
> Một ứng dụng giúp học sinh tiểu học luyện tập tính toán nhanh trên máy tính.

---

## 📝 Giới thiệu
* Đây là bài tập lớn môn **LẬP TRÌNH GIAO DIỆN (C# WinForms)**. 
* Ứng dụng cung cấp các phép tính ngẫu nhiên theo nhiều cấp độ khác nhau (5 CẤP ĐỘ), hỗ trợ học sinh tự ôn tập tại nhà.


### Các tính năng chính:
* **Tự động tạo đề:** Máy tính tự chọn số ngẫu nhiên cho các phép Cộng, Trừ, Nhân, Chia theo cấp độ mà học sinh chọn.
* **Chấm điểm tự động:** Biết kết quả đúng/sai ngay sau khi làm bài.
* **Lưu lại:** Giúp hiểu rõ bài mình đúng/sai nhiêu câu, có kèm lời phê.
* **Tính năng làm lại:** Tự Random lại và giúp học sinh vẫn ở cấp độ đó làm bài tiếp tục
* **Tính năng tiếp tục:** Giúp học sinh quay về trang ban đầu để đổi cấp độ ôn tập.
* **Hiện đáp án thông minh:** Nếu làm sai, máy sẽ tự động hiện đáp án đúng bằng chữ **màu xanh**.
* **Lưu bảng xếp hạng:** Xuất kết quả ra file CSV để theo dõi quá trình học tập.

---

## 📂 Cấu trúc dự án
* **Form1.cs**: Màn hình chào mừng, nhập tên và chọn cấp độ (1-5).
* **Form2.cs**: Giao diện làm bài, xử lý logic Random đề và chấm điểm.
* **Form3.cs**: Hiển thị kết quả chi tiết, lời phê và xếp loại.
* **Form4.cs**: Bảng xếp hạng tổng quát và tính năng xuất file CSV.
* **GlobalData.cs**: Lớp dùng để lưu trữ dữ liệu dùng chung giữa các Form.

---

## 🏆 Hệ thống xếp loại
Dựa trên số câu đúng trên tổng số 10 câu:
* **Xuất sắc:** Đúng 10/10 câu.
* **Giỏi:** Đúng từ 8 đến 9 câu.
* **Khá:** Đúng từ 6 đến 7 câu.
* **Trung bình:** Đúng 5 câu.
* **Cần cố gắng:** Đúng dưới 5 câu.
  
---

## 🛠 Công nghệ sử dụng
Dự án được xây dựng dựa trên:
* **Ngôn ngữ:** C# (C-Sharp)
* **Framework:** .NET Framework / WinForms
* **Công cụ:** Visual Studio 2022

--- 

## Hình ảnh minh họa
### Form 1
![Form1](<img width="1320" height="855" alt="form1" src="https://github.com/user-attachments/assets/6066405b-67d2-4f09-961f-af5da23f6998" />
)

### Form 2
![Form2](<img width="740" height="554" alt="form2" src="https://github.com/user-attachments/assets/e8c8ea78-d2ec-4fa4-966d-3b53da4fc81d" />
)

### Form 3
![Form3](<img width="1210" height="838" alt="form3" src="https://github.com/user-attachments/assets/6af0cf95-2da8-48a5-a910-bf681b86af16" />
)

---

## 🚀 Cách cài đặt và sử dụng
1. Tải toàn bộ mã nguồn về máy tính (hoặc Clone từ GitHub).
2. Mở file `.sln` bằng phần mềm **Visual Studio**.
3. Nhấn nút **Start (F5)** để bắt đầu chạy chương trình.
4. Nhập tên và chọn cấp độ (1-5) để bắt đầu thử thách!

---
## Tác Giả

* Người thực hiện: Lê Thanh Danh
* Ngày Thực hiện: 20/03/2026
* Ngày hoàn thành: 27/04/2026
