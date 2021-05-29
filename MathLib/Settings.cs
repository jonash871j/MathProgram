using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public static class Settings
    {
        public static bool IsFormularVisible { get; set; } = true;
        public static bool IsCalculationVisible { get; set; } = true;

        public static string Calculation(string toCalculate, string formular, string calculation, string result)
        {
            return ShortnedLongNumbersInString(toCalculate + Formular("=" + formular) + CalculationInner("=" + calculation) + Equal() + result);
        }
        public static string Formular(string formular)
        {
            if (IsFormularVisible)
                return formular;
            else
                return "";
        }
        public static string CalculationInner(string calculation)
        {
            if (IsCalculationVisible)
                return calculation.Replace(" ", "");
            else
                return "";
        }
        public static string Limit(double value)
        {
            return Math.Round(value, 3).ToString();
        }
        public static string Equal()
        {
            return "=";
        }

        private static string ShortnedLongNumbersInString(string calculation)
        {
            bool IsValidNumber(string test, ref double rNumber)
            {
                double number = 0;
                if (double.TryParse(test, out number))
                {
                    rNumber = number;
                    return true;
                }
                else
                {
                    return false;
                }
            }

            string shortnedCalculation = "";

            for (int i = 0; i < calculation.Length; i++)
            {
                string test = "";
                double number = 0.0;
                for (int j = i; j <= calculation.Length; j++)
                {
                    if (j >= calculation.Length || !IsValidNumber(test + calculation[j], ref number))
                    {
                        if (!string.IsNullOrEmpty(test))
                        {
                            shortnedCalculation += Limit(number);
                        }

                        if (j >= calculation.Length)
                        {
                            return shortnedCalculation;
                        }
                        else
                        {
                            i = j;
                            break;
                        }
                    }

                    test += calculation[j];
                }
                shortnedCalculation += calculation[i];
            }

            return shortnedCalculation;
        }
    }
}
