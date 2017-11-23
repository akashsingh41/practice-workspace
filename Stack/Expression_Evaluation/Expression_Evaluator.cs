using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression_Evaluation
{
    class Expression_Evaluator
    {
        public static int Postfix_Evaluator(String input)
        {
            Stack<int> operation_stack = new Stack<int>();
            foreach (char x in input)
            {
                if(Char.IsDigit(x))
                {
                    operation_stack.Push(Convert.ToInt32(x-'0'));
                }
                else
                {
                    int a = operation_stack.Pop();
                    int b = operation_stack.Pop();

                    switch (x)
                    {
                        case '+':
                            operation_stack.Push(a+b);
                            break;

                        case '-':
                            operation_stack.Push(b-a);
                            break;

                        case '/':
                            operation_stack.Push(b/a);
                            break;

                        case '*':
                            operation_stack.Push(a*b);
                            break;
                    }

                }
            }

            return operation_stack.Pop();
        }
    }
}
