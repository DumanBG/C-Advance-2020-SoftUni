using System;
using System.Linq;

namespace _04.MatrixShufflingCheckValidIndex
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
            while(input.ToLower() !="end")
            {
            string[] tokens = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];

                if (tokens.Length != 5 || command != "swap" )
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int firstRow = int.Parse(tokens[1]);
                    int firstCol = int.Parse(tokens[2]);
                    int secondRow = int.Parse(tokens[3]);
                    int secondCol = int.Parse(tokens[4]);
                     
                    if(firstRow >=0 && firstRow < n && firstCol >= 0 && firstCol <m && 
                        secondRow >=0 && secondRow < n && secondCol >=0 && secondCol <m)
                    {
                        string currentString = matrix[firstRow,firstCol];
                        matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                        matrix[secondRow, secondCol] = currentString;

                        for (int row = 0; row < n; row++)
                        {

                            for (int col = 0; col < m; col++)
                            {
                                Console.Write(matrix[row,col] + " ");
                            }
                            Console.WriteLine();
                        }

                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }


                }

                input = Console.ReadLine();
            }
        }
    }
}
