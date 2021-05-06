using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /**
         * 
         * https://www.hackerrank.com/challenges/electronics-shop/problem
         * 
         */
        static void Main(string[] args)
        {
            int getMoneySpent(int[] keyboards, int[] drives, int b)
            {
                Array.Sort(keyboards);
                Array.Sort(drives);
                int result = -1;
                for (int i = 0; i < keyboards.Length; i++)
                {
                    if (keyboards[i] < b)
                    {
                        for (int j = 0; j < drives.Length; j++)
                        {
                            if (drives[j] < b)
                            {
                                int sum = keyboards[i] + drives[j];
                                if (sum > b) break;
                                result = Math.Max(result, sum);
                            }
                        }
                    }
                }

                return result;
            }

            string[] bnm = Console.ReadLine().Split(' ');

            int b = Convert.ToInt32(bnm[0]);

            int n = Convert.ToInt32(bnm[1]);

            int m = Convert.ToInt32(bnm[2]);

            int[] keyboards = Array.ConvertAll(Console.ReadLine().Split(' '),
                    keyboardsTemp => Convert.ToInt32(keyboardsTemp))
                ;

            int[] drives = Array.ConvertAll(Console.ReadLine().Split(' '), drivesTemp => Convert.ToInt32(drivesTemp))
                ;
            /*
             * The maximum amount of money she can spend on a keyboard and USB drive, or -1 if she can't purchase both items
             */

            int moneySpent = getMoneySpent(keyboards, drives, b);

            Console.WriteLine(moneySpent);

            Console.ReadKey();
        }
    }
}
