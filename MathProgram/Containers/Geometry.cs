using MathLib.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathProgram.Containers
{
    public static class Geometry
    {
        public static List<IPoints> Points { get; set; } = new List<IPoints>();
        public static List<IFunction> Functions { get; set; } = new List<IFunction>();
        public static List<IShape> Shape { get; set; } = new List<IShape>();
    }
}
