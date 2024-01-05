namespace StudentAdminSystem
{
    public class Grade
    {
        public Student Student;
        public Subject Subject;
        public int GradeNum;
        public Grade(Student student, Subject subject, int grade) 
        {
            Student = student;
            Subject = subject;
            GradeNum = grade;
        }
        public void PrintMessage()
        {
            Console.WriteLine(
                $"Name of student is {Student.Name}\n" +
                $"Subject name is {Subject.Name}\n" +
                $"The final grade is {GradeNum}\n"
                );
        }
    }
}
