using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Rotation
{
    class Program
    {
        public static void rotate(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                rotate_by_1(array);
            }
        }

        private static void rotate_by_1(int[] array)
        {
            int tmp = array[0];
            for (int i = 0; i < array.Length-1; i++)
            {
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = tmp;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 2, 3, 4, 5, 6, 7 };
            int rotation_count = 3;
            Console.WriteLine("Input Array: ");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            rotate(input, rotation_count);
            Console.WriteLine("\nArray after " + rotation_count + " rotations:");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            Console.ReadLine();
        }
    }
}
