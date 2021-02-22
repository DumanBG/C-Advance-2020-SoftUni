using System;
using System.Linq;

namespace _02._2x2SquaresInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeOfTheMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = sizeOfTheMatrix[0];
            int m = sizeOfTheMatrix[1];

            char[,] matrix = new char[n, m];
            int counterMatrixInTheMatrix = 0;
            ReadMatrix(matrix);

            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    char currentElement = matrix[row, col];

                    if (currentElement == matrix[row, col + 1] && currentElement == matrix[row + 1, col]&& currentElement == matrix[row +1, col + 1])
                    {

                        counterMatrixInTheMatrix++;
                    }
                }
            }

            Console.WriteLine(counterMatrixInTheMatrix);


        }

        private static char[,] ReadMatrix(char[,]matrix)
        {
            
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowDataInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowDataInput[col];
                }
            }
            return matrix;
        }
    }
}
