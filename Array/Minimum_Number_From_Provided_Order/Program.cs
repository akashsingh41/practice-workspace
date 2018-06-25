using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimum_Number_From_Provided_Order
{
    class Program
    {
        static string printNumber(string sequence)
        {
            string result ="";
            Stack<int> opStack = new Stack<int>();
            for (int i = 0; i <= sequence.Length; i++)
            {
                opStack.Push(i + 1);

                if (i == sequence.Length || sequence[i] == 'I')
                {
                    // run till stack is empty
                    while (opStack.Count!=0)
                    {
                        // remove top element from the stack and
                        // add it to solution
                        result += opStack.Peek()+" ";
                        opStack.Pop();
                    }
                }
            }
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(printNumber("DDI"));
            Console.WriteLine(printNumber("DDIDDIID")); 
            Console.Read();
        }
    }
}
