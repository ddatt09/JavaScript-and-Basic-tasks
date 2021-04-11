"""
................................................. Divisible Sum Pairs ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/divisible-sum-pairs/problem

Cho một mảng các số nguyên và một số nguyên dương k, hãy xác định số cặp (i,j) nơi mà i < j và a[i] + ar[j] chia hết cho k.

VÍ DỤ:
    ar = [1,2,3,4,5,6]
    k = 5
Ba cặp đáp ứng các tiêu chí:[1,4], [2,3] và [4,6].

MÔ TẢ:
Hoàn thành chức năng divibleSumPairs trong trình chỉnh sửa bên dưới.

divibleSumPairs có (các) tham số sau:
    - int n: độ dài của mảng
    - int ar [n]: một mảng các số nguyên
    - int k: ước số nguyên

KÊT QUẢ TRẢ VỀ:
    - int: số lượng cặp

ĐỊNH DẠNG ĐẦU VÀO:
    - Dòng đầu tiên chứa 2 số nguyên được phân tách bằng dấu cách n và k.
    - Dòng thứ hai chứa n số nguyên được phân tách bằng dấu cách, mỗi số có giá trị arr[i].

ĐIỀU KIỆN RÀNG BUỘC:
    - 2 <= n <= 100
    - 1 <= k <= 100
    - 1 <= arr[i] <= 100
.................................. VÍ DỤ 0 ............................................

ĐẦU VÀO MẪU:
STDIN           FUNCTION
-----           --------
6 3             n = 6, k = 3
1 3 2 6 1 2     ar = [1, 3, 2, 6, 1, 2]
ĐẦU RA MẪU:
  5
GIẢI TRÌNH:
Dưới đây là các 5 cặp hợp lệ khi k = 3:
    - (0,2) -> arr[0] + arr[2] = 1 + 2 = 3
    - (0,5) -> arr[0] + arr[5] = 1 + 2 = 3
    - (1,3) -> arr[0] + arr[3] = 3 + 6 = 9
    - (2,4) -> arr[0] + arr[4] = 2 + 1 = 3
    - (4,5) -> arr[0] + arr[5] = 1 + 2 = 3
"""


# Complete the divisibleSumPairs function below.
def divisibleSumPairs(n, k, ar):
    divisibleSumPair=[]

    for i in range(len(ar)):
        for j in range(len(ar)):
            if (ar[i] + ar[j]) % k == 0 and i != j:
                if [i,j] not in divisibleSumPair and [j,i] not in divisibleSumPair:
                    divisibleSumPair.append([i,j])

    return  len(divisibleSumPair)


if __name__ == '__main__':
    nk = input().split()

    n = int(nk[0])

    k = int(nk[1])

    ar = list(map(int, input().rstrip().split()))

    result = divisibleSumPairs(n, k, ar)

    print(str(result) + '\n')
