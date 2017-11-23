using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_DLL
{
    class Program
    {
        static void Main(string[] args)
        {
            my_stack_class_using_dll<int> my_stack = new my_stack_class_using_dll<int>();
            
            my_stack.push(11);
            my_stack.push(22);
            my_stack.push(33);
            my_stack.push(44);
            my_stack.push(55);
            my_stack.push(66);
            my_stack.push(77);
            Console.WriteLine("Middle Element is " + my_stack.find_middle());
            Console.WriteLine("Item popped is " + my_stack.pop());
            Console.WriteLine("Item popped is " + my_stack.pop());
            Console.WriteLine("Middle Element is " + my_stack.find_middle());
            Console.ReadKey();
        }
    }
}
