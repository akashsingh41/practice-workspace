using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sequnce_of_integers
{
    class Program
    {
        static List<int> sequence(int n)
        {
            if (n == 1)
                return new List<int> { 1 };
            else
            {
                List<int> mid = new List<int>();
                mid.Add(n);
                return sequence(n - 1).Concat(mid).Concat(sequence(n - 1)).ToList<int>();
            }
        }

        static void Main(string[] args)
        {
            int[] inputs = Console.ReadLine().Split(' ').Select(x=>int.Parse(x)).ToArray();
            int n = inputs[0];
            int k = inputs[1];
            Console.WriteLine(sequence(n)[k-1]);
            Console.ReadLine();
         }
    }
}
