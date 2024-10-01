# Hướng Dẫn Fork và Clone `HinMinh/SaiYouni` Tuần 6

## Bước 1: Fork Repository

1. Truy cập vào repository GitHub tại [HinMinh/SaiYouni](https://github.com/HinMinh/SaiYouni.git).
2. Ở góc trên bên phải, nhấp vào nút **Fork**. Điều này sẽ tạo một bản sao của repository dưới tài khoản GitHub của bạn.

## Bước 2: Clone Repository Đã Fork

1. Sau khi fork, vào tài khoản GitHub của bạn và tìm repository đã được fork.
2. Sao chép URL của repository bạn vừa fork. Nó sẽ trông như thế này: https://github.com/ten-tai-khoan-cua-ban/SaiYouni.git.
3. Mở terminal (hoặc Git Bash trên Windows), và chạy lệnh sau để clone repository về máy tính của bạn:
git clone https://github.com/ten-tai-khoan-cua-ban/SaiYouni.git
4. Di chuyển vào thư mục của repository:
cd SaiYouni
## Bước 3: Thêm Repository Gốc Là Remote Upstream
1. Để giữ cho bản fork của bạn luôn đồng bộ với repository gốc, hãy thêm repository gốc làm một remote có tên là upstream:\
`git remote add upstream https://github.com/HinMinh/SaiYouni.git`
2. Cập nhật thông tin mới của git dùng:\
`git fetch upstream`\
3a. Nếu nhánh đó mới thì bạn sử dụng:\
`git checkout Ten_Nhanh`\
3b. Nếu nhánh đó cũ thì bạn sử dụng merge:\
`git merge upstream/Ten_Nhanh`

## Kĩ thuật sử dụng github cơ bản
`git branch`: Hiển thị các nhánh bên trong dự án của bạn.\
`git checkout Ten Nhanh`: Thay đổi nhánh của bạn.\
`git pull`: Lấy dữ liệu mới về.\
`git add`: Thay đổi cập nhật vào git.\
`git commit -m "..."`: Chấp nhận thay đổi kèm theo lời nhắn những thay đổi đó là gì.\
`git push`: Đẩy lên github.

# Lưu ý khi đổi branch thì phải commit hết tại branch đó rồi mới đổi branch
