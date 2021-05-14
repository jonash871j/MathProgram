using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static MathLib.MathEx;

namespace MathLib.Tools.Trigonometry.Internal
{
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
}
