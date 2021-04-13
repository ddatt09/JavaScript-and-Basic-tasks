using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Angry Professor ....................................................

TASK LINK: https://www.hackerrank.com/challenges/angry-professor/problem?isFullScreen=false


 */

        static void Main(string[] args)
        {


            string angryProfessor(int k, int[] a)
            {
                int[] classMem = a.Where(e => e <= 0).ToArray();

                if (classMem.Length < k) return "YES";
                return "NO";

            }


            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp))
                ;
                string result = angryProfessor(k, a);

                Console.WriteLine(result);
            }

            Console.ReadKey();
        }
    }
}
