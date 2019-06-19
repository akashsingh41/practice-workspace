using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linkedlListImplementation
{
    class Program
    {

        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine()); // length of linked list
            myLinkedList<int> demoList = new myLinkedList<int>();
            //for (int i = 0; i < n; i++)
            //{
               // Console.WriteLine("Enter the node value:");
                //demoList.AddNodeToStart(int.Parse(Console.ReadLine()),demoList);
            demoList.AddNodeToEnd(32, demoList);
            demoList.AddNodeToEnd(35, demoList);
            demoList.AddNodeToEnd(37, demoList);
            demoList.AddNodeAfter(4,33,demoList);
            demoList.AddNodeToStart(87, demoList);
            //}

            demoList.PrintList();
            Console.ReadLine();
        }
    }
}
