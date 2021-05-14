using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static MathLib.MathEx;
using MathLib.Geometry;
using System.Drawing;
using MathLib.Tools.Trigonometry.Internal;

namespace MathLib.Tools.Trigonometry
{
    public class TrigonometryTool : ICalculate, IShape, IPoints
    {
        public event CalculationEventHandler Calculation;

		public string TriangleName = "-";
		public string Calculations { get; private set; } = "";
		public double a { get => Constants["a"]; set => Constants["a"] = value; }
		public double b { get => Constants["b"]; set => Constants["b"] = value; }
		public double c { get => Constants["c"]; set => Constants["c"] = value; }
		public double A { get => Constants["A"]; set => Constants["A"] = value; }
		public double B { get => Constants["B"]; set => Constants["B"] = value; }
		public double C { get => Constants["C"]; set => Constants["C"] = value; }
		public Dictionary<string, double> Constants;

		public TrigonometryTool()
        {
			Constants = new Dictionary<string, double>()
			{
				{ "a", 0.0 },
				{ "b", 0.0 },
				{ "c", 0.0 },
				{ "A", 0.0 },
				{ "B", 0.0 },
				{ "C", 0.0 },
			};
		}

        public void Calculate()
        {
			if ((A < 90) && (B < 90) && (C == 90))
			{
				CalculateNinetyDegreeTriangle();
			}
			else if((((b > 0) && (c > 0) && (A > 0)) || ((a > 0) && (c > 0) && (B > 0)) ||
					((a > 0) && (b > 0) && (C > 0))) || ((a > 0) && (b > 0) && (c > 0)))
			{
				CalculateCosRelationTriangle();
			}
			else if (
				((b > 0) && (A > 0) && (B > 0)) || ((c > 0) && (A > 0) && (C > 0)) ||
				((a > 0) && (B > 0) && (A > 0)) || ((c > 0) && (B > 0) && (C > 0)) ||
				((a > 0) && (C > 0) && (A > 0)) || ((b > 0) && (C > 0) && (B > 0)) ||
				((B > 0) && (a > 0) && (b > 0)) || ((C > 0) && (a > 0) && (c > 0)) ||
				((A > 0) && (b > 0) && (a > 0)) || ((C > 0) && (b > 0) && (c > 0)) ||
				((A > 0) && (c > 0) && (a > 0)) || ((B > 0) && (c > 0) && (b > 0)))
			{
				CalculateSinRelationTriangle();
			}
            else
            {
				Calculations = "";
				TriangleName = "Ugyldig trekant";
			}

			Calculation?.Invoke();
		}

        public Shape Shape()
        {
			double cx = c * CosD(A);
			double cy = c * SinD(A);

			return new Shape(new List<Line>
			{
				new Line(0, 0, cx, cy, Color.White, $"c: {Settings.Limit(c)}"),
				new Line(0, 0, b, 0, Color.White, $"b: {Settings.Limit(b)}"),
				new Line(b, 0, cx, cy, Color.White, $"a: {Settings.Limit(a)}"),
			});
		}

		public Point2D[] Points()
		{
			double cx = c * CosD(A);
			double cy = c * SinD(A);

			return new Point2D[]
			{
				new Point2D(0, 0, $"A: {Settings.Limit(A)}°"),
				new Point2D(b, 0, $"C: {Settings.Limit(C)}°"),
				new Point2D(cx, cy, $"B: {Settings.Limit(B)}°"),
			};
		}

		private void CalculateCosRelationTriangle()
        {
			TriangleName = "Vilkårlig trekant - Cosinusrelationerne";

			CosRelationTriangle cosRelationTriangle = new CosRelationTriangle(a, b, c, A, B, C);
			if (cosRelationTriangle.ErrorMsg != null)
			{
				Calculations = cosRelationTriangle.ErrorMsg;
			}
			else
			{
				a = cosRelationTriangle.a;
				b = cosRelationTriangle.b;
				c = cosRelationTriangle.c;
				A = cosRelationTriangle.A;
				B = cosRelationTriangle.B;
				C = cosRelationTriangle.C;
				Calculations = cosRelationTriangle.GetCalculations();
			}
		}
		private void CalculateSinRelationTriangle()
		{
			TriangleName = "Vilkårlig trekant - Sinusrelationerne";

			SinRelationTriangle sinRelationTriangle = new SinRelationTriangle(a, b, c, A, B, C);
			if (sinRelationTriangle.ErrorMsg != null)
			{
				Calculations = sinRelationTriangle.ErrorMsg;
			}
			else
			{
				a = sinRelationTriangle.a;
				b = sinRelationTriangle.b;
				c = sinRelationTriangle.c;
				A = sinRelationTriangle.A;
				B = sinRelationTriangle.B;
				C = sinRelationTriangle.C;
				Calculations = sinRelationTriangle.GetCalculations();
			}
		}
		private void CalculateNinetyDegreeTriangle()
		{
			TriangleName = "Retvinklet trekant";

			NinetyDegreeTriangle ninetyDegreeTriangle = new NinetyDegreeTriangle(a, b, c, A, B);

			if (ninetyDegreeTriangle.ErrorMsg != null)
			{
				Calculations = ninetyDegreeTriangle.ErrorMsg;
			}
			else
			{
				a = ninetyDegreeTriangle.a;
				b = ninetyDegreeTriangle.b;
				c = ninetyDegreeTriangle.c;
				A = ninetyDegreeTriangle.A;
				B = ninetyDegreeTriangle.B;
				C = ninetyDegreeTriangle.C;
				Calculations = ninetyDegreeTriangle.GetCalculations();
			}
		}
	}



}
