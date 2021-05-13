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
        public double X1 { get => Contants["x1"]; private set => Contants["x1"] = value; }
        public double Y1 { get => Contants["y1"]; private set => Contants["y1"] = value; }
        public double X2 { get => Contants["x2"]; private set => Contants["x2"] = value; }
        public double Y2 { get => Contants["y2"]; private set => Contants["y2"] = value; }
        public double X3 { get => Contants["x3"]; private set => Contants["x3"] = value; }
        public double Y3 { get => Contants["y3"]; private set => Contants["y3"] = value; }
        public double X4 { get => Contants["x4"]; private set => Contants["x4"] = value; }
        public double Y4 { get => Contants["y4"]; private set => Contants["y4"] = value; }

        public double D { get; private set; }
        public double PX { get; private set; } = 0;
        public double PY { get; private set; } = 0;

        public Function Properties { get; private set; }

        public IntersectionPointBeetweenTwoLinesTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "x1", 3.0 },
                { "y1", 2.0 },
                { "x2", 6.0 },
                { "y2", 4.0 },
                { "x3", 8.0 },
                { "y3", 1.0 },
                { "x4", 1.0 },
                { "y4", 5.0 },
            };
        }

        public void Calculate()
        {
            D = (X1 - X2) * (Y3 - Y4) - (Y1 - Y2) * (X3 - X4);
            PX = (((X1 * Y2) - (Y1 * X2)) * (X3 - X4) - (X1 - X2) * ((X3 * Y4) - (Y3 * X4))) / D;
            PY = (((X1 * Y2) - (Y1 * X2)) * (Y3 - Y4) - (Y1 - Y2) * ((X3 * Y4) - (Y3 * X4))) / D;

            if (D == 0)
            {
                PX = double.NaN;
                PY = double.NaN;
            }

            // Restricts the intersection point to be inside of the line areas
            #region UNUSED
            //double x1Min = Min(X1, X2);
            //double x1Max = Max(X1, X2);
            //double x2Min = Min(X3, X4);
            //double x2Max = Max(X3, X4);

            //if (PX < x1Min || PX > x1Max || PX < x2Min || PX > x2Max)
            //{
            //    PX = double.NaN;
            //    PY = double.NaN;
            //}

            //double y1Min = Min(Y1, Y2);
            //double y1Max = Max(Y1, Y2);
            //double y2Min = Min(Y3, Y4);
            //double y2Max = Max(Y3, Y4);

            //if (PY < y1Min || PY > y1Max || PY < y2Min || PY > y2Max)
            //{
            //    PX = double.NaN;
            //    PY = double.NaN;
            //}
            #endregion

            Calculation?.Invoke();
        }

        public string GetDCalculation()
        {
            return "D" +
              Settings.Formular(" = (x_1-x_2)·(y_3-y_4)-(y_1-y_2)·(x_3-x_4)") +
              Settings.CalculationInner($" = ({X1}-{X2})·({Y3}-{Y4})-({Y1}-{Y2})·({X3}-{X4})") +
              Settings.Equal() + GetDResult();
        }
        public string GetDResult()
        {
            return $"{Settings.Limit(D)}";
        }
        public string GetIntersectionPointCalculation()
        {
            if (D == 0)
            {
                return msgDZero;
            }
            else
            {
                return GetDCalculation() + "\n" +
                    "P_x" + Settings.Formular(" = (((x_1·y_2)-(y_1·x_2))·(x_3-x_4)-(x_1-x_2)·((x_3·y_4)-(y_3·x_4)))/D") +
                    Settings.CalculationInner($" = ((({X1}·{Y2})-({Y1}·{X2}))·({X3}-{X4})-({X1}-{ X2})·(({X3}·{Y4})-({Y3}·{X4})))/{D}") +
                    Settings.Equal() + Settings.Limit(PX) + "\n" +
                    "P_y" + Settings.Formular(" = (((x_1·y_2)-(y_1·x_2))·(y_3-y_4)-(y_1-y_2)·((x_3·y_4)-(y_3·x_4 )))/D") +
                    Settings.CalculationInner($" = ((({X1}·{Y2})-({Y1}·{X2}))·({Y3}-{Y4})-({Y1}-{Y2})·(({X3}·{Y4})-({Y3}·{X4})))/{D}") +
                    Settings.Equal() + Settings.Limit(PY) +
                    "\n(P_x, P_y)" + Settings.Equal() + GetIntersectionPointResult();
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
                return $"({Settings.Limit(PX)} ; {Settings.Limit(PY)})";
            }
        }

        public Shape Shape()
        {
            return new Shape(new List<Line>()
            {
                new Line(X1, Y1, X2, Y2),
                new Line(X3, Y3, X4, Y4),

            });
        }

        public Point2D[] Points()
        {
            return new Point2D[]
            {
                new Point2D(X1, Y1, "a#", Color.Green),
                new Point2D(X2, Y2, "b#", Color.Green),
                new Point2D(X3, Y3, "c#", Color.Green),
                new Point2D(X4, Y4, "d#", Color.Green),
                new Point2D(PX, PY, "#\nkrydspunkt", Color.Blue),
            };
        }   
    }
}
