using System;
using System.Collections.Generic;

namespace MathLib.Interfaces
{
    public delegate void CalculationEventHandler();

    public interface ICalculate
    {
        event CalculationEventHandler Calculation;
       
        void Calculate();
    }
}
