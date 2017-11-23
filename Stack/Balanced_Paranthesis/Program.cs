using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Paranthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> working_stack = new Stack<char>();
            int success = 1;
            String input = "{}()[{]";

            foreach (char x in input)
            {
                if (x == '{' || x == '[' || x == '(')
                    working_stack.Push(x);
                else
                {
                    if ((working_stack.Count > 0) && (working_stack.Peek() == '{' || working_stack.Peek() == '[' || working_stack.Peek() == '(') )
                    {
                        working_stack.Pop();
                    }
                    else
                    {
                        success = 0;
                    }
                }
            }

            if (working_stack.Count == 0 && success == 1)
            {
                Console.WriteLine("Balanced Expression");
            }
            else
                Console.WriteLine("Unbalanced Expression");

            Console.ReadLine();

        }
    }
}
