namespace Debugging
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var range = 250;
            var counts = new int[range];
            string text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                foreach (var character in text ?? string.Empty)
                {
                    counts[(int)character]++; // 104, 101(e), 105(i), 32( ), 112(p), 229(å), 100(d), 103(g)
                }
                for (var i = 0; i < range; i++)
                {
                    if (counts[i] > 0) // 249
                    {
                        var character = (char)i;
                        Console.WriteLine(character + " - " + counts[i]);
                    }
                }
            }
        }
    }
}
