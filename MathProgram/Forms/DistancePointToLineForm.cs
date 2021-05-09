using MathLib.Distance;
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
    public partial class DistancePointToLineForm : DockContent
    {
        private PointToLineTool distancePointToLine = new PointToLineTool();

        /* Init & uninit section *********************/
        public DistancePointToLineForm()
        {
            InitializeComponent();

            IC_Main.SetInput(distancePointToLine);
            IC_Main.SetGeometry(distancePointToLine);
            distancePointToLine.Calculation += OnCalulation;
            distancePointToLine.Calculate();
        }

        public void OnCalulation()
        {
            DC_Calculation.Update(
                distancePointToLine.GetLengthCalculation(),
                distancePointToLine.GetLengthResult()
            );
            DC_MidPoint.Update(
                distancePointToLine.GetMidPointCalculation(),
                distancePointToLine.GetMidPointResult()
            );
        }
    }
}
