using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Trigonometry
{
    public class SinusRelations
    {
        public double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        public double RadiansToDegrees(double radians)
        {
            return radians * 180.0 / Math.PI;
        }

        public double GetSideResult(double value1, double degree1, double degree2)
        {
            return (value1 * Math.Sin(DegreesToRadians(degree1)))/(Math.Sin(DegreesToRadians(degree2)));
        }
        public string GetSideRegulation(double value1, double degree1, double degree2, char isChar)
        {
            return $"{isChar} = ({value1} * sin({degree1}))/(sin({degree2}))";
        }

        public double GetDegreeResult(double value1, double value2, double degree, bool convertToDegrees)
        {
            if (convertToDegrees)
            {
                return RadiansToDegrees(Math.Asin((value1 * Math.Sin(DegreesToRadians(degree)))/value2));
            }
            else
            {
                return (value1 * Math.Sin(DegreesToRadians(degree))) / (value2);
            }
        }
        public string GetDegreeRegulation(double value1, double value2, double degree, char isChar)
        {
            return $"sin({isChar}) = ({value1} * sin({degree}))/({value2})\r\n{isChar} = sin^-1({GetDegreeResult(value1, value2, degree, false)})\r\n{isChar} = {GetDegreeResult(value1, value2, degree, true)}";
        }
    }
}
