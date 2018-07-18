/*
Micro just purchased a queue and wants to perform N operations on the queue. The operations are of following type:

E x : Enqueue x in the queue and print the new size of the queue.
D : Dequeue from the queue and print the element that is deleted and the new size of the queue separated by space. If there is no element in the queue then print 1 in place of deleted element.

Since Micro is new with queue data structure, he need your help.

Input:
First line consists of a single integer denoting N
Each of the following N lines contain one of the operation as described above.

Output:
For each enqueue operation print the new size of the queue. And for each dequeue operation print two integers, deleted element (1, if queue is empty) and the new size of the queue.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monk_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            int query_list = Int32.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();
            while (query_list > 0)
            {
                string[] read_query = Console.ReadLine().Split(' ');
                if (read_query[0] == "E")
                {
                    que.Enqueue(Int32.Parse(read_query[1]));
                    Console.WriteLine(que.Count);
                }
                else
                {
                    if (que.Count == 0)
                        Console.Write("-1 ");
                    else
                        Console.Write(que.Dequeue()+" ");

                    Console.WriteLine(que.Count);
                }


                query_list--;
            }
                
        }
    }
}
