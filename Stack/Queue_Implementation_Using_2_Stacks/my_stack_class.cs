using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Implementation_Using_2_Stacks
{
    public class my_stack_class<T>
    {
        private class Node<T>  //the generic node structure
        {
            public T data;
            public Node<T> next;

            public Node(T data)  // node constructor
            {
                this.data = data;

            }
        }
        private int size;  //size of the stack
        private Node<T> head; //top element of the stack

        public void push(T e)
        {
            Node<T> new_element = new Node<T>(e); //create a new node element
            if (head == null) //check if the stack is empty
            {
                head = new_element; //replacing top of stack with new element
            }
            else
            {
                new_element.next = head; //replacing next of new element as null
                head = new_element; //replacing top of stack with new element
            }

            size++; //increasing the size value of stack
        }

        public T pop()
        {
            if (head == null)
            {
                return default(T); // return the default null value of the datatype
            }
            T top_element = head.data; 
            head = head.next;   //mark the next element as top of stack

            size--; //reduce the size of the stack
            return top_element;
        }

        public int size_of_stack()
        {
            return size; //return the size variable of the stack
        }

        public bool isEmpty()
        {
            return size == 0; //check if the size of the stack is 0
        }

        public void print_stack()
        {
            Console.WriteLine("Stack: ");

            if (size == 0)
                Console.WriteLine("Empty !");
        else
            for (Node<T> temp = head; temp != null; temp = temp.next) //loop through eacj element of the stack
                    Console.WriteLine(temp.data);
        }
    }
}

