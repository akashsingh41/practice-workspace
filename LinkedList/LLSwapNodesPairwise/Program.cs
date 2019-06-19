using System;
using LinkedListLibrary;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLSwapNodesPairwise
{
    class Program
    {
        static Node<int> Recursive_SwapNodesPairwise(Node<int> node)
        {
            if (node == null || node.next == null)
                return node;

            Node<int> next_head = node.next.next;

            Node<int> new_head = node.next;

            node.next.next = node;

            node.next = Recursive_SwapNodesPairwise(next_head);

            return new_head;

        }
        static Node<int> Iterative_SwapNodesPairwise(LinkedList<int> list)
        {
            //Node<int> previous = null;
            //Node<int> A = list.head;
            //Node<int> B = list.head.next;
            if (list.head == null || list.head.next == null)
                return list.head;
            Node<int> previous_node = list.head;
            Node<int> current_node = list.head.next;

            Node<int> head_node = current_node;

            while (current_node != null)
            {
                Node<int> next_node = current_node.next;
                current_node.next = previous_node;
                if (next_node == null || next_node.next == null)
                {
                    previous_node.next = next_node;
                    break;
                }
                else
                    previous_node.next = next_node.next;

                previous_node = next_node;
                current_node = next_node.next;
            }
            return head_node;
           
        }
            
        
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(10, list);
            list.AddNodeToEnd(15, list);
            list.AddNodeToEnd(12, list);
            list.AddNodeToEnd(14, list);
            list.AddNodeToEnd(20, list);
            list.AddNodeToEnd(18, list);
            list.AddNodeToEnd(13, list);

            Console.Write("Before: ");
            list.PrintList();
            list.head = Iterative_SwapNodesPairwise(list);
            Console.Write("After Iterative Swap: ");
            list.PrintList();
            list.head = Recursive_SwapNodesPairwise(list.head);
            Console.Write("After Recursive Swap: ");
            list.PrintList();

            Console.ReadLine();
        }
    }
}
