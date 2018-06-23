using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Element_In_Sorted_Rotated_Array
{
    class Program
    {
        public static int Search(int[] input, int left, int right, int searchKey)
        {

            if (left > right)
                return -1;

            int mid = (left + right) / 2;

            if (input[mid] == searchKey)
                return mid;

            /* If input[left...mid] is sorted */
            if (input[left] <= input[mid])
            {
                /* As this subarray is sorted, we 
                   can quickly check if key lies in 
                   half or other half */
                if (searchKey >= input[left] && searchKey <= input[mid])
                    return Search(input, left, mid - 1, searchKey);
                else
                return Search(input, mid + 1, right, searchKey);
            }

            /* If arr[l..mid] is not sorted, 
               then arr[mid... r] must be sorted*/
            if (searchKey >= input[mid] && searchKey <= input[right])
                return Search(input, mid + 1, right, searchKey);

            return Search(input, left, mid - 1, searchKey);
        }



        static void Main(string[] args)
        {
            int[] input_array = { 5, 6, 7, 8, 9, 10, 1, 2, 3 };
            int key = 9;
            Console.WriteLine("Index: "+ Search(input_array, 0, input_array.Length-1, key));
            Console.Read();
        }
    }
}
