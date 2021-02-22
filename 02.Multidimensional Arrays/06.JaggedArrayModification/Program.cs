using System;
using System.Linq;

namespace _06.JaggedArrayModification
{
    class Program
    {
        static void Main(string[] args)
        {
            //  4
            //  1 2 3 4
            //  5 6 7 8
            //  8 7 6 5
            //  4 3 2 1
            //  Add 4 4 100
            //  Add 3 3 100
            int rows = int.Parse(Console.ReadLine());

            int[][] jagedArray = new int[rows][];


            for (int row = 0; row < jagedArray.Length; row++)
            {
                int[] dataInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                jagedArray[row] = dataInput;

            }

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = tokens[0];
                int rowForCommand = int.Parse(tokens[1]);
                int colForCommand = int.Parse(tokens[2]);
                int value = int.Parse(tokens[3]);

                if (command.ToLower() == "add")
                {
                    if (rowForCommand >= 0 && colForCommand >= 0 && rowForCommand < rows && colForCommand < jagedArray[rowForCommand].Length)
                    {

                        jagedArray[rowForCommand][colForCommand] += value;
                        input = Console.ReadLine();
                        continue;

                    }
                    Console.WriteLine("Invalid coordinates");

                }
                else if (command.ToLower() == "subtract")
                {
                    if (rowForCommand >= 0 && colForCommand >= 0 && rowForCommand < rows && colForCommand < jagedArray[rowForCommand].Length)
                    {
                        jagedArray[rowForCommand][colForCommand] -= value;
                        input = Console.ReadLine();
                        continue;
                    }

                    Console.WriteLine("Invalid coordinates");
                }

                input = Console.ReadLine();
            }
            //Print JaggedArray
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jagedArray[row].Length; col++)
                {
                    Console.Write(jagedArray[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
