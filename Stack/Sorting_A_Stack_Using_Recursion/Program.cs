using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_A_Stack_Using_Recursion
{
    class Program
    {
        static void SortedInsert(Stack<int> operation_stack, int x)
        {
            if ((operation_stack.Count == 0) || (x >= operation_stack.Peek()))
            {
                operation_stack.Push(x);
            }
            else
            {
                int tmp = operation_stack.Pop();
                SortedInsert(operation_stack, x);
                operation_stack.Push(tmp);
            }
        }

        static void sortStack(Stack<int> S)
        {
            if (S.Count > 0)
            {
                int temp = S.Pop();
                sortStack(S);
                SortedInsert(S, temp);
            }
        }

        public static void Main(string[] args)
        {

            Stack<int> myStack = new Stack<int>();
            myStack.Push(45);
            myStack.Push(23);
            myStack.Push(48);
            myStack.Push(65);
            myStack.Push(34);

            foreach (int x in myStack)
                Console.Write(x + " ");
            sortStack(myStack);
            Console.WriteLine();

            foreach (int x in myStack)
                Console.Write(x + " ");
            Console.ReadLine();

        }
    }
}
