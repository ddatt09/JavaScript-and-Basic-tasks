using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................ PLUS MINUS .................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/plus-minus/problem?isFullScreen=true

Cho một mảng các số nguyên, hãy tính tỷ lệ các phần tử dương, âm và 0 của nó. In giá trị thập phân của mỗi phân số trên một dòng mới với các vị trí sau số thập phân.
Lưu ý: Thử thách này giới thiệu các vấn đề về độ chính xác. Các trường hợp thử nghiệm được chia tỷ lệ đến 6 chữ số thập phân, mặc dù các câu trả lời có sai số tuyệt đối lên đến 10^(-4) vẫn sẽ được chấp nhận.

EXAMPLE:
    arr = [1, 1, 0, -1, -1]
    Có n = 5 các phần tử, hai dương, hai âm và một không. Tỷ lệ của chúng là 2/5 = 0.400000, 2/5 = 0.400000 và 1/5 = 0.200000. Kết quả được in dưới dạng:
    0,400000
    0,400000
    0,200000

FUNCTION DESCRIPTION:
    Hoàn thành chức năng plusMinus trong trình chỉnh sửa bên dưới.
    plusMinus có (các) tham số sau:
    int arr [n]: một mảng các số nguyên

OUTPUT EXPECT:
    In ra tỷ lệ các giá trị dương, âm và 0 trong mảng. Mỗi giá trị phải được in trên một dòng riêng biệt với các chữ số sau phần thập phân. Hàm không được trả về giá trị.

INPUT FORMAT:
    Dòng đầu tiên chứa một số nguyên, kích thước của mảng.
    Dòng thứ hai chứa các số nguyên được phân tách bằng dấu cách mô tả.

CONSTRAINTS:
    0 < n <= 100
    -100 <= arr[i] <= 100

OUTPUT FORMAT:

    In ra các dòng sau, mỗi dòng có 1 số thập phân:
        tỷ lệ giá trị dương
        tỷ lệ các giá trị âm
        tỷ lệ số không

SAMPLE INPUT:
    STDIN           Function
    -----           --------
    6               arr[] size n = 6
    -4 3 -9 0 4 1   arr = [-4, 3, -9, 0, 4, 1]

SAMPLE OUTPUT:
    0,500000
    0,333333
    0,166667

EXPLANATION:
    Có 3 số dương, 2 số âm và 1 số 0 trong mảng.
    Tỷ lệ xuất hiện số dương:3/6 = 0.500000, âm:2/6 = 0.333333 và số không:1/6 = 0.166667.
                */

        static void Main(string[] args)
        {

            void plusMinus(int[] arr)
            {
                decimal positiveNum = 0M;
                decimal negativeNum = 0M;
                decimal zeroNum = 0M;
                int lenOfarr = arr.Length;
                for(int i = 0; i < lenOfarr; i++)
                {
                    if (arr[i] > 0) positiveNum += 1;
                    if (arr[i] < 0) negativeNum += 1;
                    if (arr[i] == 0) zeroNum += 1;
                }

                positiveNum = Math.Round(positiveNum/ lenOfarr,6);
                negativeNum = Math.Round(negativeNum / lenOfarr,6);
                zeroNum = Math.Round(zeroNum / lenOfarr,6);

                Console.WriteLine($"{positiveNum.ToString("N6")}\n{negativeNum.ToString("N6")}\n{zeroNum.ToString("N6")}");
            }

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);

            Console.ReadKey();
        }
    }
}
