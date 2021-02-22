using System;

namespace _04.FindFirstOccurrenceInAsciSymbolInSquareMAtrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int squareMatrixSize = int.Parse(Console.ReadLine());
            char[,] matrix = new char[squareMatrixSize, squareMatrixSize];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string input = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
            char charToCheck = char.Parse(Console.ReadLine());

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {

                    if (charToCheck == matrix[row, col])
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }

                }
            }
            Console.WriteLine($" {charToCheck} does not occur in the matrix");


        }
    }
}
