using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tower_of_Hanoi
{
    class Program
    {
        static void moveTower(int height, char fromPole, char toPole, char auxPole)
        {
            if (height == 1)
            {
                Console.WriteLine("Move disk 1 from rod " + fromPole + " to rod " + toPole);
                return;
            }
            moveTower(height - 1, fromPole, auxPole, toPole);
            Console.WriteLine("Move disk " + height + " from pole " + fromPole + " to pole " + toPole);
            moveTower(height - 1, auxPole, toPole, fromPole);
        }

        static void Main(string[] args)
        {
            int n = 3;
            moveTower(n, 'A', 'C', 'B');
            Console.ReadLine();

        }
    }
}
