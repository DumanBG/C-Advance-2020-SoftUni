using System;
using System.Collections.Generic;
using System.Text;

namespace _06.SpeedRacing
{
   public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;


        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;

        }



        public string Model { get => this.model; set => this.model =value; }
        public double FuelAmount { get => this.fuelAmount; set => this.fuelAmount = value; }
        public double FuelConsumptionPerKilometer { get => this.fuelConsumptionPerKilometer; set => this.fuelConsumptionPerKilometer = value; }
        public double TravelledDistance
        {
            get { return this.travelledDistance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Travelled distance cannot be negative.");
                }
                this.travelledDistance = value;
            }
        }

        public void Drive( double distanceToDrive)
        {
            if((this.FuelAmount-distanceToDrive *this.fuelConsumptionPerKilometer) >=0)
            {
                this.travelledDistance += distanceToDrive;
                this.fuelAmount -= distanceToDrive * this.fuelConsumptionPerKilometer;

            }
            else
            {

                Console.WriteLine("Insufficient fuel for the drive");
            }


        }
    }
}
