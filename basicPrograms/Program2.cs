using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicPrograms
{
    class Program2
    {    /*
         *Prints the pattern:    *
         *                      ***
         *                     *****
         *                    *******
         *                   *********
         *                   ...n lines
         */

        static void Main(string[] args)
        {
            Console.Write("Enter n:");
            int no_of_lines = Int32.Parse(Console.ReadLine());
            int no_of_space, no_of_star = 0, print_star;

            while (no_of_lines >= 0)
            {
                no_of_space = no_of_lines;
                while (no_of_space > 0)
                {
                    Console.Write(" ");
                    no_of_space--;
                }
                print_star = (2*no_of_star-1);
                while (print_star > 0)
                {
                    Console.Write("*");
                    print_star--;
                }

                no_of_star++;
                no_of_lines--;
                Console.Write("\n");
            }


            Console.ReadKey();
        }
    }
    
}
