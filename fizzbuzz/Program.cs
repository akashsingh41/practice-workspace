/*
Output numbers from 1 to x. If the number is divisible by 3, replace it with “Fizz”. 
If it is divisible by 5, replace it with “Buzz”. 
If it is divisible by 3 and 5 replace it with “FizzBuzz”

Sample Input: 15
Sample Output:
1
2
Fizz
4
Buzz
...
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Int32.Parse(Console.ReadLine());
            for (int i = 1;i<=x;i++)
            {
                if ((i % 5 == 0) && (i % 3 == 0))
                    Console.WriteLine("FizzBuzz");
                else
                    if (i % 5 == 0)
                    Console.WriteLine("Buzz");
                else
                        if (i % 3 == 0)
                    Console.WriteLine("Fizz");
                else
                    Console.WriteLine(i);
            }
        }
    }
}
