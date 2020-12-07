using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public class Trigonometry
    {
        #region Properties
        private double sidea;

        public double SideA
        {
            get { return sidea; }
            set { sidea = value; }
        }
        private double sideb;

        public double SideB
        {
            get { return sideb; }
            set { sideb = value; }
        }

        private double sidec;

        public double SideC
        {
            get { return sidec; }
            set { sidec = value; }
        }

        private double degreea;

        public double DegreeA
        {
            get { return degreea; }
            set { degreea = value; }
        }

        private double degreeb;

        public double DegreeB
        {
            get { return degreeb; }
            set { degreeb = value; }
        }

        private double degreec;

        public double DegreeC
        {
            get { return degreec; }
            set { degreec = value; }
        }
        #endregion

        public double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        #region Cosinus
        public double GetCosinusSide_Result(double value1, double value2, double degree)
        {
            return Math.Sqrt(Math.Pow(value1, 2) + Math.Pow(value1, 2) - 2 * value1 * value2 * Math.Cos(DegreesToRadians(degree)));
        }

        public string GetCosinusSide_Regulation(double value1, double value2, double degree, char isChar)
        {
            return $"{isChar} = sqrt({value1}^2 + {value2}^2 - 2 * {value1} * {value2} * cos({degree}))";
        }

        public double GetCosinusDegree_Result(double value1, double value2, double value3)
        {
            return Math.Acos((Math.Pow(value1, 2) + Math.Pow(value3, 2) - Math.Pow(value2, 2) / (2 * value1 * value3)));
        }
        #endregion

    }
}
