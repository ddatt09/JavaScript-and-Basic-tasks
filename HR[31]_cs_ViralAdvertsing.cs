using System;

namespace ConsoleApp1
{
    class Program
    {
        /*............................. Viral Advertising ...............................

        LINK :https://www.hackerrank.com/challenges/strange-advertising/problem
        */

        static void Main(string[] args)
        {


            int viralAdvertising(int n)
            {

                int Shared = 0;
                int Liked = 0;
                int Cumulative = 0;


                for (int i = 0; i < n; i++)
                {
                    if (i == 0) Shared = 5;
                    else Shared = Liked * 3;

                    Liked = Shared / 2;
                    Cumulative += Liked;

                }

                return Cumulative;
            }


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            int result = viralAdvertising(n);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
