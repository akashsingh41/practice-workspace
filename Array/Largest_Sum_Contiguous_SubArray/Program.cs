using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Sum_Contiguous_SubArray
{
    class Program
    {
        static int kadaneAlgorithm(int[] array)
        {
            int max_so_far = default(int), max_ending_here = 0;

            foreach (int x in array)
            {
                max_ending_here = max_ending_here + x;

                if (max_ending_here < 0)
                    max_ending_here = 0;

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;
            }

            return max_so_far;
        }

        static void Main(string[] args)
        {
            int[] input = { -2, -3, 4, -1, -2, 1, 5, -3 };
            Console.WriteLine("Max Contiguous Subarray Sum = " + kadaneAlgorithm(input));
            Console.Read();
        }
    }
}
