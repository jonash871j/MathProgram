using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Geometry
{
    public class Line
    {
        public PointD A { get; set; }
        public PointD B { get; set; }

        public Line(PointD a, PointD b)
        {
            A = a;
            B = b;
        }
        public Line(double x1, double y1, double x2, double y2)
        {
            A = new PointD(x1, y1);
            B = new PointD(x2, y2);
        }
    }
}
