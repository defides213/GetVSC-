using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobtheBuilder.Rooms
{
    internal class LivingRoom : Room
    {
        public LivingRoom() { }
        public override void print()
        {
            Console.WriteLine("Livingroom");
        }
    }
}
