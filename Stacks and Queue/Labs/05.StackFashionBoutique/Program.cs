using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.StackFashionBoutique
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 7 8 2 5 4 7 8 9 6 3 2 5 4 6
            //20                                  5

            int[] clothes = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();

            int stackCapacity = int.Parse(Console.ReadLine()); //20
            Stack<int> boxes = new Stack<int>(clothes);

            int racksNumbers = 1; //стелажи
            int currentCapacity = stackCapacity;
            while(boxes.Any())
            {
                int current = boxes.Peek();

                if(currentCapacity >=current)
                {
                    currentCapacity -= boxes.Pop();
                }
                else
                {
                    racksNumbers++;
                    currentCapacity = stackCapacity;
                   

                }



            }
            Console.WriteLine(racksNumbers);

        }
    }
}
