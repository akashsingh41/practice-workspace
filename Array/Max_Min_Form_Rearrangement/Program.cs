using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Min_Form_Rearrangement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1,2, 3,4, 5,6, 7,8, 9,11 };
            int start = 0, end = input.Length - 1;

            int[] output = new int[input.Length];

            int i = 0;
            while (start <= end)
            {
                output[i] = input[end];
                if (i + 1 < input.Length) 
                    output[i+1] = input[start];

                i += 2;
                end--;
                start++;
            }

            foreach(int x in output)
            Console.Write(x + "");

            Console.Read();

        }
    }
}
