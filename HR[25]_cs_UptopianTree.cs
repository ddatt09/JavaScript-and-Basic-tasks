using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Utopian Tree ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/utopian-tree/problem


 */

        static void Main(string[] args)
        {


            int utopianTree(int n)
            {
                if (n == 0) return 1;

                int originHeight = 1;
                for(int i=0;i< n; i++)
                {
                    if (i % 2 == 0)
                    {
                        originHeight = originHeight * 2;
                    }
                    if (i % 2 != 0)
                    {
                        originHeight += 1;
                    }
                }

                return originHeight;
            }


            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                int n =  Convert.ToInt32(Console.ReadLine());

                int result = utopianTree(n);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
