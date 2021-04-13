using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        /*
................................................. Designer PDF Viewer ....................................................

LINK ORIGIN: https://www.hackerrank.com/challenges/designer-pdf-viewer/problem


 */

        static void Main(string[] args)
        {


            int designerPdfViewer(int[] h, string word)
            {
                string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
                int maxHeightCharacterOfWord = h[Array.IndexOf(alphabet, word.Substring(0, 1))];
                for (int i = 0; i < word.Length; i++)
                {
                    if (h[Array.IndexOf(alphabet, word.Substring(i, 1))] > maxHeightCharacterOfWord) maxHeightCharacterOfWord = h[Array.IndexOf(alphabet, word.Substring(i, 1))];
                }

                return maxHeightCharacterOfWord * word.Length;
            }


            int[] h = Array.ConvertAll(Console.ReadLine().Split(' '), hTemp => Convert.ToInt32(hTemp));
            string word = Console.ReadLine();

            int result = designerPdfViewer(h, word);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
