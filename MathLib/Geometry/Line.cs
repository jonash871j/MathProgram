using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace MathLib.Geometry
{
    public class Line
    {
        public Point2D A { get; set; } = new Point2D(0, 0);
        public Point2D B { get; set; } = new Point2D(0, 0);
        public Color Color { get; set; }
        public bool IsStriped { get; set; }
        public string Text { get; set; }
        public int LineWidth { get; set; }

        public Line(Point2D a, Point2D b, Color color, string text = "", bool isStriped = false, int lineWidth = 2)
        {
            A = a;
            B = b;
            Color = color;
            IsStriped = isStriped;
            Text = text;
            LineWidth = lineWidth;
        }
        public Line(Point2D a, Point2D b)
            : this(a, b, Color.White)
        {

        }
        public Line(double x1, double y1, double x2, double y2)
            : this(new Point2D(x1, y1), new Point2D(x2, y2), Color.White)
        {

        }
        public Line(double x1, double y1, double x2, double y2, Color color, string text = "", bool isStriped = false, int lineWidth = 2)
            : this(new Point2D(x1, y1), new Point2D(x2, y2), color, text, isStriped, lineWidth)
        {

        }
    }
}
