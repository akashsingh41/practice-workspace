using System;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLIntersectionPoint
{
    class Program
    {
        static Node<int> FindNode(int x, LinkedList<int> list)
        {
            Node<int> temp = list.head;
            while (temp != null)
            {
                if (temp.data == x)
                    return temp;
                else
                    temp = temp.next;
            }
            return null;
        }

        static Node<int> IntersectionPoint(LinkedList<int> list1, LinkedList<int> list2)
        {
            System.Collections.Generic.HashSet<int> hash = new System.Collections.Generic.HashSet<int>();
            Node<int> temp = list1.head;
            while (temp != null)
            {
                hash.Add(temp.data);
                temp = temp.next;
            }

            temp = list2.head;
            while (temp != null)
            {
                if (hash.Contains(temp.data))
                    return temp;
                else
                    temp = temp.next;
            }
            return null;
        }

        static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();

            list1.AddNodeToStart(1, list1);
            list1.AddNodeToEnd(3, list1);
            list1.AddNodeToEnd(5, list1);
            list1.AddNodeToEnd(7, list1);
            list1.AddNodeToEnd(9, list1);
            list1.AddNodeToEnd(11, list1);
            list1.AddNodeToEnd(13, list1);
            list1.AddNodeToEnd(15, list1);
            list1.PrintList();
            list2.AddNodeToStart(2, list2);
            list2.head.next = FindNode(11, list1);           
            list2.PrintList();

            Console.WriteLine("Intersection Point: " + IntersectionPoint(list1,list2).data);
            Console.ReadLine();

        }
    }
}
