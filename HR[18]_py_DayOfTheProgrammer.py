"""
................................................. Day of the Programmer ..................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/day-of-the-programmer/problem

Marie đã phát minh ra Cỗ máy thời gian và muốn thử nghiệm nó bằng cách du hành thời gian để đến thăm Nga vào Ngày của Lập trình viên (ngày thứ 256 trong năm) trong một năm trong phạm vi bao gồm từ 1700 đến 2700.

Từ năm 1700 đến năm 1917, lịch chính thức của Nga là lịch Julian; kể từ năm 1919 họ sử dụng hệ thống lịch Gregory. Sự chuyển đổi từ hệ thống lịch Julian sang Gregorian xảy ra vào năm 1918, khi ngày tiếp theo sau ngày 31 tháng 1 là ngày 14 tháng 2. Điều này có nghĩa là vào năm 1918, ngày 14 tháng 2 là ngày thứ 32 trong năm ở Nga.

Trong cả hai hệ thống lịch, tháng Hai là tháng duy nhất có số ngày thay đổi; nó có 29 ngày trong một năm nhuận và 28 ngày trong tất cả các năm khác. Trong lịch Julian, năm nhuận chia hết cho 4; trong lịch Gregory, năm nhuận là một trong những năm sau:
   - Chia hết cho 400.
   - Chia hết cho 4 và không chia hết cho 100.
Cho một năm y, hãy tìm ngày tháng cụ thể của ngày thứ 256 năm đó theo lịch chính thức của Nga trong năm đó. Sau đó in nó ở định dạng dd.mm.yyyy, trong đó dd là ngày có hai chữ số, mm là tháng có hai chữ số và yyyy là y.

Ví dụ, đã cho = 1984. Năm 1984 chia hết cho 4, vì vậy nó là một năm nhuận. Ngày thứ 256 của một năm nhuận sau năm 1918 là ngày 12 tháng 9, vì vậy câu trả lời là 12.09.1984.

Mô tả:
    Hoàn thành hàm dayOfProgrammer trong trình chỉnh sửa bên dưới. Nó sẽ trả về một chuỗi đại diện cho ngày của ngày thứ 256 trong năm đã cho.

dayOfProgrammer có (các) tham số sau:
    - năm: một số nguyên

Định dạng đầu vào:
    Một số nguyên biểu thị năm y.


Định dạng đầu ra:
    In đầy đủ ngày của Ngày của Lập trình viên trong năm ở định dạng dd.mm.yyyy, trong đó dd là ngày có hai chữ số, mm là tháng có hai chữ số và yyy là.

    ................................... example 0 .....................................................

Đầu vào mẫu 0:
    2017
Đầu ra mẫu 0:
    13.09.2017
Giải thích 0:
Trong năm y = 2017, tháng 1 có 31 ngày, tháng 2 có 28 ngày, tháng 3 có 31 ngày, tháng 4 có 30 ngày, tháng 5 có 31 ngày, tháng 6 có 30 ngày, tháng 7 có 31 ngày và tháng 8 có 31 ngày. Khi cộng tổng số ngày trong tám tháng đầu tiên, chúng ta nhận được 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 = 243. Ngày của Lập trình viên là ngày thứ 256, vì vậy hãy tính 256 - 243 = 13 để xác định rằng nó rơi vào ngày 13 của tháng 9 (tháng 9). Sau đó, chúng tôi in ngày đầy đủ ở định dạng được chỉ định, đó là ngày 13.09.2017.
.   .................................. example 1 .....................................................
Đầu vào mẫu 1:
    2016
Đầu ra mẫu 1:
    12.09.2016
Giải thích 1:
Năm y = 2016 là năm nhuận, vì vậy tháng 2 có 29 ngày nhưng tất cả các tháng khác đều có cùng số ngày như năm 2017. Khi tính tổng số ngày trong tám tháng đầu tiên, chúng ta nhận được 31 + 29 + 31 + 30 + 31 + 30 + 31 + 31 = 244. Ngày Lập trình là ngày thứ 256 nên tính 256 - 244 = 12 để xác định nó rơi vào ngày 12 của tháng 9 (tháng 9). Sau đó, chúng tôi in ngày đầy đủ theo định dạng được chỉ định, đó là ngày 12.09.2016.

    ................................... example 2 .....................................................

Đầu vào mẫu 2:
    1800
Đầu ra mẫu 2:
    12.09.1800
Giải thích 2:
    Vì năm 1800 là năm nhuận theo lịch Julian. Ngày nằm vào ngày 12 tháng 9.
"""


# Complete the dayOfProgrammer function below.
def dayOfProgrammer(year):
    if (year == 1918):
        return '26.09.1918'
    elif ((year <= 1917) & (year % 4 == 0)) or (
            (year > 1918) & (year % 400 == 0 or ((year % 4 == 0) & (year % 100 != 0)))):
        return '12.09.%s' % year
    else:
        return '13.09.%s' % year


if __name__ == '__main__':
    year = int(input().strip())

    result = dayOfProgrammer(year)

    print(result)
