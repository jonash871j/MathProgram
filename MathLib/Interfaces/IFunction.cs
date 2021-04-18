
using System.Drawing;

namespace MathLib.Geometry
{
    public interface IFunction : IGeometry
    {
        Function Properties { get; }
        double Function(double x);
    }
}
