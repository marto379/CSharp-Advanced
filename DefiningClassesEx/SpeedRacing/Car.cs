using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedRacing
{
    public class Car
    {
       public Car(string model,double amountKm,double fuelConsumption)
        {
            Model = model;
            FuelAmount = amountKm;
            FuelConsumptionPerKilometer = fuelConsumption;
            TravelDistance = 0;
        }

        string model;
        double fuelAmount;
        double fuelConsumptionPerKilometer;
	    double travelleDistance;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelDistance { get; set; }
        

        public void Drive(double amountKm)
        {
            double neededFuel = amountKm * FuelConsumptionPerKilometer;
            if (neededFuel <= FuelAmount)
            {
                FuelAmount -= neededFuel;
                TravelDistance += amountKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

        }

    }
}
