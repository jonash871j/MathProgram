using System;
using System.Collections.Generic;
using System.Drawing;

namespace MathLib.Geometry
{
    public class Shape
    {
        private static Random random = new Random();

        public List<Line> Lines { get; set; }
        public Color Color { get; set; }

        private Shape()
        {
            Color = Color.FromArgb(random.Next(64, 255), random.Next(64, 255), random.Next(64, 255));
        }

        /// <summary>
        /// Used to create polygon shape
        /// </summary>
        public Shape(List<Line> lines)
            : this()
        {
            Lines = lines;
        }

        /// <summary>
        /// Used to create triangular shape
        /// </summary>
        public Shape(Line a, Line b, Line c)
                   : this()
        {
            Lines.Add(a);
            Lines.Add(b);
            Lines.Add(c);
        }

        /// <summary>
        /// Used to set color on the shape
        /// </summary>
        public void SetColor(Color color)
        {
            Color = color;
        }
    }
}
