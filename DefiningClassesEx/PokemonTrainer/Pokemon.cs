﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonTrainer
{
    public class Pokemon
    {
        public Pokemon(string name,string element,int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        string name;
        string element;
        int health;

        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }

        public void ReduceHealth()
        {
            this.Health -= 10;
        }
    }
}
