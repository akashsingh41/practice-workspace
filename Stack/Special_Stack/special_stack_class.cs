using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Stack
{
    public class special_stack_class
    {
        Stack<int> s = new Stack<int>();
        Stack<int> min_container = new Stack<int>();

        public void push(int new_element)
        {
            s.Push(new_element);

            if (min_container.Count > 0)
            {
                if (new_element < min_container.Peek())
                    min_container.Push(new_element);
                else
                    min_container.Push(min_container.Peek());
            }
            else
                min_container.Push(new_element);
        }

        public int pop()
        {
            min_container.Pop();
            return s.Pop();
        }

        public int getMin()
        {
            return min_container.Peek();
        }
    }
}
