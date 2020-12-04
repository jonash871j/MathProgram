using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class QuadraticEquation : IFunction, IPoints
    {
        public enum Solution
        {
            Postive = 1,
            Negative = -1,
        }

        private double a;
        private double b;
        private double c;
        private double d;

        public double A 
        { 
            get
            {
                return a;
            }
            set
            {
                a = value;
                Calculate();
            }
        }
        public double B 
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
                Calculate();
            }
        }
        public double C 
        {
            get
            {
                return c;
            }
            set
            {
                c = value;
                Calculate();
            }
        }
        public double D
        {
            get 
            { 
                return d; 
            }
            set
            {
                d = value;
            }
        }

        public double X1 { get; private set; }
        public double X2 { get; private set; }

        public Point2D TopPoint { get; private set; }

        public QuadraticEquation(double a = 0, double b = 0, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }

        private void Calculate()
        {
            d = (Math.Pow(b, 2) - 4 * a * c);
            X1 = (-b + Math.Sqrt(d)) / (2 * a);
            X2 = (-b - Math.Sqrt(d)) / (2 * a);
            TopPoint = new Point2D(-b / (2 * a), -d / (4 * a));
        }

        public string GetSolutionMessage()
        {
            if (a == 0)
                return "Udefineret, a ≠ 0";
            if (d < 0.0)
                return "Umulig, d < 0";
            else if (d == 0)
                return "En løsning, d = 0";
            else
                return "To løsninger, d > 0";
        }
        public string GetRootResult(double x)
        {
            if (a == 0)
                return "Udefineret, a ≠ 0";
            if (d < 0.0)
                return "Umulig, d < 0";
            else
                return x.ToString();
        }

        public string GetFunction()
        {
            return $"f(x) = ax^2 + bx + c = { a }x^2 + { b }x + { c }";
        }
        public string GetDiscriminantCalculation()
        {
            return $"d = b^2 - 4 * a * c = { b }^2 - 4 * { a } * { c } = { d }";
        }
        public string GetRootsCalculation()
        {
            return $"({-b} ± sqrt({ d }))/(2 * { a }) = ";
        }
        public string GetRootPositiveCalculation()
        {
            return $"({-b} - sqrt({ d }))/(2 * { a }) = " + GetRootResult(X1);
        }
        public string GetRootNegativeCalculation()
        {
            return $"({-b} - sqrt({ d }))/(2 * { a }) = " + GetRootResult(X1);
        }
        public string GetRootResult()
        {
            return "{ "+ GetRootResult(X1) + " ; "+ GetRootResult(X2) + " }";
        }
        public string GetTopPointCalulation()
        {
            return $"(T_x, T_y) = ({ -b }/(2 * { a }), { -d }/(4 * { a })) = " + GetTopPointResult();
        }
        public string GetTopPointResult()
        {
            return $"( { TopPoint.X } ; { TopPoint.Y })";
        }

        public double Function(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }
        public Point2D[] Points()
        {
            Point2D[] points =
            {
                new Point2D(X1, 0),
                new Point2D(X2, 0),
                TopPoint,
            };

            return points;
        }
    }
}
