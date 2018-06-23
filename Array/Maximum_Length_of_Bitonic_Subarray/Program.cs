using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Length_of_Bitonic_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 10, 20, 8, 9};
            int[] increasing_ = new int[input.Length];
            int[] decreasing_ = new int[input.Length];
            increasing_[0] = 1;
            decreasing_[input.Length - 1] = 1;
            for (int i = 1; i < input.Length; i++)
            {
                increasing_[i] = input[i - 1] < input[i]?  increasing_[i - 1] + 1:1;
            }
            for (int i = input.Length - 2; i >= 0; i--)
            {
                decreasing_[i] = input[i + 1] < input[i] ? decreasing_[i + 1] + 1 : 1;
            }

            int max = increasing_[0] + decreasing_[0] - 1;
            int current_val = max;
            for (int i = 1; i < input.Length - 1; i++)
            {
                current_val = increasing_[i] + decreasing_[i] - 1;
                if (current_val > max)
                    max = current_val;
            }

            Console.WriteLine("Maximum Bitonic Subarray Lenght: " + max);
            Console.Read();
        }
    }
}
