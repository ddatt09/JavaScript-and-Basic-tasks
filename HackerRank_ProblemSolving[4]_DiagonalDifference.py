"""
..................................... DIAGONAL DIFFERENCE (chẩn đoán sự khác biệt) ...................................
Cho một ma trận vuông, hãy tính hiệu số tuyệt đối giữa các tổng của các đường chéo của nó.

Ví dụ, ma trận vuông được hiển thị bên dưới:
    1 2 3
    4 5 6
    9 8 9
    Đường chéo trái sang phải =. Đường chéo từ phải sang trái =. Sự khác biệt tuyệt đối của họ là.

FUNCTION DESCRIPTION:
    Hoàn thành chức năng trong trình chỉnh sửa bên dưới.

DIAGONAL DIFFERENCE  nhận tham số sau:
    int arr [n] [m]: một mảng các số nguyên

RETURN:
    int: hiệu số đường chéo tuyệt đối

INPUT FORMAT:
    Dòng đầu tiên chứa một số nguyên duy nhất, số hàng và cột trong ma trận vuông.
    Mỗi dòng tiếp theo mô tả một hàng và bao gồm các số nguyên được phân tách bằng dấu cách.

CONSTRAINTS:
    -100 <= arr[i][j] <= 100

OUTPUT FORMAT:
    Trả về sự khác biệt tuyệt đối giữa tổng của hai đường chéo của ma trận dưới dạng một số nguyên duy nhất.

SAMPLE INPUT:
    3
    11 2 4
    4 5 6
    10 8 -12
SAMPLE OUTPUT:
15
EXPLANTATION:
    Đường chéo chính là:
    11
        5
            -12
    Tổng trên đường chéo chính: 11 + 5 - 12 = 4

    Đường chéo phụ là:
             4
        5
    10
    Tổng trên đường chéo phụ: 4 + 5 + 10 = 19
    Hiệu số: | 4 - 19 | = 15

NOTES: | x | là giá trị tuyệt đối của x
"""

# Complete the 'diagonalDifference' function below.
#
# The function is expected to return an INTEGER.
# The function accepts 2D_INTEGER_ARRAY arr as parameter.
#

def diagonalDifference(arr):
    # Write your code here
    primaryDiagonal = 0
    secondDiagonal = 0
    for i in range(len(arr)):
        primaryDiagonal += arr[i][i]
        secondDiagonal += arr[i][len(arr) - 1 - i]
    return abs(primaryDiagonal - secondDiagonal)


if __name__ == '__main__':

    n = int(input().strip())

    arr = []

    for _ in range(n):
        arr.append(list(map(int, input().rstrip().split())))

    result = diagonalDifference(arr)

    print(result)
