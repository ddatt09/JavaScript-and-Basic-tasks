
"""
................................................. Grading Students ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/grading/problem?isFullScreen=true

Đại học HackerLand có chính sách chấm điểm sau:

Mỗi học sinh nhận được một số điểm từ 0 đến 100.
Bất kỳ điểm nào ít hơn 40 là một điểm trượt.
Sam là một giáo sư tại trường đại học và thích làm tròn mỗi sinh viên theo các quy tắc sau:

Nếu hiệu giữa điểm và bội số tiếp theo của 5, nhỏ hơn 3, hãy làm tròn đến bội số tiếp theo của 5.
Nếu điểm nhỏ hơn 38, không có sự làm tròn nào xảy ra vì kết quả vẫn là điểm không đạt.

VÍ DỤ:
     grade = 84, làm tròn đến 85 (85 - 84 nhỏ hơn 3)
     grade = 29, không làm tròn (kết quả nhỏ hơn 40)
     grade = 57, không làm tròn (60 - 57 là 3 hoặc cao hơn)
    Với giá trị ban đầu của mỗi học sinh của Sam, hãy viết mã để tự động hóa quá trình làm tròn.

MÔ TẢ:
    Hoàn thành phân loại chức năng Học viên trong trình chỉnh sửa bên dưới.
    Học sinh có (các) tham số sau:
    int Grade [n]: điểm trước khi làm tròn

KẾT QUẢ TRẢ VỀ:
    int [n]: điểm sau khi làm tròn nếu thích hợp

ĐỊNH DẠNG INPUT:
    Dòng đầu tiên chứa một số nguyên duy nhất, n số học sinh.
    Mỗi dòng i của n các dòng tiếp theo chứa một số nguyên duy nhất, grade[i].

ĐIỀU KIỆN RÀNG BUỘC:
    1 <= n <= 60
    0 <= grade[i] <= 10

VÍ DỤ MẪU 0:
    4
    73
    67
    38
    33
KẾT QUẢ MẪU 0:
    75
    67
    40
    33
GIẢI TRÌNH MẪU 0:
    ID      Origin Grade      Final Grade
    ------------------------------------------
    1           73                  75
    2           67                  67
    3           38                  40
    4           33                  33
"""

def gradingStudents(grades):
    finalGrades = []
    
    # nearest_multiple = base * round(a_number/base)

    for i in range(len(grades)):
        if grades[i] < 38:
            finalGrades.append(grades[i])
        else:
            nearest_multiple = 5 * round(grades[i] / 5)
            if nearest_multiple - grades[i] > 0 and nearest_multiple - grades[i] < 3:
                finalGrades.append(nearest_multiple)
            else:
                finalGrades.append(grades[i])

    return finalGrades


if __name__ == '__main__':

    grades_count = int(input().strip())

    grades = []

    for _ in range(grades_count):
        grades_item = int(input().strip())
        grades.append(grades_item)

    result = gradingStudents(grades)

    print('\n'.join(map(str, result)))
