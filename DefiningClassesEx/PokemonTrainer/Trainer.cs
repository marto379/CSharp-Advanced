using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    internal class Trainer
    {
        public Trainer(string name)
        {
            this.Name = name;
            NumBadgets = 0;
            this.Pokemons = new List<Pokemon>();
        }

        string name;
        int numBadgets;
        List<Pokemon> pokemons;

        public string Name { get; set; }
        public int NumBadgets { get; set; }
        public List<Pokemon> Pokemons { get; set; }

        public void IncreaseBadgets()
        {
            this.NumBadgets++;
        }
    }
}
