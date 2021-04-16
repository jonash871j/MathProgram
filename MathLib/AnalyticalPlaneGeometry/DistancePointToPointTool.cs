using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.AnalyticalPlaneGeometry
{
    public class DistancePointToPointTool : IInput, IShape, IPoints
    {
        public double X1 { get => Contants["x1"]; private set => Contants["x1"] = value; }
        public double X2 { get => Contants["x2"]; private set => Contants["x2"] = value; }
        public double Y1 { get => Contants["y1"]; private set => Contants["y1"] = value; }
        public double Y2 { get => Contants["y2"]; private set => Contants["y2"] = value; }
        public double Length { get; private set; }

        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }

        public DistancePointToPointTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "x1", 0.0 },
                { "x2", 0.0 },
                { "y1", 0.0 },
                { "y2", 0.0 },
            };
        }

        public void Calculate()
        {
            Length = Math.Abs(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
            Calculation?.Invoke();
        }

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
    }
}
