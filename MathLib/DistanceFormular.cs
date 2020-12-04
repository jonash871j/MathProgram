using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class DistanceFormular : IShape
    {
        public double X1 { get; set; } = 0.0;
        public double X2 { get; set; } = 0.0;
        public double Y1 { get; set; } = 0.0;
        public double Y2 { get; set; } = 0.0;

        public Shape Shape()
        {
            return new Shape(new Line(X1, Y1, X2, Y2));
        }
    }
}
