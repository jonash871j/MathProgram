using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Geometry
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point2D(double x = 0.0, double y = 0.0)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"({X.ToString("N2")}; {Y.ToString("N2")})";
        }
    }
}
