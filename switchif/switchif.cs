// See https://aka.ms/new-console-template for more information

using switchif.Folder;

namespace GetVSC.SwitchIf
{
    public class SwitchIf
    {
        public static void Main(string[] args)
        {
            
            Ifs newIfs = new Ifs();

            string input = "1";

            while (input != "0")
            {
                input = menu();
                switch (input)
                {
                    default:
                        Console.WriteLine("");
                        break;

                    case "1":
                        newIfs.returnTrue();
                        break;

                    case "2":
                        newIfs.differentOrSame();
                        break;

                    case "3":
                        newIfs.equalToTrue();
                        break;
                }
                Console.WriteLine("Press <Enter> to continue");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public static string menu()
        {
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|-  Switches and Ifselse  -|");
            Console.WriteLine("|--------------------------|");
            Console.WriteLine("|-1. Return True Task ");
            Console.WriteLine("|-2. Different or same Task ");
            Console.WriteLine("|-3. 30 = true Task ");
            Console.WriteLine("|-0. Exit \n");
            Console.WriteLine("- Choose");
            string menu_input = Console.ReadLine();
            return menu_input;
        }
    }
}