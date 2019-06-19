using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLLength
{
    class Program
    {
        static int getLengthIterative(LinkedList<int> list)
        {
            int length = 0;
            Node<int> temp = list.head;
            while (temp != null)
            {
                length += 1;
                temp = temp.next;
            }
            return length;
        }

        static int getLengthRecursive(Node<int> head)
        {
            Node<int> temp = head;
            if (temp == null)
                return 0;
            else
                return 1 + getLengthRecursive(temp.next);
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

            
            
            Console.WriteLine("Iterative Count: " + getLengthIterative(list));
            Console.WriteLine("Recursive Count: " + getLengthRecursive(list.head));
            Console.ReadLine();
        }
    }
}
