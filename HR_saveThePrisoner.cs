using System;
using System.Linq;

namespace ConsoleApp1
{
    class Result
    {
        public static int saveThePrisoner(int n, int m, int s)
        {
            int surplus = s + m - 1;
            if (surplus > n) surplus = surplus - ((surplus / n) * n);
            if (surplus == 0) return n;
            return surplus;
        }
    }
   
    class Solution
    {

        /*
         https://www.hackerrank.com/challenges/save-the-prisoner/problem?isFullScreen=true
         
         */

        static void Main(string[] args)
        {


            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int n = Convert.ToInt32(firstMultipleInput[0]);

                int m = Convert.ToInt32(firstMultipleInput[1]);

                int s = Convert.ToInt32(firstMultipleInput[2]);

                int result = Result.saveThePrisoner(n, m, s);

                Console.WriteLine(result);
            }
        }
    }


}
