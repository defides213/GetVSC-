using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobtheBuilder.Rooms
{
    internal class Kitchen : Room
    {
        public Kitchen() { }

        public override void print()
        {
            Console.WriteLine("Kitchen");
        }
    }
}
