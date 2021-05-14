using System;
using System.Collections.Generic;
using System.Text;
using static System.Math;
using static MathLib.MathEx;

namespace MathLib.Tools.Trigonometry.Internal
{
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
