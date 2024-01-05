namespace ParProgrameringMedSimonUke5
{
    internal class Program
    {
        public static List<Task> tasks = new List<Task>
        {
            new Task("Rydd rommet mitt", "Jeg må rydde rommet mitt for klær og rot, før søndag"),
            new Task("Ta ut søppla", "jeg har nødt å ta ut matsøppla og restavfall før søppelbilen kommer"),
        };

        static void Main(string[] args)
        {
            Console.CursorLeft = 45;
            Console.CursorTop = 13;
            Ask("Velkommen Til Todo App");
            Console.Clear();
            while (true)
            {
                switch (Ask("Vil du:\n1. Legge til oppgave\n2. slette en oppgave\n3. se en oppgave"))
                {
                    case "1":
                        AddTast();
                        break;
                    case "2":
                        RemoveTask();
                        break;
                    case "3":
                        for (int i = 0; i < tasks.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {tasks[i].Name}");
                        }
                        tasks[AskInt("Hvilken oppgave vil du se?") - 1].PrintTaskInfo();
                        break;
                    default:
                        break;
                }
                pause();
            }
        }

        private static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }

        private static void AddTast()
        {
            tasks.Add(new Task(Ask("Hva heter oppgaven?"), Ask("Hva handle oppgaven om?")));
        }

        private static void RemoveTask()
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i].Name}");
            }
            tasks.RemoveAt(AskInt("Hvilken oppgave vil du slette?") - 1);
        }

        private static string Ask(string s)
        {
            Console.WriteLine(s);
            return Console.ReadLine();
        }
        private static int AskInt(string s)
        {
            return Convert.ToInt32(Ask(s));
        }
    }
}

/*
Konsollbasert ToDo liste
Lag en todo app! Du skal kunne legge til oppgaver, slette dem og gå inn på en task for å se beskrivelse eller flere detaljer
 */
