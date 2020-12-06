using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Geometry
{
    public interface IPoints : IGeometry
    {
        Point2D[] Points();
    }
}
