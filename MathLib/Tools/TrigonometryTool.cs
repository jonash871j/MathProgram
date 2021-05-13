using MathLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static MathLib.MathEx;
using MathLib.Geometry;
using System.Drawing;

namespace MathLib.Tools
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
			else if (
				((b > 0) && (A > 0) && (B > 0)) || ((c > 0) && (A > 0) && (C > 0)) ||
				((a > 0) && (B > 0) && (A > 0)) || ((c > 0) && (B > 0) && (C > 0)) ||
				((a > 0) && (C > 0) && (A > 0)) || ((b > 0) && (C > 0) && (B > 0)) ||
				((B > 0) && (a > 0) && (b > 0)) || ((C > 0) && (a > 0) && (c > 0)) ||
				((A > 0) && (b > 0) && (a > 0)) || ((C > 0) && (b > 0) && (c > 0)) ||
				((A > 0) && (c > 0) && (a > 0)) || ((B > 0) && (c > 0) && (b > 0)))
			{
				TriangleName = "Vilkårlig trekant - Sinusrelationerne";
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

	internal class CosRelationTriangle
	{
		public double a { get; private set; }
		public double b { get; private set; }
		public double c { get; private set; }
		public double A { get; private set; }
		public double B { get; private set; }
		public double C { get; private set; }
		public string ErrorMsg { get; private set; } = null;
		public List<string> Calculations { get; private set; }

		public CosRelationTriangle(double a, double b, double c, double A, double B, double C)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.A = A;
			this.B = B;
			this.C = C;
			Calculations = new List<string>();

			Calculate();
		}
		public string GetCalculations()
		{
			string calculations = "";
			foreach (string calculation in Calculations)
			{
				calculations += calculation + "\n";
			}
			return calculations;
		}

		private void Calculate()
        {
			if ((b > 0) && (c > 0) && (A > 0))
			{
				Form_a();
				Form_B1();
				Form_C2();
			}
			else if ((a > 0) && (c > 0) && (B > 0))
			{
				Form_b();
				Form_A1();
				Form_C2();
			}
			else if ((a > 0) && (b > 0) && (C > 0))
			{
				Form_c();
				Form_B1();
				Form_A2();
			}
			// Error checking
			else if (b + c < a || a + c < b || a + b < c)
			{
				ErrorMsg = "De indtastet 3 sider danner ikke en trekant!";
			}
			else if ((a > 0) && (b > 0) && (c > 0))
			{
				Form_A1();
				Form_B1();
				Form_C2();
			}

			// Error checking
			if (A >= 180 || B >= 180 || C >= 180)
			{
				ErrorMsg = "En vinkel må ikke være 180° eller mere!";
			}
		}

		private void Form_a()
        {
			a = Sqrt(Pow(b, 2) + Pow(c, 2) - 2 * b * c * CosD(A));
			Calculations.Add(Settings.Calculation(
				"a",
				"√(b^2+c^2-2*b*c*cos(A))",
				$"√({b}^2+{c}^2-2*{b}*{c}*cos({A}))",
				$"{a}"
			));
        }
		private void Form_b()
        {
			b = Sqrt(Pow(a, 2) + Pow(c, 2) - 2 * a * c * CosD(B));
            Calculations.Add(Settings.Calculation(
                "b",
				"√(a^2+c^2-2*a*c*cos(B))",
                $"√({a}^2+{c}^2-2*{a}*{c}*cos({B}))",
                $"{b}"
            ));
        }
		private void Form_c()
        {
			c = Sqrt(Pow(a, 2) + Pow(b, 2) - 2 * a * b * CosD(C));
			Calculations.Add(Settings.Calculation(
				"c",
				"√(a^2+b^2-2*a*b*cos(C))",
				$"√({a}^2+{b}^2-2*{a}*{b}*cos({C}))",
				$"{c}"
			));
        }

		private void Form_A1()
		{
			A = AcosD((Pow(b, 2) + Pow(c, 2) - Pow(a, 2)) / (2 * b * c));
			Calculations.Add(Settings.Calculation(
				"A",
				"acos((b^2+c^2-a^2)/(2*b*c))",
				$"acos(({b}^2+{c}^2-{a}^2)/(2*{b}*{c}))",
				$"{A}°"
			));
		}
		private void Form_A2()
        {
			A = 180 - B - C;
			Calculations.Add(Settings.Calculation(
				"A",
				"180-B-C",
				$"180-{B}-{C}",
				$"{A}°"
			));
        }

		private void Form_B1()
        {
			B = AcosD((Pow(a, 2) + Pow(c, 2) - Pow(b, 2)) / (2 * a * c));
			Calculations.Add(Settings.Calculation(
				"B",
				"acos((a^2+c^2-b^2)/(2*a*c))",
				$"acos(({a}^2+{c}^2-{b}^2)/(2*{a}*{c}))",
				$"{B}°"
			));
        }

		private void Form_C2()
		{
			C = 180 - A - B;
			Calculations.Add(Settings.Calculation(
				"C",
				"180-A-B",
				$"180-{A}-{B}",
				$"{C}°"
			));
		}
	}
	internal class NinetyDegreeTriangle
	{
		public double a { get; private set; }
		public double b { get; private set; }
		public double c { get; private set; }
		public double A { get; private set; }
		public double B { get; private set; }
		public readonly double C = 90.0;
		public string ErrorMsg { get; private set; } = null;

		public List<string> Calculations { get; private set; }

		public NinetyDegreeTriangle(double a, double b, double c, double A, double B)
		{
			this.a = a;
			this.b = b;
			this.c = c;
			this.A = A;
			this.B = B;

			Calculations = new List<string>();

			// Error checking
			if (((a >= c) || (b >= c)) && (c > 0))
			{
				ErrorMsg = "c skal altid være længere end a eller b i en retvinklet trekant!";
			}
			// Error checking
			else if (A + B > 90) 
			{
				ErrorMsg = "A lagt sammen med B må ikke overstige 90°!";
			}
			// If to sides is given
			else if (((a > 0) && (b > 0)) || ((a > 0) && (c > 0)) || ((b > 0) && (c > 0)))
            {
				if ((a > 0) && (b > 0))
				{
					Form_c1();
					Form_A1();
					Form_B3();
				}
				else if ((a > 0) && (c > 0))
				{
					Form_b1();
					Form_A1();
					Form_B3();
				}
				else if ((b > 0) && (c > 0))
				{
					Form_a1();
					Form_A1();
					Form_B3();
				}
			}
			// If an angle and a side is given
			else if (((a > 0) && (A > 0)) || ((a > 0) && (B > 0)) || 
					 ((b > 0) && (A > 0)) || ((b > 0) && (B > 0)) || 
					 ((c > 0) && (A > 0)) || ((c > 0) && (B > 0)))
			{
				if ((a > 0) && (A > 0))
				{
					Form_b2();
					Form_c1();
					Form_B3();
				}
				else if ((a > 0) && (B > 0))
				{
					Form_b3();
					Form_c1();
					Form_A3();
				}
				else if ((b > 0) && (A > 0))
				{
					Form_a2();
					Form_c1();
					Form_B3();
				}
				else if ((b > 0) && (B > 0))
				{
					Form_a3();
					Form_c1();
					Form_A3();
				}
				else if ((c > 0) && (A > 0))
				{
					Form_a4();
					Form_b1();
					Form_B3();
				}
				else if ((c > 0) && (B > 0))
				{
					Form_a5();
					Form_b1();
					Form_A3();
				}
			}
			else // Error checking
            {
				ErrorMsg = "I en retvinklet trekant skal C = 90 og der skal kendes mindst en side og en vinkel, eller to sider.";
			}
		}

		public string GetCalculations()
        {
			string calculations = "";
			foreach (string calculation in Calculations)
            {
				calculations += calculation + "\n";
			}
			return calculations;
		}

		private void Form_a1()
        {
			a = Sqrt(Pow(c, 2) - Pow(b, 2));
			Calculations.Add(Settings.Calculation(
				"a",
				"√(c^2-b^2)",
				$"√(({c})^2-({b})^2)",
				$"{a}"
			));
        }
		private void Form_a2()
        {
			a = b * TanD(A);
			Calculations.Add(Settings.Calculation(
				"a",
				"b*tan(A)",
				$"{b}*tan({A})",
				$"{a}c"
			));
        }
		private void Form_a3()
        {
			a = b / TanD(B);
			Calculations.Add(Settings.Calculation(
				"a",
				"b/tan(B)",
				$"{b}/tan({B})",
				$"{a}"
			));
        }
		private void Form_a4()
        {
			a = c * SinD(A);
			Calculations.Add(Settings.Calculation(
				"a",
				"c*sin(A)",
				$"{c}*sin({A})",
				$"{a}"
			));
        }
		private void Form_a5()
        {
			a = c * CosD(B);
			Calculations.Add(Settings.Calculation(
				"a",
				"c*cos(B)",
				$"{c}*cos({B})",
				$"{a}"
			));
        }
		private void Form_b1()
        {
			b = Sqrt(Pow(c, 2) - Pow(a, 2));
			Calculations.Add(Settings.Calculation(
				"b",
				"√(c^2-a^2)",
				$"√(({c})^2-({a})^2)",
				$"{b}"
			));
        }
		private void Form_b2()
        {
			b = a / TanD(A);
			Calculations.Add(Settings.Calculation(
				"b",
				"a/tan(A)",
				$"{a}/tan({A})",
				$"{b}"
			));
        }
		private void Form_b3()
        {
			b = a * TanD(B);
			Calculations.Add(Settings.Calculation(
				"b",
				"a*tan(B)",
				$"{a}*tan({B})",
				$"{b}"
			));
        }

        private void Form_c1()
		{
			c = Sqrt(Pow(a, 2) + Pow(b, 2));
			Calculations.Add(Settings.Calculation(
				"c",
				"√(a^2+b^2)",
				$"√(({a})^2+({b})^2)",
				$"{c}"
			));
		}
		private void Form_A1()
        {
			A = AtanD(a / b);
			Calculations.Add(Settings.Calculation(
				"A",
				"atan(a/b)",
				$"atan({a}/{b})",
				$"{A}°"
			));
        }
		private void Form_A3()
        {
			A = 180 - 90 - B;
			Calculations.Add(Settings.Calculation(
				"B",
				"180-90-B",
				$"180-90-{B}",
				$"{A}°"
			));
        }
		private void Form_B3()
        {
			B = 180 - 90 - A;
			Calculations.Add(Settings.Calculation(
				"B",
				"180-90-A",
				$"180-90-{A}",
				$"{B}°"
			));
        }
    }
}
