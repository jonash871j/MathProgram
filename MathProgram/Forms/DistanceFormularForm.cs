using MathProgram.Interfaces;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathLib;
using MathProgram.Static;
using MathLib.AnalyticalPlaneGeometry;

namespace MathProgram.Forms
{
    public partial class DistanceFormularForm : DockContent
    {
        private DistancePointToPointTool distanceFormular = new DistancePointToPointTool();

        /* Init & uninit section *********************/
        public DistanceFormularForm()
        {
            InitializeComponent();
            CoordinateSystemForm.Program.Geometries.Add(distanceFormular);
            IC_Main.SetInput(distanceFormular);
            distanceFormular.Calculation += OnCalulation;
        }

        public void OnCalulation()
        {
            TB_Calculations.Text = distanceFormular.GetLengthCalculation();
            TB_Result.Text = distanceFormular.GetLengthResult();
        }
    }
}
