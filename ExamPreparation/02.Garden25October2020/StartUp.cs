using System;
using System.Linq;

namespace _02.Garden25October2020
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] rowCols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int n = rowCols[0];
            int m = rowCols[1];
            int[, ] matrix = new int[n, m];

            for (int row = 0; row <matrix.GetLength(0) ; row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = 0;
                }
            }
            string input = Console.ReadLine();
            ;
            while(input != "Bloom Bloom Plow")
            {
                //0 1 0 1 0
                //1 1 1 2 1
                //0 1 0 1 0
                //1 2 1 1 1
                //0 1 0 1 0
                int[] coordinateFlower = input.Split(" ").Select(int.Parse).ToArray();
                int startRow = coordinateFlower[0];
                int startCol = coordinateFlower[1];
               if(!ValidCoordinate(matrix, startRow, startCol))
                {
                    Console.WriteLine("Invalid coordinates.");
                }
               else
                {
                    // 1 1 row++  blooming
                    for (int row = startRow; row < matrix.GetLength(0); row++)
                    {
                            matrix[row, startCol]++;
                    }
                    // 1 1 row --  blooming
                    for (int row = startRow-1; row >=0; row--)
                    {
                        matrix[row, startCol]++;
                    }
                    // col++ blooming
                    for (int col = startCol+1; col < matrix.GetLength(1); col++)
                    {
                        matrix[startRow, col]++;
                    }
                    // col-- blooming
                    for (int col = startCol - 1; col >= 0; col--)
                    {
                        matrix[startRow, col]++;
                    }

                }
                input = Console.ReadLine();
            }
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col] +" ");
                }
                
                Console.WriteLine();
            }
        }

        private static bool ValidCoordinate(int[,] matrix, int currRow, int currCol)
        {
            if (currRow >= 0 && currCol >= 0 && currCol < matrix.GetLength(1) && currRow < matrix.GetLength(0))
            {
                return true;
            }
            return false;
        }
    }
}
