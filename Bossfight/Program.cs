// See https://aka.ms/new-console-template for more information
namespace Bossfight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            GameCharacter userfighter = new(200, 200, 20, 100);
            GameCharacter bossFighter = new(400, 400, 0, 200);

            string options = string.Empty;
            string fightoptions = string.Empty;
            while (options != "2")
            {
                options = MainMenu();
                switch(options)
                {
                    case "1":
                        while(fightoptions != "0")
                        {
                            fightoptions = fightMenu(userfighter);
                            switch (fightoptions)
                            {
                                case "0":
                                    break;

                                case "1":
                                    userfighter.fight(bossFighter);
                                    break;

                                case "2":
                                    userfighter.recharge();
                                    break;
                            }
                            pause();
                        }
                        break;

                    case "2":
                        break;
                }
                pause();
            }
        }

        public static string MainMenu()
        {
            Console.WriteLine("|-- Boss Fight --|");
            Console.WriteLine("|- 1. Fight");
            Console.WriteLine("|- 2. Leave");
            Console.WriteLine("Choose");
            return Console.ReadLine();
        }

        public static string fightMenu(GameCharacter data)
        {
            Console.Clear();
            Console.WriteLine("|- 1. Attack");
            Console.WriteLine("|- 2. Recharge");
            Console.WriteLine("|- 0. Leave the Battle");
            Console.WriteLine("Current Stats:");
            Console.WriteLine($"{data.Health} // {data.MaxHealth}");
            Console.WriteLine($"{data.Stamina}");
            Console.WriteLine("Choose");
            return Console.ReadLine();
        }

        public static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}
