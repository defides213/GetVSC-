namespace StudentAdminSystem
{
    internal class StudentWithList
    {
        public string Name;
        public int Age;
        public int Id;
        public List<Subject> Subjects;
        public List<Student> Students;

        public StudentWithList(string name, int age, int id) 
        {
            Name = name;
            Age = age;
            Id = id;
            Subjects = new List<Subject>();
            Students = new List<Student>();

        }
        public string subjectNames()
        {
            string names = string.Empty;
            foreach (Subject subject in Subjects)
            {
                names += subject.Name + ", ";
            }
            return names;
        }
        public string studentNames()
        {
            string names = string.Empty;
            foreach (Student student in Students)
            {
                names += student.Name + ", ";
            }
            return names;
        }
        public void printMessage()
        {
            Console.WriteLine($"Student Name:{Name}");
            Console.WriteLine($"Student Age: {Age} ");
            Console.WriteLine($"Student ID: {Id}");
            Console.WriteLine($"Student's current subjects: {subjectNames()}");
            Console.WriteLine($"Student's current subjects: {studentNames()}\n");
        }
    }
}
