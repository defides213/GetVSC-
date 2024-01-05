// See https://aka.ms/new-console-template for more information
using CodeAlong;
using System.Security.Cryptography.X509Certificates;

namespace CodeaAlong
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new()
            {
                new(6, "Lars", "Oslo"),
                new(5, "Sarah", "Eidsvoll"),
                new(6, "Fredrik", "Oslo"),
                new(3, "Bjørn", "Tromsø")
            };

            string options = string.Empty;
            while(options != "0")
            {
                options = mainMenu();
                switch(options)
                {
                    case "0":
                        break;

                    case "1":
                        averageGrade(students);
                        break;

                    case "2":
                        areaSearch(students);
                        break;
                }
                pause();
            }
        }
        private static void averageGrade(List<Student> students)
        {
            int average = 0; 
            foreach(Student student in students)
            {
                average += student.Grade;
            }
            average = average / students.Count;
            Console.WriteLine(average);
        }

        private static void areaSearch(List<Student> students)
        {
            string name = Console.ReadLine();
            foreach(Student student in students) 
                if (name == student.Area) 
                    Console.WriteLine($"{student.Name} is in this {student.Area}");
        }

        private static string mainMenu()
        {
            Console.WriteLine("|-  Search  -|");
            Console.WriteLine("|- 1. Average Grade");
            Console.WriteLine("|- 2. Area Search");
            Console.WriteLine("|- 0. Exit");
            Console.WriteLine("Choose");
            return Console.ReadLine();
        }
        private static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}