/*
Our friend Monk has been made teacher for the day today by his school professors . He is going to teach informatics to his colleagues as that is his favorite subject . Before entering the class, Monk realized that he does not remember the names of all his colleagues clearly . He thinks this will cause problems and will not allow him to teach the class well. However, Monk remembers the roll number of all his colleagues very well . Monk now wants you to help him out. He will initially give you a list indicating the name and roll number of all his colleagues. When he enters the class he will give you the roll number of any of his colleagues belonging to the class. You need to revert to him with the name of that colleague.

Input Format
The first line contains a single integers N denoting the number of Monk's colleagues. Each of the next N lines contains an integer and a String denoting the roll number and name of the i th colleague of Monk. The next Line contains a single integer q denoting the number of queries Monk shall present to you when he starts teaching in class. Each of the next q lines contains a single integer x denoting the roll number of the student whose name Monk wants to know.

Output Format
You need to print q Strings, each String on a new line, indicating the answers to each of Monk's queries.

Note
The name of each student shall consist of lowercase English alphabets only. It is guaranteed that the roll number appearing in each query shall belong to some student from the class.

*/

using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monk_HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable hTable = new Hashtable();
            int count_of_collegues = Int32.Parse(Console.ReadLine());
            while (count_of_collegues > 0)
            {
                string[] entry = Console.ReadLine().Split(' ');
                hTable.Add(Int32.Parse(entry[0]), entry[1]);
                count_of_collegues--;
            }

            int query_count = Int32.Parse(Console.ReadLine());
            while (query_count > 0)
            {
                int query = Int32.Parse(Console.ReadLine());
                Console.WriteLine(hTable[query]);
                query_count--;
            }
        }
    }
}
