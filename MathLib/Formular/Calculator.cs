using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MathLib.Formular
{
    public class Calculator
    {
        private ExpectedResult expectedResult;

        public Dictionary<string, double> Constants { get; private set; }
        public string Formular { get; private set; }


        public Calculator(Dictionary<string, double> constants, string formular)
        {
            Constants = constants;
            Formular = formular;

            Calculate();
        }

        public void Calculate()
        {
            Formular = Misc.RemoveWhitespace(Formular);

            expectedResult = new ExpectedResult(Formular);
        }

        public string GetCalulation()
        {
            return Formular;
        }
        public string GetResult()
        {
            return expectedResult.Name + " IsAbsolute:" + expectedResult.IsAbsolute;
        }
    }
}
