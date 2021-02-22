using System;
using System.Collections.Generic;

namespace _06.QueueSupermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string namesInput = Console.ReadLine();

            Queue<string> queue = new Queue<string>();
            while (namesInput.ToLower() != "end")
            {
                if (namesInput.ToLower() != "paid")
                {
                    queue.Enqueue(namesInput);
                }
                else
                {
                    while (queue.Count > 0)
                    {
                        Console.WriteLine(queue.Dequeue());
                    }
                }

                namesInput = Console.ReadLine();
            }
            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
