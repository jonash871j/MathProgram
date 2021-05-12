using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using MathLib.Geometry;
using MathLib.Interfaces;

namespace MathLib.Tools.Vector
{
    public class DotProductTool : IInput, IShape, IPoints
    {
        public double A1 { get => Contants["a1"]; private set => Contants["a1"] = value; }
        public double A2 { get => Contants["a2"]; private set => Contants["a2"] = value; }
        public double B1 { get => Contants["b1"]; private set => Contants["b1"] = value; }
        public double B2 { get => Contants["b2"]; private set => Contants["b2"] = value; }

        public DotProductTool()
        {
            Contants = new Dictionary<string, double>
            {
                { "a1", 1.0 },
                { "a2", 3.0 },
                { "b1", 1.0 },
                { "b2", 1.0 }
            };
        }

        public double DotProduct { get; set; }

        public Dictionary<string, double> Contants { get; set; }

        public event CalculationEventHandler Calculation;

        public void Calculate()
        {
            DotProduct = (A1 * B1) + (A2 * B2);
            Calculation?.Invoke();
        }

        public string GetDotResult()
        {
            return Settings.Result(DotProduct);
        }
        public string GetDotCalculation()
        {
            return "□(→┬a· □(→┬b ))" +
                Settings.Formular(" = (■(a_1@a_2 ))·(■(b_1@b_2 ))=a_1·b_1+a_2·b_2 ") +
                Settings.Calculation($" = ({A1}·{B1})+({A2}·{B2})") +
                Settings.Equal() + GetDotResult();
        }

        public Shape Shape()
        {
            return new Shape(new List<Line>()
            {
                new Line(0, 0, A1, A2),
                new Line(0, 0, B1, B2),
                new Line(0, 0, DotProduct, 0, Color.Red)
            });
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(A1, A2, "a#", Color.Green),
                new Point2D(B1, B2, "b#", Color.Green),
                new Point2D(DotProduct, 0, $"Længde: {DotProduct.ToString("N2")}", Color.Blue),
            };
        }
    }
}
