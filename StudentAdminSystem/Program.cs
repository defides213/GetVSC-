using StudentAdminSystem;

namespace StudenAdminSystem
{
    public class Program
    {
        public static List<Student> students;

        public static void Main(string[] args)
        {
            string options = string.Empty;
            while (options != "0")
            {
                options = menu();
                switch (options)
                {
                    case "1":
                        TaskOne();
                        break;
                    case "2":
                        TaskTwo();
                        break;
                    case "3":
                        TaskThree();
                        break;
                    case "0":
                        break;
                }
                Console.WriteLine("Press <Enter> To Contine");
                while (Console.ReadKey().Key != ConsoleKey.Enter) { }
                Console.Clear();
            }
        }

        public static void TaskOne()
        {
            students = GenerateStudents();
            foreach (var student in students) student.PrintMessage();

            GenerateGrades(students);

        }

        public static void TaskTwo()
        {
            Subject[] subjectArray = {
                new(1020, "Math", 6),
                new(1021, "Geography", 6),
            };

            foreach (var subject in subjectArray) subject.PrintMessage();

            List<Student> newStudents = new()
            {
                new("Fredrik", 25, 100, subjectArray),
                new("Frank", 30, 101, subjectArray)
            };

            for (var i = 0; i < newStudents.Count; i++)
            {
                newStudents[i].PrintMessage();
                students.Add(newStudents[i]);
                Grade newGrade = new(newStudents[i], newStudents[i].StudyPrograms[i], 2);
                newGrade.PrintMessage();
            }

        }

        public static void TaskThree()
        {
            GenerateGrades(students);
            foreach (var student in students)
            {
                var averageGrade = student.AverageGrade().ToString();
                Console.WriteLine($"Average grade for {student.Name} is {averageGrade}");

                var averageCredits = student.AverageCredits().ToString();
                Console.WriteLine($"Expected credit for {student.Name} is {averageCredits}\n");
            }


        }

        public static List<Student> GenerateStudents()
        {
            var subjects = GenerateSubjects();
            List <Student> students = new()
            {
                new("Per", 23, 242, subjects),
                new("Pål", 95, 242, subjects),
                new("Askeladden", 10, 242, subjects),
            };
            return students;
        }

        public static Subject[] GenerateSubjects()
        {
            Subject english = new(10920, "English", 6);
            Subject norwegian = new(10920, "Norwegian", 4);
            Subject programming = new(10920, "Programming", 5);
            Subject[] subjects = { english, norwegian, programming };
            return subjects;
        }

        public static void GenerateGrades(List<Student> students)
        {
            foreach (Student student in students)
            {
                Grade grade = new(student, student.StudyPrograms[1], 2);
                student.Grades.Add(grade);
                grade.PrintMessage();
            }
        }
        public static string menu()
        {
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|-        Task       -|");
            Console.WriteLine("|---------------------|");
            Console.WriteLine("|- 1: Part 1");
            Console.WriteLine("|- 2: Part 2");
            Console.WriteLine("|- 3: Part 3");
            Console.WriteLine("|- 0: Exit \n");
            Console.WriteLine("|- Choose");
            string menu_input = Console.ReadLine();
            return menu_input;
        }
    }
}
    