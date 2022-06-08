using System;
using System.Collections.Generic;
using System.Linq;

namespace PokemonTrainer
{
    internal class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Trainer> trainers = new List<Trainer>();
            while (input != "Tournament")
            {
                string trainerName = input.Split()[0];
                string pokemonName = input.Split()[1];
                string element = input.Split()[2];
                int pokemonHealth = int.Parse(input.Split()[3]);

                Trainer trainer = trainers.FirstOrDefault(x => x.Name == trainerName);

                if (trainer != null)
                {
                    trainer.Pokemons.Add(new Pokemon(pokemonName,element,pokemonHealth));   
                }
                else
                {
                    Trainer newTrainer = new Trainer(trainerName);
                    newTrainer.Pokemons.Add(new Pokemon(pokemonName,element,pokemonHealth));
                    trainers.Add(newTrainer);
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                for (int i = 0; i < trainers.Count; i++)
                {
                    if (trainers[i].Pokemons.Any(x => x.Element == input))
                    {
                        trainers[i].IncreaseBadgets();
                    }
                    else
                    {
                        foreach (var item in trainers[i].Pokemons)
                        {
                            item.ReduceHealth();
                        }
                    }
                }
                input= Console.ReadLine();


            }
            foreach (var item in trainers)
            {
                item.Pokemons.RemoveAll(x => x.Health <= 0);
            }
            trainers.OrderByDescending(x => x.NumBadgets).ToList().ForEach(x => Console.WriteLine($"{x.Name} {x.NumBadgets} {x.Pokemons.Count}"));
        }
    }
}
