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