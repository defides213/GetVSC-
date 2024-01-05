using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrganTransplant
{
    internal class Organ
    {
        public string Name;
        public bool Healthy;
        public string Type;

        public Organ(string name, bool healthy, string type)
        {
            Name = name;
            Healthy = healthy;
            Type = type;
        }

        public bool isCompatible(Organ anotherOrgan)
        {
            if(anotherOrgan.Name == Name &&
                anotherOrgan.Healthy == true &&
                anotherOrgan.Type == Type
                ) 
            {
                Console.WriteLine($"the {anotherOrgan.Name}(s) is compatible\n"); 
                return true;
            }
            return false;
        }
    }
}
