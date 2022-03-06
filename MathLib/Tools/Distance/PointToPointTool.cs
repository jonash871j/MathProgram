using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace MathLib.Distance
{
    public class PointToPointTool : IInput, IShape, IPoints
    {
        public double X1 { get => Contants["x1"]; private set => Contants["x1"] = value; }
        public double Y1 { get => Contants["y1"]; private set => Contants["y1"] = value; }
        public double X2 { get => Contants["x2"]; private set => Contants["x2"] = value; }
        public double Y2 { get => Contants["y2"]; private set => Contants["y2"] = value; }
        public double Length { get; private set; }
        public Point2D MidPoint { get; private set; } = new Point2D();

        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }

        public PointToPointTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "x1", 5.0 },
                { "y1", 4.0 },
                { "x2", 1.0 },
                { "y2", 1.0 },
            };
        }

        public void Calculate()
        {
            Length = Math.Abs(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
            MidPoint = new Point2D((X2 + X1) / 2, (Y2 + Y1) / 2, $"M#\nLaegnde: {Length.ToString("N3")}");
            Calculation?.Invoke();
        }

        public string GetLengthCalculation()
        {
            return Settings.Calculation(
                "|AB|",
                "\\sqrt((x_2-x_1)^2+(y_2-y_1)^2)",
                $"\\sqrt(({ X2 }-{ X1 })^2+({ Y2 }-{ Y1 })^2)",
                GetLengthResult()
            );
        }
        public string GetLengthResult()
        {
            return Settings.Limit(Length);
        }
        public string GetMidPointCalculation()
        {
            return Settings.Calculation(
                "M(x, y)",
                "((x_2+x_1)/2,(y_2+y_1)/2)",
                $"(({X2}+{X1})/2,({Y2}+{Y1})/2)",
                GetMidPointResult()
            );
        }
        public string GetMidPointResult()
        {
            return $"({Settings.Limit(MidPoint.X)} ; {Settings.Limit(MidPoint.Y)})";
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(X1, Y1, "P1#", Color.Green),
                new Point2D(X2, Y2, "P2#", Color.Red),
                MidPoint,
            };
        }
        public Shape Shape()
        {
            return new Shape(new Line(X1, Y1, X2, Y2));
        }
    }
}
