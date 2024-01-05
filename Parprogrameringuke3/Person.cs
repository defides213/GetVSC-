using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrameringuke3
{
    internal class Person
    {
        public string Name;
        public string HairColor;
        public int Age;
        public List<Hobbies> Hobbies;


        public Person(string name, string hairColor, int age)
        {
            Name = name;
            HairColor = hairColor;
            Age = age;
            Hobbies = new List<Hobbies>();
        }

        public void PrintInfo()
        {
            Console.WriteLine($"My name is {Name}");
            Console.WriteLine($"I have {HairColor} Hair Color");
            Console.WriteLine($"And i am {Age} years old");
        }

        public void PrintHobbiesInfo()
        {
            Console.WriteLine($"{Name}'s hobby is {hobbyName()}");
            Console.WriteLine($"That entails {hobbyDesc()}\n");
        }

        public string hobbyName()
        {
            string hobbiesN = string.Empty;
            foreach (Hobbies hobb in Hobbies)
            {
                hobbiesN += hobb.Name;
            }
            return hobbiesN;
        }
        public string hobbyDesc()
        {
            string hobbiesN = string.Empty;
            foreach (Hobbies hobb in Hobbies)
            {
                hobbiesN += hobb.Description;
            }
            return hobbiesN;
        }
    }
}
