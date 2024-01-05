using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7
{
    internal class Square : Shape
    {
        private double _sides;

        public Square(double sides, string name) : base(name) 
        {
            _sides = sides;
        }

        public override double GetAreal()
        {
            double Areal = _sides * 2;
            return Areal;
        }
        public override double GetPerimeter()
        {
            double Perimeter = _sides * 4;
            return Perimeter;
        }
    }
}
