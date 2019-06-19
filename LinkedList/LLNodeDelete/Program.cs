using System;
//using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListLibrary;


namespace LLNodeDelete
{
    class Program
    {
        static void DeleteNode(int value, LinkedList<int> linkedList)
        {
            int flag = 0;

            if (linkedList.head.data.Equals(value))
            {
                linkedList.head = linkedList.head.next;
                flag = 1;
            }
            else
            {
                Node<int> temp_node = new Node<int>();
                temp_node = linkedList.head.next;
                Node<int> prev_node = new Node<int>();
                prev_node = linkedList.head;
                while (temp_node != null)
                {
                    if (temp_node.data.Equals(value))
                    {
                        prev_node.next = temp_node.next;
                        flag = 1;
                        break;
                    }
                    else
                    {
                        prev_node = temp_node;
                        temp_node = temp_node.next;
                    }
                }
            }

            if (flag == 0)
                Console.WriteLine("Key Not Found");
            else
            {
                Console.Write("Altered List: ");
                linkedList.PrintList();
            }
        }
        static void DeleteNodeatIndex(int position, LinkedList<int> linkedList)
        {
            int flag = 0;
            if (position == 1)
            {
                linkedList.head = linkedList.head.next;
                flag = 1;
            }
            else
            {
                Node<int> temp_node = linkedList.head.next;
                Node<int> previous_node = linkedList.head;
                for (int i = 2; i < position && temp_node != null; i++)
                {
                    previous_node = temp_node;
                    temp_node = temp_node.next;
                }
                if (temp_node != null)
                {
                    previous_node.next = temp_node.next;
                    flag = 1;
                }
            }

            if (flag == 0)
                Console.WriteLine("Key Not Found");
            else
            {
                Console.Write("Altered List: ");
                linkedList.PrintList();
            }

        }
        static void Main(string[] args)
        {
            LinkedList<int> myList = new LinkedList<int>();
            myList.AddNodeToStart(32, myList);
            myList.AddNodeToEnd(98, myList);
            myList.AddNodeToEnd(43, myList);
            myList.AddNodeToEnd(26, myList);
            myList.AddNodeToEnd(57, myList);

            myList.PrintList();
            Console.WriteLine("Enter the key/position to delete(Positions start from 1): ");
            int key = int.Parse(Console.ReadLine());
            //DeleteNode(key, myList);
            DeleteNodeatIndex(key, myList);
            Console.ReadLine();
        }
    }
}
