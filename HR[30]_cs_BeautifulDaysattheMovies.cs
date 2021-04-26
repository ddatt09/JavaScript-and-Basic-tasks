
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*............................. Beautiful Days at the Movies ...............................

        LINK :https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem?isFullScreen=true
        */

        static void Main(string[] args)
        {


            int beautifulDays(int i, int j, int k)
            {
                return Enumerable.Range(i, j - i + 1).Count(f => getDiffWithReverse(f) % k == 0);
            }

            int getDiffWithReverse(int i)
            {

                int r = 0;
                int n = i;
                while (n != 0)
                {
                    r = r * 10 + n % 10;
                    n /= 10;
                }
                return i - r;
            }



            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int i = Convert.ToInt32(firstMultipleInput[0]);

            int j = Convert.ToInt32(firstMultipleInput[1]);

            int k = Convert.ToInt32(firstMultipleInput[2]);

            int result = beautifulDays(i, j, k);

            Console.WriteLine(result);


            Console.ReadKey();
        }
    }
}
