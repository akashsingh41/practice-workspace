/*
You have to print Nth non-pallindromic number.
Input: 
First line of input is T representing number of test cases 
Each of the following T lines represent N.
Output:
Print Nth non-pallindromic number. 
Constraints:
1 <= T <= 105
1 <= N <= 109
 */

using System;

namespace non_palindrome
{
    public class Class1
    {
        private static long reverse_x(long x)
        {
            long rev_x = 0;
            while (x > 0)
            {
                rev_x = rev_x * 10 + x % 10;
                x /= 10;
            }

            return rev_x;
        }
        public static void Main()
        {
            int test_cases = Int32.Parse(Console.ReadLine());
            long p = 10, q, count = 0;
            for (int i = 0; i < test_cases; i++)
            {
                q = Int32.Parse(Console.ReadLine());

                while (true)
                {
                    if (reverse_x(p) != p)
                    {
                        count++;
                    }
                    if (count == q)
                    {
                        Console.WriteLine(p);
                        p++;
                        break;
                    }
                    p++;
                }
            }


        }
    }
}



