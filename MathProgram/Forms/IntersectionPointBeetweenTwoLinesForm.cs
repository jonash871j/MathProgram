using MathLib.Tools.Geometry;
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
    public partial class IntersectionPointBeetweenTwoLinesForm : DockContent
    {
        IntersectionPointBeetweenTwoLinesTool lineLineIntersection = new IntersectionPointBeetweenTwoLinesTool();

        public IntersectionPointBeetweenTwoLinesForm()
        {
            InitializeComponent();

            IC_Main.SetInput(lineLineIntersection);
            IC_Main.SetGeometry(lineLineIntersection);
            lineLineIntersection.Calculation += OnCalulation;
        }

        public void OnCalulation()
        {
            DC_D.Update(
                  lineLineIntersection.GetDCalculation(),
                  lineLineIntersection.GetDResult()
              );
            DC_IntersectionPoint.Update(
                lineLineIntersection.GetIntersectionPointCalculation(),
                lineLineIntersection.GetIntersectionPointResult()
            );
        }
    }
}
