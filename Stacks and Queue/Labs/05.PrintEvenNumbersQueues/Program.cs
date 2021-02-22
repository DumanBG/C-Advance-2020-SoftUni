using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.PrintEvenNumbersQueues
{
    class Program
    {
        static void Main(string[] args)
        {
            //11 13 18 95 2 112 81 46    // 18, 2, 112, 46
            int[] input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            Queue<int> queue = new Queue<int>(input);
            int count = queue.Sum();
            int sum = 0;
            while (sum != count)
            {
                sum += queue.Peek();
                if (queue.Peek() % 2 == 1)
                {
                    queue.Dequeue();
                }
                else
                {
                    queue.Enqueue(queue.Dequeue());
                }

            }
            Console.WriteLine(string.Join(", ", queue));
        }
    }
}