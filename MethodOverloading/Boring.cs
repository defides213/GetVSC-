using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Boring
    {
        public void PrintMessage()
        {
            Console.WriteLine("morning");
        }
        public void PrintMessage(string name = "Akali")
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
