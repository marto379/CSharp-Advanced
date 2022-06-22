using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Zoo
{
    public class Zoo
    {
        public Zoo(string name,int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Animals = new List<Animal>();
        }

        List<Animal> animals;
        string name;
        int capacity;

        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Animal> Animals { get; set; }

        public string AddAnimal(Animal animal)
        {
            bool isNull =  string.IsNullOrEmpty(animal.Species);
            bool diet = animal.Diet != "herbivore" && animal.Diet != "carnivore";

            if (isNull)
            {
                return "Invalid animal species.";
            }
            if (diet)
            {
                return "Invalid animal diet.";
            }
            if (Capacity < Animals.Count)
            {
                return "The zoo is full.";
            }
            Animals.Add(animal);
            return $"Successfully added {animal.Species} to the zoo.";
        }

        public int RemoveAnimals(string species)
        {
            int count = 0;  
            for (int i = 0; i < Animals.Count; i++)
            {
                if (Animals[i].Species == species)
                {
                    Animals.Remove(Animals[i]);
                    count++;
                    i--;
                }
            }
            return count;
        }

        public List<Animal> GetAnimalsByDiet(string diet)
        {
            List<Animal> animalsByDiet = new List<Animal>();

            foreach (var animal in Animals)
            {
                if (animal.Diet == diet)
                {
                    animalsByDiet.Add(animal);
                }
            }
            return animalsByDiet;
        }

        public Animal GetAnimalByWeight(double weight)
        {
            foreach (var animal in Animals)
            {
                if (animal.Weight == weight)
                {
                    return animal;
                }
            }
            return null;
           
        }
        public string GetAnimalCountByLength(double minimumLength, double maximumLength)
        {
            int count = 0;
            foreach (var animal in Animals)
            {
                if (animal.Lenght >= minimumLength && animal.Lenght <= maximumLength)
                {
                    count++;
                }
            }
            return $"There are {count} animals with a length between {minimumLength} and {maximumLength} meters.";
        }

    }
}
