using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._TruckTourPetrolPomsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            //3   1 5     10 3      3 4

            int numOfPomps = int.Parse(Console.ReadLine());
            Queue<string> circle = new Queue<string>();

            for (int i = 0; i < numOfPomps; i++)
            {
                string input = Console.ReadLine(); //  2lit  5km _1 -va stanc
                input += $" {i}";
                circle.Enqueue(input);
            }
            var totalFuel = 0;
            for (int i = 0; i < numOfPomps; i++)
            {
                string currentInfo = circle.Dequeue(); // 1 5 0
                var info = currentInfo.Split().Select(int.Parse).ToArray();
                var fuel = info[0];
                var distance = info[1];
                totalFuel += fuel;
                if(totalFuel>= distance)
                {
                    totalFuel -= distance;
                }
                else
                {
                    totalFuel = 0;
                    i= -1;  /// зануляване на 0-ла
                   
                }

                circle.Enqueue(currentInfo);
            }
            var firstElement = circle.Peek().Split().ToArray();  // 10 3 1
            Console.WriteLine(firstElement[2]);


        }
    }
}
