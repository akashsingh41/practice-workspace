using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotation_Count_Of_Array
{
    class Program
    {
        static int RotationCount(int[] array, int left, int right)
        {
            if (right < left)
                return -1;
            if (left == right)
                return left;
            int middle = (left + right) / 2;

            if (middle > left && array[middle] < array[middle - 1])
                return middle;

            if (middle < right && array[middle] > array[middle + 1])
                return (middle + 1);

            if (array[right] > array[middle])
                return RotationCount(array, left, middle - 1);
            else
                return RotationCount(array, middle + 1, right);

        }
        static void Main(string[] args)
        {
            int[] input = { 4, 5, 6, 7, 1, 2, 3 };
            Console.WriteLine("Count of Rotation is: " + RotationCount(input, 0, input.Length - 1));
            Console.ReadKey();
        }
    }
}
