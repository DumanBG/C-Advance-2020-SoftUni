using System;
using System.Linq;

namespace _02.RevoltSecontEdition22Feb2020
{
    public class Program
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            int commandsCount = int.Parse(Console.ReadLine());

            char[,] matrix = FillTheMAtrix(size);

            (int, int) start = StartIndexes(matrix);
            int playerRow = start.Item1;
            int playerCol = start.Item2;

            bool isWon = false;
            // PrintFinalMatrix(matrix);
            ;
            for (int i = 0; i < commandsCount; i++)
            {
                matrix[playerRow, playerCol] = '-';

                string command = Console.ReadLine();

             //   bool insideTheMatrix = InsideTheMtrix(playerRow, playerCol, matrix);

                int nextPlayerRow = playerRow;
                int nextPlayerCol = playerCol;
                // Mouve nextPlayer coordinate by command "right", "left", ecc
                (nextPlayerRow, nextPlayerCol) = Mouve(matrix, playerRow, playerCol, command, ref nextPlayerRow, ref nextPlayerCol);
              
                if (matrix[nextPlayerRow, nextPlayerCol] == 'B')
                {
                    (nextPlayerRow, nextPlayerCol) = Mouve(matrix, playerRow, playerCol, command, ref nextPlayerRow, ref nextPlayerCol);
                }


                else if (matrix[nextPlayerRow, nextPlayerCol] == 'T')
                {
                    nextPlayerRow = playerRow;
                    nextPlayerCol = playerCol;

                }
               if (matrix[nextPlayerRow, nextPlayerCol] == 'F')
                {

                matrix[nextPlayerRow, nextPlayerCol] = 'f';
                    isWon = true;
                    break;
                }
                playerRow = nextPlayerRow;
                playerCol = nextPlayerCol;
                matrix[playerRow, playerCol] = 'f';
             
                // PrintFinalMatrix(matrix);   // за проверки
            }



            if (isWon)
            {
                Console.WriteLine("Player won!");
            }
            else
            {
                Console.WriteLine("Player lost!");
            }

            PrintFinalMatrix(matrix);


        }

        private static void PrintFinalMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static (int, int) Mouve(char[,] matrix, int playerRow, int playerCol, string command, ref int nextPlayerRow, ref int nextPlayerCol)
        {
            if (command == "right")
            {
                nextPlayerCol++;
                if (!InsideTheMtrix(nextPlayerRow, nextPlayerCol, matrix))
                {
                    nextPlayerCol = 0;
                }
            }
            else if (command == "left")
            {
                nextPlayerCol--;
                if (!InsideTheMtrix(nextPlayerRow, nextPlayerCol, matrix))
                {
                    nextPlayerCol = matrix.GetLength(0) - 1;
                }
            }
            else if (command == "up")
            {
                nextPlayerRow--;
                if (!InsideTheMtrix(nextPlayerRow, nextPlayerCol, matrix))
                {
                    nextPlayerRow = matrix.GetLength(0) - 1;
                }
            }
            else if (command == "down")
            {
                nextPlayerRow++;
                if (!InsideTheMtrix(nextPlayerRow, nextPlayerCol, matrix))
                {
                    nextPlayerRow = 0;
                }
            }
            return (nextPlayerRow, nextPlayerCol);
        }





        private static bool InsideTheMtrix(int playerRow, int playerCol, char[,] matrix)
        {

            if (playerRow >= 0 && playerCol >= 0)
            {

                if (playerRow < matrix.GetLength(0) && playerCol < matrix.GetLength(1))
                {
                    return true;
                }
            }
            return false;
        }

        private static (int, int) StartIndexes(char[,] matrix)
        {

            int startRow = -1;
            int startCol = -1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] == 'f')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }
            return (startRow, startCol);
        }

        private static char[,] FillTheMAtrix(int size)
        {
            char[,] matrix = new char[size, size];
            for (int row = 0; row < size; row++)
            {

                char[] dataInfo = Console.ReadLine().ToCharArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = dataInfo[col];
                }
            }
            return matrix;
        }
    }
}
