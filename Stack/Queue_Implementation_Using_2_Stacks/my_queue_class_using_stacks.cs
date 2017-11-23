using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation_Using_2_Stacks
{
    class my_queue_class_using_stacks<T>
    {
        private my_stack_class<T> input_stack;
        private my_stack_class<T> output_stack;

        private int size;

        public my_queue_class_using_stacks()
        {
            input_stack = new my_stack_class<T>();
            output_stack = new my_stack_class<T>();
        }

        public void enqueue(T data)
        {
            input_stack.push(data);
            size++;
        }

        public T dequeue()
        {
            // fill out all the Input if output stack is empty
            if (output_stack.isEmpty())
                while (!input_stack.isEmpty())
                    output_stack.push(input_stack.pop());

            T out_element = default(T);
            if (!output_stack.isEmpty())
            {
                out_element = output_stack.pop();
                size--;
            }

            return out_element;
        }

        public int size_of_queue()
        {
            return size;
        }

        public bool isEmpty()
        {
            return size == 0;
        }

        public void print_queue()
        {
            Console.WriteLine("Input Stack:");
            input_stack.print_stack();
            Console.WriteLine("Output Stack:");
            output_stack.print_stack();
        }
    }
}
