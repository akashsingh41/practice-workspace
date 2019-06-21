using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryMatrix
{
    class BinaryMatrix
    {
        static void Main()
        {
            string[] dimension = Console.ReadLine().Split(' ');
            int n = Int32.Parse(dimension[0]);
            int m = Int32.Parse(dimension[1]);
            int[] decimal_value = new int[n];

            for (int i = 0; i < n; i++)
            {
                string binary = Console.ReadLine();
                 
                for (int j = 0; j<m; j++)
                {
                    decimal_value[i] += (int)(Math.Pow(2,(m-j-1))) * Convert.ToInt32(binary[j].ToString());
                }
            }

            int max_value = -1;
            int max_column = 0;

            for (int z = 0; z < n; z++)
            {
                if (decimal_value[z] > max_value)
                {
                    max_value = decimal_value[z];
                    max_column = z;
                }
            }

            Console.Write(max_column+1);
        }
    }
}