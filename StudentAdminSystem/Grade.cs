using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    internal class Grade
    {
        public Student Student;
        public Subject Subject;
        int GradeNum;
        public Grade(Student student, Subject subject, int grade) 
        {
            Student = student;
            Subject = subject;
            GradeNum = grade;
        }
        public void printMessage()
        {
            Console.WriteLine(
                $"Name of student is {Student.Name}\n" +
                $"Subject name is {Subject.Name}\n" +
                $"The final grade is {GradeNum}\n"
                );
        }
    }
}
