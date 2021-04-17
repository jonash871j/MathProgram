﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MathLib.Geometry
{
    public class Point2D
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Color Color { get; set; }
        public string Text { get; set; }

        public Point2D(double x, double y, string text, Color color)
        {
            X = double.IsNaN(x) ? 0 : x;
            Y = double.IsNaN(y) ? 0 : y;
            Color = color;
            Text = text;
        }
        public Point2D(double x = 0.0, double y = 0.0, string text = "")
            : this(x, y, text, Color.FromArgb(192, 32, 32))
        {
        }

        public override string ToString()
        {
            string coordinate = $"({X.ToString("N2")} ; {Y.ToString("N2")})";

            if (Text == "")
            {
                return coordinate;
            }
            else
            {
                return Text.Replace("#", coordinate);
            }
        }
    }
}
