using System;
using System.Linq;

namespace _01.SumMatrixElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] matrixSize = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int rol = matrixSize[0];
            int col = matrixSize[1];
            int[,] matrix = new int[rol, col];
            int totalSUm = 0;

            for (int i = 0; i < rol; i++)
            {
                 int[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

                for (int j = 0; j < input.Length; j++)
                {

                matrix[i, j]= input[j];
                    totalSUm += input[j];
                }
                
            }
            Console.WriteLine(rol);
            Console.WriteLine(col);
            Console.WriteLine(totalSUm);
        }
    }
}
