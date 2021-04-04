
"""
................................................. STAIRCASE ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/staircase/problem?isFullScreen=true

Chi tiết cầu thang
Đây là một cầu thang có kích thước:
       #
      ##
     ###
    ####
Cơ sở và chiều cao của nó đều bằng n. Nó được vẽ bằng # ký hiệu và dấu cách. Dòng cuối cùng không được đặt trước bất kỳ khoảng trắng nào.

Viết chương trình in cầu thang với kích thước n.

FUNCTION DESCRIPTION:
    Hoàn thành chức năng cầu thang trong trình chỉnh sửa bên dưới.
    cầu thang có (các) thông số sau:
    int n: một số nguyên

PRINT OUT:
    In một cầu thang như mô tả ở trên.

INPUT FORMAT:
    Một số nguyên duy nhất n, biểu thị kích thước của cầu thang.

CONSTRAINTS:
    0 < n <= 100

OUTPUT FORMAT:
In ra cầu thang kích thước n bằng cách sử dụng # ký hiệu và dấu cách.
Lưu ý: Dòng cuối cùng phải có 0 khoảng trắng.

SAMPLE INPUT:
    6
SAMPLE OUTPUT:
     #
    ##
   ###
  ####
 #####
######
EXPLANATION(giải trình):
Cầu thang được căn phải, bao gồm # ký hiệu và dấu cách, đồng thời có chiều cao và chiều rộng là n = 6.
"""



def staircase(n):
    for i in range(n):
        print(" " * (n - 1 - i) + "#" * (i + 1))


if __name__ == '__main__':
    n = int(input())
    staircase(n)
