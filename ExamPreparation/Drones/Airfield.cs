using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        

        public string Name { get; set; }
        public int Capacity { get ; set ; }
        public double LandingStrip { get ; set ; }
        public List<Drone> Drones { get; set; }

        public Airfield(string name, int capacity, double landingStrip)
        {
            Name = name;
            Capacity = capacity;
            LandingStrip = landingStrip;
            this.Drones = new List<Drone>();

        }

        public int Count
            => this.Drones.Count;

        

        public string AddDrone(Drone drone)
        {
            bool strName = string.IsNullOrEmpty(drone.Name);
            bool strBrand = string.IsNullOrEmpty(drone.Brand);

            bool range = drone.Range < 5 && drone.Range > 15;

            if (strName || strBrand || range)
            {
                return "Invalid drone.";
            }
            if (Capacity <= this.Drones.Count)
            {
                return "Airfield is full.";
            }
            else
            {
               Drones.Add(drone);
                return $"Successfully added {drone.Name} to the airfield.";
            }
        }

        public bool RemoveDrone(string name)
        {
            int count = this.Drones.RemoveAll(d => d.Name == name);
            return count > 0;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = this.Drones.RemoveAll(d => d.Brand == brand);
            
            return count;
        }

        public Drone FlyDrone(string name)
        {
            //bool flag = false;
            foreach (Drone drone in Drones)
            {

                if (drone.Name == name)
                {
                    //flag = true;
                    drone.Aveable = false;
                    return drone;

                }
            }
            return null;

        }

        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = Drones.Where(d => d.Range >= range).ToList();
            foreach (var d in drones)
            {
                d.Aveable = false;
            }
            return drones;
        }

          public string Report() 
        {
            List<Drone> drones = Drones.Where(d => d.Aveable == true).ToList();
            return
                $"Drones available at {this.Name}:"+  Environment.NewLine + string.Join(Environment.NewLine, drones);

        }

    }
}
