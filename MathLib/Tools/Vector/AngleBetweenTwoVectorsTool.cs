using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Math;

namespace MathLib.Tools.Vector
{
    public class AngleBetweenTwoVectorsTool : IInput, IShape, IPoints
    {
        public event CalculationEventHandler Calculation;
        
        public Dictionary<string, double> Contants { get; set; }
        public double AX { get => Contants["ax"]; private set => Contants["ax"] = value; }
        public double AY { get => Contants["ay"]; private set => Contants["ay"] = value; }
        public double BX { get => Contants["bx"]; private set => Contants["bx"] = value; }
        public double BY { get => Contants["by"]; private set => Contants["by"] = value; }

        public double Angle { get; private set; }

        public AngleBetweenTwoVectorsTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "ax", 1.0 },
                { "ay", 4.0 },
                { "bx", 5.0 },
                { "by", 1.0 },
            };
        }

        public void Calculate()
        {
            Angle = Acos(((AX * BX) + (AY * BY)) / (Sqrt(Pow(AX, 2) + Pow(AY, 2)) * Sqrt(Pow(BX, 2) + Pow(BY, 2)))) * 180.0 / PI;
            Calculation?.Invoke();
        }

        public string GetAngleCalculation()
        {
            return "v" +
                Settings.Formular(" = acos⁡((→┬a·→┬b)/(|→┬a |·|→┬b | ))") +
                Settings.CalculationInner($" = acos⁡(((■({AX}@{AY}))·(■({BX}@{BY})))/(|■({AX}@{AY})|·|■({BX}@{BY})| )) = (({AX}·{BX})+({AY}·{BY}))/(√(({AX})^2+({AY})^2)·√(({BX})^2+({BY})^2))") +
                Settings.Equal() + GetAngleResult() + "°";
        }
        public string GetAngleResult()
        {
            return Settings.Limit(Angle);
        }

        public Shape Shape()
        {
            return new Shape(new List<Line>()
            {
                new Line(0, 0, AX, AY),
                new Line(0, 0, BX, BY),
            });
        }

        public Point2D[] Points()
        {
            return new Point2D[]
          {
                new Point2D(0, 0, $"{Angle.ToString("N2")}°", Color.Red),
                new Point2D(AX, AY, "a#", Color.Green),
                new Point2D(BX, BY, "b#", Color.Green),
          };
        }
    }
}
