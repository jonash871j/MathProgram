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
        ProjectionOfVectorOnVector projectionOfVectorOnVector = new ProjectionOfVectorOnVector();

        public ProjectionOfVectorOnVectorForm()
        {
            InitializeComponent();

            IC_Main.SetInput(projectionOfVectorOnVector);
            IC_Main.SetGeometry(projectionOfVectorOnVector);
            projectionOfVectorOnVector.Calculation += OnCalulation;
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
