
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
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
 */

        static void Main(string[] args)
        {


            int divisibleSumPairs(int n, int k, int[] ar)
            {
                List<int[]> divisibleSumPairs = new List<int[]>();

                for (int i = 0; i < ar.Length; i++)
                {
                    for (int j = 0; j < ar.Length; j++)
                    {

                        if (i != j && (ar[i] + ar[j]) % k == 0)
                        {
                            int[] pair = { i, j };
                            if (!divisibleSumPairs.Any(e => e.SequenceEqual(pair)) && !divisibleSumPairs.Any(e => e.SequenceEqual(pair.Reverse()))) divisibleSumPairs.Add(pair);
                        }

                    }
                }

                return divisibleSumPairs.Count;
            }


            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = divisibleSumPairs(n, k, ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
