using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            special_stack_class specialStack = new special_stack_class();
            specialStack.push(42);
            specialStack.push(56);
            Console.WriteLine("Minimum Value: "+specialStack.getMin());
            Console.WriteLine("Popped Value: " + specialStack.pop()) ;
            specialStack.push(32);
            specialStack.push(28);
            Console.WriteLine("Minimum Value: " + specialStack.getMin());
            Console.WriteLine("Popped Value: " + specialStack.pop());
            specialStack.push(64);
            Console.WriteLine("Minimum Value: " + specialStack.getMin());
            Console.WriteLine("Popped Value: " + specialStack.pop());
            specialStack.push(39);
            specialStack.push(42);
            Console.WriteLine("Minimum Value: " + specialStack.getMin());
            Console.WriteLine("Popped Value: " + specialStack.pop());
            Console.ReadKey();
        }
    }
}
