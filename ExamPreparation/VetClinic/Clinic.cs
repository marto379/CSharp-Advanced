using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VetClinic
{
    internal class Clinic
    {
        List<Pet> pets;
        public List<Pet> Pets { get; set; }
        public int Capacity { get; set; }
        public int Count { get => Pets.Count; }

        public Clinic(int capacity)
        {
            Pets = new List<Pet>();
            Capacity = capacity;
        }

        public void Add(Pet pet)
        {
            if (Capacity > Pets.Count)
            {
                Pets.Add(pet);
            }
        }
        public bool Remove(string name)
        {
            if (Pets.Any())
            {
                Pet pet = Pets.Where(p => p.Name == name).First();
                return Pets.Remove(pet);
            }
            return false;
            
        }

        public Pet GetPet(string name, string owner)
        {
            Pet pet = Pets.Where(p => p.Name == name && p.Owner == owner).FirstOrDefault();
            if (pet != null)
            {
                return pet;
            }
            return null;
        }
        public Pet GetOldestPet()
        {
            Pet pet = Pets.OrderByDescending(p => p.Age).First();
            return pet;

        }
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("The clinic has the following patients:");
            foreach (Pet pet in Pets)
            {
                sb.AppendLine($"Pet {pet.Name} with owner: {pet.Owner}");
            }
            return sb.ToString().TrimEnd();
        }

    }
}
