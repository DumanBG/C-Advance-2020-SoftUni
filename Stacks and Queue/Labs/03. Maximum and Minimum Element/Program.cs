using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int commNumbers = int.Parse(Console.ReadLine());

            Stack<int> stack = new Stack<int>();


            for (int i = 0; i < commNumbers; i++)
            {
                int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

                int command = input[0];

                if (command == 1)
                {
                    stack.Push(input[1]);
                }
                else if (stack.Count > 0)
                {
                    if (command == 2)
                    {
                        stack.Pop();
                    }
                    else if (command == 3)
                    {
                        Console.WriteLine(stack.Max());
                    }
                    else if (command == 4)
                    {
                        Console.WriteLine(stack.Min());
                    }


                }

            }
            if (stack.Count > 0)
            {
                Console.Write(stack.Pop());

                while (stack.Count > 0)
                {
                    Console.Write(", " + stack.Pop());
                }
            }
        }
    }
}


