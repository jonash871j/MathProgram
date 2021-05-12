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
    public partial class ProjectionOfVectorOnVectorForm : DockContent
    {
        ProjectionOfVectorOnVectorTool projectionOfVectorOnVector = new ProjectionOfVectorOnVectorTool();

        public ProjectionOfVectorOnVectorForm()
        {
            InitializeComponent();

            IC_Main.SetGeometry(projectionOfVectorOnVector);
            IC_Main.SetInput(projectionOfVectorOnVector);
            projectionOfVectorOnVector.Calculation += OnCalulation;
            projectionOfVectorOnVector.Calculate();
        }

        public void OnCalulation()
        {
            DC_Main.Update(
                projectionOfVectorOnVector.GetProjectionVectorCalculation(),
                projectionOfVectorOnVector.GetProjectionVectorResult()
            );
        }
    }
}
