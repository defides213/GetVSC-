using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7
{
    internal class Rectangle : Shape
    {
        private double _length;
        private double _height;

        public Rectangle(double length, double height, string name) : base(name)
        {
            _length = length;
            _height = height;
        }

        public override double GetAreal()
        {
            double Areal = _length * _height;
            return Areal;
        }
        public override double GetPerimeter() {
            double Perimeter = _length * 2 + _height * 2;
            return Perimeter;
        }
    }
}
