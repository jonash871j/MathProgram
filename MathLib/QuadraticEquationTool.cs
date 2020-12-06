using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;

namespace MathLib
{
    public class QuadraticEquationTool : IInput, IFunction, IPoints
    {
        private string msgAUndefined = "Udefineret, a ≠ 0";
        private string msgDImpossible = "Umulig, d < 0";
        private string msgOneSolution = "En løsning, d = 0";
        private string msgTwoSolutions = "To løsninger, d > 0";

        public event CalculationEventHandler Calculation;

        public double A { get => Contants["a"]; set => Contants["a"] = value; }
        public double B { get => Contants["b"]; set => Contants["b"] = value; }
        public double C { get => Contants["c"]; set => Contants["c"] = value; }

        public double D { get; private set; }
        public double X1 { get; private set; }
        public double X2 { get; private set; }
        public Point2D TopPoint { get; private set; }
        public bool IsFormularVisible { get; set; }
        public bool IsCalculationVisible { get; set; }
        public Dictionary<string, double> Contants { get; set; }

        public QuadraticEquationTool()
        {
            Contants = new Dictionary<string, double>();
            Contants.Add("a", 0.0);
            Contants.Add("b", 0.0);
            Contants.Add("c", 0.0);
            Calculate();
        }

        public void Calculate()
        {
            D = (Math.Pow(B, 2) - 4 * A * C);
            X1 = (-B + Math.Sqrt(D)) / (2 * A);
            X2 = (-B - Math.Sqrt(D)) / (2 * A);
            TopPoint = new Point2D(-B / (2 * A), -D / (4 * A));
            Calculation?.Invoke();
        }
        public double Function(double x)
        {
            if (A == 0)
                return 0;
            else
                return A * Math.Pow(x, 2) + B * x + C;
        }
        public Point2D[] Points()
        {
            if (A == 0)
            {
                return new Point2D[] { };
            }
            else if (D >= 0)
            {
                return new Point2D[]
                {
                    new Point2D(X1, 0),
                    new Point2D(X2, 0),
                    TopPoint,
                };
            }
            else
            {
                return new Point2D[] { TopPoint };
            }
        }

        public string GetFunction()
        {
            return "f(x) = ax^2 + bx + c \r\n" +
                $"f(x) = { A }x^2 + { B }x + { C }";
        }
        public string GetCalulations()
        {
            return $"f(x) = { A }x^2 + { B }x + { C }\r\n" +
                GetDiscriminantCalculation() + "\r\n" +
                GetRootsCalculation() + 
               "{█(" + GetRootPositiveCalculation() + "@" + GetRootNegativeCalculation() + ")┤";
        }
        public string GetDiscriminantCalculation()
        {
            return "d" +
                   Settings.Formular(" = b^2 - 4ac") +
                   Settings.Calculation($" = { B }^2 - 4 * { A } * { C }") +
                   " = " + D;
        }
        public string GetRootsCalculation()
        {
            return "x" +
                   Settings.Formular(" = (-b ± \\sqrt(d))/(2a)") +
                   Settings.Calculation($" = ({-B} ± \\sqrt({ D }))/(2 * { A }) =");
        }
        public string GetRootPositiveCalculation()
        {
            return Settings.Calculation($"({-B} + \\sqrt({ D }))/(2 * { A })") +
                   Settings.Equal() + GetRootResult(X1);
        }
        public string GetRootNegativeCalculation()
        {
            return Settings.Calculation($"({-B} - \\sqrt({ D }))/(2 * { A })") +
                   Settings.Equal() + GetRootResult(X2);
        }
        public string GetRootResult()
        {
            return "{ "+ GetRootResult(X1) + " ; "+ GetRootResult(X2) + " }";
        }

        public string GetTopPointCalulation()
        {
            return $"(T_x, T_y)" +
                   Settings.Formular(" = (-b/(2a) , -d/(4a)) ") +
                   Settings.Calculation($"= ({ -B }/(2 * { A }), { -D }/(4 * { A }))") +
                   Settings.Equal() + GetTopPointResult();
        }

        public string GetSolutionMessage()
        {
            if (A == 0)     return msgAUndefined;
            if (D < 0.0)    return msgDImpossible;
            if (D == 0)     return msgOneSolution;
            else            return msgTwoSolutions;
        }
        public string GetRootResult(double x)
        {
            if (A == 0)     return msgAUndefined;
            if (D < 0.0)    return msgDImpossible;
            else            return Settings.Result(x);
        }
        public string GetTopPointResult()
        {
            if (A == 0)     return msgAUndefined;
            else            return $"( { Settings.Result(TopPoint.X) } ; { Settings.Result(TopPoint.Y) })";
        }
    }
}