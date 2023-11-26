// See https://aka.ms/new-console-template for more information
using StudentAdminSystem;

namespace StudenAdminSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subject english = new Subject(10920, "English", 6);
            Subject norwegian = new Subject(10920, "Norwegian", 4);
            Subject programming = new Subject(10920, "Programming", 5);
            Subject[] subjects = {english, norwegian, programming};
            Student student = new Student("test", 23, 242, subjects);
            student.printMessage();

            Grade grade = new Grade(student, student.StudyPrograms[1], 2);
            grade.printMessage();
        }
    }
}
    