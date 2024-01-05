using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codealong2024
{
    internal class Car
    {
        public int Speed;
        public int Meter;
        public Car(int speed, int meter) 
        {
            Speed = speed;
            Meter = meter;
        }

        public void Driving()
        {
            int meter = 0; 
            int speed = 10;
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Meter {meter}");
                Console.WriteLine($"hastighet {speed}");
                if (meter >= 500) { speed -= 10; }
                else { speed += 10; }
                meter += speed;
            }
        }
    }
}
