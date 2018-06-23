using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Array_In_Wave_Form
{
    class Program
    {
        static void swap(int[] array, int x, int y)
        {
            int t=0;
            t = array[x];
            array[x] = array[y];
            array[y] = t;
        }

        static void Main(string[] args)
        {
            int[] input = { 2, 5, 7, 3, 1, 9 };
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }

            for (int i = 0; i < input.Length; i += 2)
            {
                if (((i - 1) >= 0) &&(input[i - 1] > input[i]))
                    swap(input, i - 1, i);

                if ((i + 1 < input.Length) && (input[i + 1] > input[i]))
                    swap(input, i + 1, i);
            }
            Console.WriteLine("After Rearrangement: ");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }

            Console.Read();
        }
    }
}
