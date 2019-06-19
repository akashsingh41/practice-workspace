using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLSearch
{
    class Program
    {
        static bool searchIterative(int key, LinkedList<int> list)
        {
            Node<int> temp = list.head;
            while (temp != null)
            {
                if (temp.data == key)
                    return true;

                temp = temp.next;
            }
            return false;
        }

        static bool searchRecursive(int key, Node<int> head)
        {
            Node<int> temp = head;
            if (temp !=null && temp.data == key)
                return true;
            else
                if (temp.next != null) 
                searchRecursive(key, temp.next);

            return false;
        }
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(2, list);
            list.AddNodeToEnd(3, list);
            list.AddNodeToEnd(5, list);
            list.AddNodeToEnd(7, list);
            list.AddNodeToEnd(9, list);
            list.AddNodeToEnd(11, list);
            list.AddNodeToEnd(13, list);
            list.AddNodeToEnd(17, list);
            list.AddNodeToEnd(19, list);
            list.AddNodeToEnd(23, list);
            list.AddNodeToEnd(29, list);
            list.AddNodeToEnd(31, list);
            list.AddNodeToEnd(37, list);
            list.AddNodeToEnd(41, list);
            list.AddNodeToEnd(43, list);
            list.AddNodeToEnd(47, list);
            list.AddNodeToEnd(53, list);
            list.AddNodeToEnd(59, list);
            list.AddNodeToEnd(61, list);
            list.AddNodeToEnd(67, list);
            list.AddNodeToEnd(73, list);
            list.AddNodeToEnd(79, list);
            list.AddNodeToEnd(83, list);
            list.AddNodeToEnd(87, list);
            list.AddNodeToEnd(93, list);
            list.AddNodeToEnd(97, list);



            Console.WriteLine("Iterative Count: " + searchIterative(43, list));
            Console.WriteLine("Recursive Count: " + searchRecursive(79, list.head));
            Console.ReadLine();
        }
    }
}
