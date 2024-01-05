using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7opp2
{
    abstract class Inventory
    {
        public string Name;
        public int Amount;
        public double Price;
        public Inventory(string name, int amount, double price) { 
            Name = name;
            Amount = amount;
            Price = price;
        }
        public double CalculateSale()
        {
            double Sum = Amount * Price;
            return Sum;
        }
    }
}
