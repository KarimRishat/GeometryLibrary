using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Circle : TwoDimFigure
    {
        private double _radius { get; }
        public double GetRadius() => _radius;
        public Circle() { _radius = 0; }
        public Circle(double radius)
        {
            if (radius > 0)
                _radius = radius;
            else Console.WriteLine("Negative radius");
        }
        public override double Area()
        {
            return _radius * _radius * Math.PI;
        }

        public override double Length()
        {
            return 2 * _radius * Math.PI;
        }
    }
}
