using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static MathLib.MathEx;

namespace MathLib.Tools.Trigonometry.Internal
{
	internal class SinRelationTriangle
	{
		public double a { get; private set; }
		public double b { get; private set; }
		public double c { get; private set; }
		public double A { get; private set; }
		public double B { get; private set; }
		public double C { get; private set; }
		public string ErrorMsg { get; private set; } = null;
		public List<string> Calculations { get; private set; }

		public SinRelationTriangle(double a, double b, double c, double A, double B, double C)
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
			if ((b > 0) && (A > 0) && (B > 0)) //a1
			{
				Form_a1();
				Form_C3();
				Form_c1();
			}
			else if ((c > 0) && (A > 0) && (C > 0)) //a2
			{
				Form_a2();
				Form_B3();
				Form_b1();
			}
			else if ((a > 0) && (B > 0) && (A > 0)) //b1
			{
				Form_b1();
				Form_C3();
				Form_c1();
			}
			else if ((c > 0) && (B > 0) && (C > 0)) //b2
			{
				Form_b2();
				Form_A3();
				Form_a1();
			}
			else if ((a > 0) && (C > 0) && (A > 0)) //c1
			{
				Form_c1();
				Form_B3();
				Form_b1();
			}
			else if ((b > 0) && (C > 0) && (B > 0)) //c2
			{
				Form_c2();
				Form_A3();
				Form_a1();
			}
			else if ((B > 0) && (a > 0) && (b > 0)) //A1
			{
				Form_A1();
				Form_C3();
				Form_c1();
			}
			else if ((C > 0) && (a > 0) && (c > 0)) //A2
			{
				Form_A2();
				Form_B3();
				Form_b1();
			}
			else if ((A > 0) && (b > 0) && (a > 0)) //B1
			{
				Form_B1();
				Form_C3();
				Form_c1();
			}
			else if ((C > 0) && (b > 0) && (c > 0)) //B2
			{
				Form_B2();
				Form_A3();
				Form_a1();
			}
			else if ((A > 0) && (c > 0) && (a > 0)) //C1	
			{
				Form_C1();
				Form_B3();
				Form_b1();
			}
			else if ((B > 0) && (c > 0) && (b > 0)) //C2
			{
				Form_C2();
				Form_A3();
				Form_a1();
			}

			// Error checking
			if (A >= 180 || B >= 180 || C >= 180 || A < 0 || B < 0 || C < 0)
			{
				ErrorMsg = "En vinkel må ikke være 180° eller mere!";
			}
		}

		void Form_a1()
		{
			a = (b * SinD(A))/SinD(B);
			Calculations.Add(Settings.Calculation(
				"a",
				"(b*sin(A))/sin(B)",
				$"({b}*sin({A}))/sin({B})",
				$"{a}"
			));
		}
		void Form_a2()
		{
			a = (c * SinD(A)) / SinD(C);
			Calculations.Add(Settings.Calculation(
				"a",
				"(c*sin(A))/sin(C)",
				$"({c}*sin({A}))/sin({C})",
				$"{a}"
			));
		}

		void Form_b1()
		{
			b = (a * SinD(B)) / SinD(A);
			Calculations.Add(Settings.Calculation(
				"b",
				"(a*sin(B))/sin(A)",
				$"({a}*sin({B}))/sin({A})",
				$"{b}"
			));
		}
		void Form_b2()
		{
			b = (c * SinD(B)) / SinD(C);
			Calculations.Add(Settings.Calculation(
				"b",
				"(c*sin(B))/sin(C)",
				$"({c}*sin({B}))/sin({C})",
				$"{b}"
			));
		}

		void Form_c1()
		{
			c = (a * SinD(C)) / SinD(A);
			Calculations.Add(Settings.Calculation(
				"c",
				"(a*sin(C))/sin(A)",
				$"({a}*sin({C}))/sin({A})",
				$"{c}"
			));
		}
		void Form_c2()
		{
			c = (b * SinD(C)) / SinD(B);
			Calculations.Add(Settings.Calculation(
				"c",
				"(b*sin(C))/sin(B)",
				$"({b}*sin({C}))/sin({B})",
				$"{c}"
			));
		}

		void Form_A1()
		{
			A = AsinD((a * SinD(B)) / b);
			Calculations.Add(Settings.Calculation(
				"A",
				"asin(a*sin(B))/b",
				$"asin({a}*sin({B}))/{b}",
				$"{A}°"
			));
		}
		void Form_A2()
		{
			A = AsinD((a * SinD(C)) / c);
			Calculations.Add(Settings.Calculation(
				"A",
				"asin((a*sin(C))/c)",
				$"asin(({a}*sin({C}))/{c})",
				$"{A}°"
			));
		}
		void Form_A3()
		{
			A = 180 - B - C;
			Calculations.Add(Settings.Calculation(
				"A",
				"180-B-C",
				$"180-{B}-{C}",
				$"{A}°"
			));
		}

		void Form_B1()
		{
			B = AsinD((b * SinD(A)) / a);
			Calculations.Add(Settings.Calculation(
				"B",
				"asin(b*sin(A))/a",
				$"asin({b}*sin({A}))/{a}",
				$"{B}°"
			));
		}
		void Form_B2()
		{
			B = AsinD((a * SinD(C)) / c);
			Calculations.Add(Settings.Calculation(
				"B",
				"asin((b*sin(C))/c)",
				$"asin(({b}*sin({C}))/{c})",
				$"{B}°"
			));
		}
		void Form_B3()
		{
			B = 180 - A - C;
			Calculations.Add(Settings.Calculation(
				"B",
				"180-A-C",
				$"180-{A}-{C}",
				$"{B}°"
			));
		}

		void Form_C1()
		{
			C = AsinD((c * SinD(A)) / b);
			Calculations.Add(Settings.Calculation(
				"C",
				"asin(c*sin(A))/b",
				$"asin({c}*sin({A}))/{b}",
				$"{C}°"
			));
		}
		void Form_C2()
		{
			C = AsinD((a * SinD(C)) / c);
			Calculations.Add(Settings.Calculation(
				"C",
				"asin((c*sin(B))/b)",
				$"asin(({c}*sin({B}))/{b})",
				$"{C}°"
			));
		}
		void Form_C3()
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
