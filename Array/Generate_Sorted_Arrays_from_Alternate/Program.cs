using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Sorted_Arrays_from_Alternate
{
    class Program
    {
        static void printArray(int[] array, int length)
        {
            for (int x = 0; x < length; x++)
                Console.Write(array[x] + " ");

            Console.WriteLine();
        }
        static void generateArrays(int[] A, int[] B)
        {
            int m = A.Length, n = B.Length;
            int[] C = new int[m + n];
            arrayGenerationUtility(A, B, C, 0, 0, m, n, 0, true);
        }

        static void arrayGenerationUtility(int[] A,int[] B, int[] C, int i,int j, int m, int n, int length, bool flag)
        {
            if (flag)
            {
                if (length != 0)
                    printArray(C, length + 1);
                for (int k = i; k < m; k++)
                {
                    if (length == 0)
                    {
                        C[length] = A[k];
                        arrayGenerationUtility(A, B, C, k + 1, j, m, n, length, !flag);
                    }
                    else if (A[k] > C[length])
                    {
                        C[length + 1] = A[k];
                        arrayGenerationUtility(A, B, C, k + 1, j, m, n, length + 1, !flag);
                    }
                }
            }
            else
            {
                for (int l = j; l < n; l++)
                {
                    if (B[l] > C[length])
                    {
                        C[length + 1] = B[l];
                        arrayGenerationUtility(A, B, C, i, l + 1, m, n, length + 1, !flag);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] A = { 3, 6, 9, 11 };
            int[] B = { 4, 8, 12 };
            generateArrays(A,B);
            Console.Read();
        }
    }
}
