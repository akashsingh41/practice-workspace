using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLSwapNodes
{
    class Program
    {
        static void SwapNodes(LinkedList<int> list, int x, int y)
        {
            Node<int> temp = list.head;
            Node<int> prev = null; 
            Node<int> nodeX = null;
            Node<int> prevX = null;
            Node<int> nodeY = null;
            Node<int> prevY = null;
            while (temp != null)
            {
                if (temp.data == x)
                {
                    nodeX = temp;
                    prevX = prev;
                }
                if (temp.data == y)
                {
                    nodeY = temp;
                    prevY = prev;
                }
                prev = temp;
                temp = temp.next;
                
            }

            if (nodeX == null || nodeY == null)
            {
                Console.WriteLine("Nodes not found");
                return;
            }

            if (prevX != null)
                prevX.next = nodeY;
            else
                list.head = nodeY;
            if (prevY != null)
                prevY.next = nodeX;
            else
                list.head = nodeX;

            temp = nodeX.next;
            nodeX.next = nodeY.next;
            nodeY.next = temp;
            
        }
    
    
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(10, list);
            list.AddNodeToEnd(15,list);
            list.AddNodeToEnd(12, list);
            list.AddNodeToEnd(14, list);
            list.AddNodeToEnd(20, list);
            list.AddNodeToEnd(18, list);
            list.AddNodeToEnd(13, list);

            Console.WriteLine("Before: ");
            list.PrintList();
            SwapNodes(list, 10, 13);

            Console.WriteLine("After: ");
            list.PrintList();
            Console.ReadLine();
        }
    }
}
