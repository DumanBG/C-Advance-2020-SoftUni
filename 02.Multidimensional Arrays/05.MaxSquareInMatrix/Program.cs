using System;
using System.Linq;

namespace _05.MaxSquareInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
          // 3, 6                                               9 8
          // 7, 1, 3, 3, 2, 1                                   7 9 
          // 1, 3, 9, 8, 5, 6                                   33                                
          // 4, 6, 7, 9, 1, 0

            int sizeOfMaxSqure = 2; //  Can be dynamic with CReadLine

            int[] input = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];

            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] rowData = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];
                }
            }
            int maxSum = int.MinValue;
            int maxSumRow = 0;
            int maxSumCol = 0;

            for (int row = 0; row < rows - sizeOfMaxSqure + 1; row++)
            {
                for (int col = 0; col < cols - sizeOfMaxSqure + 1; col++)
                {
                    //int squareSum = matrix[row, col] + matrix[row, col + 1] +
                    //    matrix[row + 1, col] + matrix[row + 1, col + 1];
                    int squareSum = 0;
                    for (int squareRow = row; squareRow < row + sizeOfMaxSqure; squareRow++)
                    {
                        for (int squareCol = col; squareCol < col + sizeOfMaxSqure; squareCol++)
                        {
                            squareSum += matrix[squareRow, squareCol];
                        }
                    }

                    if (squareSum > maxSum)
                    {
                        maxSum = squareSum;
                        maxSumRow = row;
                        maxSumCol = col;
                    }
                }
            }

            // Print  maxSqure  
            for (int row = maxSumRow; row < maxSumRow + sizeOfMaxSqure; row++)
            {
                for (int col = maxSumCol; col < maxSumCol + sizeOfMaxSqure; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}