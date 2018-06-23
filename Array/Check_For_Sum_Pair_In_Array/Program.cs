using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_For_Sum_Pair_In_Array
{
    class Program
    {
        static int findPivot(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = (low - 1);
            int temp;
            for (int j = low; j <= high - 1; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            temp = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp;

            return i + 1;
        }

        static void sort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pivot = findPivot(array, low, high);
                sort(array, low, pivot - 1);
                sort(array, pivot + 1, high);
            }
        }

        static bool CheckSumPair(int[] array, int sum)
        {
            sort(array,0,array.Length-1);
            int left, right;
            left = 0;
            right = array.Length - 1;

            while (left < right)
            {
                if (array[left] + array[right] == sum)
                    return true;
                else
                {
                    if (array[left] + array[right] < sum)
                        left++;
                    else
                        right--;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            int[] input = { 1, 4, 45, 6, 10, -8};
            int sum_key = 16;
            if (CheckSumPair(input, sum_key))
                Console.WriteLine("There is a pair in array that adds upto " + sum_key);
            else
                Console.WriteLine("No pair of elements found in array that adds upto " + sum_key);

            Console.ReadLine();
        }
    }
}
