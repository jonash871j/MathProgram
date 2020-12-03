using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.StaticContainers
{
    static class VSRender
    {
        public static ThemeBase Theme { get; set; } = new VS2015DarkTheme();
        public static VisualStudioToolStripExtender VSTool { get; set; } = new VisualStudioToolStripExtender();

        public static void SetStyle(ToolStrip toolStrip)
        {
            VSTool.SetStyle(toolStrip, VisualStudioToolStripExtender.VsVersion.Vs2015, Theme);
        }
    }
}
