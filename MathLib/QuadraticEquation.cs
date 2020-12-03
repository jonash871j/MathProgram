using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    //public class Number
    //{
    //    private double x;
    //    public double Value 
    //    { 
    //        get
    //        {
    //            return x;
    //        }
    //        set
    //        {
    //            this.x = value;
    //            Result = this.x.ToString();
    //        }
    //    }
    //    public string Result { get; internal set; }

    //    internal Number(double x)
    //    {
    //        Value = x;
    //        Result = x.ToString();
    //    }
    //    internal Number(string result = "fejl")
    //    {
    //        Result = result;
    //        Value = 0;
    //    }
    //}

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
        }

        //public Number GetSolution(Solution solution)
        //{
        //    if (GetSolutionsAmount() == 0)
        //        return new Number("Ingen løsninger for andengradsligningen!");
        //    else
        //        return new Number((-d + Math.Sqrt(d) * (double)solution) / (2 * d));
        //}

        public double GetSolutionsAmount()
        {
            if (d < 0.0) 
                return 0.0;
            else if (d == 0.0)
                return 1.0;
            else
                return 2.0;
        }

        public string GetFunctionCalculation()
        {
            return $"f(x) = ax^2 + bx + c = { a }x^2 + { b }x + { c }";
        }
        public string GetDiscriminantCalculation()
        {
            return $"d = b^2 - 4 * a * c = { b }^2 - 4 * { a } * { c } = { d }";
        }

        public double Function(double x)
        {
            return A * Math.Pow(x, 2) + B * x + C;
        }
        public PointD[] Points()
        {
            PointD[] points =
            {
                new PointD(X1, 0),
                new PointD(X2, 0),
            };

            return points;
        }
    }
}
