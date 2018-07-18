/*
Sumit is given an array A of size N, where Ai represents the happiness sumit get by eating the i-th dish.
Sumit will eat all the dishes in a series of steps. 
In each step, sumit pick a non empty subset of the remaining dishes and eat them.
The happiness sumit get from eating these dishes is the size of the subset multiplied by the sum of the individual happiness from the dishes in the subset. 
Sumit want to maximize the happiness he get from the entire feast, which is the sum of happiness in each step.

Input :
test cases, t
no. of dishes, N
happiness by eating ith dish, Ai

Output :

Maximum Happiness Sumit can get
Constraints:
1<=t<=8
1<=N<=10^5
-10^8<=Ai<=10^8

Note : Essentially u need to choose subsets of different sizes, covering all elements exactly once and maximizing the happiness.
*/


using System;


namespace Sumit_s_Happiness
{
    class Program
    {
        static void Main(string[] args)
        {
            int test_case_count = Int32.Parse(Console.ReadLine());
            while (test_case_count-- > 0)
            {
                int item_count = Int32.Parse(Console.ReadLine());
                int[] A = new int[item_count];

                int value;


                string[] inputs = (Console.ReadLine().Split(' '));
                for (int i = 0; i < item_count; i++)
                {
                    if (Int32.TryParse(inputs[i], out value))
                    {
                        A[i] = value;
                    }
                }


                Array.Sort(A);

                long sum_positive = 0, sum_negative = 0;
                int count_positive = 0, count_negative = 0;

                for (int i = 0; i < item_count; i++)
                {
                    if (A[i] >= 0)
                    {
                        sum_positive += A[i];
                        count_positive++;
                    }
                    else
                    {
                        sum_negative += A[i];
                        count_negative++;
                    }
                }

                long happiness = sum_positive * count_positive + sum_negative;
                long next_iteration;
                int index = count_negative - 1;
                while (index >= 0)
                {
                    sum_positive += A[index];
                    sum_negative -= A[index];
                    count_positive++;
                    next_iteration = sum_positive * count_positive + sum_negative;

                    if (happiness < next_iteration)
                        happiness = next_iteration;
                    else
                        break;

                    if (index - 1 >= 0)
                        index--;
                    else
                        break;
                }
                Console.WriteLine(happiness);
            }
        }
    }
}
