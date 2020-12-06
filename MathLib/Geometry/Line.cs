using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Geometry
{
    public class Line
    {
        public Point2D A { get; set; }
        public Point2D B { get; set; }

        public Line(Point2D a, Point2D b)
        {
            A = a;
            B = b;
        }
        public Line(double x1, double y1, double x2, double y2)
        {
            A = new Point2D(x1, y1);
            B = new Point2D(x2, y2);
        }
    }
}
