using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7opp2
{
    internal class Clothingitem : Inventory
    {
        private string _size;
        public string Color;
        public Clothingitem(string name, int amount, double price, string size, string color) : base(name, amount, price)
        {
            _size = size;
            Color = color;
        }
    }
}
