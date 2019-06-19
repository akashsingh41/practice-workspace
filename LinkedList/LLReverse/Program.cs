using System;
using LinkedListLibrary;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLReverse
{
    class Program
    {
        static public LinkedList<int> list;
        static void Iterative_Reverse(LinkedList<int> list)
        {
            Node<int> previous_node = null, current_node = list.head, next_node = null;
            if ((current_node == null) || (current_node.next == null))
                return;
            
            while (current_node != null)
            {
                next_node = current_node.next;
                current_node.next = previous_node;

                previous_node = current_node;
                current_node = next_node;
            }
            list.head = previous_node;
        }

        static void Recursive_Reverse(Node<int> node)
        {
            if (node == null) return;
            Node<int> current, rest;
            current = node;
            rest = node.next;
            if (node.next == null)
            {
                list.head = current;
                return;
            }

            Recursive_Reverse(rest);
            current.next.next = current;
            current.next = null;        
        }



        static void Main(string[] args)
        {
            list = new LinkedList<int>();
            list.AddNodeToStart(10, list);
            list.AddNodeToEnd(15, list);
            list.AddNodeToEnd(12, list);
            list.AddNodeToEnd(14, list);
            list.AddNodeToEnd(20, list);
            list.AddNodeToEnd(18, list);
            list.AddNodeToEnd(13, list);

            Console.Write("Before: ");
            list.PrintList();
            Iterative_Reverse(list);
            Console.Write("After Iterative Reverse: ");
            list.PrintList();
            Recursive_Reverse(list.head);
            Console.Write("After Recursive Reverse: ");
            list.PrintList();
            Console.ReadLine();
        }
    }
}
