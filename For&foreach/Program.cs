// See https://aka.ms/new-console-template for more information
namespace GetCSV.Forforeach
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int roundNumber = 0;
            string textThing = "something is cool";
            for(int i = 0; i < 5; i++) { Console.WriteLine(textThing); }
            foreach(char name in textThing) { Console.WriteLine(name); }
            while(roundNumber != 11)
            {
                Console.WriteLine($"Round is {roundNumber}");
                roundNumber++;
            }
        }
    }

}