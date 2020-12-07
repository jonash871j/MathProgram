using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib.Formular
{
    internal class Parentheses
    {
        internal Parentheses ParenthesesInner { get; set; } = null;
        internal int Start { get; set; } = 0;
        internal int End { get; set; } = 0;

        internal Parentheses(string input, int start)
        {
            Start = start;
            FindEnd(input);
        }

        internal void FindEnd(string input)
        {
            for (int i = Start; i < input.Length; i++)
            {
                if (input[i] == ')')
                {
                    End = i;
                    break;
                }
                if (input[i] == '(')
                {
                    ParenthesesInner = new Parentheses(input, i);
                    i = ParenthesesInner.End;
                }
            }
            if (End == 0)
            {
                Console.WriteLine("Erorr");
            }    
        }
    }
}
