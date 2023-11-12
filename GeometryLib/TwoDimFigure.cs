using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public abstract class TwoDimFigure
    {
        protected double eps = 1e-8;
        public abstract double Area();
        public abstract double Length();

    }
}
