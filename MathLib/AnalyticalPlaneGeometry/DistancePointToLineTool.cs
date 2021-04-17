using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;

namespace MathLib.AnalyticalPlaneGeometry
{
    public class DistancePointToLineTool : IInput, IShape, IFunction, IPoints
    {
        public double X1 { get => Contants["x"]; private set => Contants["x"] = value; }
        public double Y1 { get => Contants["y"]; private set => Contants["y"] = value; }
        public double A { get => Contants["a"]; private set => Contants["a"] = value; }
        public double B { get => Contants["b"]; private set => Contants["b"] = value; }
        public double Length { get; private set; }
        public double X2 { get; private set; }
        public double Y2 { get; private set; }

        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }

        public DistancePointToLineTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "x", 0.0 },
                { "y", 0.0 },
                { "a", 0.0 },
                { "b", 0.0 },
            };
        }

        public void Calculate()
        {
            Length = Math.Abs(A * X1 + B - Y1) / Math.Sqrt(A * A + 1);

            double c = Math.Sqrt(Math.Pow(Function(X1) - Y1, 2));
            double a = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(Length, 2));
            double angle = (A < 0 ? -1 : 1) * (Math.Acos(a / c) / (Math.PI / 180)) + (A < 0 ? 180 : 0);
            double d = A * X1 + B - Y1;

            X2 = X1 - ((d > 0 ? Length : -Length) * Math.Cos(angle * Math.PI / 180));
            Y2 = Y1 + ((d > 0 ? Length : -Length) * Math.Sin(angle * Math.PI / 180));

            Calculation?.Invoke();
        }


        public Shape Shape()
        {
            return new Shape(
                new Line(X1, Y1, X2, Y2)
            );
        }

        public string GetLengthCalculation()
        {
            return "dist(P, l)" +
                Settings.Formular(" = |ax_1+b-y_1|/\\sqrt(a^2+1)") +
                Settings.Calculation($" = |{A}*{X1}+{B}-{Y1}|/\\sqrt({A}^2+1)") +
                Settings.Equal() + GetLengthResult();
        }
        public string GetLengthResult()
        {
            return Settings.Result(Length);
        }

        public double Function(double x)
        {
            return A * x + B;
        }

        public Point2D[] Points()
        {
         
            return new Point2D[]
            {
                new Point2D(X1, Y1),
                new Point2D(X2, Y2)
            };
        }
    }
}
