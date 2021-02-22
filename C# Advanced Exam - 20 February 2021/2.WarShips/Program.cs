using System;
using System.Linq;

namespace _2.WarShips
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            string[] coordinates = Console.ReadLine().Split(",", StringSplitOptions.RemoveEmptyEntries);

            int firstPlayerShips = 0;
            int secondPlayerShips = 0;

            for (int row = 0; row < n; row++)
            {
                string[] rowData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < n; col++)
                {
                    var currElement = char.Parse(rowData[col]);

                    if (currElement == '<')
                    {
                        firstPlayerShips++;
                    }
                    else if (currElement == '>')
                    {
                        secondPlayerShips++;
                    }

                    matrix[row, col] = currElement;
                }
            }

            int startCountShipFirst = firstPlayerShips;
            int startCountShipSecond = secondPlayerShips;

            for (int i = 0; i < coordinates.Length; i++)
            {

                if (firstPlayerShips == 0 || secondPlayerShips == 0)
                {
                    break;
                }

                string[] coordinate = coordinates[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);

                int row = int.Parse(coordinate[0]);
                int col = int.Parse(coordinate[1]);

                if (!IsValidCoordinates(row, col, n))
                {
                    continue;
                }

                if (i % 2 == 0)
                    //PlayerOne
                {
                    if (matrix[row, col] == '>')
                    {
                        matrix[row, col] = 'X';
                        secondPlayerShips--;
                    }

                    if (matrix[row, col] == '#')
                    {
                        matrix = Mine(ref firstPlayerShips, ref secondPlayerShips, row, col, matrix, n);
                    }
                }
                else 
                //SecondPlayer 
                {
                    if (matrix[row, col] == '<')
                    {
                        matrix[row, col] = 'X';
                        firstPlayerShips--;
                    }

                    if (matrix[row, col] == '#')
                    {
                        matrix = Mine(ref firstPlayerShips, ref secondPlayerShips, row, col, matrix, n);
                    }
                }
            }
            // to do print
       
            if (firstPlayerShips == 0 || secondPlayerShips == 0)
            {
                if (firstPlayerShips > 0)
                {
                    int allDestroy = startCountShipSecond + (startCountShipFirst - firstPlayerShips);
                    Console.WriteLine($"Player One has won the game! {allDestroy} ships have been sunk in the battle.");
                }
                else
                {
                    int allDestroy = startCountShipFirst + (startCountShipSecond - secondPlayerShips);
                    Console.WriteLine($"Player Two has won the game! {allDestroy} ships have been sunk in the battle.");
                }
            }
            else
            {
                Console.WriteLine($"It's a draw! Player One has {firstPlayerShips} ships left. Player Two has {secondPlayerShips} ships left.");
            }


        }

        static bool IsValidCoordinates(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }

        static void ShiptToRemove(ref int firstShips, ref int secondShips, char character)
        {
           

            if (character == '>')
            {
                secondShips--;
            }
           else if (character == '<')
            {
                firstShips--;
            }
        }

        static char[,] Mine(ref int firstPlayerShip, ref int secondPlayerShip, int row, int col, char[,] matrix, int n)
        {
            int coordinateRow;
            int coordinateCol;

           

            if (IsValidCoordinates(row + 1, col, n)) 
            {
                coordinateRow = row + 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, col]);
                matrix[coordinateRow, col] = 'X';
            }
            if (IsValidCoordinates(row - 1, col, n))
            {
                coordinateRow = row - 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, col]);
                matrix[coordinateRow, col] = 'X';
            }

           
            if (IsValidCoordinates(row, col - 1, n)) 
            {
                coordinateCol = col - 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[row, coordinateCol]);
                matrix[row, coordinateCol] = 'X';
            }
            if (IsValidCoordinates(row, col + 1, n))
            {
                coordinateCol = col + 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[row, coordinateCol]);
                matrix[row, coordinateCol] = 'X';
            }

            if (IsValidCoordinates(row - 1, col - 1, n)) 
            {
                coordinateRow = row - 1;
                coordinateCol = col - 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, coordinateCol]);
                matrix[coordinateRow, coordinateCol] = 'X';
            }

            if (IsValidCoordinates(row - 1, col + 1, n)) 
            {
                coordinateRow = row - 1;
                coordinateCol = col + 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, coordinateCol]);
                matrix[coordinateRow, coordinateCol] = 'X';
            }
            if (IsValidCoordinates(row + 1, col + 1, n))
            {
                coordinateRow = row + 1;
                coordinateCol = col + 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, coordinateCol]);
                matrix[coordinateRow, coordinateCol] = 'X';
            }
            if (IsValidCoordinates(row + 1, col - 1, n)) 
            {
                coordinateRow = row + 1;
                coordinateCol = col - 1;
                ShiptToRemove(ref firstPlayerShip, ref secondPlayerShip, matrix[coordinateRow, coordinateCol]);
                matrix[coordinateRow, coordinateCol] = 'X';
            }

           

            matrix[row, col] = 'X';

            return matrix;
        }
    }
}
