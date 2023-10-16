using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Compute_sum_of_3_given_integer
{
    internal class Program
    {
        static int SumOrThird(int a, int b, int c)
        {
            if (a == b)
            {
                return c;
            }
            else if (b == c)
            {
                return a;
            }
            else
            {
                return a + b + c;
            }
        }
        static void Main(string[] args)
        {
            int[,] testCases = {
            {4, 5, 7},
            {7, 4, 12},
            {10, 10, 12},
            {12, 12, 18}
        };

            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                int a = testCases[i, 0];
                int b = testCases[i, 1];
                int c = testCases[i, 2];

                int result = SumOrThird(a, b, c);
                Console.WriteLine(result);
                Console.ReadLine();
            }   }
    }
}
