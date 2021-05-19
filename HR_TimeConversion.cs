
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Time Convertion ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/time-conversion/problem?isFullScreen=true

Đưa ra một thời gian ở định dạng-giờ sáng / giờ chiều, hãy chuyển đổi nó thành thời gian quy ước (24 giờ).

Lưu ý: - 12:00:00 AM trên đồng hồ 12 giờ là 00:00:00 trên đồng hồ 24 giờ.
- 12:00:00 PM trên đồng hồ 12 giờ là 12:00:00 trên đồng hồ 24 giờ.

VÍ DỤ:
    - s='12:01:00PM'
    return '12:01:00'
    - s='12:01:00AM'
    return '00:01:00'

MÔ TẢ:
Hoàn thành chức năng timeConversion trong trình chỉnh sửa bên dưới. Nó sẽ trả về một chuỗi mới đại diện cho thời gian đầu vào ở định dạng 24 giờ.
timeConversion có (các) tham số sau:
    string s: một thời gian ở định dạng giờ

KẾT QUẢ TRẢ VỀ:
    string: thời gian ở định dạng giờ

ĐỊNH DẠNG CỦA INPUT:
    Một chuỗi đơn đại diện cho định dạng đồng hồ thời gian trong 12-giờ (tức là: hh:mm:ssAM hoặc hh:mm:ssPM).

ĐIỀU KIỆN RÀNG BUỘC:
    Tất cả thời gian nhập đều phải hợp lệ

VÍ DỤ MẪU:
    07:05:45PM
ĐẦU RA MẪU:
    19:05:45
                */

        static void Main(string[] args)
        {
            string timeConversion(string s)
            {
                string timePeriods = s.Substring(s.Length - 2), result = "";
                int hour = Convert.ToInt32(s.Substring(0, 2));

                if (timePeriods == "AM" && hour == 12) hour = 0;
                if (timePeriods == "PM" && hour != 12) hour += 12;

                if (hour < 10) result = "0" + Convert.ToString(hour) + s.Substring(2, s.Length - 2 - 2);
                else result = Convert.ToString(hour) + s.Substring(2, s.Length - 2 - 2);

                return result;
            }

            string s = Console.ReadLine();

            string result = timeConversion(s);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
