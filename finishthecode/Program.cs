// See https://aka.ms/new-console-template for more information

namespace GetVSC.finishthecode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int range = 250;
            var counts = new int[range];
            int letterCount = 0;
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("Write a string");
                text = Console.ReadLine() ?? string.Empty;
                foreach (char character in text.ToUpper())
                {
                    letterCount++;
                    counts[(int)character]++;
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0)
                    {
                        char character = (char)i;
                        var percentageNumber = 100 * (double)counts[i] / letterCount;
                        string output = character + " - " + percentageNumber.ToString("f1") + "%" + " - " + counts[i];
                        Console.WriteLine(output);
                    }
                }
            }
        }
    }
}
