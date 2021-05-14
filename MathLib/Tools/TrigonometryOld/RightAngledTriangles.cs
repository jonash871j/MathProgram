using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Trigonometry
{
    class RightAngledTriangles
    {
        
        public double SideABCSqrt_Result(double value1, double value2, bool isSidec)
        {
            if (isSidec)
            {
                return Math.Sqrt(Math.Pow(value1, 2) + Math.Pow(value2, 2));
            }
            else
            {
                return Math.Sqrt(Math.Pow(value1, 2) - Math.Pow(value2, 2));
            }
        }
        public string SideABCSqrt_Regulation(double value1, double value2, char isChar, char plusOrMinus)
        {
            return $"{isChar} = √{value1} {plusOrMinus} {value2}";
        }
    }
}
