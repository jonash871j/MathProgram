using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Formular
{
    internal class ExpectedResult
    {
        internal string Name { get; set; }
        internal bool IsAbsolute { get; set; }
    }

    internal class ExpectedResults
    {
        internal List<ExpectedResult> Values { get; set; }
        
        internal ExpectedResults(string formular)
        { 
        }
    }
}
