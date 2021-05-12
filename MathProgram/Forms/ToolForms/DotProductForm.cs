using MathLib.Tools.Vector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.Forms
{
    public partial class DotProductForm : DockContent
    {
        private DotProductTool dotProduct = new DotProductTool();

        public DotProductForm()
        {
            InitializeComponent();
            IC_Main.SetGeometry(dotProduct);
            IC_Main.SetInput(dotProduct);
            dotProduct.Calculation += OnCalculation;
            dotProduct.Calculate();
        }

        private void OnCalculation()
        {
            DC_Main.Update(dotProduct.GetDotCalculation(), dotProduct.GetDotResult());
            CoordinateSystemForm.Program.Update();
        }
    }
}
