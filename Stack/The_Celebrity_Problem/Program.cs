using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Celebrity_Problem
{
    class Program
    {
        static int[,] aquaintaince_matrix = { {0, 1, 1, 1, 1},
                                              {0, 0, 0, 1, 0},
                                              {1, 1, 0, 1, 1},
                                              {0, 0, 0, 0, 0},
                                              {1, 1, 1, 1, 0} };

        static bool HasAquaintance(int i, int j)
        {
            return aquaintaince_matrix[i,j]==1?true:false;
        } 

        static int findCelebrity()
        {
            int[] guest_list = { 0, 1, 2, 3, 4 };
            Stack<int> celebrity_stack = new Stack<int>();

            foreach (int x in guest_list)
            {
               celebrity_stack.Push(x);
            }

            while (celebrity_stack.Count >= 2)
            {
                int a = celebrity_stack.Pop();
                int b = celebrity_stack.Pop();
                if (HasAquaintance(a, b))
                {
                    celebrity_stack.Push(b);
                }
                else
                    celebrity_stack.Push(a);
            }

            int c = celebrity_stack.Pop();
            for (int i = 0; i < guest_list.Length; i++)
            {
                if (    !(i == c) && ((HasAquaintance(c, i)) || !(HasAquaintance(i, c))) )
                {
                    return -1;
                }
            }

            return c;
        }

        static void Main(String[] args)
        {
            int celebrity = findCelebrity();
            if ( celebrity != -1)
                Console.WriteLine("Our Celebrity is : "+ celebrity);
            else
                Console.WriteLine("No Celebrity in the house today!!!");

            Console.ReadLine();
        }
    
}
}
