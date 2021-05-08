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
    public partial class AngleBetweenTwoVectorsForm : DockContent
    {
        AngleBetweenTwoVectors angleBetweenTwoVectors = new AngleBetweenTwoVectors();

        public AngleBetweenTwoVectorsForm()
        {
            InitializeComponent();

            IC_Main.SetInput(angleBetweenTwoVectors);
            IC_Main.SetGeometry(angleBetweenTwoVectors);
            angleBetweenTwoVectors.Calculation += OnCalulation;
        }

        public void OnCalulation()
        {
            DC_Main.Update(
                angleBetweenTwoVectors.GetAngleCalculation(),
                angleBetweenTwoVectors.GetAngleResult()
            );
        }
    }
}
