using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                string model = input.Split()[0];
                double amountKm = double.Parse(input.Split()[1]);
                double fuelConsumption = double.Parse(input.Split()[2]);
                Car car = new Car(model,amountKm,fuelConsumption);

                cars.Add(car);

            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string carModel = command.Split()[1];
                double amountKm = double.Parse(command.Split()[2]);

                Car carToDrive = cars.First(car => car.Model == carModel);
                carToDrive.Drive(amountKm);

                command = Console.ReadLine();   
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelDistance}");
            }
        }
    }
}
