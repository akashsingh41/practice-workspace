using System;
using LinkedListLibrary;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLLastToFront
{
    class Program
    {
        public static void Last2Front(LinkedList<int> list)
        {
            Node<int> last, second_last;
            Node<int> temp1 = list.head;
            Node<int> temp2 = null;

            while (temp1.next != null)
            {
                temp2 = temp1;
                temp1 = temp1.next;
            }

            last = temp1;
            second_last = temp2;

            second_last.next = null;
            last.next = list.head;
            list.head = last;
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
            Last2Front(list);
            Console.Write("After Last to Front: ");
            list.PrintList();


        }
    }
}
