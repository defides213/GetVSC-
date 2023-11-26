// See https://aka.ms/new-console-template for more information
namespace GetVSC.CrocodileGame
{
    public class CrocodileGame
    {
        public static void Main(string[] args)
        {
            int points = 0;
            string userInput = string.Empty;
            
            while (userInput != "0")
            {
                int randomNumber1 = randomNumbers();
                int randomNumber2 = randomNumbers();
                mainMenu();
                Console.WriteLine($"|- Points: {points}");
                Console.WriteLine($"|- {randomNumber1} _ {randomNumber2}");
                Console.WriteLine("|- Write either '<', '>' or '='");
                userInput = Console.ReadLine();
                if (userInput == "<" && randomNumber1 < randomNumber2 ||
                   (userInput == ">" && randomNumber1 > randomNumber2) ||
                   (userInput == "=" && randomNumber1 == randomNumber2)
                   )
                {
                    Console.WriteLine("correct");
                    points++;
                }
                else if(userInput != "0") 
                {
                    Console.WriteLine("Wrong");
                    points--;
                }
                Console.WriteLine("Press <Enter> to continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public static int randomNumbers()
        {
            Random number = new();
            int randomNumber = number.Next(0, 11);
            return randomNumber;
        }

        public static void mainMenu()
        {
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|-     Crocodile Game     -|");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|- 0 Exit                  |\n");

        }
    }
}
