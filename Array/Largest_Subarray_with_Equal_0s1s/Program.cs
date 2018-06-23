using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Subarray_with_Equal_0s1s
{
    class Program
    {
        static void longestSubArray(int[] array)
        {
            int sum = 0, maxSize = -1, start = 0, end = 0;
            for (int i = 0; i < array.Length-1; i++)
            {
                sum = (array[i] == 0) ? -1 : 1;

                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == 0)
                        sum += -1;
                    else
                        sum += 1;

                    // If this is a 0 sum subarray, then 
                    // compare it with maximum size subarray
                    // calculated so far
                    if (sum == 0 && maxSize < j - i + 1)
                    {
                        maxSize = j - i + 1;
                        start = i;
                    }
                }
            }
            end = start + maxSize - 1;

            if (maxSize == -1)
                Console.WriteLine("No such SubArray");
            else
                Console.WriteLine(start + " to " + end);

            Console.WriteLine("Length = "+ maxSize);
        }

        static void Main(string[] args)
        {
            int[] input = { 0, 1, 1, 0, 0, 1, 0 };
            longestSubArray(input);
            Console.Read();
        }
    }
}
