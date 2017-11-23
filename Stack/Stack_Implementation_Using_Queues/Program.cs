using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            my_stack_using_queues<int> my_stack = new my_stack_using_queues<int>();
            my_stack.push(10);
            my_stack.push(12);
            my_stack.push(14);
            my_stack.push(16);
            my_stack.push(18);
            my_stack.print_stack();
            my_stack.pop();
            my_stack.pop();
            my_stack.print_stack();
            Console.ReadKey();
        }
    }
}
