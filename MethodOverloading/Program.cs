// See https://aka.ms/new-console-template for more information
namespace MethodOverloading
{
    public class Program
    {
        public static void Main(string[] args) 
        { 
            Boring boring = new Boring();
            boring.PrintMessage();
            Console.WriteLine("\nWrite a name\n");
            string name = Console.ReadLine();
            boring.PrintMessage(name);
        }
    }
}