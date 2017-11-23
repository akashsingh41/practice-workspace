using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Implementation_Using_DLL
{
    public class my_stack_class_using_dll<T>
    {
        /// <summary>
        /// Implementation of class of nodes of a doubly linked list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        public class Node<T>
        {
            public T data;
            public Node<T> next;
            public Node<T> previous;
            public Node(T data)
                {
                    this.data=data;
                }
        }

        
            int count;
            Node<T> head;
            Node<T> middle;

            public void push(T new_element)
            {
                Node<T> new_node = new Node<T>(new_element);
                new_node.previous = null;
                new_node.next = head;

                count++;

                if (count == 1)
                {
                    middle = new_node;
                }
                else
                {
                    head.previous = new_node;

                    if ((count % 2) != 0) // Update mid if ms->count is odd
                        middle = middle.previous;
                }

                /* move head to point to the new DLLNode */
                head = new_node;
            }

            public T pop()
            {
                if (count == 0)
                {
                    Console.WriteLine("Stack is Empty!!!");
                    return default(T);
                }
                T popped_value = head.data;
                head = head.next;

                if (head.next != null)
                {
                    head.previous = null;
                }

                count--;

                if (count % 2 == 0)
                {
                    middle = middle.next;
                }

                return popped_value;
                    
            }

            public T find_middle()
            {
                if (count == 0)
                {
                    Console.WriteLine("Stack is Empty!!!");
                        return default(T);
                }

                else
                {
                    return middle.data;
                }
            }
        
    }
}
