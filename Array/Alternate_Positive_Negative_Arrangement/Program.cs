using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alternate_Positive_Negative_Arrangement
{
    class Program
    {
        static void rearrange(int[] array)
        {
            int i = -1;
            int temp = 0;
            for (int x = 0; x < array.Length - 1; x++)
            {
                
                if (array[x] < 0)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[x];
                    array[x] = temp;
                }
            }

            int positive_index = i + 1;
            int negative_index = 0;

            while (positive_index < array.Length && negative_index < positive_index && array[negative_index] < 0)
            {
                temp = array[negative_index];
                array[negative_index] = array[positive_index];
                array[positive_index] = temp;
                positive_index++;
                negative_index++;
                negative_index++;
            }
        }
        static void Main(string[] args)
        {
            int[] input = { -1, 2, -3, 4, 5, 6, -7, 8, 9 };
            Console.WriteLine("Before Rearrangement: ");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }
            rearrange(input);
            Console.WriteLine("\nAfter Rearrangement: ");
            foreach (int x in input)
            {
                Console.Write(x + " ");
            }

            Console.ReadLine();

        }
    }
}
