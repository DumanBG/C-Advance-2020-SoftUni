using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.CrossroadsTraffic24April2018
{
    public class Program
    {
       public static void Main()
        {
            int greeenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if(input.ToLower() !="green" )
                {

                    cars.Enqueue(input);
                    continue;
                }
                int currGreenLight = greeenDuration;

                string currPassingCar = null;
                while (currGreenLight >0 && cars.Any())
                {
                    currPassingCar = cars.Dequeue();
                    currGreenLight -= currPassingCar.Length;
                    passedCars++;
                }

                int freeWindowLeft = freeWindow + currGreenLight;

                if(freeWindowLeft < 0)
                {

                    int crashIndex = currPassingCar.Length - Math.Abs(freeWindowLeft);
                    char symbolCrash = currPassingCar[crashIndex];
                    Console.WriteLine("A crash happened!");
                    Console.WriteLine($"{currPassingCar} was hit at {symbolCrash}.");
                    return;

                }
            }
            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{passedCars} total cars passed the crossroads.");

        }
    }
}
