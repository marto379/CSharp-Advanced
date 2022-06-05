using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        public Car()
        {
            this.Make = "VW";
            this.Model = "Golf";
            this.Year = 2025;
            this.FuelQuantity = 200;
            this.FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
            
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            : this(make, model, year)
        {
           
           
            FuelQuantity = fuelQuantity;
            
            FuelConsumption = fuelConsumption;
        }

        string make = "WV";
        string model;
        int year;
        double fuelQuantity;



        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        private double fuelConsumption;

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }


        public void Drive(double distance)
        {
            double consumption = distance * FuelConsumption;
            if (consumption <= FuelQuantity)
            {
                FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string carInfo =
                 $"Make: {Make}\n" +
                $"Model: {Model}\n" +
                $"Year: {Year}\n" +
                $"Fuel: {FuelQuantity:f2}";
            return carInfo;
        }



    }
}
