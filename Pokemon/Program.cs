// See https://aka.ms/new-console-template for more information
namespace PokemoDing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int healtH = readINNT("Write an amount");
            int leveL = readINNT("Write an amount");
            string name = readString("Write a name");
            Pokemon newPoke = new Pokemon(healtH, leveL, name);
            name = readString("Write another name");
            Pokemon namePoke = new Pokemon(name);

            Console.WriteLine($"Look at pokemon you made \n{newPoke.Name}\n{newPoke.Health}\n{newPoke.Level}\n");
            Console.WriteLine($"Name: \n{namePoke.Name}");
        }

        public static string readString(string consoleQuestion)
        {
           Console.WriteLine(consoleQuestion);
           return Console.ReadLine();
        }

        public static int readINNT(string consoleQuestion)
        {
            return int.Parse(readString(consoleQuestion));
        }
    }
}