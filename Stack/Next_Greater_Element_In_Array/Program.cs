using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Next_Greater_Element_In_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 13, 6, 8, 7, 14 };
            int[] next_greater = new int[input.Length];

            for (int x = 0; x < input.Length; x++) 
            {
                if (x == input.Length - 1)
                {
                    next_greater[x] = -1;
                }
                else
                    for (int i = x + 1; i < input.Length; i++)
                    {
                        if (input[x] >= input[i])
                        {
                            next_greater[x] = -1;
                        }
                        else
                        {
                            next_greater[x] = input[i];
                            break;
                        }
                    }
            }
            if (next_greater.Length > 0)
            {
                foreach (int x in next_greater)
                    Console.Write(x + " ");
            }

            Console.ReadKey();
        }
    }
}
