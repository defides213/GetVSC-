using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobtheBuilder.Rooms
{
    internal class Bathroom : Room
    {
        public Bathroom() { }
        public override void print()
        {
            Console.WriteLine("Bathroom");
        }
    }
}
