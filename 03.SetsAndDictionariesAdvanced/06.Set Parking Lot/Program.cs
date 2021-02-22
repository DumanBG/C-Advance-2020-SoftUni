using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Set_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> carsNumbers = new HashSet<string>();

            string input = Console.ReadLine();

            while (input.ToLower() != "end")
            {
                string[] dataCommand = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = dataCommand[0];
                string numberOfTheCar = dataCommand[1];
                if (command.ToLower() == "in")
                {
                    carsNumbers.Add(numberOfTheCar);
                }
                if (command.ToLower() == "out")
                {
                    if (carsNumbers.Contains(numberOfTheCar))
                    {
                        carsNumbers.Remove(numberOfTheCar);
                    }
                }
                input = Console.ReadLine();
            }

            if (carsNumbers.Any())
            {
                foreach (var car in carsNumbers)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }

        }
    }
}
