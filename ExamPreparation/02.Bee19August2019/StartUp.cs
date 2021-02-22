using System;

namespace _02.Bee19August2019
{
    public class StartUp
    {
        static void Main()
        {

            int num = int.Parse(Console.ReadLine());
            char[,] matrix = new char[num, num];

            int beeRow = -1;
            int beeCol = -1;
            int flowers = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                matrix[beeRow, beeCol] = '.';
                if (input == "right")
                {
                    beeCol++;
                    if (!ValidInTheMatrix(beeRow, beeCol, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    else if( matrix[beeRow,beeCol] =='O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        beeCol++;
                    }
                }
                else if (input == "left")
                {
                    beeCol--;
                    if (!ValidInTheMatrix(beeRow, beeCol, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        beeCol--;
                    }
                }
                else if (input == "up")
                {
                    beeRow--;
                    if (!ValidInTheMatrix(beeRow, beeCol, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        beeRow--;
                    }
                }
                else if (input == "down")
                {
                    beeRow++;
                    if (!ValidInTheMatrix(beeRow, beeCol, matrix.GetLength(0), matrix.GetLength(1)))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }
                    else if (matrix[beeRow, beeCol] == 'O')
                    {
                        matrix[beeRow, beeCol] = '.';
                        beeRow++;
                    }
                }
                if(matrix[beeRow,beeCol] =='f')
                {
                    flowers++;
                }
                matrix[beeRow, beeCol] = 'B';
                input = Console.ReadLine();
            }

            if(flowers >=5)
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {flowers} flowers!");
            }
            else
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5-flowers} flowers more");
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j <matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i,j]);
                }
                Console.WriteLine();
            }

        }


        private static bool ValidInTheMatrix(int row, int col, int rowMat, int colMat)
        {
            if (row >= 0 && col >= 0 && row < rowMat && col < colMat)
            {
                return true;
            }
            return false;
        }
    }
}
