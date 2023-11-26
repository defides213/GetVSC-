using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    internal class Student
    {
        public string Name;
        public int Age;
        public int Id;
        public Subject[] StudyPrograms;

        public Student(string name, int age, int id, Subject[] studyProgram) 
        {
            Name = name; 
            Age = age; 
            Id = id; 
            StudyPrograms = studyProgram;
        }

        public string subjectNames()
        {
            string names = string.Empty;
            foreach (Subject subject in StudyPrograms)
            {
                names += subject.Name + ", ";
            }
            return names;
        }
        public void printMessage()
        {
            Console.WriteLine($"Student Name:{Name}");
            Console.WriteLine($"Student Age: {Age} ");
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student's current subjects: {subjectNames()}");
        }
    }
}
