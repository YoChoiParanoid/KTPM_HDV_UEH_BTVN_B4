# Bài 1
## Bước 1: Tạo Proj
- Tạo Proj ASP.NET Core Empty với tên Proj là TodoAPI:
    - ![alt text](./image_1/image.png)
    - ![alt text](./image_1/image-1.png)
    - ![alt text](./image_1/image-2.png)
- Chạy thử nghiệm Proj code sau
    - ![alt text](./image_1/image-3.png)
    - Kết quả nhận được
        - ![alt text](./image_1/image-4.png)

## Bước 2: Tải package và tạo các đối tượng
- Thêm package Microsoft.EntityFrameworkCore.InMemory
    - ![alt text](./image_1/image-5.png)
- Thêm package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore
    - ![alt text](./image_1/image-6.png)
- Tạo lớp Todo
    - ![alt text](./image_1/image-7.png)
- Tạo lớp TodoDB
    - ![alt text](./image_1/image-8.png)

## Bước 3: Thêm API code
- ![alt text](./image_1/image-9.png)

## Bước 4: Test API
- Chọn Endpoints Explorer
    - ![alt text](./image_1/image-10.png)
    - ![alt text](./image_1/image-11.png)
- Thử HTTP POST
    - Chuột phải vào POST method, chọn Generate Request
        - ![alt text](./image_1/image-12.png)
        - ![alt text](./image_1/image-13.png)

    - Thay đổi phần code json
        - ![alt text](./image_1/image-14.png)

    - Chọn nút Send Request ở phía trên
        - ![alt text](./image_1/image-15.png)
    - Kết quả:
        - ![alt text](./image_1/image-16.png)
- Thử HTTP GET
    - Làm tương tự như ở trên
        - ![alt text](./image_1/image-17.png)
    - Kết quả lần lượt từ trên xuống:
        - ![alt text](./image_1/image-18.png)
        - ![alt text](./image_1/image-19.png)
        - ![alt text](./image_1/image-20.png)
- Thử HTTP PUT và HTTP DELETE
    - Làm tương tự như trên
        - ![alt text](./image_1/image-21.png)
    - Kết quả lần lượt từ trên xuống:
        - ![alt text](./image_1/image-22.png)
        - ![alt text](./image_1/image-23.png)

# Bài 2
## Bước 1: Cài MongoDB COmpass và tạo database
- Tạo connection
    - ![alt text](./image_2/image.png)
- Nhấn save and connect
    - ![alt text](./image_2/image-1.png)
- Tạo database
    - ![alt text](./image_2/image-2.png)
- Insert database
    - ![alt text](./image_2/image-3.png)
    - ![alt text](./image_2/image-4.png)
- Chỉnh sửa file appsetting.json
    - ![alt text](./image_2/image-20.png)

## Bước 2: Tạo API
- Tạo Proj
    - ![alt text](./image_2/image-5.png)
    - ![alt text](./image_2/image-6.png)
    - ![alt text](./image_2/image-7.png)
- Tải package MongoDB
    - ![alt text](./image_2/image-8.png)
- Tải package Swashbuckle.AspNetCore.SwaggerGen
    - ![alt text](./image_2/image-12.png)
- Tải package Swashbuckle.AspNetCore.SwaggerUI
    - ![alt text](./image_2/image-13.png)

## Bước 3: Tạo Models
- ![alt text](./image_2/image-9.png)
- ![alt text](./image_2/image-10.png)
- ![alt text](./image_2/image-11.png)

## Bước 4: Thay đổi code file Program.cs
- ![alt text](./image_2/image-18.png)

## Bước 5: Thêm thư file Services/BookService.cs
- ![alt text](./image_2/image-15.png)

## Buowcs 6: Thêm đoạn code sau vào Program.cs
- ![alt text](./image_2/image-16.png)

## Bước 7: Thêm file Controller/BookController.cs
- ![alt text](./image_2/image-17.png)

## Bước 8: Sau khi chạy chương trình
- ![alt text](./image_2/image-19.png)

- Test chức năng:
    - Lấy toàn bộ data
        - ![alt text](./image_2/image-21.png)
    - Lấy data theo id
        - ![alt text](./image_2/image-22.png)
    - Chỉnh sửa một item
        - ![alt text](./image_2/image-23.png)
    - Xóa một item
        - ![alt text](./image_2/image-24.png)