using System;
//using System.Collections.Generic;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLRemoveDuplicatesUnsorted
{
    class Program
    {
        static void removeDuplicates(LinkedList<int> list)
        {
            System.Collections.Generic.HashSet<int> hashSet = new System.Collections.Generic.HashSet<int>();
            Node<int> temp = new Node<int>();
            Node<int> previous = new Node<int>();

            temp = list.head;
            previous = temp;

            while (temp != null)
            {
                if (hashSet.Contains(temp.data))
                {
                    previous.next = temp.next;
                    temp = temp.next;
                }
                else
                {
                    hashSet.Add(temp.data);
                    previous = temp;
                    temp = temp.next;
                }
            }
        }
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(23, list);
            list.AddNodeToEnd(43, list);
            list.AddNodeToEnd(73, list);
            list.AddNodeToEnd(43, list);
            list.AddNodeToEnd(43, list);
            list.AddNodeToEnd(33, list);
            list.AddNodeToEnd(43, list);
            list.AddNodeToEnd(23, list);

            Console.WriteLine("Before");
            list.PrintList();
            removeDuplicates(list);
            Console.WriteLine("After");
            list.PrintList();

            Console.ReadLine();





        }
    }
}
