using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Geometry
{
    public class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }

        public PointD(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
}
