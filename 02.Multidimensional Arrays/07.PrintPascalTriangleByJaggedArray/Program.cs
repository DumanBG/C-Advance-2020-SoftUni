using System;

namespace _07.PrintPascalTriangleByJaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            long[][] pascal = new long[n][];

            for (int row = 0; row < n; row++)
            {
                pascal[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    long sum = 0;
                    if (row - 1 >= 0 && col - 1 >= 0) // if 2 elements exesist
                    {
                        sum += pascal[row - 1][col - 1];
                    }
                    if (row - 1 >= 0 && col < pascal[row - 1].Length) // if only 1 element exist
                    {
                        sum += pascal[row - 1][col];
                    }

                    if (sum == 0)
                    {
                        sum = 1;
                    }

                    pascal[row][col] = sum;
                }
            }

            for (int row = 0; row < pascal.Length; row++)
            {
                for (int col = 0; col < pascal[row].Length; col++)
                {
                    Console.Write(pascal[row][col] + " ");
                }
                Console.WriteLine();
            }
            }
        }
    }
