
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
        static int getMiddle(LinkedList<int> list)
        {
            Node<int> temp1 = list.head;
            Node<int> temp2 = list.head;
            while (temp2 != null && temp2.next !=null)
            {
                    temp1 = temp1.next;
                    temp2 = temp2.next.next;
            }
            return temp1.data;
        }

        
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();
            list.AddNodeToStart(1, list);
            list.AddNodeToEnd(2, list);
            list.AddNodeToEnd(3, list);
            list.AddNodeToEnd(4, list);
            list.AddNodeToEnd(5, list);
            list.AddNodeToEnd(6, list);


            Console.WriteLine("Middle Node :" + getMiddle(list));
            
            Console.ReadLine();
        }
    }
}
