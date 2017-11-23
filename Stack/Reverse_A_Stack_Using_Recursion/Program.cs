using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_A_Stack_Using_Recursion
{
    class Program
    {
        static Stack<int> operation_stack = new Stack<int>();
        public static void insertAtBottom(int x)
        {
            if (operation_stack.Count == 0)
                operation_stack.Push(x);
            else
            {
                int a = operation_stack.Peek();
                operation_stack.Pop();
                insertAtBottom(x);
                operation_stack.Push(a);
            }
        }

        public static void StackReversal()
        {
            if (operation_stack.Count > 0)
            {
                int a = operation_stack.Peek();
                operation_stack.Pop();
                StackReversal();
                insertAtBottom(a);
            }
        }

        static void Main(string[] args)
        {
            operation_stack.Push(1);
            operation_stack.Push(2);
            operation_stack.Push(3);
            operation_stack.Push(4);
            operation_stack.Push(5);

            foreach(int x in operation_stack)
                Console.Write(x+" ");
            StackReversal();
            Console.WriteLine();

            foreach (int x in operation_stack)
                Console.Write(x + " ");
            Console.ReadLine();
        }
    }
}
