using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parprogrammeringuke7
{
    internal class Circle : Shape
    {
        private double _radius;

        public Circle(double radius, string name) : base(name)
        {
            _radius = radius;
        }


        public override double GetAreal()
        {
            double Areal = _radius * _radius * Math.PI;
            return Areal;
        }
        public override double GetPerimeter()
        {
            double Perimeter = _radius * 2 * Math.PI;
            return Perimeter;
        }
    }
}
