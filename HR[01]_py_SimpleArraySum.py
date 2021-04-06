"""
Cho một mảng các số nguyên, hãy tìm tổng các phần tử của nó.
Ví dụ, nếu là mảng thì: ar=[1,2,3]. 1+2+3=6, vì thế return 6.
MÔ TẢ CHỨC NĂNG: Hoàn thành hàm simpleArraySum trong trình chỉnh sửa bên dưới. Nó phải trả về tổng của các phần tử mảng là một số nguyên.
simpleArraySum có (các) tham số sau:
    ar: một mảng các số nguyên
ĐỊNH DẠNG ĐẦU VÀO:
    - Dòng đầu tiên chứa một số nguyên, biểu thị kích thước của mảng.
    - Dòng thứ hai chứa các số nguyên được phân tách bằng dấu cách đại diện cho các phần tử của mảng.
RÀNG BUỘC: 0 < n, ar[i] <= 1000
ĐỊNH DẠNG ĐẦU RA:
    - In tổng các phần tử của mảng dưới dạng một số nguyên duy nhất.
ĐẦU VÀO MẪU:
    6
    1 2 3 4 10 11
ĐẦU RA MẪU:
    31
GIẢI TRÌNH:
    Chúng tôi in ra tổng các phần tử của mảng: 1 + 2 + 3 + 4 + 10 + 11 = 31
"""

#
# Complete the simpleArraySum function below.
#
def simpleArraySum(ar):
    #
    # Write your code here.
    #
    return sum(ar)


if __name__ == '__main__':
    ar_count = int(input())
    ar = list(map(int, input().rstrip().split()))
    result = simpleArraySum(ar)
    print(result)

