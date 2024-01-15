using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobtheBuilder.Rooms
{
    public abstract class Room
    {
        public Room() {  }

        public virtual void print()
        {
            Console.WriteLine("I am a room");
        }
    }
}
