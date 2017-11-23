using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_Array
{
    class my_stack_using_array
    {
        int[] array;
        int size;
        int top_stack_1, top_stack_2;

        public my_stack_using_array(int n)
        {
            array = new int[n];
            size = n;
            top_stack_1 = -1;
            top_stack_2 = size;
        }

        // Method to push an element x to stack1
        public void push_stack_1(int x)
        {
            // There is at least one empty space for
            // new element
            if (top_stack_1 < top_stack_2 - 1)
            {
                top_stack_1++;
                array[top_stack_1] = x;
            }
            else
            {
                Console.WriteLine("Stack Overflow");
            }
        }

        // Method to push an element x to stack2
        public void push_stack_2(int x)
        {
            // There is at least one empty space for
            // new element
            if (top_stack_1 < top_stack_2 - 1)
            {
                top_stack_2--;
                array[top_stack_2] = x;
            }
            else
            {
                Console.WriteLine("Stack Overflow!!!");
            }
        }

        // Method to pop an element from first stack
        public int pop_stack_1()
        {
            if (top_stack_1 >= 0)
            {
                int x = array[top_stack_1];
                top_stack_1--;
                return x;
            }
            else
            {
                Console.WriteLine("Stack Empty!!!");
            }
            return 0;
        }

        // Method to pop an element from second stack
        public int pop_stack_2()
        {
            if (top_stack_2 < size)
            {
                int x = array[top_stack_2];
                top_stack_2++;
                return x;
            }
            else
            {
                Console.WriteLine("Stack Empty!!!");
            }
            return 0;
        }
    }
}
