// See https://aka.ms/new-console-template for more information
namespace OrganTransplant
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write your name");
            Human user = new Human(Console.ReadLine());
            Human Robert = new Human("Robert");
            Console.WriteLine("Robert is in dire need of a new kidney.");


            Organ kidney = new Organ("Kidney", true, "A+");
            Organ robertKidney = new Organ("Kidney", false, "A+");
            Robert.Organs.Add(robertKidney);
            user.Organs.Add(kidney);
            user.printInfo();
            robertKidney.isCompatible(kidney);

            Console.WriteLine($"Press <Enter> To Save {Robert.Name}");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();

            user.Organs.Remove(kidney);
            Robert.Organs.Remove(robertKidney);
            Robert.Organs.Add(kidney);
            Console.WriteLine($"You Saved {Robert.Name}");
            Robert.printInfoHealthy();
        }
    }
}
