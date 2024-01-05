using Parprogrammeringuke4.PokemonOppgave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammeringuke4.PokemonOppgave
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.CursorLeft = 45;
            Console.CursorTop = 13;
            Console.WriteLine("Welcome to the world of Pokemon \nWhat is your name?");
            string userName = Console.ReadLine();
            Trener User = new Trener(userName);
            string option = string.Empty;
            while (option != "0")
            {
                option = Menu();
                switch (option)
                {
                    case "0":
                        break;

                    case "1":
                        GrassPlain(User);
                        break;

                    case "2":
                        WaterPlain(User);
                        break;

                    case "3":
                        Shop(User);
                        break;

                    case "4":
                        Console.WriteLine("Do you want to se:\n1. pokemon\n2. items");
                        if (Console.ReadLine() == "1")
                        {
                            foreach (var item in User.pokemons)
                            {
                                Console.WriteLine($"Name: {item.Name} Type: {item.Type}");
                            }
                        }
                        else
                        {
                            foreach (var item in User.Inventory)
                            {
                                Console.WriteLine($"Type: {item.Type}");
                            }
                        }
                        break;
                }
                pause();
            }

            //chooseWhichTerrain();
        }

        public static List<Items> pokeShop = new List<Items>
        {
            new Items("Pokeballer"),
            new Items("Health potions"),
        };

        public static Random Random = new Random();

        //private static void chooseWhichTerrain()
        //{
        //    int randomnumb = Random.Next(0, 2);
        //    if (randomnumb == 0) GrassPlane();
        //    else WaterPlane();
        //}

        private static void GrassPlain(Trener user)
        {
            Console.WriteLine("You walk in some grass");
            List<Pokemon> PlainPokemon = new List<Pokemon>
            {
                new Pokemon("Bulbasaur", "Grass"),
                new Pokemon("Pikachu", "Electric"),
                new Pokemon("Houndoom", "Fire"),
                new Pokemon("Mew", "Psychic")
            };

            int randomNumb = Random.Next(0, PlainPokemon.Count);
            PlainPokemon[randomNumb].Encounter(user);
        }

        private static void WaterPlain(Trener user)
        {
            Console.WriteLine("You surf on the water");
            List<Pokemon> WaterPokemon = new List<Pokemon>
            {
                new Pokemon("Lapras", "Water"),
                new Pokemon("Glaceon", "Ice"),
                new Pokemon("Blastoise", "Water"),
                new Pokemon("Poliwag", "Water")
            };

            int randomNumb = Random.Next(0, WaterPokemon.Count);
            WaterPokemon[randomNumb].Encounter(user);
        }

        private static void Shop(Trener user)
        {
            //string option = string.Empty;
            //while(option != "0")
            //{
            //    if(option != "0")
            //    {
            for (int i = 0; i < pokeShop.Count; i++)
            {
                Console.WriteLine($"{i + 1}. Item: {pokeShop[i].Type}");
            }
            Console.WriteLine("What do you want to bye?");
            user.Inventory.Add(pokeShop[Convert.ToInt32(Console.ReadLine()) - 1]);
            Thread.Sleep(1000);
            Console.Clear();
            //}
            Console.WriteLine("-- 1. Continue Shooping -- ");
            Console.WriteLine("-- 0. Exit Shop         --");
            //option = Console.ReadLine();
            if (Convert.ToInt32(Console.ReadLine()) != 0) Shop(user);
            //}
        }

        private static string Menu()
        {
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("1. Grass");
            Console.WriteLine("2. Water");
            Console.WriteLine("3. Shop");
            Console.WriteLine("4. Show Inventory");
            Console.WriteLine("0. Exit Sim");
            return Console.ReadLine();
        }

        private static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}
