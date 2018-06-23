using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range_Partitioning_OF_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 14, 5, 20, 4, 2, 54, 20, 87, 98, 3, 1, 32 };
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            Console.WriteLine("\n");
            int left = 10;
            int right = 30;
            int start = 0, end = input.Length - 1;
            for (int i = 0; i < end;)
            {
                if (input[i] < left)
                {
                    int t = input[start];
                    input[start] = input[i];
                    input[i] = t;
                    start++; i++;
                }
                else if (input[i] > right)
                {
                    int t = input[end];
                    input[end] = input[i];
                    input[i] = t;
                    end--;
                }
                else i++;
            }

            foreach (int x in input)
            {
                Console.Write(x+" ");
            }

            Console.Read();
        }
    }
}
