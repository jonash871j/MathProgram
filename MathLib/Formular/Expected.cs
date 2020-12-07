using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Formular
{
    //internal class ExpectedResult
    //{
    //    internal string Name { get; set; }
    //    internal bool IsAbsolute { get; set; }
    //}

    internal class ExpectedResult
    {
        internal string Name { get; set; }
        internal bool IsAbsolute { get; set; }

        internal ExpectedResult(string formular)
        {
            Name = Misc.ReadUntil(formular, '=');
            IsAbsolute = Misc.IfStartsAndEndsWidth(Name, '|');
        }
    }
}
