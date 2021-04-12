using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Migratory Birds ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/migratory-birds/problem

Cho một mảng các lần nhìn thấy chim trong đó mỗi phần tử đại diện cho một id loại chim, hãy xác định id của loại được nhìn thấy thường xuyên nhất. Nếu nhiều hơn 1 loại đã được phát hiện số tiền tối đa đó, hãy trả về id nhỏ nhất của chúng.

VÍ DỤ:
    arr = [1,1,2,2,3]
    Có hai loại 1 và 2, và một loại nhìn thấy là loại 3. Chọn giá trị thấp hơn của hai loại được nhìn thấy hai lần: loại 1.

MÔ TẢ:
    Hoàn thành chức năng migratoryBirds trong trình chỉnh sửa bên dưới.
    migratoryBirds có (các) tham số sau:
    - int arr [n]: các loại chim được nhìn thấy

KẾT QUẢ TRẢ VỀ:
    - int: id loại thấp nhất của các loài chim được nhìn thấy thường xuyên nhất

ĐỊNH DẠNG CỦA INPUT:
    - Dòng đầu tiên chứa một số nguyên n, kích thước của mảng arr.
    - Dòng thứ hai là các phần tử của mảng arr.

ĐIỀU KIỆN RÀNG BUỘC:
    - 5 <= n <= 2*10^5
    - Nó được đảm bảo rằng mỗi loại là 1,2,3,4 hoặc 5.

................................. EXANPLE 0 ......................................
ĐẦU VÀO MẪU 0:
    6
    1 4 4 4 5 3
ĐẦU RA MẪU 0:
    4
GIẢI THÍCH MẪU 0:
Các loại chim khác nhau xảy ra với tần số sau:
    - Loại 1: 1 chim
    - Loại 2: 0 chim
    - Loại 3: 1 chim
    - Loại 4: 3 chim
    - Loại 5: 1 chim
Số loại xuất hiện ở tần suất cao nhất là loại 4, vì vậy 4 là câu trả lời.

................................. EXANPLE 1 ......................................

ĐẦU VÀO MẪU 1:
    11
    1 2 3 4 5 4 3 2 1 3 4
ĐẦU RA MẪU 1:
    3
GIẢI THÍCH MẪU 1:
Các loại chim khác nhau xảy ra với tần số sau:
    - Kiểu 1 : 2
    - Kiểu 2 : 2
    - Kiểu 3 : 3
    - Kiểu 4 : 3
    - Kiểu 5 : 1
Hai loại có tần suất của 3 và tần suất thấp hơn trong số đó là loại 3.
 */

        static void Main(string[] args)
        {


            int migratoryBirds(List<int> arr)
            {
                arr.Sort();
                List<int> arrTypes = new List<int>();
                List<int> arrTypesTimes = new List<int>();

                arr.ForEach(e => { if (!arrTypes.Contains(e)) arrTypes.Add(e); });

                arrTypes.ForEach(e => { arrTypesTimes.Add(arr.Where(e1 => e1 == e).ToList().Count); });

                int maximumType = arrTypesTimes.Max();

                return arrTypes[arrTypesTimes.IndexOf(maximumType)];
            }


            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
