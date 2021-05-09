using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using static System.Math;

namespace MathLib.Tools.Geometry
{
    public class IntersectionPointBeetweenTwoLinesTool : IInput, IShape, IPoints
    {
        private string msgDZero = "Linjerne er parallelle, D = 0";
        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }
        public double AX { get => Contants["ax"]; private set => Contants["ax"] = value; }
        public double AY { get => Contants["ay"]; private set => Contants["ay"] = value; }
        public double BX { get => Contants["bx"]; private set => Contants["bx"] = value; }
        public double BY { get => Contants["by"]; private set => Contants["by"] = value; }
        public double CX { get => Contants["cx"]; private set => Contants["cx"] = value; }
        public double CY { get => Contants["cy"]; private set => Contants["cy"] = value; }
        public double DX { get => Contants["dx"]; private set => Contants["dx"] = value; }
        public double DY { get => Contants["dy"]; private set => Contants["dy"] = value; }

        public double D { get; private set; }
        public double PX { get; private set; } = 0;
        public double PY { get; private set; } = 0;

        public Function Properties { get; private set; }

        public IntersectionPointBeetweenTwoLinesTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "ax", 0.0 },
                { "ay", 0.0 },
                { "bx", 0.0 },
                { "by", 0.0 },
                { "cx", 0.0 },
                { "cy", 0.0 },
                { "dx", 0.0 },
                { "dy", 0.0 },
            };
        }

        public void Calculate()
        {
            D = (AX - BX) * (CY - DY) - (AY - BY) * (CX - DX);
            PX = (((AX * BY) - (AY * BX)) * (CX - DX) - (AX - BX) * ((CX * DY) - (CY * DX))) / D;
            PY = (((AX * BY) - (AY * BX)) * (CY - DY) - (AY - BY) * ((CX * DY) - (CY * DX))) / D;

            //if (D == 0)
            //{
            //    PX = double.NaN;
            //    PY = double.NaN;
            //}

            //double x1Min = Min(AX, BX);
            //double x1Max = Max(AX, BX);
            //double x2Min = Min(CX, DX);
            //double x2Max = Max(CX, DX);

            //if (PX < x1Min || PX > x1Max || PX < x2Min || PX > x2Max)
            //{
            //    PX = double.NaN;
            //    PY = double.NaN;
            //}

            //double y1Min = Min(AY, BY);
            //double y1Max = Max(AY, BY);
            //double y2Min = Min(CY, DY);
            //double y2Max = Max(CY, DY);

            //if (PY < y1Min || PY > y1Max || PY < y2Min || PY > y2Max)
            //{
            //    PX = double.NaN;
            //    PY = double.NaN;
            //}

            //if ((PX >= 0 && PX <= 1) && (PY >= 0 && PY >= 1))
            //{
            //    PX = 0;
            //    PY = 0;
            //}

            Calculation?.Invoke();
        }

        public string GetDCalculation()
        {
            return "";
        }
        public string GetDResult()
        {
            return $"{Settings.Result(D)}";
        }
        public string GetIntersectionPointCalculation()
        {
            if (D == 0)
            {
                return msgDZero;
            }
            else
            {
                return "";
            }
        }
        public string GetIntersectionPointResult()
        {
            if (D == 0)
            {
                return msgDZero;
            }
            else
            {
                return $"({Settings.Result(PX)} ; {Settings.Result(PY)})";
            }
        }

        public Shape Shape()
        {
            return new Shape(new List<Line>()
            {
                new Line(AX, AY, BX, BY),
                new Line(CX, CY, DX, DY),

            });
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(AX, AY, "a#", Color.Green),
                new Point2D(BX, BY, "b#", Color.Green),
                new Point2D(CX, CY, "c#", Color.Green),
                new Point2D(DX, DY, "d#", Color.Green),
                new Point2D(PX, PY, "#\nkrydspunkt", Color.Blue),
            };
        }   
    }
}
