using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_An_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 6, 8, 4, 7, 9, 2, 5 };
            Console.WriteLine("\nInput Array");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            int start = 0;
            int end = input.Length - 1;
            int temp=0;
            while (start < end)
            {
                temp = input[start];
                input[start] = input[end];
                input[end] = temp;
                start++;
                end--;
            }

            Console.WriteLine("\nReverse Array");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            Console.Read();
        }
    }
}
