﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10.Radioactive_Mutant_Vampire_Bunnies
{ 
    public class RadioactiveBunnies
    {
        public static void Main()
        {
            var bunnies = InitializeMatrix(out var playerPosition);
            PlayTheGame(bunnies, playerPosition);
        }

        private static void PlayTheGame(bool[][] bunnies, int[] playerPosition)
        {
            while (true)
            {
                var playerSpepDirections = Console.ReadLine().ToCharArray();

                foreach (var stepDirection in playerSpepDirections)
                {
                    var isPlayerEscaped = IsPlayerEscaped(bunnies, playerPosition, stepDirection);
                    MultiplyBunnies(bunnies);

                    if (isPlayerEscaped)
                    {
                        PrintMatrix(bunnies);
                        Console.WriteLine($"won: {playerPosition[0]} {playerPosition[1]}");
                        return;
                    }

                    if (bunnies[playerPosition[0]][playerPosition[1]])
                    {
                        PrintMatrix(bunnies);
                        Console.WriteLine($"dead: {playerPosition[0]} {playerPosition[1]}");
                        return;
                    }
                }
            }
        }

        private static void PrintMatrix(bool[][] bunnies)
        {
            var sb = new StringBuilder();

            foreach (var t in bunnies)
            {
                foreach (var t1 in t)
                {
                    sb.Append(t1 ? 'B' : '.');
                }

                sb.Append(Environment.NewLine);
            }

            Console.WriteLine(sb.ToString().Trim());
        }

        private static void MultiplyBunnies(bool[][] bunnies)
        {
            var newBunnies = new Stack<int[]>();

            for (int row = 0; row < bunnies.Length; row++)
            {
                for (int col = 0; col < bunnies[row].Length; col++)
                {
                    if (bunnies[row][col])
                    {
                        newBunnies.Push(new[] { row + 1, col });
                        newBunnies.Push(new[] { row - 1, col });
                        newBunnies.Push(new[] { row, col + 1 });
                        newBunnies.Push(new[] { row, col - 1 });
                    }
                }
            }

            while (newBunnies.Count > 0)
            {
                var currentBunny = newBunnies.Pop();
                if (IsInsideTheLayer(currentBunny, bunnies))
                {
                    bunnies[currentBunny[0]][currentBunny[1]] = true;
                }
            }
        }

        private static bool IsInsideTheLayer(int[] cell, bool[][] matrix)
        {
            return cell[0] >= 0 && cell[0] < matrix.Length && cell[1] >= 0 && cell[1] < matrix[0].Length;
        }

        private static bool IsPlayerEscaped(bool[][] bunnies, int[] playerPosition, char stepDirection)
        {
            if (stepDirection == 'U')
            {
                playerPosition[0]--;

                if (!IsInsideTheLayer(playerPosition, bunnies))
                {
                    playerPosition[0]++;
                    return true;
                }
            }
            else if (stepDirection == 'D')
            {
                playerPosition[0]++;

                if (!IsInsideTheLayer(playerPosition, bunnies))
                {
                    playerPosition[0]--;
                    return true;
                }
            }
            else if (stepDirection == 'L')
            {
                playerPosition[1]--;

                if (!IsInsideTheLayer(playerPosition, bunnies))
                {
                    playerPosition[1]++;
                    return true;
                }
            }
            else if (stepDirection == 'R')
            {
                playerPosition[1]++;

                if (!IsInsideTheLayer(playerPosition, bunnies))
                {
                    playerPosition[1]--;
                    return true;
                }
            }

            return false;
        }

        private static bool[][] InitializeMatrix(out int[] playerPosition)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            playerPosition = new int[] { 0, 0 };
            var bunnies = new bool[dimensions[0]][];

            for (int row = 0; row < bunnies.Length; row++)
            {
                string input = Console.ReadLine();
                bunnies[row] = new bool[input.Length];

                for (int col = 0; col < bunnies[row].Length; col++)
                {
                    if (input[col] == 'B')
                    {
                        bunnies[row][col] = true;
                    }
                    else if (input[col] == 'P')
                    {
                        playerPosition[0] = row;
                        playerPosition[1] = col;
                    }
                }
            }

            return bunnies;
        }
    }
}
