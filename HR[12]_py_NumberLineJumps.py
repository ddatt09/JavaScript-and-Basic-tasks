
"""
................................................. Number Line Jumps ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/kangaroo/problem?isFullScreen=true

Bạn đang biên đạo một chương trình xiếc với nhiều loài động vật khác nhau. Đối với một hành động, bạn có hai con chuột túi trên một dãy số sẵn sàng nhảy theo chiều dương (tức là về phía dương vô cùng).

Con kangaroo đầu tiên bắt đầu tại vị trí x1 và di chuyển với tốc độ v1 mét mỗi lần nhảy.
Con kangaroo thứ hai bắt đầu tại vị trí x2 và di chuyển với tốc độ v2 mét mỗi lần nhảy.
Bạn phải tìm ra cách để chương trình đưa cả hai con kanguru ở cùng một địa điểm vào cùng một thời điểm. Nếu có thể, hãy trả về YES, nếu không thì trả lại NO.

VÍ DỤ:
    x1 = 2
    v1 = 1
    x2 = 1
    v1 = 2
    Sau một lần nhảy, cả hai đều ở x = 3, (x1 + v1 = 2 + 1, x2 + v2 = 1 +2), vì vậy câu trả lời là YES.

MÔ TẢ:
    Hoàn thành hàm kangaroo trong trình chỉnh sửa bên dưới.
    kangaroo có (các) tham số sau:
    int x1, int v1: vị trí bắt đầu và khoảng cách nhảy cho kangaroo 1
    int x2, int v2: vị trí bắt đầu và khoảng cách nhảy cho kangaroo 2

KẾT QUẢ TRẢ VỀ:
    string: YES hoặc NO

ĐỊNH DẠNG CỦA INPUT:
    Một dòng duy nhất gồm bốn số nguyên được phân tách bằng dấu cách biểu thị các giá trị tương ứng của x1, v1, x2 và v2.

RÀNG BUỘC:
    0 <= x1 < x2 <= 10000
    1 <= v1, v2 <= 10000

VÍ DỤ MẪU 0:
    0 3 4 2
ĐẦU RA MẪU 0:
    YES
GIẢI TRÌNH:
    Hai con chuột túi nhảy qua chuỗi địa điểm sau:
    hình ảnh...

Từ hình ảnh, rõ ràng là các con kanguru gặp nhau ở cùng một vị trí (số 12 trên trục số) sau cùng một số lần nhảy (4 lần nhảy), và kết quả trả về là YES.

VÍ DỤ MẪU 1:
    0 2 5 3
ĐẦU RA MẪU 0:
    NO
GIẢI TRÌNH:
    Con chuột túi thứ hai có vị trí xuất phát ở phía trước (xa hơn về bên phải) vị trí xuất phát của con chuột túi thứ nhất (tức là x1 >x2). Bởi vì con kangaroo thứ hai di chuyển với tốc độ nhanh hơn (có nghĩa là v2 > v1) và đã đi trước con kangaroo đầu tiên, con kangaroo đầu tiên sẽ không bao giờ có thể đuổi kịp. Do đó,kết quả sẽ là NO.
"""

# !/bin/python3


# Complete the kangaroo function below.
print(1.3 % 1 == 0)
print(1 % 3)
print(type(10 // 3) == int)


def kangaroo(x1, v1, x2, v2):
    if x1 >= x2 and v1 > v2: return "NO"
    if x2 >= x1 and v2 > v1: return "NO"
    if x2 < x1 and v2 == v1: return "NO"
    if x2 > x1 and v2 == v1: return "NO"
    if (x1 - x2) % (v2 - v1) == 0 and ((x1 - x2) / (v2 - v1)) % 1 == 0 and (x1 - x2) / (v2 - v1) > 0: return "YES"
    return "NO"


if __name__ == '__main__':
    x1V1X2V2 = input().split()

    x1 = int(x1V1X2V2[0])

    v1 = int(x1V1X2V2[1])

    x2 = int(x1V1X2V2[2])

    v2 = int(x1V1X2V2[3])

    result = kangaroo(x1, v1, x2, v2)

    print(result)
