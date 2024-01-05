 namespace StudentAdminSystem
{
    public class Student
    {
        public string Name;
        public int Age;
        public int Id;
        public Subject[] StudyPrograms;
        public List<Grade> Grades;

        public Student(string name, int age, int id, Subject[] studyProgram) 
        {
            Name = name; 
            Age = age; 
            Id = id; 
            StudyPrograms = studyProgram;
            Grades = new();
        }

        public string SubjectNames()
        {
            string names = string.Empty;
            foreach (Subject subject in StudyPrograms)
            {
                names += subject.Name + ", ";
            }
            return names;
        }

        public int AverageGrade()
        {
            int total = 0;
            int count = 0;
            foreach(var grade in Grades)
            {
                total += grade.GradeNum;
                count++;
            }

            var average = (decimal)(total / count);
            return Convert.ToInt32(Math.Round(average));
        }

        public int AverageCredits()
        {
            int total = 0;
            int count = 0;
            foreach (var subject in StudyPrograms) 
            { 
                total += subject.Credits;
                count++;
            }
            var average = (decimal)(total / count);
            return Convert.ToInt32(Math.Round(average));
        }
        
        public void PrintMessage()
        {
            Console.WriteLine($"Student Name:{Name}");
            Console.WriteLine($"Student Age: {Age} ");
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student's current subjects: {SubjectNames()}\n");
        }
    }
}
