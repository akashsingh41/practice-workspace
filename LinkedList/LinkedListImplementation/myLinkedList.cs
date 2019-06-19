using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlListImplementation
{
    public class myListNode<T>
    {
        public T data;
        public myListNode<T> next;

        public myListNode() { }

        public myListNode(T value)
        {
            this.data = value;
        }
    }

    public class myLinkedList<T>
    {
        public myListNode<T> head;

        public void PrintList()
        {
            myListNode<T> node = new myListNode<T>();
            node = head;

            for (;node!=null;node=node.next)
            { 
                Console.Write(node.data + " ");
            }
            
            Console.WriteLine();
        }

        public myLinkedList<T> AddNodeToStart(T value, myLinkedList<T> myList)
        {
            myListNode<T> node = new myListNode<T>(value);
            if (myList.head != null)
            {
                node.next = myList.head;
                myList.head = node;
            }
            else
                myList.head = node;
            return myList;
        }

        public myLinkedList<T> AddNodeToEnd(T value, myLinkedList<T> myList)
        {
            myListNode<T> node = new myListNode<T>(value);
            
            if (myList.head != null)
            {
                myListNode<T> tempNode = myList.head;
                while (tempNode.next != null)
                    tempNode = tempNode.next;

                tempNode.next = node;
            }
            else
                myList.head = node;
            return myList;
        }

        public myLinkedList<T> AddNodeAfter(T value, T nodeValue, myLinkedList<T> myList)
        {
            int found = 0;
            myListNode<T> node = new myListNode<T>(value);
            myListNode<T> tempNode = myList.head;
            while (tempNode.next != null)
            {
                if (tempNode.data.Equals(nodeValue))
                {
                    found = 1;
                    node.next = tempNode.next;
                    tempNode.next = node;
                }
                tempNode = tempNode.next;
            }
            if (tempNode.data.Equals(nodeValue))
            {
                found = 1;
                node = tempNode.next;
            }
            if (found == 0)
            {
                Console.WriteLine("Node not found!");
            } 

            return myList;
        }
    }
}
