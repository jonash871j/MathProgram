using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Number
    {
        private double x;
        public double Value 
        { 
            get
            {
                return x;
            }
            set
            {
                this.x = value;
                Result = this.x.ToString();
            }
        }
        public string Result { get; internal set; }

        internal Number(double x)
        {
            Value = x;
            Result = x.ToString();
        }
        internal Number(string result = "fejl")
        {
            Result = result;
            Value = 0;
        }
    }

    public class QuadraticEquation
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

        public QuadraticEquation(double a = 0, double b = 0, double c = 0)
        {
            A = a;
            B = b;
            C = c;
        }

        private void Calculate()
        {
            d = (Math.Pow(b, 2) - 4 * a * c);
        }

        public Number GetSolution(Solution solution)
        {
            if (GetSolutionsAmount() == 0)
                return new Number("Ingen løsninger for andengradsligningen!");
            else
                return new Number((-d + Math.Sqrt(d) * (double)solution) / (2 * d));
        }

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
    }
}
