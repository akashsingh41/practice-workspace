/*
Given a 2D array A, your task is to convert all rows to columns and columns to rows.

Input: 
First line contains 2 space separated integers, N - total rows, M - total columns. 
Each of the next N lines will contain M space separated integers.

Output: 
Print M lines each containing N space separated integers.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_transpose
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, columns;
            string[] dimensions = Console.ReadLine().Split(' ');//reads rows & column value
            rows = Int32.Parse(dimensions[0]);
            columns = Int32.Parse(dimensions[1]);
            int[,] matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] x = Console.ReadLine().Split(' ');
                for (int j = 0; j < columns; j++)
                    matrix[i, j] = Int32.Parse(x[j]);
            }
            int[,] transpose = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {       for (int j = 0; j < rows; j++)
                {
                    transpose[j, i] = matrix[i, j];
                    Console.Write(transpose[j, i]);
                }
            Console.WriteLine();
            }


        }
    }
}
