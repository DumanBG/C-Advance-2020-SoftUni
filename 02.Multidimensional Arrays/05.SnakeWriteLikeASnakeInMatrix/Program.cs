using System;
using System.Linq;

namespace _05.SnakeWriteLikeASnakeInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeMatrix = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = sizeMatrix[0];
            int cols = sizeMatrix[1];

            char[,] matrix = new char[rows, cols];
            string snakeName = Console.ReadLine();

            int currentLetter = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 == 0)
                {

                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        matrix[row, col] = snakeName[currentLetter];

                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }


                    }
                }
                else
                {
                    for (int col = matrix.GetLength(1)-1; col >= 0; col--)
                    {
                        matrix[row, col] = snakeName[currentLetter];
                        currentLetter++;
                        if (currentLetter == snakeName.Length)
                        {
                            currentLetter = 0;
                        }
                    }
                }
            }
            PrintMatrix(matrix);

        }
        private static void PrintMatrix (char[,]matrix)
        {
            for (int row = 0; row <matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }
                Console.WriteLine();
            }
        }

       
    }
}

