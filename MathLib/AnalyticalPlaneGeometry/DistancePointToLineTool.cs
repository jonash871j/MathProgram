using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;

namespace MathLib.AnalyticalPlaneGeometry
{
    public class DistancePointToLineTool : IInput, IShape, IFunction, IPoints
    {
        public double X { get => Contants["x"]; private set => Contants["x"] = value; }
        public double Y { get => Contants["y"]; private set => Contants["y"] = value; }
        public double A { get => Contants["a"]; private set => Contants["a"] = value; }
        public double B { get => Contants["b"]; private set => Contants["b"] = value; }
        public double Length { get; private set; }

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
            Length = Math.Abs(A * X + B - Y) / Math.Sqrt(A * A + 1);
            Calculation?.Invoke();
        }


        public Shape Shape()
        {
            double x2 = X;
            double y2 = Function(X);


            return new Shape(
                new Line(X, Y, X + Length, Y)
            );
        }

        public string GetLengthCalculation()
        {
            return "dist(P, l)" +
                Settings.Formular(" = |ax_1+b-y_1|/\\sqrt(a^2+1)") +
                Settings.Calculation($" = |{A}*{X}+{B}-{Y}|/\\sqrt({A}^2+1)") +
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
                new Point2D(X, Y)
            };
        }
    }
}
