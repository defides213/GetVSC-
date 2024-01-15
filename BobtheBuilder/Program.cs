// See https://aka.ms/new-console-template for more information
using BobtheBuilder.Rooms;

namespace BobtheBuilder
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            House house = new House();
            Console.WriteLine("how many floors do you want?");
            int floor = int.Parse(Console.ReadLine());
            for(int i = 0; i < floor; i++)
            {
                house.Floors.Add(new Floor());
            }
            
            Flooradding(house.Floors);
            pause();
            Result(house.Floors);
            pause();
        }

        public static void Result(List<Floor> floors)
        {
            int number = 1;
            foreach(Floor floor in floors)
            {
                Console.WriteLine($"Floor {number}");
                floor.printRooms();
                Console.WriteLine("\n");
                number++;
            }
        }

        public static void AddFloors(Floor data)
        {
            while(data.RoomCount() != 5)
            {
                Console.Clear();
                Console.WriteLine($"|- Room Count: {data.RoomCount()}  -|");
                Console.WriteLine("|- Menu ");
                Console.WriteLine("|- What do you want to add? ");
                Console.WriteLine("| 1. Bathroom");
                Console.WriteLine("| 2. Livingroom");
                Console.WriteLine("| 3. Kitchen");
                Console.WriteLine("| 4. Bedroom");
                Console.WriteLine("| 0. Exit");
                string option = Console.ReadLine();
                if (option == "1") { data.AddRoom(new Bathroom()); }
                else if (option == "2") { data.AddRoom(new LivingRoom()); }
                else if (option == "3") { data.AddRoom(new Kitchen()); }
                else if (option == "4") { data.AddRoom(new Bedroom()); }
                pause();
            }
        }

        public static void Flooradding(List<Floor> floors)
        {
            int number = 1;
            foreach(Floor floor in floors)
            {
                Console.WriteLine($"You are working on floor {number}");
                pause();
                AddFloors(floor);
                number++;
            }
        }
        public static void pause()
        {
            Console.WriteLine($"Press <Enter> To Continue");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
            Console.Clear();
        }
    }
}


