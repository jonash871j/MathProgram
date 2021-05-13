using System;
using static System.Math;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{
    public static class MathEx
    {
        public static double SinD(double x)
        {
            return Sin(x * PI / 180.0);
        }
        public static double CosD(double x)
        {
            return Cos(x * PI / 180.0);
        }
        public static double TanD(double x)
        {
            return Tan(x * PI / 180.0);
        }
        public static double AsinD(double x)
        {
            return Asin(x) * 180 / PI;
        }
        public static double AcosD(double x)
        {
            return Acos(x) * 180 / PI;
        }
        public static double AtanD(double x)
        {
            return Atan(x) * 180 / PI;
        }
    }
}
