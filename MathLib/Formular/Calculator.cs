using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.FormularCalculator
{
    public class Calculator
    {
        public string Formular { get; private set; }
        public Dictionary<string, double> Constants { get; private set; }

        public Calculator(Dictionary<string, double> constants, string formular)
        {
            Constants = constants;
            Formular = formular;
        }

        public void Calculate()
        {

        }

        public string GetCalulation()
        {
            return "GetCalulation";
        }
        public string GetResult()
        {
            return "GetResult";
        }
    }
}
