"""
Trong thử thách này, bạn được yêu cầu tính toán và in ra tổng các phần tử trong một mảng, hãy nhớ rằng một số số nguyên đó có thể khá lớn.

FUNCTION DESCRIPTION:
    Hoàn thành hàm aVeryBigSum trong trình chỉnh sửa bên dưới. Nó phải trả về tổng của tất cả các phần tử mảng.

aVeryBigSum có (các) tham số sau:
    int ar [n]: một mảng các số nguyên.

RETURN:
    long: tổng của tất cả các phần tử mảng

INPUT FORMAT:
    Dòng đầu tiên của đầu vào bao gồm một số nguyên.
    Dòng tiếp theo chứa các số nguyên được phân tách bằng dấu cách chứa trong mảng.

OUTPUT FORMAT:
    Trả về tổng số nguyên của các phần tử trong mảng.

CONSTRAINTS(ràng buộc):
    1 <= n <= 10
    0 <= ar[i] <= 10^10

SAMPLE INPUT:
    5
    1000000001 1000000002 1000000003 1000000004 1000000005
SAMPLE OUTPUT:
    5000000015

NOTES:
    Phạm vi của số nguyên 32 bit là: (-2^31) tới (2^31 - 1) hoặc [-2147483648, 2147483647].
    Khi chúng tôi thêm một số giá trị số nguyên, tổng kết quả có thể vượt quá phạm vi trên. Bạn có thể cần sử dụng int long C / C ++ / Java để lưu trữ các tổng như vậy.
"""


# Complete the aVeryBigSum function below.
def aVeryBigSum(ar):
    return sum(ar)


if __name__ == '__main__':
    ar_count = int(input())

    ar = list(map(int, input().rstrip().split()))

    result = aVeryBigSum(ar)

    print(result)
