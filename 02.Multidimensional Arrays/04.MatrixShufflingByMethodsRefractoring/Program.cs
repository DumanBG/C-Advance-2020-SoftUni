using System;
using System.Linq;

namespace _04.MatrixShufflingByMethodsRefractoring
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizeData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = sizeData[0];
            int m = sizeData[1];

            string[,] matrix = new string[sizeData[0], sizeData[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] dataRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataRow[col];
                }
            }
            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (tokens.Length != 5 || command != "swap")
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);

                    if (IsValidCell(firstRow,firstCol,n,m) && IsValidCell(secondRow, secondCol, n, m))
                    {
                        string currentString = matrix[firstRow, firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = currentString;

                        PrintMatrix(matrix);

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }


                }

                input = Console.ReadLine();
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col <matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsValidCell(int row, int col, int n,int m)
    {
        return row >= 0 && row < n && col >= 0 && col < m;

    }
    }
}
