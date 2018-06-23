using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorted_Subsequence_ofSize3
{
    class Program
    {
        static void find3Subsequence(int[] array)
        {
            int left = 0, right = array.Length - 1;

            int[] smaller = new int[array.Length];
            smaller[0] = -1;
            for (int i = 1; i < array.Length - 1; i++)
            { 
                if (array[i] <= array[left])
                {
                    left = i;
                    smaller[i] = -1;
                }
                else
                    smaller[i] = left;
            }

            int[] greater = new int[array.Length];
            greater[right - 1] = -1;  
            for (int i = right-1; i >= 0; i--)
            {
                if (array[i] >= array[right])
                {
                    right = i;
                    greater[i] = -1;
                }
                else
                    greater[i] = right;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (smaller[i] != -1 && greater[i] != -1)
                {
                    Console.WriteLine(array[smaller[i]] + " " + array[i] + " " + array[greater[i]]);
                    return;
                }
                
            }

            // If we reach number, then there are no such 3 numbers
            Console.WriteLine("No such triplet found");
            return;
        }


        static void Main(string[] args)
        {
            int[] input = { 12, 3, 10, 5, 6, 2, 11, 30 };
            find3Subsequence(input);
            Console.Read();
        }
    }
}
