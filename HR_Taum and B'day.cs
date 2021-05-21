using System;
using System.Collections.Generic;
using System.Linq;
/*
 To do: - HackerRank
        - Bài thi vòng loại số 2 slide -> pdf
        - https://learn.unity.com/pathway/unity-essentials?fbclid=IwAR2B1xlnyxMYr9FwMSEtL6mkxF7Y-ZVgqfecjrxZW_BnjLQEESpL56DSZGE&signup=true
        - My Team Gaming
        - luyện kiến thức của Hào
 */

namespace ConsoleApp1
{
    class Result
    {
        public static long taumBday(long b, long w, long bc, long wc, long z)
        {
           return b * Math.Min(bc, wc + z) + w * Math.Min(wc, bc + z);
        }
    }

    class Solution
    {

        /*
        https://www.hackerrank.com/challenges/taum-and-bday/problem?isFullScreen=true
         
         */

        static void Main(string[] args)
        {


            int t = Convert.ToInt32(Console.ReadLine().Trim());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int b = Convert.ToInt32(firstMultipleInput[0]);

                int w = Convert.ToInt32(firstMultipleInput[1]);

                string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

                int bc = Convert.ToInt32(secondMultipleInput[0]);

                int wc = Convert.ToInt32(secondMultipleInput[1]);

                int z = Convert.ToInt32(secondMultipleInput[2]);

                long result = Result.taumBday(b, w, bc, wc, z);

                Console.WriteLine(result);
            }
        }
    }
}



