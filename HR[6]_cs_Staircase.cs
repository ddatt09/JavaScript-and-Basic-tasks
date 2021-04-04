
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
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
                */

        static void Main(string[] args)
        {
            void staircase(int n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(new string(' ', n - 1 - i) + new string('#', i + 1));
                }

            }

            int n = Convert.ToInt32(Console.ReadLine());

            staircase(n);

            Console.ReadKey();
        }
    }
}
