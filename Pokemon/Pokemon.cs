using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemoDing
{
    internal class Pokemon
    {
        public int Health;
        public int Level;
        public string Name;
        public Pokemon(int health, int level, string name) 
        { 
            this.Health = health;
            this.Level = level;
            this.Name = name;
        }
        public Pokemon(string name) 
        {
            this.Name = name;
        }
    }
}
