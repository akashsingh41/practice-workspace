using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AugustCircuit_PicuBank
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_cases = int.Parse(Console.ReadLine());
            while (test_cases > 0)
            {
                int[] input = Console.ReadLine().Trim().Split(' ').Select(x=>int.Parse(x)).ToArray();
                int D = input[0];
                int A = input[1];
                int M = input[2];
                int B = input[3];
                int X = input[4];

                int m = (X - D) / (A + (B / M));
                int n = m / M;

 
                //int counter = 0, sum = D;
                //while (true)
                //{
                //    if (sum >= X)
                //        break;

                //    if (counter%M != 0)
                //        sum += A;
                //    else
                //        sum += B;

                //    counter++;               
                //}

                Console.WriteLine(m+n);
                test_cases--;
            }
            //Console.ReadLine();
        }
    }
}
