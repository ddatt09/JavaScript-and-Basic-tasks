using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Sequence Equation ....................................................

TASK LINK: https://www.hackerrank.com/challenges/permutation-equation/problem


 */

        static void Main(string[] args)
        {


            int[] permutationEquation(int[] p)
            {
                int[] result = { };
                int x = 0;

                for (int i = 0; i < p.Length; i++)
                {
                    x += 1;
                    int a = Array.IndexOf(p, x) + 1;
                    int b = Array.IndexOf(p, a);
                    result = result.Concat(new int[] { b + 1 }).ToArray();
                }

                return result;
            }


            int n = Convert.ToInt32(Console.ReadLine());

            int[] p = Array.ConvertAll(Console.ReadLine().Split(' '), pTemp => Convert.ToInt32(pTemp))
            ;
            int[] result = permutationEquation(p);

            Console.WriteLine(string.Join("\n", result));

            Console.ReadKey();
        }
    }
}
