using Parprogrammeringuke4.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammeringuke4.PokemonOppgave
{
    internal class Trener
    {
        public string Name { get; set; }
        public List<Pokemon> pokemons { get; set; }
        public List<Items> Inventory;

        public Trener(string name)
        {
            Name = name;
            pokemons = new List<Pokemon>
            {
                new Pokemon("Charizard", "Fire")
            };
            Inventory = new List<Items>();
        }
    }
}
