using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Math;

namespace MathLib.Tools.Vector
{
    public class ProjectionOfVectorOnVectorTool : IInput, IShape, IPoints
    {
        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }
        public double AX { get => Contants["ax"]; private set => Contants["ax"] = value; }
        public double AY { get => Contants["ay"]; private set => Contants["ay"] = value; }
        public double BX { get => Contants["bx"]; private set => Contants["bx"] = value; }
        public double BY { get => Contants["by"]; private set => Contants["by"] = value; }

        public double PX { get; private set; }
        public double PY { get; private set; }
        public double R { get; private set; }
        public double PPX { get; private set; }
        public double PPY { get; private set; }

        public ProjectionOfVectorOnVectorTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "ax", 0.0 },
                { "ay", 0.0 },
                { "bx", 0.0 },
                { "by", 0.0 },
            };
        }

        public void Calculate()
        {
            R = ((AX * BX) + (AY * BY)) / Pow(Sqrt(Pow(BX, 2) + Pow(BY, 2)), 2);
            PX = R * BX;
            PY = R * BY;

            Calculation?.Invoke();
        }

        public string GetProjectionVectorCalculation()
        {
            return "〖□(→┬a )〗_□(→┬b )" +
                Settings.Formular(" = (□(→┬a )·□(→┬b ))/|□(→┬b )|^2 ·→┬b") +
                Settings.Calculation($" = ((■({AX}@{AY}))·(■({BX}@{BY})))/|(■({BX}@{BY}))|^2 ·(■({BX}@{BY}))" +
                $"=(({AX}·{BX})+({AY}·{BY}))/(√(({BX})^2+({BY})^2 ))^2 ·(■({BX}@{BY}))" +
                $"={Settings.Result(R)}·(■({BX}@{BY}))") +
                Settings.Equal() + GetProjectionVectorWMResult();
        }
        public string GetProjectionVectorWMResult()
        {
            return $"(■({Settings.Result(PX)}@{Settings.Result(PY)}))";
        }
        public string GetProjectionVectorResult()
        {
            return $"({Settings.Result(PX)} ; {Settings.Result(PY)})";
        }

        public Shape Shape()
        {
            return new Shape(new List<Line>()
            {
                new Line(0, 0, AX, AY),
                new Line(0, 0, BX, BY),
                new Line(0, 0, PX, PY, Color.Red),
                new Line(PX, PY, AX, AY, Color.White, true),
 
            });
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(AX, AY, "a#", Color.Green),
                new Point2D(BX, BY, "b#", Color.Green),
                new Point2D(PX, PY, "#\nprojektion vektor", Color.Blue),
            };
        }
    }
}
