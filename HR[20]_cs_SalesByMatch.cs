using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Sales by Match ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/sock-merchant/problem?isFullScreen=false


 */

        static void Main(string[] args)
        {


            int sockMerchant(int n, int[] ar)
            {
                int sockNum = 0;

                List<int> pairOfSock = new List<int>();

                for(int i = 0; i < ar.Length; i++)
                {
                    if (!pairOfSock.Contains(ar[i]))
                    {
                        pairOfSock.Add(ar[i]);
                        sockNum += ar.Count(e => e == ar[i]) / 2;
                    }
                }

                return sockNum;
            }



            int n = Convert.ToInt32(Console.ReadLine());

            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
            ;
            int result = sockMerchant(n, ar);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
