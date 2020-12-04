using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class DistanceFormular : IShape, IPoints
    {
        public double X1 { get; set; } = 0.0;
        public double X2 { get; set; } = 0.0;
        public double Y1 { get; set; } = 0.0;
        public double Y2 { get; set; } = 0.0;

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(X1, Y1),
                new Point2D(X2, Y2),
            };
        }

        public Shape Shape()
        {
            return new Shape(new Line(X1, Y1, X2, Y2));
        }
    }
}
