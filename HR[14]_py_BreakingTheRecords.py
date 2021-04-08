
"""
................................................. Breaking The Records ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/breaking-best-and-worst-records/problem?isFullScreen=true

Maria chơi bóng rổ ở trường đại học và muốn trở thành 1 người chuyên nghiệp. Mỗi mùa giải, cô ấy có thói quen ghi chép lại điểm số của mình. Cô lập bảng số lần phá kỷ lục theo mùa của mình mỗi lần điểm nhiều nhất và điểm thấp nhất trong mỗi trận đấu. Số điểm ghi được trong trận đấu đầu tiên xác lập kỷ lục của cô ấy trong mùa giải và cô ấy bắt đầu ghi chép từ đó.

VÍ DỤ:
    Điểm số theo thứ tự như các trò chơi đã chơi. Cô ấy lập bảng kết quả của mình như sau:

                                           Count
    Game   Score    Minimum   Maximum   Min     Max
  -----------------------------------------------------
     0      12         12       12       0       0
     1      24         12       24       0       1
     2      10         10       24       1       1
     3      24         10       24       1       1
    Với điểm số của mỗi mùa giải, hãy xác định số lần Maria phá kỷ lục ghi được nhiều điểm nhất và ít điểm nhất trong mùa giải.

MÔ TẢ:
    Hoàn thành hàm breakRecords bên dưới.
    breakRecords có (các) tham số sau:
    int score [n]: điểm ghi được mỗi trận

KẾT QUẢ TRẢ VỀ:
    int [2]: Một mảng có số lần cô ấy phá vỡ kỷ lục của mình. index 0 là số lần phá kỷ lục đã lập trước đó. index 1 số lần chơi kém hơn kỷ lục đã lập trước đó.

ĐỊNH DẠNG CỦA INPUT:
    - Dòng đầu tiên chứa một số nguyên n, số lượng trận đấu.
    - Dòng thứ hai là n phần tử của mảng score=[score(0),score(1),...,score(n-1)]

ĐIỀU KIỆN RÀNG BUỘC:
    1 <= n <= 1000
    0 <= score[i] <= 10^8
.................................................... EXAMPLE 0 ..........................................................
INPUT MẪU 0:
    9
    10 5 20 20 4 5 2 25 1
OUTPUT MẪU 0:
2 4
GIẢI THÍCH MẪU 0:
Sơ đồ dưới đây mô tả số lần Maria phá kỷ lục tốt nhất và tệ nhất của mình trong suốt mùa giải:

hình ảnh....

Cô ấy đã phá kỷ lục tốt nhất của mình hai lần (sau các trận 2 và 7) và kỷ lục tồi tệ nhất của mình bốn lần (sau các trận 1,4,6 và 8), vì vậy kết quả in ra là 2 4. Lưu ý rằng cô ấy đã không phá kỷ lục về điểm số tốt nhất của mình trong 3 trận đấu, vì điểm số của cô ấy trong trận đấu đó không hoàn toàn lớn hơn kỷ lục tốt nhất của cô ấy vào thời điểm đó.

.................................................... EXAMPLE 1 ..........................................................

INPUT MẪU 1:
    10
    3 4 21 36 10 28 35 5 24 42
OUTPUT MẪU 1:
    4 0
GIẢI THÍCH MẪU 1:
Sơ đồ dưới đây mô tả số lần Maria phá kỷ lục tốt nhất và tệ nhất của mình trong suốt mùa giải:

hình ảnh....

Cô ấy đã phá kỷ lục tốt nhất của mình bốn lần (sau các trận đấu 1,2,3 và 9) và kỷ lục tồi tệ nhất của cô ấy là 0 lần (không có điểm nào trong mùa giải thấp hơn điểm mà cô ấy kiếm được trong trận đấu đầu tiên của mình), vì vậy kết quả sẽ là 4 0.
"""


# Complete the breakingRecords function below.
def breakingRecords(scores):
    bestRecord = scores[0]
    leastRecord = scores[0]
    timesBreakingRecordsForMost = 0
    timesBreakingRecordsForLeast = 0

    scores.remove(bestRecord)
    for i in range(len(scores)):

        if scores[i] > bestRecord:
            bestRecord = scores[i]
            timesBreakingRecordsForMost += 1

        if scores[i] < leastRecord:
            leastRecord = scores[i]
            timesBreakingRecordsForLeast += 1

    return [timesBreakingRecordsForMost, timesBreakingRecordsForLeast]


if __name__ == '__main__':
    n = int(input())

    scores = list(map(int, input().rstrip().split()))

    result = breakingRecords(scores)

    print(' '.join(map(str, result)))
