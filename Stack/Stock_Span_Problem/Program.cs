using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Span_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] stock_prices = { 100, 80, 60, 70, 60, 75, 85 };
            Stack<int> stack = new Stack<int>();
            int[] Span=new int[stock_prices.Length];

            for (int x = 0; x < stock_prices.Length; x++)
            {
                while (!(stack.Count == 0) && stock_prices[x] > stock_prices[stack.Peek()])
                {
                   stack.Pop();
                }

                Span[x] = stack.Count == 0? 1:(x - stack.Peek());
                
                stack.Push(x);
            }

            foreach (int i in Span)
                Console.Write(i+" ");
            Console.ReadKey();
        }
    }
}
