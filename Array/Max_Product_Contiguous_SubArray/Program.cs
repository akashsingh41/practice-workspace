using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Product_Contiguous_SubArray
{
    class Program
    {
        static int maxSubArray(int[] array)
        {
            int current_max = 1, max_yet=1;
            foreach (int x in array)
            {
                if (x == 0)
                    current_max = 1;
                else
                {
                    current_max = current_max * x;
                }

                if (max_yet < current_max)
                    max_yet = current_max;
            }
            return max_yet;
        }

        static void Main(string[] args)
        {
            int[] input = { 4,-8,-2,0,6,1};
            Console.WriteLine("Max Product of a Sub Array here can be:" + maxSubArray(input));
            Console.Read();
        }
    }
}
