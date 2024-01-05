using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Human
    {
        public string Name;
        public List<Organ> Organs;
        
        public Human(string name) 
        {
            Name = name;
            Organs = new List<Organ>();
        }
        public void printInfo()
        {
            Console.WriteLine($"The Humans name is {Name}");
            Console.WriteLine($"{Name} is currently in possesion of 2 {organInfo()}(s)\n");
        }
        public void printInfoHealthy()
        {
            Console.WriteLine($"{Name} now has Healthy({organInfoHealthy()})\n");
        }
        public string organInfo()
        {
            string organs = string.Empty;
            foreach (Organ org in Organs)
            {
                organs += org.Name;
            }
            return organs;
        }
        public string organInfoHealthy()
        {
            string organs = string.Empty;
            foreach (Organ org in Organs)
            {
                organs += org.Healthy;
            }
            return organs;
        }
    }
}
