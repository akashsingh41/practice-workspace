using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation_Using_Reverse
{
    class Program
    {
        public static void rotate(int[] array, int n)
        {
            Array.Reverse(array, 0, n);
            Array.Reverse(array, n, (array.Length - n));
            Array.Reverse(array);
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7 };
            rotate(input, 2);
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
