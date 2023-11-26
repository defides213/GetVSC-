// See https://aka.ms/new-console-template for more information
namespace GetVSC.Parprogramering
{
    public class ParTask
    {
        public static void Main(string[] args)
        {
            string theText = readString("Write a string");
            string options = String.Empty;
            while(options != "0")
            {
                options = mainMenu();
                switch (options)
                {
                    case "1":
                        string finishedReverse = reverseing(theText);
                        Console.WriteLine($"|- The reverse here {finishedReverse}");
                        break;

                    case "2":
                        Console.WriteLine("Uppercase String: " + theText.ToUpper());
                        break;

                    case "3":
                        Console.WriteLine("Lowercase String: " + theText.ToLower());
                        break;

                    case "4":
                        coloring(theText);
                        break;

                    case "5":
                        errorCase();
                        break;

                    case "6":
                        upperCaseStianVersjon(theText);
                        break;

                    case "7":
                        lowerCaseStianVersjon(theText);
                        break;
                }
                Console.WriteLine("Press <Enter> To Contine");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }
        public static void coloring(string argText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"|- {argText}");
            Console.ResetColor();
        }
        public static string readString(string consoleQuestion)
        {
            Console.WriteLine(consoleQuestion);
            return Console.ReadLine();
        }
        public static string reverseing(string argText)
        {
            
            char[] reverseArray = argText.ToCharArray();
            string finishedReverse = String.Empty;
            for(int i = reverseArray.Length - 1; i > -1; i--)
            {
                finishedReverse += reverseArray[i];
            }
            Console.WriteLine($"|- The written here {argText}");
            return finishedReverse;
        }

        /// <summary>
        /// Converts a string of characters to upper case, using ASCII values
        /// </summary>
        /// <param name="text">The text you want to convert to uppercase</param>
        private static void upperCaseStianVersjon(string text)
        {
            string newString = string.Empty;
            foreach(char c in text)
            {
                if (c >= 97)
                {
                    newString += (char)c - ('a' - 'A');
                    //97(a) - 65(A) = 32
                    //hvis c = s, så er s basically 115
                    //og 115 - 32 = 83, som er S
                    //det er alltid 32 tegn mellom en stor og en liten bokstav.
                    //ascii verdien til 'M' + 32 = 'm'
                    //ascii verdien til 'm' - 32 = 'M'
                }
                else newString += c;
            }
        }

        /// <summary>
        /// Converts a string of characters to lower case, using ASCII values
        /// </summary>
        /// <param name="text">The text you want to convert to lowercase</param>
        private static void lowerCaseStianVersjon(string text)
        {
            string newString = string.Empty;
            foreach (char c in text)
            {
                if (c < 97) newString += (char)c + ('a' - 'A');
                else newString += c;
            }
        }

        public static void errorCase()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ERROR!\n");
            Console.WriteLine("You don't have access to these files");
            Console.ResetColor();
            Environment.Exit(0);
        }
        public static string mainMenu()
        {
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|-        Task       -|");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|- 1: Reverse");
            Console.WriteLine("|- 2: Uppercase");
            Console.WriteLine("|- 3: Lowercase");
            Console.WriteLine("|- 4: Color the string");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("|- 5: Classified");
            Console.ResetColor();
            Console.WriteLine("|- 6: Upper Stian Method");
            Console.WriteLine("|- 7: Lower Stian Method");
            Console.WriteLine("|- 0: Exit \n");
            Console.WriteLine("|- Choose");
            string menu_input = Console.ReadLine();
            return menu_input;
        }
    }
}
