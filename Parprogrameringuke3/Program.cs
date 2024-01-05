// See https://aka.ms/new-console-template for more information
namespace Parprogrameringuke3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string options = string.Empty;
            while (options != "0")
            {
                options = menu();
                switch (options)
                {
                    case "0":
                        break;

                    case "1":
                        partOne();
                        break;

                    case "2":
                        partTwo();
                        break;
                }
                Console.WriteLine($"Press <Enter> To Continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }


        }
        public static void partOne()
        {
            Person simon = new("Simon", "brown", 21);
            simon.PrintInfo();

            //----------------------------------------------------//

            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }

            //-----------------------------------------------------//

            Person kristoffer = new("kristoffer", "blonde", 33);
            kristoffer.PrintInfo();
        }

        public static void partTwo()
        {
            Person simon = new("Simon", "brown", 21);
            Person kristoffer = new("kristoffer", "blonde", 33);

            Hobbies gaming = new("Gaming", "hvor man spiller spill");
            Hobbies anime = new("Anime", "Ser på japansk animasjons film");
            simon.Hobbies.Add(gaming);
            simon.PrintHobbiesInfo();
            kristoffer.Hobbies.Add(anime);
            kristoffer.PrintHobbiesInfo();

        }

        public static string menu()
        {
            Console.Clear();
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|-           PP            -|");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|- 1. Part one");
            Console.WriteLine("|- 2. Part two");
            Console.WriteLine("|- 0. Exit");
            Console.WriteLine("|- Choose");
            string? choice = null;
            while (string.IsNullOrEmpty(choice)) choice = Console.ReadLine();
            return Console.ReadLine();
        }
    }
}
