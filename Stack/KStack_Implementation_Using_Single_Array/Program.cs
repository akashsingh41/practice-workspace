using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KStack_Implementation_Using_Single_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 3, n = 10;

            my_kstack_class ks = new my_kstack_class(k, n);

            ks.push(15, 2);
            ks.push(45, 2);
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            // Let us put some items in stack number 1
            ks.push(17, 1);
            ks.push(49, 1);
            ks.push(39, 1);
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            // Let us put some items in stack number 0
            ks.push(11, 0);
            ks.push(9, 0);
            ks.push(7, 0);
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            Console.WriteLine("Popped element from stack 2 is " + ks.pop(2));
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            Console.WriteLine("Popped element from stack 1 is " + ks.pop(1));
            ks.push(38, 1);
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            Console.WriteLine("Popped element from stack 0 is " + ks.pop(0));
            Console.WriteLine("KStack looks like:");
            ks.print_kstack();
            Console.ReadKey();

        }
    }
}
