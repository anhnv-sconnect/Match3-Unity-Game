# Bài tập 1 :Cần ít nhất 3 tối ưu để cải thiện hiệu năng game

1.	Đổi từ việc dùng List<Cell> để lưu rồi trả về danh sách phần tử PotentialMatch -> IENumurable<Cell> để duyệt rồi trả về các phần tử đủ điều kiện luôn
![descriptive alt text](https://github.com/anhnv-sconnect/Match3-Unity-Game/blob/Phase-VietAnh/Document/1.1%20ScriptBoard.png "Logo Title Text 1")

2.	UIManager sẽ được reference vào gameManger chứ không cần FindObjectByType 
=>	Vì FIndObjectByType sẽ tốn 1 lượng thời gian để Tìm kiếm object trên scene 
![descriptive alt text](https://github.com/anhnv-sconnect/Match3-Unity-Game/blob/Phase-VietAnh/Document/2.1%20ScriptBoard.png "Logo Title Text 1")
