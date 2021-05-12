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
            IC_Main.SetInput(dotProduct);
            IC_Main.SetGeometry(dotProduct);
            dotProduct.Calculate();
            dotProduct.Calculation += OnCalculation;
        }

        private void OnCalculation()
        {
            DC_Main.Update(dotProduct.GetDotCalculation(), dotProduct.GetDotResult());
        }
    }
}
