// See https://aka.ms/new-console-template for more information
namespace GetVSC.task1test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a number here:");
            string input = Console.ReadLine();
            int money1 = int.Parse(input);
            Console.WriteLine("Write another number here:");
            input = Console.ReadLine();
            int money2 = int.Parse(input);
            Console.WriteLine($"your sum is {moneySum(money1, money2)}");
            empty();
        }
        public static int moneySum(int number1, int number2)
        {
            return number1 + number2;
        }
        public static void empty()
        {
            Console.WriteLine("This does nothing :)");
        }
    }
}

