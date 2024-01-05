using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7
{
    abstract class Shape 
    {
        public string Name;

        public Shape(string name)
        {
            Name = name;
        }
        public abstract double GetAreal();
        public abstract double GetPerimeter();
    }
}
