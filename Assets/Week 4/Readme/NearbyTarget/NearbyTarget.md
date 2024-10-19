# Bài Tập Thực Hành: Tìm Mục Tiêu Gần Nhất

## Giới Thiệu

Trong các trò chơi và ứng dụng, việc tìm mục tiêu gần nhất là một kỹ năng quan trọng, đặc biệt trong hệ thống điều hướng, tấn công tự động hoặc lựa chọn đối tượng. Dưới đây là 2 bài tập giúp bạn thực hành việc tìm mục tiêu gần nhất trong môi trường lập trình.

## 2 Bài Tập Về Tìm Mục Tiêu Gần Nhất

### Bài Tập 1: Tìm Kẻ Địch Gần Nhất

**Yêu cầu**:
Viết một chương trình để tìm kẻ địch gần nhất từ một danh sách các kẻ địch, mỗi kẻ địch có vị trí cụ thể trên bản đồ. Người chơi sẽ di chuyển trên bản đồ, và chương trình sẽ tính toán khoảng cách từ người chơi đến các kẻ địch để xác định kẻ địch gần nhất và trả về thông tin của nó.

**Hướng dẫn**:

- Tạo một danh sách các kẻ địch với tọa độ vị trí (x, y, z) trong một không gian 3D.
- Sử dụng công thức **khoảng cách Euclid** hoặc `Vector3.Distance()` để tính khoảng cách từ vị trí của người chơi đến từng kẻ địch.
- So sánh khoảng cách của từng kẻ địch để tìm ra kẻ địch gần nhất.
- Trả về thông tin (ID, vị trí) của kẻ địch gần nhất.

### Bài Tập 2: Tìm Vật Phẩm Gần Nhất

**Yêu cầu**:
Trong một trò chơi, người chơi cần thu thập các vật phẩm rải rác trên bản đồ. Viết một chương trình để giúp người chơi tìm ra vật phẩm gần nhất dựa trên tọa độ hiện tại của họ.

**Hướng dẫn**:

- Tạo danh sách các vật phẩm trên bản đồ, mỗi vật phẩm có tọa độ (x, y) trong không gian 2D.
- Sử dụng hàm tính khoảng cách để đo khoảng cách giữa người chơi và từng vật phẩm trong danh sách.
- So sánh và tìm ra vật phẩm có khoảng cách ngắn nhất với người chơi.
- Trả về thông tin của vật phẩm gần nhất, bao gồm tên hoặc loại vật phẩm và tọa độ của nó.

## Kết Luận

Hai bài tập trên sẽ giúp bạn thực hành các kỹ thuật tính toán khoảng cách và duyệt qua danh sách để tìm mục tiêu gần nhất. Đây là một kỹ năng quan trọng khi phát triển các trò chơi và hệ thống điều hướng thông minh.
