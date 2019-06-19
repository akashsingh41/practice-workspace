using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLIntersectionOfSortedLists
{
    class Program
    {
        static LinkedList<int> Intersection(LinkedList<int> list1, LinkedList<int> list2)
        {
            LinkedList<int> output = new LinkedList<int>();

            Node<int> node1 = list1.head;
            Node<int> node2 = list2.head;
            while (node1!=null && node2!=null)
            {
                if (node1.data == node2.data)
                {
                    output.AddNodeToEnd(node1.data, output);
                    node1 = node1.next;
                    node2 = node2.next;
                    continue;
                }

                if (node1.data > node2.data)
                {
                    node2 = node2.next;
                    continue;
                }


                if (node1.data < node2.data)
                {
                    node1 = node1.next;
                    continue;
                }
            }

            return output;
        }
        static void Main(string[] args)
        {
            LinkedList<int> listA = new LinkedList<int>();
            LinkedList<int> listB = new LinkedList<int>();

            listA.AddNodeToStart(10, listA);
            listA.AddNodeToEnd(12, listA);
            listA.AddNodeToEnd(14, listA);
            listA.AddNodeToEnd(18, listA);
            listA.AddNodeToEnd(20, listA);
            listA.AddNodeToEnd(24, listA);
            listA.PrintList();
            listB.AddNodeToStart(12, listB);
            listB.AddNodeToEnd(13, listB);
            listB.AddNodeToEnd(14, listB);
            listB.AddNodeToEnd(15, listB);
            listB.AddNodeToEnd(16, listB);
            listB.AddNodeToEnd(18, listB);
            listB.PrintList();
            LinkedList<int> outList = Intersection(listA, listB);
            outList.PrintList();

            Console.ReadLine();
        }
    }
}
