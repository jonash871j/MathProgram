using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public static class Settings
    {
        public static bool IsFormularVisible { get; set; } = true;
        public static bool IsCalculationVisible { get; set; } = true;

        public static string Formular(string formular)
        {
            if (IsFormularVisible)
                return formular;
            else
                return "";
        }
        public static string Calculation(string calculation)
        {
            if (IsCalculationVisible)
            {
                string finalCalculation = "";
                char lastChar = ' ';

                for (int i = 0; i < calculation.Length; i++)
                {
                    if ((lastChar != '-') || (calculation[i] != '-'))
                    {
                        finalCalculation += calculation[i];
                    }
                    if (calculation[i] != ' ')
                    {
                        lastChar = calculation[i];
                    }
                }

                return finalCalculation;

            }
            else
                return "";
        }
        public static string Result(double result)
        {
            return Math.Round(result, 3).ToString();
        }
        public static string Equal()
        {
            return " = ";
        }
    }
}
