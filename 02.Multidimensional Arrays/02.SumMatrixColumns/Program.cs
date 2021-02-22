using System;
using System.Linq;

namespace _02.SumMatrixColumns
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rols = size[0];
            int cols = size[1];
            int[,] matrix= new int[rols, cols];
            for (int i = 0; i < rols; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = input[j];
                }
            }
            int columsSum = 0;
            for (int i = 0; i < cols; i++)
            {

                for (int j = 0; j < rols; j++)
                {
                    columsSum += matrix[j, i];
                }
                Console.WriteLine(columsSum);
                columsSum = 0;
            }
        }
    }
}
