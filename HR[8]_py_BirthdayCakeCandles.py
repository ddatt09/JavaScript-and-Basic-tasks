"""
................................................... Birthday Cake Candles ..............................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/birthday-cake-candles/problem?isFullScreen=true

Bạn phụ trách bánh kem cho sinh nhật của một đứa trẻ. Bạn đã quyết định chiếc bánh sẽ có một ngọn nến cho mỗi năm trong tổng số tuổi của chúng. Họ sẽ chỉ có thể thổi tắt ngọn nến cao nhất. Đếm xem có bao nhiêu cây nến cao nhất.

VÍ DỤ:
    candles = [4,4,1,3]
    Các ngọn nến có chiều cao tối đa là 4. Có 2 trong số đó là ngọn nến có chiều cao tối đa, vì vậy trả lại 2.

MÔ TẢ:
    Hoàn thành hàm birthdayCakeCandles trong trình chỉnh sửa bên dưới.
    birthdayCakeCandles có (các) tham số sau:
    int Cands [n]: chiều cao của ngọn nến

KẾT QUẢ TRẢ VỀ:
    int: số lượng nến có chiều cao lớn nhất

ĐỊNH DẠNG ĐẦU VÀO:
    Dòng đầu tiên chứa một số nguyên duy nhất, có kích thước bằng.
    Dòng thứ hai chứa các số nguyên được phân tách bằng dấu cách, trong đó mỗi số nguyên mô tả chiều cao của.

ĐIỀU KIỆN RÀNG BUỘC:
    1 <= n <= 10^5
    1 <= candles[i] <= 10^7

VÍ DỤ ĐẦU VÀO:
    4
    3 2 1 3
ĐẦU RA MẪU:
    2
GIẢI TRÌNH:
    Chiều cao ngọn nến là [3,2,1,3]. Ngọn nến cao nhất là 3 đơn vị, và có 2 ngọn cao nhất có thể thổi được.
"""


def birthdayCakeCandles(candles):
    maxHigh = candles[0]
    for i in range(len(candles)):
        if candles[i] >= maxHigh:
            maxHigh = candles[i]

    return candles.count(maxHigh)


# Write your code here

if __name__ == '__main__':
    candles_count = int(input().strip())

    candles = list(map(int, input().rstrip().split()))

    result = birthdayCakeCandles(candles)

    print(result)
