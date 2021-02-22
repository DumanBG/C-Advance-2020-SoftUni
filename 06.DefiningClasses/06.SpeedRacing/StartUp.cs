using System;
using System.Collections.Generic;

namespace _06.SpeedRacing
{
   public class StartUp
    {
       public static void Main()
        {
            var listOfCars = ReadCars(int.Parse(Console.ReadLine()));

            string input = Console.ReadLine();
            while (input.ToLower() != "end")
            {
                // Drive { carModel} { amountOfKm}

                string[] commandData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = commandData[1];
                double amountOfKm = double.Parse(commandData[2]);
                int index =listOfCars.FindIndex(x => x.Model == model);
                listOfCars[index].Drive(amountOfKm);


                input = Console.ReadLine();
            }
            // "{model} {fuelAmount} {distanceTraveled}"
            foreach (var item in listOfCars)
            {
                Console.WriteLine($"{item.Model} {item.FuelAmount:F2} {item.TravelledDistance}");
            }
        }

        private static List<Car> ReadCars(int num)
        {
            var listOfCars = new List<Car>();
            //{ model}{ fuelAmount} { fuelConsumptionFor1km}
            for (int i = 0; i < num; i++)
            {
                string[] dataInput = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = dataInput[0];
                double fuelAmount = double.Parse(dataInput[1]);
                double fuelConsumationFor1km = double.Parse(dataInput[2]);
                Car currCar = new Car(model, fuelAmount, fuelConsumationFor1km);
                listOfCars.Add(currCar);
            }
            return listOfCars;
        }
    }
}
