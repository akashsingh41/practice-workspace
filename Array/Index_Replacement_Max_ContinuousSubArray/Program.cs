using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_Replacement_Max_ContinuousSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 1, 0, 0, 1, 0, 1, 1, 1, 0, 1, 1, 1 };

            foreach (int x in input)
                Console.Write(x + " ");
            Console.WriteLine();
            int current_index=0, previous_zero=-1, previous_2_zero=-1;
            int max_diff = 0, max_index = 0;

            for (current_index = 0; current_index < input.Length; current_index++)
            {
                if (input[current_index] == 0)
                {
                    if ((current_index - previous_2_zero) > max_diff)
                    {
                        max_diff = current_index - previous_2_zero;
                        max_index = previous_zero;
                    }
                    previous_2_zero = previous_zero;
                    previous_zero = current_index;
                 }
            }
            if (input.Length - previous_2_zero > max_diff)
                max_index = previous_zero;

            Console.WriteLine("Index: " + max_index);
            Console.Read();
        }
    }
}
