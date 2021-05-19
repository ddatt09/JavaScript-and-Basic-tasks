using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Result
    {
        public static List<int> cutTheSticks(List<int> arr)
        {
            List<int> result = new List<int>() { arr.Count };
            arr.Sort();
            if (arr[0] == arr[arr.Count - 1]) return result;
            while (arr.Count > 1)
            {
                int minValue = arr.Min();
                arr = arr.Where(e => e != minValue).ToList();
                if (arr.Count == 0) return result;
                arr.ForEach(e => e -= minValue);
                result.Add(arr.Count);
            }

            return result;
        }
    }

    class Solution
    {

        /*
         https://www.hackerrank.com/challenges/cut-the-sticks/problem?isFullScreen=true
         
         */

        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> result = Result.cutTheSticks(arr);

            Console.WriteLine(String.Join("\n", result));
        }
    }
}



