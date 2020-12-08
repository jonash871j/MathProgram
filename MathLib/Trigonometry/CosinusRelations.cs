using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Trigonometry
{
    public class CosinusRelations
    {

        public double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        public double GetSideResult(double value1, double value2, double degree)
        {
            return Math.Sqrt((Math.Pow(value1, 2) + Math.Pow(value2, 2) - 2 * value1 * value2 * Math.Cos(DegreesToRadians(degree))));
        }

        public string GetSideRegulation(double value1, double value2, double degree, char isChar)
        {
            return $"{isChar} = √({value1}^2 + {value2}^2 - 2 * {value1} * {value2} * cos({degree}))";
        }

        public double GetDegreeResult(double value1, double value2, double value3, bool convertToDegrees)
        {
            if (convertToDegrees)
            {
                return RadiansToDegrees(Math.Acos((Math.Pow(value1, 2) + Math.Pow(value2, 2) - Math.Pow(value3, 2))/( 2 * value1 * value2)));
            }
            else
            {
                return Math.Acos((Math.Pow(value1, 2) + Math.Pow(value2, 2) - Math.Pow(value3, 2)) / (2 * value1 * value2));
            }
        }
        public string GetDegreeRegulation(double value1, double value2, double value3, char isChar)
        {
            return $"cos({isChar}) = ({value1}^2 + {value2}^2 - {value3}^2)/(2 * {value1} * {value2})\r\n{isChar} = cos^-1({GetDegreeResult(value1, value2, value3, false)})\r\n{isChar} = {GetDegreeResult(value1, value2, value3, true)}∘\r\n";
        }
    }
}
