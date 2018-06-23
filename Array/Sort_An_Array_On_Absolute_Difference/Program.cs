using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_An_Array_On_Absolute_Difference
{
    class Program
    {
        static int[] SortedArray(int[] array, int d)
        {
            Dictionary<int, int> diffTable = new Dictionary<int, int>();
            foreach (int x in array)
            {
                diffTable.Add(Math.Abs(d - x), x);
            }

            var keyList = from pair in diffTable
                            orderby pair.Key ascending
                    select pair.Value;
            int i = 0;
            foreach (int x in keyList)
            {
                array[i] = x;
                i++;
            }

            return array;
        }

        static void Main(string[] args)
        {
            int[] input = { 10, 5, 3, 2 };
            foreach (int x in input)
                Console.Write(x + " ");

            int d = 7;
            int[] abs_sorted_array = SortedArray(input, d);
            Console.WriteLine("Sorted Array:");
            foreach(int x in input)
            Console.Write(x + " ");
            Console.Read();

        }
    }
}
