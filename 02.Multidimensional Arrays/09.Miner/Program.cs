using System;
using System.Collections.Generic;
using System.Linq;

namespace _09.Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            //  5
            //      up right right up right
            //      *** c *
            //      ***e *
            //      **c * *
            //      s * *c *
            //      **c * *

            int n = int.Parse(Console.ReadLine());
            char[,] field = new char[n, n];
            string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int playerRow = -1;
            int playerCol = -1;
            List<int[]> coalArr = new List<int[]>();

            FilThefieldsAndFindParameters(field, ref playerRow, ref playerCol, coalArr);
            int newPlayerRow = playerRow;
            int newPlayerCol = playerCol;
            int coalLeft = coalArr.Count;

            bool timeToEnd = false;
            string result = string.Empty;


            int totalCoal = coalArr.Count();

            for (int i = 0; i < command.Length; i++)
            {
                if (command[i] == "up")
                {
                    newPlayerRow = playerRow - 1;
                    newPlayerCol = playerCol;
                    MouvingOptions(field, ref playerRow, ref playerCol, ref newPlayerRow, ref newPlayerCol, ref coalLeft, ref timeToEnd, ref result);
                }
                if (command[i] == "down")
                {
                    newPlayerRow = playerRow + 1;
                    newPlayerCol = playerCol;
                    MouvingOptions(field, ref playerRow, ref playerCol, ref newPlayerRow, ref newPlayerCol, ref coalLeft, ref timeToEnd, ref result);
                }
                if (command[i] == "left")
                {
                    newPlayerCol = playerCol - 1;
                    newPlayerRow = playerRow;
                    MouvingOptions(field, ref playerRow, ref playerCol, ref newPlayerRow, ref newPlayerCol, ref coalLeft, ref timeToEnd, ref result);
                }
                    if (command[i] == "right")
                {
                    newPlayerCol = playerCol + 1;
                    newPlayerRow = playerRow;
                    MouvingOptions(field, ref playerRow, ref playerCol, ref newPlayerRow, ref newPlayerCol, ref coalLeft, ref timeToEnd, ref result);
                }
                if (timeToEnd)
                {
                    Console.WriteLine(result);
                    return;
                }

            }
            Console.WriteLine($"{coalLeft} coals left. ({playerRow}, {playerCol})");
            //PrintTheField(field);

        }

        private static void MouvingOptions(char[,] field, ref int playerRow, ref int playerCol, ref int newPlayerRow, ref int newPlayerCol, ref int coalLeft, ref bool timeToEnd, ref string result)
        {
            if (IsInsideTheField(field, newPlayerRow,newPlayerCol))
            {
                if (field[newPlayerRow, newPlayerCol] == '*')
                {
                    field[playerRow, playerCol] = '*';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                }
                if (field[newPlayerRow, newPlayerCol] == 'c')
                {
                    field[playerRow, playerCol] = '*';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    coalLeft--;
                    if (coalLeft == 0)
                    {
                        timeToEnd = true;
                        result = $"You collected all coals! ({playerRow}, {playerCol})";
                    }

                }
                if (field[newPlayerRow, newPlayerCol] == 'e')
                {
                    field[playerRow, playerCol] = '*';
                    playerRow = newPlayerRow;
                    playerCol = newPlayerCol;
                    timeToEnd = true;
                    result = $"Game over! ({playerRow}, {playerCol})";
                }
            }
            else
            {
                newPlayerRow = playerRow;
                newPlayerCol = playerCol;
            }
        }


        private static bool IsInsideTheField(char[,] field, int newPlayerRow, int newPlayerCol)
        {
            return newPlayerRow >= 0 && newPlayerRow < field.GetLength(0) && newPlayerCol >=0 && newPlayerCol <field.GetLength(1);

        }

        private static void FilThefieldsAndFindParameters(char[,] field, ref int playerRow, ref int playerCol, List<int[]> coalArr)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] dataRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {

                    field[row, col] = dataRow[col];
                    if (field[row, col] == 's')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                    if (field[row, col] == 'c')
                    {
                        coalArr.Add(new int[] { row, col });
                    }
                }
            }
        }

        private static void PrintTheField(char[,] field)
        {
            for (int row = 0; row < field.GetLength(0); row++)
            {

                for (int col = 0; col < field.GetLength(1); col++)
                {
                    Console.Write(field[row, col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
