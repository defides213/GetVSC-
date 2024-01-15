using BobtheBuilder.Rooms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobtheBuilder
{
    public class Floor
    {
        private List<Room> Rooms;
        public bool BathroomAdded = false;
        public bool KitchenAdded = false;
        public Floor() { Rooms = new List<Room>(); }

        public void AddRoom(Room room) 
        { 
            if(Rooms.Count >= 5) { Console.WriteLine("you Have max amount of rooms available"); return; }
            if (room is Bathroom && BathroomAdded) { Console.WriteLine("You already have one"); return;}
            if (room is Kitchen && KitchenAdded) { Console.WriteLine("You already have one"); return;}
            Rooms.Add(room);
            if(room is Bathroom) { BathroomAdded = true; }
            if (room is Kitchen) {  KitchenAdded = true; }
        }

        public void printRooms()
        {
            foreach (var item in Rooms)
            {
                item.print();
            }
        }

        public int RoomCount()
        {
            return Rooms.Count;
        }
    }
}
