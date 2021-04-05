using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
......................................................... Mini-Max Sum ........................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/mini-max-sum/problem

Cho năm số nguyên dương, hãy tìm giá trị nhỏ nhất và lớn nhất có thể được tính bằng cách tính tổng chính xác bốn trong năm số nguyên. Sau đó, in các giá trị tối thiểu và tối đa tương ứng dưới dạng một dòng gồm hai số nguyên kiểu dữ liệu "long" được phân tách bằng dấu cách.

VÍ DỤ:
    arr = [1,3,5,7,9]
    Tổng nhỏ nhất là 1 + 3 + 5 + 7 = 16 và tổng lớn nhất là 3 + 5 + 7 + 9 = 24. In ra:
    16 24

MÔ TẢ CHỨC NĂNG:
    Hoàn thành hàm miniMaxSum trong trình chỉnh sửa bên dưới.
    miniMaxSum có (các) tham số sau:
    arr: một mảng có 5 số nguyên
KẾT QUẢ ĐẦU RA:

In hai số nguyên được phân tách bằng dấu cách trên một dòng: tổng nhỏ nhất và tổng lớn nhất của các phần tử.

ĐỊNH DẠNG INPUT:
    Một dòng gồm năm số nguyên được phân tách bằng dấu cách.

CONSTRAINTS(Ràng buộc):
    1 <= arr[i] <= 10^9

ĐỊNH DẠNG OUTPUT:
    In hai số nguyên dài được phân tách bằng dấu cách biểu thị các giá trị nhỏ nhất và lớn nhất tương ứng có thể được tính bằng cách tính tổng chính xác bốn trong năm số nguyên. (Đầu ra có thể lớn hơn một số nguyên 32 bit.)

ĐẦU VÀO MẪU:
1 2 3 4 5
ĐẦU RA MẪU:
10 14
GIẢI TRÌNH:
Các số là 1,2,3,4 và 5. Tính các tổng sau bằng cách sử dụng bốn trong năm số nguyên:

Tổng tất cả mọi thứ ngoại trừ 1, tổng là 2 + 3 + 4 + 5 = 14.
Tổng tất cả mọi thứ ngoại trừ 2, tổng là 1 + 3 + 4 + 5 = 13.
Tổng tất cả mọi thứ ngoại trừ 3, tổng là 1 + 2 + 4 + 5 = 12.
Tổng tất cả mọi thứ ngoại trừ 4, tổng là 1 + 2 + 3 + 5 = 11.
Tổng tất cả mọi thứ ngoại trừ 5, tổng là 1 + 2 + 3 + 4 = 10.

LƯU Ý: Cẩn thận với tràn số nguyên! Sử dụng Số nguyên 64-bit.
                */

        static void Main(string[] args)
        {
            void miniMaxSum(int[] arr)
            {
                long minSum = 0, maxSum = 0;

                for (int i = 0; i < arr.Length; i++)
                {
                    minSum += arr[i];
                    maxSum += arr[i];
                }

                Console.WriteLine($"{minSum - arr.Max()} {maxSum - arr.Min()}");
            }

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);

            Console.ReadKey();
        }
    }
}
