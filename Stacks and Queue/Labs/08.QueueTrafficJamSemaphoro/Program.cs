using System;
using System.Collections.Generic;

namespace _08.QueueTrafficJamSemaphoro
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersCarToPass = int.Parse(Console.ReadLine());

            Queue<string> carsQueue = new Queue<string>();
            string input = Console.ReadLine();
            int counter = 0;
            while(input.ToLower() != "end")
            {
                if(input.ToLower() == "green")
                {
                    for (int i = 0; i < numbersCarToPass; i++)
                    {
                        if (carsQueue.Count == 0)
                        {
                            break;
                        }
                            Console.WriteLine($"{carsQueue.Dequeue()} passed!");
                            counter++;
                        
                    }

                }else
                {
                    carsQueue.Enqueue(input);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"{counter} cars passed the crossroads.");

        }
    }
}
