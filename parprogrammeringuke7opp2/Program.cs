// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

namespace parprogrammeringuke7opp2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string option = string.Empty;
            while(option != "0")
            {
                option = mainMenu();
                switch(option)
                {
                    case "0":
                        break;

                    case "1":
                        clothing();
                        break;

                    case "2":
                        electronics();
                        break;

                }
                pause();
            }
            
        }

        public static void clothing()
        {
            Console.Clear();
            Clothingitem whiteDress = new Clothingitem("Dress", 20, 1000, "slim-fit", "White");
            Clothingitem blackHoodie = new Clothingitem("Hoodie", 40, 200, "large", "Black");
            List<Clothingitem> list = new List<Clothingitem> { whiteDress, blackHoodie };
            foreach (var item in list)
            {
                Console.WriteLine($"Order item name: {item.Color} {item.Name}:\n");
                Console.WriteLine($"Amount ordered: {item.Amount}");
                Console.WriteLine($"Price per item {item.Price}");
                Console.WriteLine($"Total price for the order: {item.CalculateSale()}\n");
            }
        }

        public static void electronics()
        {
            Console.Clear();
            Electronics IPhone = new Electronics("IPhone", 20, 3500, "1 year");
            Electronics Samsungphone = new Electronics("Samsung", 20, 2500, "2 years");
            List<Electronics> list = new List<Electronics> { IPhone, Samsungphone };
            foreach (var item in list)
            {
                Console.WriteLine($"Order item name: {item.Name}:\n");
                Console.WriteLine($"Amount ordered: {item.Amount}");
                Console.WriteLine($"Price per item {item.Price}");
                Console.WriteLine($"Insurance policy for {item.Insurance}");
                Console.WriteLine($"Total price for the order: {item.CalculateSale()}\n");
            }
        }

        public static string mainMenu()
        {
            string option;
            Console.WriteLine("|-- Ordered Menu --|");
            Console.WriteLine("| 1. Clothing");
            Console.WriteLine("| 2. Electronics");
            Console.WriteLine("| 0. Exit");
            Console.WriteLine($"|- {option = Console.ReadLine()}");
            return option;
        }

        public static void pause()
        {
            Console.WriteLine($"Press <Enter> to continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}