using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.BasicStackSecondWay
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            int n = data[0];
            int s = data[1];
            int x = data[2];

            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                if(stack.Count >0)
                {
                    stack.Pop();
                }
            }

            if(!stack.Any())
            {
                Console.WriteLine(0);
            }
            else if(stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
