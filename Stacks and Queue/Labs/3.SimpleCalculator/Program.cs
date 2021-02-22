using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2 + 5 + 10 - 2 - 1    = 14
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();

            Stack<string> stack = new Stack<string>(input);
            // горното замества долното
            //  Stack<string> stack = new Stack<string>();
            //  for (int i = 0; i < input.Length; i++)
            //  {
            //      stack.Push(input[i]);
            //  }
            while (stack.Count > 1)
            {
                //   PrintStack(stack);// Metod принт , не е от задачата 
                int first = int.Parse(stack.Pop());
                string sign = stack.Pop();
                int second = int.Parse(stack.Pop());

                switch (sign)
                {
                    case "+":
                        stack.Push((first + second).ToString());
                        break;
                    case "-":
                        stack.Push((first - second).ToString());
                        break;
                    default:
                        break;
                }

            }
            Console.WriteLine(stack.Pop()); // sum

        }
        static void PrintStack(Stack<string> stack) // принт на всяка операция
        {
            foreach (var item in stack)// forech e полезен само за тестване на Stack
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }
    }
}
