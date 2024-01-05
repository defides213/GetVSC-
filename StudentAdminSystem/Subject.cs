using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAdminSystem
{
    public class Subject
    {
        public int Code;
        public string Name;
        public int Credits;

        public Subject(int code, string name, int credits)
        {
            Code = code;
            Name = name;
            Credits = credits;
        }
        public void PrintMessage()
        {
            Console.WriteLine($"Subject Code: {Code}");
            Console.WriteLine($"Subject Name: {Name}");
            Console.WriteLine($"Subject Grade: {Credits}\n");
        }
    }
}
