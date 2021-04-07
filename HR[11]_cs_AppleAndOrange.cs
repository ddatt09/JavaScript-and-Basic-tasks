
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Apple and Orange ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/apple-and-orange/problem?isFullScreen=true

Nhà Sam có một cây táo và một cây cam, cả 2 đều cho rất nhiều quả. Sử dụng thông tin cho dưới đây, hãy xác định số quả táo và số cam rụng vào nhà Sam.

Trong sơ đồ dưới đây:
    Vùng màu đỏ biểu thị ngôi nhà, s là điểm bắt đầu và t là điểm cuối. Cây táo ở bên trái ngôi nhà, và cây cam ở bên phải.
    Giả sử các cây nằm trên một điểm duy nhất, tại đó cây táo và cây cam ở tại một điểm.
    Khi một quả rơi khỏi cây của nó, nó sẽ tiếp đất với khoảng cách d đơn vị từ cây gốc của nó dọc theo trục x. Giá trị âm của d nghĩa là trái cây rơi d đơn vị bên trái cây và giá trị dương nghĩa là trái cây rơi d đơn vị bên phải cây. *


Với giá trị d của m quả táo và n cam, hãy xác định xem nhà Sam sẽ rơi xuống bao nhiêu quả táo và cam (tức là trong phạm vi bao gồm[s,t])?

VÍ DỤ: nhà của Sam nằm giữa s = 7 và t = 10. Cây táo ở vị trí a = 4 và cây cam ở vị trí b = 12. Có táo và cam. Táo sẽ rơi ở các vị trí apples=[2,3,-4] và cam là oranges=[3,-2,-4]. Cộng khoảng cách của mỗi quả táo vào vị trí của cây, chúng sẽ hạ cánh tại [4+2,4+3,4-4]. Oranges hạ cánh tại [12+3,12-2,12-4]. Một quả táo và hai quả cam nằm trong phạm vi 7 - 10 vì vậy chúng ta có kết quả:
    1
    2

MÔ TẢ:
    Hoàn thành chức năng countApplesAndOranges trong trình chỉnh sửa bên dưới. Nó sẽ in ra số táo và cam đổ xuống nhà Sam, mỗi quả trên một dòng riêng biệt.

countApplesAndOranges có các tham số sau:
    s: số nguyên, điểm bắt đầu của vị trí nhà Sam.
    t: số nguyên, vị trí kết thúc của vị trí nhà Sam.
    a: số nguyên, vị trí của cây Táo.
    b: số nguyên, vị trí của cây Cam.
    Táo: mảng số nguyên, khoảng cách mà mỗi quả táo rơi khỏi cây.
    cam: mảng số nguyên, khoảng cách mà mỗi quả cam rơi khỏi cây.

ĐỊNH DẠNG INPUT:
    Dòng đầu tiên chứa hai số nguyên được phân tách bằng dấu cách biểu thị các giá trị tương ứng của s và t.
    Dòng thứ hai chứa hai số nguyên được phân tách bằng dấu cách biểu thị các giá trị tương ứng của a và b.
    Dòng thứ ba chứa hai số nguyên được phân tách bằng dấu cách biểu thị các giá trị tương ứng của m và n.
    Dòng thứ tư chứa m số nguyên được phân tách bằng dấu cách biểu thị khoảng cách tương ứng mà mỗi quả táo rơi từ điểm a.
    Dòng thứ năm chứa n số nguyên được phân tách bằng dấu cách biểu thị khoảng cách tương ứng mà mỗi quả cam rơi xuống từ điểm b.

RÀNG BUỘC:
    1 <= s,t,a,b,m,n <= 10^5
    -10^5 <= d <= 10^5
    a < s < t < b

ĐỊNH DẠNG OUTPUT:
    In hai số nguyên trên hai dòng khác nhau:
    Số nguyên đầu tiên: số quả táo rụng xuống nhà Sam.
    Số nguyên thứ hai: số quả cam rụng xuống nhà Sam.

INPUT MẪU 0:
    7 11
    5 15
    3 2
    -2 2 1
    5 -6
OUTPUT MẪU 0:
    1
    1
GIẢI TRÌNH MẪU 0:
    Quả táo đầu tiên rơi đúng vị trí 5 - 2 = 3.
    Quả táo thứ hai rơi đúng vị trí 5 + 2 = 7.
    Quả táo thứ ba rơi đúng vị trí 5 + 1 = 6.
    Quả cam đầu tiên rơi đúng vị trí 15 + 5 = 20.
    Quả cam thứ hai rơi tại vị trí 15 - 6 = 9.
    Chỉ có một quả (quả táo thứ hai) nằm trong vùng giữa 7 và 11, vì vậy chúng ta có kết quả dòng đầu là 1.
    Chỉ có quả cam thứ hai nằm trong vùng giữa 7 và 11,  vì vậy chúng ta có kết quả dòng thứ 2 là 1.
 */

        static void Main(string[] args)
        {
            void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges)
            {

                List<int> fallApplePositions = apples.Select(e => { e = e + a; return e; }).ToList();
                List<int> fallOrangePositions = oranges.Select(e => { e = e + b; return e; }).ToList();

                int appleNum = fallApplePositions.Count(e => e >= s && e <= t);
                int orangeNum = fallOrangePositions.Count(e => e >= s && e <= t);

                Console.WriteLine($"{appleNum}\n{orangeNum}");
            }

            string[] st = Console.ReadLine().Split(' ');

            int s = Convert.ToInt32(st[0]);

            int t = Convert.ToInt32(st[1]);

            string[] ab = Console.ReadLine().Split(' ');

            int a = Convert.ToInt32(ab[0]);

            int b = Convert.ToInt32(ab[1]);

            string[] mn = Console.ReadLine().Split(' ');

            int m = Convert.ToInt32(mn[0]);

            int n = Convert.ToInt32(mn[1]);

            int[] apples = Array.ConvertAll(Console.ReadLine().Split(' '), applesTemp => Convert.ToInt32(applesTemp))
            ;

            int[] oranges = Array.ConvertAll(Console.ReadLine().Split(' '), orangesTemp => Convert.ToInt32(orangesTemp))
            ;
            countApplesAndOranges(s, t, a, b, apples, oranges);

            Console.ReadKey();
        }
    }
}
