using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7opp2
{
    internal class Electronics : Inventory
    {
        public string Insurance;
        public Electronics(string name, int amount, double price, string insurance) : base(name, amount, price) 
        {
            Insurance = insurance;
        }
    }
}
