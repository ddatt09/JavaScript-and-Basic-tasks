
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Cats and a Mouse ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/cats-and-a-mouse/problem?isFullScreen=false


 */

        static void Main(string[] args)
        {


            string catAndMouse(int x, int y, int z)
            {
                int distanceXandZ = Math.Abs(x-z);
                int distanceYandZ = Math.Abs(y - z);

                if (distanceXandZ == distanceYandZ) return "Mouse C";
                if (distanceXandZ > distanceYandZ) return "Cat B";

                return "Cat A";
            }



            int q = Convert.ToInt32(Console.ReadLine());

            for (int qItr = 0; qItr < q; qItr++)
            {
                string[] xyz = Console.ReadLine().Split(' ');

                int x = Convert.ToInt32(xyz[0]);

                int y = Convert.ToInt32(xyz[1]);

                int z = Convert.ToInt32(xyz[2]);

                string result = catAndMouse(x, y, z);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
