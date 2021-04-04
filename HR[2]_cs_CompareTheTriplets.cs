using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
        Alice và Bob mỗi người tạo ra một vấn đề cho HackerRank. Một người đánh giá xếp hạng hai thử thách, cho điểm trên thang điểm từ 1 đến 100 cho ba hạng mục: độ rõ ràng, tính độc đáo và độ khó của vấn đề.

       Xếp hạng cho thử thách của Alice là bộ ba a = (a [0], a [1], a [2]) và xếp hạng cho thử thách của Bob là bộ ba b = (b [0], b [1], b [2]).

       Nhiệm vụ là tìm điểm so sánh của chúng bằng cách so sánh a [0] với b [0], a [1] với b [1], và a [2] với b [2].

             - Nếu a [i]> b [i], thì Alice được thưởng 1 điểm.
             - Nếu a [i] <b [i], thì Bob được thưởng 1 điểm.
             - Nếu a [i] = b [i], thì không người nào nhận được điểm.
         Điểm so sánh là tổng số điểm mà một người kiếm được.

         Cho trước a và b, xác định điểm so sánh tương ứng của chúng.

         EXAMPLE:
             a = [1, 2, 3]
             b = [3, 2, 1]
         Đối với các phần tử * 0 *, Bob được thưởng một điểm vì [0].
         Đối với các phần tử bằng nhau a [1] và b [1], không được điểm nào.
         Cuối cùng, đối với phần tử 2, a [2]> b [2] nên Alice nhận được một điểm.
         Mảng trả về là [1, 1] với điểm của Alice đầu tiên và điểm thứ hai của Bob.

         FUNCTION DESCRIPTION:
         Hoàn thành hàm CompareTriplets trong trình chỉnh sửa bên dưới.
         CompareTriplets có (các) tham số sau:
             int a [3]: Xếp hạng thử thách của Alice
             int b [3]: Xếp hạng thử thách của Bob

         RETURN:
             int [2]: Điểm của Alice ở vị trí đầu tiên và điểm của Bob ở vị trí thứ hai.

         INPUT:
             Dòng đầu tiên chứa 3 số nguyên được phân tách bằng dấu cách, a [0], a [1] và a [2], các giá trị tương ứng trong bộ ba a.
             Dòng thứ hai chứa 3 số nguyên được phân tách bằng dấu cách, b [0], b [1] và b [2], các giá trị tương ứng trong bộ ba b.

         INPUT FORMAT:
             1 ≤ a [i] ≤ 100
             1 ≤ b [i] ≤ 100

         SAMPLE INPUT 0
             5 6 7
             3 6 10
         SAMPLE OUTPUT 0
             1 1
         EXPLANTATION 0
         Trong ví dụ này,ta có:
             a = (a[0],a[1],a[2]) = (5,6,7)
             b = (b[0],b[1],b[2]) = (3,6,10)
         Bây giờ, hãy so sánh từng điểm số riêng lẻ:
             a[0] > b[0], vì vậy Alice nhận được điểm.
             a[1] = b[1], vì vậy không ai nhận được một điểm.
             a[2] < b[2], vì vậy Bob nhận được điểm.
         Điểm so sánh của Alice là 1, và điểm so sánh của Bob là 1. Do đó, chúng tôi trả về mảng [1,1].
                */
        static void Main(string[] args)
        {
            List<int> compareTriplets(List<int> a, List<int> b)
            {
                List<int> result = new List<int>() { 0, 0 };
                for(int i = 0; i < a.Count; i++)
                {
                    if (a[i] > b[i]) result[0] += 1;
                    if (a[i] < b[i]) result[1] += 1;
                }
                return result;
            }
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = compareTriplets(a, b);

            Console.WriteLine(String.Join(" ", result));
            Console.ReadKey();
        }
    }
}
