using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Segregation_left_to_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 0, 0, 1, 0, 1, 0, 1, 0 };

            int left = 0, right = input.Length - 1;
            Array.Sort(input);
            while (left < right)
            {
                while (input[left] == 0 && left < right)
                {
                    left++;
                }
                while (input[right] == 1 && left < right)
                {
                    right--;
                }

                if (left < right)
                {
                    input[left] = 0;
                    input[right] = 1;
                    left++; right--;
                }
            }

            Console.WriteLine("Array after segregation: ");
            foreach (int x in input)
            {
                Console.Write(x+" ");
            }
            Console.Read();

        }
    }
}
