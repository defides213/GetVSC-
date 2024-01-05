using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrameringuke3
{
    public class Hobbies
    {
        public string Name;
        public string Description;

        public Hobbies(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void printInfo()
        {
            Console.WriteLine($"Vi har til felles {Name}");
            Console.WriteLine($"Det innebærer {Description}");
        }
    }
}
