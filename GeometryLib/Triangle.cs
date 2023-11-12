using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryLib
{
    public class Triangle : TwoDimFigure
    {
        public readonly double[]? Sides;    
        private bool CheckPositivity(ref double[] sides)    
        {
            bool flag = true;
            for (int i = 0; i < sides.Length && flag; ++i)
            {
                flag &= (sides[i] > 0);
            }
            return flag;
        }
        private bool CheckTriangle(ref double[] sides)
        {
            bool flag = true;
            flag &= (sides.Length == 3);
            if (flag)
            {
                Array.Sort(sides);  //sort our sides, so last side is largest
                flag &= CheckPositivity(ref sides);
                if (flag)
                {
                    flag &= sides[2] < sides[0] + sides[1];
                    if (!flag) Console.WriteLine("Provided sides do not form a triangle");
                }
                else Console.WriteLine("Provided side length is not a positive double");
            }
            return flag;
        }

        public Triangle(double[] values)
        {
            if (CheckTriangle(ref values))
            {
                Sides = values;
            }
            else Sides = null;
        }


        public Triangle(double a, double b, double c)
        {
            double[] values = new double[3] { a, b, c };
            if (CheckTriangle(ref values))
            {
                Sides = values;
            }
            else Console.WriteLine("Сan't make a triangle");
        }


        public override double Area()
        {
            double area = 0;
            if(Sides != null)
            {
                if (IsRight())
                {
                    area = Sides[0] * Sides[1] * 0.5;
                }
                else
                {
                    double halfPerimeter = Length() * 0.5;
                    area = Math.Sqrt(halfPerimeter *
                        (halfPerimeter - Sides[0]) * (halfPerimeter - Sides[1]) * (halfPerimeter - Sides[2]));
                }
            }
            return area;
        }

        public override double Length()
        {
            return Sides == null ? 0 : Sides[0] + Sides[1] + Sides[2];
        }

        public bool IsRight()
        {
            return Sides != null ? Math.Abs
                (Sides[0] * Sides[0] + Sides[1] + Sides[1] - Sides[2] * Sides[2]) <= eps : false;
        }

    }
}
