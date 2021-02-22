using System;

namespace _02.MatrixSelling16December2020
{
    class StartUp
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            int posRow = -1;
            int posCol = -1;
            int pillarOneRow = -1;
            int pillarOneCol = -1;
            int pillarTwoRow = -1;
            int pillarTwoCol = -1;
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string dataRow = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = dataRow[col];

                    if (matrix[row, col] == 'S')
                    {
                        posRow = row; posCol = col;

                    }
                    else if (matrix[row, col] == 'O')
                    {
                        if (pillarOneRow == -1)
                        {
                            pillarOneRow = row; pillarOneCol = col;
                        }
                        else
                        {
                            pillarTwoRow = row; pillarTwoCol = col;
                        }
                    }
                }
            }

            while (true)
            {
                matrix[posRow, posCol] = '-';

                string command = Console.ReadLine();

                Mouve(ref posRow, ref posCol, command);


                if (!IsValidCoord(matrix, posRow, posCol))
                {
                    Console.WriteLine("Bad news, you are out of the bakery.");
                    break;

                }
                if (matrix[posRow, posCol] == 'O')
                {
                    matrix[posRow, posCol] = '-';
                    if (posRow == pillarOneRow && posCol == pillarOneCol)
                    {
                        posRow = pillarTwoRow; posCol = pillarTwoCol;

                    }
                    else
                    {
                        posRow = pillarOneRow; posCol = pillarOneCol;
                    }

                }
                else if( matrix[posRow,posCol] == '-')
                {
                    continue;
                }else
                {
                    char currChar = matrix[posRow, posCol];
                    int value = int.Parse(currChar.ToString());
                    sum += value;
                    
                }
                if (sum >= 50)
                {
                    Console.WriteLine("Good news! You succeeded in collecting enough money!");
                    matrix[posRow, posCol] = 'S';
                    break;
                }
            }

            Console.WriteLine($"Money: {sum}");
            PrintMatrix(matrix);

        }

        private static void Mouve(ref int posRow, ref int posCol, string command)
        {
            if (command == "right")
            {
                posCol++;
            }
            else if (command == "left")
            {
                posCol--;
            }
            else if (command == "up")
            {
                posRow--;
            }
            else if (command == "down")
            {
                posRow++;
            }
        }

        private static void PrintMatrix(char[,] matrix)
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

        private static bool IsValidCoord(char[,] matrix, int posRow, int posCol)
        {
            return (posRow >= 0 & posCol >= 0 && posRow < matrix.GetLength(0) && posCol < matrix.GetLength(1));
          
        }
    }
}
