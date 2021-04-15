using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Trigonometry
{
    public class TrigonometryManager : IShape
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

        public static CosinusRelations cosinus = new CosinusRelations();
        public static SinusRelations sinus = new SinusRelations();

        private bool CheckValues(double side1, double side2, double degree)
        {
            if ((side1 > 0) && (side2 > 0) && (degree > 0))
                return true;
            else
                return false;
        }

        public string Calculate()
        {
            if (degreec != 90)
            {
                //Cosinus Relationer
                if (CheckValues(sideb, sidec, degreea) || CheckValues(sidea, sidec, degreeb) || CheckValues(sidea, sideb, degreec) || CheckValues(sidea, sideb, sidec))
                {
                    return CosinusRelations();
                }
                //Sinus Relationer
                else if (CheckValues(sideb, degreea, degreeb) || CheckValues(sidec, degreeb, degreec) || CheckValues(sidea, degreec, degreea) || CheckValues(sidea, sideb, degreeb) || CheckValues(sideb, sidec, DegreeC) || CheckValues(sidec, sidea, degreea))
                {
                    return SinusRelations();
                }
                else
                {
                    return "Fandt ingen formel der matchede:0";
                }
            }
            //Retvinklede trekanter
            else if (degreea == 90 || degreeb == 90 || degreec == 90)
            {
                return "";
            }
            else
            {
                return "Fandt ingen formel der matchede:0";
            }
        }


        private string CosinusRelations()
        {
            if (degreea + degreeb + degreec < 180)
            {
                //Sides
                if (sideb > 0 && sidec > 0 && degreea > 0)
                {
                    return cosinus.GetSideRegulation(sideb, sidec, degreea, 'a') + ":" + cosinus.GetSideResult(sideb, sidec, degreea);
                }
                else if (sidea > 0 && sidec > 0 && degreeb > 0)
                {
                    return cosinus.GetSideRegulation(sidea, sidec, degreeb, 'b') + ":" + cosinus.GetSideResult(sidea, sidec, degreeb);
                }
                else if (sidea > 0 && sideb > 0 && degreec > 0)
                {
                    return cosinus.GetSideRegulation(sidea, sideb, degreec, 'b') + ":" + cosinus.GetSideResult(sidea, sideb, degreec);
                }

                //Degrees
                else if (sidea > 0 && sideb > 0 && sidec > 0)
                {
                    return cosinus.GetDegreeRegulation(sideb, sidec, sidea, 'A') + "#" + cosinus.GetDegreeRegulation(sidea, sidec, sideb, 'B') + "#" + cosinus.GetDegreeRegulation(sidea, sideb, sidec, 'C') + ":" + cosinus.GetDegreeResult(sideb, sidec, sidea, true) + "∘" + "#" + cosinus.GetDegreeResult(sidea, sidec, sideb, true) +"∘" + "#" + cosinus.GetDegreeResult(sidea, sideb, sidec, true) + "∘";
                }
                else
                {
                    return "Fandt ingen formel der matchede:0";
                }
            }
            else
            {
                return "A lagt sammen med B & C må ikke overstige 180:0";
            }
        }

        private string SinusRelations()
        {
            if (sideb > 0 && degreea > 0 && degreeb > 0)
            {
                return sinus.GetSideRegulation(sideb, degreea, degreeb, 'a') + ":" + sinus.GetSideResult(sideb, degreea, degreeb);
            }
            else if (sidec > 0 && degreeb > 0 && degreec > 0)
            {
                return sinus.GetSideRegulation(sidec, degreeb, degreec, 'b') + ":" + sinus.GetSideResult(sidec, degreeb, degreec);
            }
            else if (sidea > 0 && degreec > 0 && degreea > 0)
            {
                return sinus.GetSideRegulation(sidea, degreec, degreea, 'c') + ":" + sinus.GetSideResult(sidea, degreec, degreea);
            }
            else if (sidea > 0 && sideb > 0 && degreeb > 0)
            {
                return sinus.GetDegreeRegulation(sidea, sideb, degreeb, 'A') + ":" + sinus.GetDegreeResult(sidea, sideb, degreeb, true);
            }
            else if (sideb > 0 && sidec > 0 && degreec > 0)
            {
                return sinus.GetDegreeRegulation(sideb, sidec, degreec, 'B') + ":" + sinus.GetDegreeResult(sideb, sidec, degreec, true);
            }
            else if (sidec > 0 && sidea > 0 && degreea > 0)
            {
                return sinus.GetDegreeRegulation(sidec, sidea, degreea, 'A') + ":" + sinus.GetDegreeResult(sidec, sidea, degreeb, true);
            }
            else
            {
                return "Fandt ingen formel der matchede:0";
            }
        }


        public Shape Shape()
        {
            double ax = SideA * Math.Cos(DegreeA * Math.PI / 180);
            double ay = SideA * Math.Sin(DegreeA * Math.PI / 180);
            double bx = SideB * Math.Cos(DegreeB * Math.PI / 180);
            double by = SideB * Math.Sin(DegreeB * Math.PI / 180);
            double cx = SideC * Math.Cos(DegreeC * Math.PI / 180);
            double cy = SideC * Math.Sin(DegreeC * Math.PI / 180);

            return new Shape(new List<Line>
            {
                new Line(0, 0, ax, ay),
                new Line(ax, ay, bx, by),
                new Line(bx, by, cx, cy),
            });
        }

        //public double Function(double x)
        //{
        //    return Math.Sin(x);
        //}

        //public Point2D[] Points()
        //{
        //    return new Point2D[]
        //    {
        //        new Point2D(16, 16),
        //        new Point2D(-16, 32),
        //    };
        //}

    }
}
