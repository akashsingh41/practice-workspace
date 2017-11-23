using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort_A_Stack_Using_TempStack
{
    class Program
    {
        public static Stack<int> sortstack(Stack<int> input)
        {
            Stack<int> tmpStack = new Stack<int>();
            while (input.Count>0)
            {
                // pop out the first element
                int tmp = input.Pop();

                // while temporary stack is not empty and
                // top of stack is greater than temp
                while (tmpStack.Count>0 && tmpStack.Peek() > tmp)
                {
                    // pop from temporary stack and 
                    // push it to the input stack
                    input.Push(tmpStack.Pop());
                }

                // push temp in tempory of stack
                tmpStack.Push(tmp);
            }
            return tmpStack;
        }
        static void Main(string[] args)
        {
            Stack<int> input = new Stack<int>();
            input.Push(34);
            input.Push(3);
            input.Push(31);
            input.Push(98);
            input.Push(92);
            input.Push(23);

            // This is the temporary stack
            Stack<int> tmpStack = sortstack(input);
            Console.WriteLine("Sorted numbers are:");

            foreach (int x in tmpStack)
            {
                Console.Write(x + " ");
            }

            Console.ReadKey();
        }
    }
}
