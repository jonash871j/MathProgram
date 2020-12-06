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
            IC_Main.SetInput(distanceFormular);
            distanceFormular.Calculation += OnCalulation;
        }

        public void OnCalulation()
        {
            textBox1.Text = distanceFormular.Formular.GetCalulation();
            textBox2.Text = distanceFormular.Formular.GetResult();
        }
    }
}
