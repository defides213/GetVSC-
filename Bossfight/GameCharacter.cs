using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight
{
    public class GameCharacter
    {
        public int Health;
        public int MaxHealth;
        public int Strength;
        public int Stamina;
        public GameCharacter(int health, int maxHP, int strength, int stamina) 
        {
            Health = health;
            MaxHealth = maxHP;
            Strength = strength;
            Stamina = stamina;
        }

        public void recharge()
        {
            Console.Clear();
            if (Stamina == 100 || Health >= 186)
            {
                Console.WriteLine("Can't recharge now");
                return;
            }
            else
            {
                Console.WriteLine("You recharge 5 Stamina and 10 health");
                Stamina += 5;
                Health += 15;
            }
        }

        public void fight(GameCharacter boss)
        {
            Console.Clear();
            Console.WriteLine("User punches the boss");
            boss.Health -= Strength;
            Stamina -= 10;
            Console.WriteLine($"The Boss took {Strength} points of DMG");
            Console.WriteLine($"Boss now has {boss.Health} // {boss.MaxHealth}HP");
            if (boss.Stamina >= 20 && boss.Stamina <= 40)
            {
                Console.WriteLine("Boss Rests to build Stamina");
                boss.Strength = 1;
                boss.Health += 5;
                boss.Stamina += 60;
            }
            if (boss.Strength == 0)
            {
                Random random = new Random();
                int bossDMG = random.Next(0, 30);
                boss.Strength = bossDMG;
                boss.Stamina -= 20;
                Console.WriteLine($"The Boss Punches back. doing {boss.Strength} DMG to the User");
                Health -= boss.Strength;
            }
            boss.Strength = 0;

        }
    }
}
