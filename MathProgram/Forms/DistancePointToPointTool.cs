using MathProgram.Interfaces;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathLib;
using MathProgram.Static;
using MathLib.AnalyticalPlaneGeometry;

namespace MathProgram.Forms
{
    public partial class DistancePointToPointForm : DockContent
    {
        private DistancePointToPointTool distanceFormular = new DistancePointToPointTool();

        /* Init & uninit section *********************/
        public DistancePointToPointForm()
        {
            InitializeComponent();

            IC_Main.SetInput(distanceFormular);
            IC_Main.SetIGeometry(distanceFormular);
            distanceFormular.Calculation += OnCalulation;
        }

        public void OnCalulation()
        {
            DC_Calculation.Update(
                distanceFormular.GetLengthCalculation(),
                distanceFormular.GetLengthResult()
            );
        }
    }
}
