using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLDetectLoop
{
    class Program
    {
        static bool DetectLoop(LinkedList<int> list)
        {
            System.Collections.Generic.HashSet<Node<int>> hashSet = new System.Collections.Generic.HashSet<Node<int>>();
            Node<int> temp = new Node<int>();
            temp = list.head;
            while(temp!=null)
            {
                if (hashSet.Contains(temp))
                    return true;
                else
                {
                    hashSet.Add(temp);
                    temp = temp.next;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(23, list);
            list.AddNodeToEnd(55, list);
            list.AddNodeToEnd(87, list);
            list.AddNodeToEnd(25, list);
            list.AddNodeToEnd(98, list);
            list.AddNodeToEnd(50, list);

            list.head.next.next.next.next = list.head;

            if (DetectLoop(list))
                Console.WriteLine("Loop Detected");
            else
                Console.WriteLine("No Loop Found");

            Console.ReadLine();
        }
    }
}



