using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sum_of_Consecutive_Differences
{
    class Program
    {
        static int maxSum(int[] array)
        {
            int sum = 0;

            // Sorting the array.
            Array.Sort(array);

            for (int i = 0; i < array.Length / 2; i++)
            {
                sum -= (2 * array[i]);
                sum += (2 * array[array.Length - i - 1]);
            }

            return sum;
        }

        static void Main(string[] args)
        {
            int[] input = { 4, 2, 1, 5, 8 };
            Console.WriteLine("Max Sum: " + maxSum(input));
            Console.Read();
        }
    }
}
