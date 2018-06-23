using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            my_stack_using_array ts = new my_stack_using_array(5);
            ts.push_stack_1(5);
            ts.push_stack_2(10);
            ts.push_stack_2(15);
            ts.push_stack_1(11);
            ts.push_stack_2(7);
            Console.WriteLine("Popped element from" +
                               " stack1 is " + ts.pop_stack_1());
            ts.push_stack_2(40);
            Console.WriteLine("Popped element from" +
                             " stack2 is " + ts.pop_stack_2());
            Console.ReadKey();
        }
    }
}
