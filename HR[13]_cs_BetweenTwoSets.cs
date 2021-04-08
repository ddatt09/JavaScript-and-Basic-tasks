
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
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
 */

        static void Main(string[] args)
        {
            int getTotalX(List<int> a, List<int> b)
            {
                int maxOfa = a.Max();
                int minOfb = b.Min();

                List<int> numbersBetween = new List<int>();
                List<int> resultArr = new List<int>();

                for (int i = maxOfa; i <= minOfb; i++)
                {
                    numbersBetween.Add(i);
                }

                foreach (int item in numbersBetween)
                {
                    if (a.AsQueryable().All(val => item % val == 0) && b.AsQueryable().All(val => val % item == 0)) resultArr.Add(item);
                }

                return resultArr.Count();
            }

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);

            Console.ReadKey();
        }
    }
}
