using System;

namespace _11.SnakeAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int snakeRow = -1;
            int snakeCol = -1;
            int burrowOneRow = -1;
            int burrowOneCol = -1;
            int burrowTwoRow = -1;
            int burrowTwoCOl = -1;

            int food = 0;


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string data = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = data[col];

                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;

                    }
                    else if (matrix[row, col] == 'B')
                    {
                        if (burrowOneRow == -1)
                        {
                            burrowOneRow = row;
                            burrowOneCol = col;
                        }
                        else
                        {
                            burrowTwoRow = row;
                            burrowTwoCOl = col;
                        }
                    }
                }
            }


            while (true)
            {
                matrix[snakeRow, snakeCol] = '.';
                string command = Console.ReadLine();

                if (command == "right")
                {
                    snakeCol++;
                }
                if (command == "left")
                {
                    snakeCol--;
                }
                if (command == "up")
                {
                    snakeRow--;
                }
                if (command == "down")
                {
                    snakeRow++;
                }
                if (!IsValidCoordinate(matrix, snakeRow, snakeCol))
                {
                    break;
                }
                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food++;
                }
                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';
                    if (snakeRow == burrowOneRow && snakeCol == burrowOneCol)
                    {
                        snakeRow = burrowTwoRow;
                        snakeCol = burrowTwoCOl;
                    }
                    else
                    {
                        snakeRow = burrowOneRow;
                        snakeCol = burrowOneCol;
                    }
                }

                matrix[snakeRow, snakeCol] = 'S';

                if (food == 10)
                {
                    Console.WriteLine("You won! You fed the snake.");

                    break;
                }

            }

            Console.WriteLine($"Food eaten: {food}");

            Print(matrix);

        }

        private static void Print(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine(); ;
            }
        }

        private static bool IsValidCoordinate(char[,] matrix, int snakeRow, int snakeCol)
        {
            if(snakeRow >= 0 & snakeCol >= 0 && snakeRow < matrix.GetLength(0) && snakeCol < matrix.GetLength(1))
            {
                return true;
            }
           
            Console.WriteLine("Game over!");
            return false;
        }
    }
}
