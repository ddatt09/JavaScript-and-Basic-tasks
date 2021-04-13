using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. The Hurdle Race ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/the-hurdle-race/problem


 */

        static void Main(string[] args)
        {


            int hurdleRace(int k, int[] height)
            {
                int maxHeightOfHurdle = height.Max();

                if (k >= maxHeightOfHurdle) return 0;

                return maxHeightOfHurdle - k;

            }



            string[] nk = Console.ReadLine().Split(' ');

            int n = Convert.ToInt32(nk[0]);

            int k = Convert.ToInt32(nk[1]);

            int[] height = Array.ConvertAll(Console.ReadLine().Split(' '), heightTemp => Convert.ToInt32(heightTemp))
            ;
            int result = hurdleRace(k, height);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
