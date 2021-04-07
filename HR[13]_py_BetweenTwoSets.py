
"""
................................................. Between Two Sets ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/between-two-sets/problem?isFullScreen=true

Có hai mảng số nguyên. Xác định tất cả các số nguyên thỏa mãn hai điều kiện sau:
    - Các số này >= phần tử lớn nhất của mảng thứ nhất  và <= phần tử nhỏ nhất của mảng thứ 2.
    - Các số này là bội của các phần tử mảng 1 và là ước của các phần tử mảng 2.
 Xác định xem có bao nhiêu số như vậy tồn tại.

VÍ DỤ:
    a = [2,6]
    b = [24,36]

Có hai số giữa các mảng: 6 và 12.
    6 % 2 = 0, 6 % 6 = 0, 24 % 6 = 0 và 36 % 6 = 0 cho giá trị đầu tiên.
    12 % 2 = 0, 12 % 6 = 0, 24 % 12 = 0 và 36 % 12 = 0 đối với giá trị thứ hai. Trả về kết quả là 2.

MÔ TẢ:
Hoàn thành hàm getTotalX bên dưới. Nó sẽ trả về số lượng các số nguyên nằm giữa các tập hợp.
getTotalX có (các) tham số sau:
    int a [n]: một mảng các số nguyên
    int b [m]: một mảng các số nguyên

KẾT QUẢ TRẢ VỀ:
    int: số lượng số nguyên nằm giữa các tập hợp

ĐIỀU KIỆN CỦA INPUT:
    Dòng đầu tiên chứa hai số nguyên được phân tách bằng dấu cách n và m tương ứng với số phần tử trong mảng a và b.
    Dòng thứ hai là mảng a[i] có n phần tử.
    Dòng thứ hai là mảng b[j] có m phần tử.

ĐIỀU KIỆN RÀNG BUỘC:
    1 <= n,m <= 10
    1 <= a[i] <= 100
    1 <= b[j] <= 100

INPUT MẪU:
    2 3
    2 4
    16 32 96
OUTPUT MẪU:
    3

"""


def getTotalX(a, b):
    a.sort()
    b.sort()
    maxOfa = max(a)
    minOfb = min(b)
    numbersBetween = []
    resultArr = []

    for i in range(maxOfa, minOfb + 1):
        numbersBetween.append(i)

    for i in range(len(numbersBetween)):
        if all(numbersBetween[i] % e == 0 for e in a) and all(e % numbersBetween[i] == 0 for e in b): resultArr.append(
            numbersBetween[i])

    return len(resultArr)


if __name__ == '__main__':
    first_multiple_input = input().rstrip().split()

    n = int(first_multiple_input[0])

    m = int(first_multiple_input[1])

    arr = list(map(int, input().rstrip().split()))

    brr = list(map(int, input().rstrip().split()))

    total = getTotalX(arr, brr)

    print(total)
