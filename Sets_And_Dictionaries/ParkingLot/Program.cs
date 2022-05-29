using System;
using System.Collections.Generic;

namespace ParkingLot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            HashSet<string> set = new HashSet<string>();    
            while ((input = Console.ReadLine()) != "END")
            {
                string[] command = input.Split(", ");
                string inOrOut = command[0];    
                string registracion = command[1];
                if (inOrOut == "IN")
                {
                    set.Add(registracion);
                }
                else
                {
                    set.Remove(registracion);
                }
            }
            if (set.Count > 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine,set));
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
