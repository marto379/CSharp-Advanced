
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "MK3";
            car.Year = 1992;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;
            car.Drive(700);
            Console.WriteLine(car.WhoAmI());
            car.Drive(100);
            Console.WriteLine(car.WhoAmI());
            
            
        }
    }
}