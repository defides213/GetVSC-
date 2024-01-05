using Parprogrammeringuke4.Pokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammeringuke4.PokemonOppgave
{
    internal class Pokemon
    {
        public string Name;
        public string Type;

        public Pokemon(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void Encounter(Trener trener)
        {
            Console.WriteLine("Vil du:\n1. fange\n2. kjempe");
            switch (Console.ReadLine())
            {
                case "1":
                    if (Run() == 1)
                    {
                        capture(trener);
                    }
                    break;
                case "2":
                    if (Run() == 1)
                    {
                        Fight();
                    }
                    break;
            }
        }

        private int Run()
        {
            Random random = new Random();
            if (random.Next(0, 6) == 1)
            {
                Console.WriteLine("They ran");
                return 0;
            }
            else return 1;
        }


        private void capture(Trener trener)
        {
            if (ReturnIfPokeball(trener) == 1)
            {
                Console.WriteLine("You Caught the pokemon");
                trener.pokemons.Add(this);
                Console.WriteLine("this is your pokemon");
                foreach (var item in trener.pokemons)
                {
                    Console.WriteLine(item.Name);
                }
            }
            else Console.WriteLine("No Pokeballs in inventory");
        }

        private static int ReturnIfPokeball(Trener trener)
        {
            foreach (var item in trener.Inventory)
            {
                if (item.Type == "Pokeballer")
                {
                    return 1;
                }
            }
            return 0;
        }

        private void Fight()
        {
            Console.WriteLine("Pokemon fainted");
        }
    }
}

