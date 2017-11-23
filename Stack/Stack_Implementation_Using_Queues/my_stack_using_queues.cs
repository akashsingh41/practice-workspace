using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_Queues
{
    class my_stack_using_queues<T>
    {
        private Queue<T> queue = new Queue<T>();

        public void push(T val)
        {
            queue.Enqueue(val);
        }

        public T pop()
        {

            if (queue.Count == 0)
            {
                Console.Write("Stack is empty!");
                return default(T);

            }
            if (queue.Count > 0)
            {
                for (int i = 0; i < queue.Count - 1; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }
            }

            return queue.Dequeue();
        }

        public void print_stack()
        {
            Console.Write("My Stack reads:");
            foreach (T val in queue)
            {
                Console.Write(val + " ");
            }
            Console.WriteLine();
                
        }
    }
}
