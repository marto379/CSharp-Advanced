using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniParking
{
    internal class Parking
    {
        List<Car> cars;
        int capacity;

        public List<Car> Cars { get; set; }
        public int Capacity { get; set; }
        public int Count { get { return Cars.Count; } }  

        public Parking(int capacity)
        {
             Cars = new List<Car>();
            Capacity = capacity;
        }

        public string AddCar(Car car)
        {
            bool canAddCar = true;
            foreach (Car c in Cars)
            {
                
                if (c.RegNum == car.RegNum)
                {
                    return "Car with that registration number, already exists!";
                    canAddCar = false;
                }
                
            }
            if (Cars.Count + 1 > Capacity)
            {
                return "Parking is full!";
                canAddCar = false;
            }
            if (canAddCar)
            {
                Cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegNum}";
            }
            return "";
        }
        public string RemoveCar(string registration)
        {

            
            
            foreach (Car car in Cars)
            {
                if (car.RegNum == registration)
                {
                    Cars.Remove(car);
                    return $"Successfully removed {car.RegNum}";
                }
                
            }
            return "Car with that registration number, doesn't exist!";

        }
        public Car GetCar(string regNum)
        {
            return Cars.First(c => c.RegNum == regNum);
        }
       public void RemoveSetOfRegistrationNumber(List<string> RegistrationNumbers)
        {
            foreach (string reg in RegistrationNumbers)
            {
                RemoveCar(reg);
            }
        }


    }
}
