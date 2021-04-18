using System.Drawing;

namespace MathLib.Geometry
{
    public class Function
    { 
        private static int index = 0;
        private Color[] colors =
        {
           Color.FromArgb(64, 128, 64),
           Color.FromArgb(128, 64, 64),
           Color.FromArgb(64, 128, 128),
           Color.FromArgb(192, 128, 64),
           Color.FromArgb(192, 64, 192),
        };

        public Color Color { get; set; }

        public Function()
        {
            Color = colors[index % colors.Length];
            index++;
        }
    }
}
