using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Interfaces
{
    public interface IInput : ICalculate
    {
        Dictionary<string, double> Contants { get; set; }
    }
}
