# Bài Tập Thực Hành: Đệ Quy Đơn Giản

## Giới Thiệu

Đệ quy là một kỹ thuật lập trình mà một hàm gọi lại chính nó để giải quyết một vấn đề lớn bằng cách chia nhỏ nó thành các vấn đề nhỏ hơn. Dưới đây là 5 bài tập giúp bạn thực hành đệ quy trong lập trình.

## 5 Bài Tập Về Đệ Quy Đơn Giản

### Bài Tập 1: Tính Giai Thừa Của Một Số

**Yêu cầu**:
Viết một hàm đệ quy để tính **giai thừa** của một số nguyên dương `n`. Giai thừa của `n` được tính bằng công thức:
n! = n _ (n - 1) _ (n - 2) _ ... _ 1

**Hướng dẫn**:

- Nếu `n = 0`, trả về 1 (giai thừa của 0 bằng 1).
- Gọi lại hàm với giá trị `n-1` và nhân kết quả với `n`.

### Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N

**Yêu cầu**:
Viết một hàm đệ quy để tính **tổng các số** từ 1 đến `n`.

**Hướng dẫn**:

- Nếu `n = 1`, trả về 1.
- Gọi lại hàm với giá trị `n-1` và cộng kết quả với `n`.

### Bài Tập 3: Chuỗi Fibonacci

**Yêu cầu**:
Viết một hàm đệ quy để tính số Fibonacci thứ `n`. Chuỗi Fibonacci được định nghĩa như sau:
F(0) = 0, F(1) = 1, F(n) = F(n-1) + F(n-2)

**Hướng dẫn**:

- Nếu `n = 0`, trả về 0.
- Nếu `n = 1`, trả về 1.
- Gọi lại hàm với giá trị `n-1` và `n-2` và cộng kết quả của hai hàm này.

### Bài Tập 4: Đếm Ngược

**Yêu cầu**:
Viết một hàm đệ quy để in ra các số từ `n` đếm ngược về 1.

**Hướng dẫn**:

- Nếu `n = 0`, dừng việc in.
- Gọi lại hàm với giá trị `n-1` sau khi in ra giá trị hiện tại của `n`.

### Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)

**Yêu cầu**:
Viết một hàm đệ quy để tìm **Ước Chung Lớn Nhất (UCLN)** của hai số nguyên `a` và `b` bằng thuật toán Euclid:
UCLN(a, b) = UCLN(b, a % b)

**Hướng dẫn**:

- Nếu `b = 0`, trả về `a`.
- Gọi lại hàm với giá trị `b` và `a % b`.

## Kết Luận

Các bài tập trên giúp bạn rèn luyện kỹ năng viết các hàm đệ quy đơn giản, từ tính toán giai thừa đến chuỗi Fibonacci và tìm UCLN. Thực hành nhiều bài tập sẽ giúp bạn nắm vững kỹ thuật đệ quy và ứng dụng vào các bài toán phức tạp hơn.
