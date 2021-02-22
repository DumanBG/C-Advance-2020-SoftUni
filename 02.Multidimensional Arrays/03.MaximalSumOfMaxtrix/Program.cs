using System;
using System.Linq;

namespace _03.MaximalSumOfMaxtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowCol = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = rowCol[0];
            int m = rowCol[1];

            int[,] matrix = new int[n,m];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowData[col];
                        
                }
            }
            int maxSum = int.MinValue;
            int maxRowIndex = -1;
            int maxColIndex = -1;
            for (int row = 0; row < n-2; row++)
            {
                for (int col = 0; col < m-2; col++)
                {
                    // take max 3 3 square by sum
                    int sum = matrix[row,col];
                    sum += matrix[row, col + 1];
                    sum += matrix[row, col + 2];

                    sum += matrix[row + 1, col];
                    sum += matrix[row + 1, col+1];
                    sum += matrix[row + 1, col+2];

                    sum += matrix[row + 2, col];
                    sum += matrix[row + 2, col+1];
                    sum += matrix[row + 2, col+2];

                    if(sum> maxSum)
                    {
                        maxSum = sum;
                        maxRowIndex = row;
                        maxColIndex = col;

                    }

                }
            }
            Console.WriteLine("Sum = " +maxSum);

            // print SubMatrixMax 3 3 square
            for (int row = maxRowIndex; row < maxRowIndex+3; row++)
            {
                for (int col = maxColIndex; col < maxColIndex+3; col++)
                {
                    Console.Write(matrix[row,col] + " ");

                }
                Console.WriteLine();
            }

        }
    }

}