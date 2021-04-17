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
                { "x1", 0.0 },
                { "y1", 0.0 },
                { "x2", 0.0 },
                { "y2", 0.0 },
            };
        }

        public void Calculate()
        {
            Length = Math.Abs(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
            MidPoint = new Point2D((X2 + X1) / 2, (Y2 + Y1) / 2, $"M#\nLægnde: {Length.ToString("N3")}", Color.Blue);
            Calculation?.Invoke();
        }

        public string GetLengthCalculation()
        {
            return "|AB|" +
                Settings.Formular(" = \\sqrt((x_2-x_1)^2+(y_2-y_1)^2)") +
                Settings.Calculation($" = \\sqrt(({ X2 }-{ X1 })^2+({ Y2 }-{ Y1 })^2)") +
                Settings.Equal() + GetLengthResult();
        }
        public string GetLengthResult()
        {
            return Settings.Result(Length);
        }
        public string GetMidPointCalculation()
        {
            return "M(x, y)" +
                Settings.Formular(" = ((x_2+x_1)/2,(y_2+y_1)/2)") +
                Settings.Calculation($"  = (({X2}+{X1})/2,({Y2}+{Y1})/2)") +
                Settings.Equal() + GetMidPointResult();
        }
        public string GetMidPointResult()
        {
            return $"({Settings.Result(MidPoint.X)} ; {Settings.Result(MidPoint.Y)})";
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(X1, Y1, "P1#"),
                new Point2D(X2, Y2, "P2#"),
                MidPoint,
            };
        }
        public Shape Shape()
        {
            return new Shape(new Line(X1, Y1, X2, Y2));
        }
    }
}
