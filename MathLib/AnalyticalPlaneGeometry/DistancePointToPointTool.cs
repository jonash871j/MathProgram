using MathLib.Geometry;
using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using MathLib.Formular;

namespace MathLib.AnalyticalPlaneGeometry
{
    public class DistancePointToPointTool : IInput
    {
        public event CalculationEventHandler Calculation;

        public Dictionary<string, double> Contants { get; set; }
        public Calculator Formular { get; set; }

        public DistancePointToPointTool()
        {
            Contants = new Dictionary<string, double>()
            {
                { "x_1", 0.0 },
                { "x_2", 0.0 },
                { "y_1", 0.0 },
                { "y_2", 0.0 },
            };
            Formular = new Calculator(Contants, "|AB| = √((x_2 - x_1)^2 + (y_2 - y_1)^2)");

  

            //Formulars = new Dictionary<string, Formular>()
            //{
            //    { "Length", new Formular(Contants, "|AB| = sqrt((x_2 - x_1)^2 + (y_2 - y_1)^2)") },
            //    { "Mid", new Formular(Contants, "M(x, y) = ((x_2 + x_1) / 2 , (y_2 + y_1) / 2)") },
            //};
        }

        public void Calculate()
        {
            Formular.Calculate();
            Calculation?.Invoke();
        }

        //public void Calculate()
        //{
        //    Length = Math.Abs(Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2)));
        //    Calculation?.Invoke();
        //}
        //public Point2D[] Points()
        //{
        //    return new Point2D[]
        //    {
        //        new Point2D(X1, Y1),
        //        new Point2D(X2, Y2),
        //    };
        //}
        //public Shape Shape()
        //{
        //    return new Shape(new Line(X1, Y1, X2, Y2));
        //}

        //public string GetLengthCalculation()
        //{
        //    return "|AB|" +
        //        Settings.Formular(" = \\sqrt((x_2 - x_1)^2 + (y_2 - y_1)^2)") +
        //        Settings.Calculation($" = \\sqrt(({ X2 } - { X1 })^2 + ({ Y2 } - { Y1 })^2)") +
        //        Settings.Equal() + GetLengthResult();
        //}
        //public string GetLengthResult()
        //{
        //    return Settings.Result(Length);
        //}
    }
}
