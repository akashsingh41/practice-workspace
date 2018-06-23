using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Sum_For_i_Into_a_i__On_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 5, 6, 7, 8, 9, 1, 3, 4 };

            int array_sum = 0;
            int current_max_sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                array_sum += input[i];
                current_max_sum += i * input[i];
            }

            int max_val = current_max_sum;
            int rotation_number = 0;
            
            for (int j = 1; j < input.Length; j++)
            {
                current_max_sum += array_sum - input.Length * input[input.Length - j];

                if (current_max_sum > max_val)
                {
                    max_val = current_max_sum;
                    rotation_number = j;
                }
            }

            Console.WriteLine("The Maximum Value for Sum(i*a[i]) is " + max_val + " at rotation #" + rotation_number);
            Console.ReadLine();

        }
    }
}
