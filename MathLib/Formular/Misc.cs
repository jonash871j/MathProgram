using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLib.Formular
{
    internal static class Misc
    {
        internal static string RemoveWhitespace(this string input)
        {
            return new string(input.ToCharArray()
                .Where(c => !Char.IsWhiteSpace(c))
                .ToArray());
        }
        internal static string ReadUntil(string input, char stop)
        {
            string output = "";

            foreach(char character in input)
            {
                if (character == stop)
                    break;

                output += character;
            }

            return output;
        }
        internal static string ReadFrom(string input, char start)
        {
            string output = "";

            foreach (char character in input)
            {
                if (character == start)
                    break;

                output += character;
            }

            return output;
        }
        internal static bool IfStartsAndEndsWidth(string input, char character)
        {
            if (input.Length <= 0)
                return false;

            if ((input[0] == character) && (input[input.Length - 1] == character))
                return true;

            return false;
        }
    }
}
