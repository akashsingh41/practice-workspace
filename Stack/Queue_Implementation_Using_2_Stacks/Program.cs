using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation_Using_2_Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            my_queue_class_using_stacks<int> queue = new my_queue_class_using_stacks<int>();

            // enqueue integers 1..3
            for (int i = 1; i <= 3; i++)
                queue.enqueue(i);

            queue.print_queue();

            // execute 2 dequeue operations 
            for (int i = 0; i < 2; i++)
                Console.WriteLine("Dequeued: " + queue.dequeue());

            // enqueue integers 4..5
            for (int i = 4; i <= 5; i++)
                queue.enqueue(i);

            queue.print_queue();

            // dequeue the rest
            while (!queue.isEmpty())
                Console.WriteLine("Dequeued: " + queue.dequeue());

            Console.ReadKey();
        }
    }
}
