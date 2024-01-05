// See https://aka.ms/new-console-template for more information
using Codealong2024;

namespace codeAlong2024
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car car = new(10, 0);
            car.Driving();

            
            Console.WriteLine("Car is now Parked");
        }
    }
}
