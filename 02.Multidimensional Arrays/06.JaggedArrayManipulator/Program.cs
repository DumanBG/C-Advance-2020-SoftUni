using System;
using System.Linq;

namespace _06.JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double[][] array = new double[n][];

            for (int row = 0; row < array.Length; row++)
            {
                double[] dataRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).ToArray();
                array[row] = new double[dataRow.Length];
                for (int col = 0; col < array[row].Length; col++)
                {

                    array[row][col] = dataRow[col];
                }

            }
            for (int row = 0; row < n - 1; row++)
            {
                double[] firstArr = array[row];
                double[] secondArr = array[row+1];
                if (firstArr.Length == secondArr.Length)
                {
                    // Select  :D
                    array[row] = firstArr.Select(e => e * 2).ToArray();
                    array[row + 1] = secondArr.Select(e => e * 2).ToArray();
                }
                else
                {
                    array[row] = firstArr.Select(e => e / 2).ToArray();
                    array[row + 1] = secondArr.Select(e => e / 2).ToArray();
                }
            }


            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int firstRow = int.Parse(tokens[1]);
                int firstCol = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (ValidIndex(array, firstRow, firstCol))
                {
                    if (command.ToLower() == "add")
                    {

                        array[firstRow][firstCol] += value;

                    }
                    else if (command.ToLower() == "subtract")
                    {

                        array[firstRow][firstCol] -= value;


                    }
                }

                input = Console.ReadLine();
            }
            PrintArray(array);

        }

        private static bool ValidIndex(double[][] array, int firstRow, int firstCol)
        {
            return firstRow >= 0 && firstRow < array.Length && firstCol >= 0 && firstCol < array[firstRow].Length;

        }

        private static void PrintArray(double[][] array)
        {
            for (int row = 0; row < array.Length; row++)
            {
                for (int col = 0; col < array[row].Length; col++)
                {

                    Console.Write(array[row][col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
