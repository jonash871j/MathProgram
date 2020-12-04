using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProgram.Static
{
    public static class Misc
    {
        public static double TextboxParse(TextBox textBox)
        {
            try
            {
                return double.Parse(textBox.Text);
            }
            catch
            {
                return 0.0;
            }
        }
    }
}
