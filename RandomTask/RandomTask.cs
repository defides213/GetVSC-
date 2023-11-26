// See https://aka.ms/new-console-template for more information

namespace GetVSC.RandomTask
{
    public class RandomTask
    {
        public static void Main(string[] args)
        {
            Random number = new();
            bool win = false;
            int tries = 0;
            int randomNumber = number.Next(0, 100);
            
            while(win == false)
            {
                if (randomNumber <= 33)
                {
                    Console.WriteLine("number is between 33 and 0");
                }
                else if (randomNumber <= 66 && randomNumber >= 34)
                {
                    Console.WriteLine("number is between 66 and 34");
                }
                else if (randomNumber <= 100 && randomNumber >= 65)
                {
                    Console.WriteLine("number is between 100 and 65");
                }
                Console.WriteLine("Guess the number:");
                string input = Console.ReadLine();
                int numberParsed = int.Parse(input);
                if (numberParsed == randomNumber)
                {
                    Console.WriteLine("|----------|");
                    Console.WriteLine("| CORRECT! |");
                    Console.WriteLine("|----------|");
                    Console.WriteLine($"The number was {randomNumber}");
                    Console.WriteLine($"You got correct after {tries} tries");
                    win = true;
                    Console.WriteLine("Press <Enter> to continue");
                }
                else
                {
                    Console.WriteLine("Wrong");
                    if (numberParsed > randomNumber) { Console.WriteLine("Too High!"); }
                    else { Console.WriteLine("Too Low!"); }
                    tries++;
                    Console.WriteLine("Press <Enter> to try again");
                }
                while(Console.ReadKey().Key != ConsoleKey.Enter) {}
                Console.Clear();
            }
        }
    }
}
