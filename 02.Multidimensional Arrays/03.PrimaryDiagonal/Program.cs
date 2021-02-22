using System;
using System.Linq;

namespace _03.PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {

            int squareSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[squareSize, squareSize];

            int diagonalSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[row];

                    if (row == col)
                    {
                        diagonalSum += matrix[row, col];
                    }

                }
            }
            Console.WriteLine(diagonalSum);
        }
    }
}
