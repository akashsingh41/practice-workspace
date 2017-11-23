using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infix_To_Prefix
{
    class Program
    {
        static int Precedence(char i)
        {
            switch (i)
            {
                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }

        static string Reverse(string sz) // ideal for an extension method
        {
            if (string.IsNullOrEmpty(sz) || sz.Length == 1)
                return sz;

            char[] chars = sz.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static String PostfixConverter(String input)
        {
            String output = null;
            Stack<char> operating_stack = new Stack<char>();

            foreach (char x in input)
            {
                if (char.IsLetterOrDigit(x))
                    output += x;
                else
                    if (x == '(')
                    operating_stack.Push(x);
                else
                        if (x == ')')
                {
                    while (operating_stack.Count != 0 && operating_stack.Peek() != '(')
                    {
                        output += operating_stack.Pop();
                    }
                    if (operating_stack.Count != 0 && operating_stack.Peek() != '(')
                    {
                        return "Invalid Expression";
                    }
                    else
                        operating_stack.Pop();
                }
                else
                {
                    while (operating_stack.Count != 0 && Precedence(x) <= Precedence(operating_stack.Peek()))
                    {
                        output += operating_stack.Pop();
                    }
                    operating_stack.Push(x);
                }

            }


            while (operating_stack.Count != 0)
            {
                output += operating_stack.Pop();
            }

            return output;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the infix expression:");
            String input = "a+b^c*d";//"a+b*(c^d-e)^(f+g*h)-i";//Console.ReadLine();

            String interim_string_1 = Reverse(input);

            String interim_string_2 = PostfixConverter(interim_string_1.Replace('(', '@').Replace(')', '(').Replace('@', ')'));

            Console.WriteLine(Reverse(interim_string_2));

            Console.ReadKey();


            

        }

        

    }
}


