using MathProgram.Interfaces;
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
using MathLib;
using MathProgram.Static;

namespace MathProgram.Forms
{
    public partial class DistanceFormularForm : DockContent, IToolForm
    {
        DistanceFormular distanceFormular = new DistanceFormular();

        public DistanceFormularForm()
        {
            InitializeComponent();
            Geometry.Geometries.Add(distanceFormular);
        }
        private void DistanceFormularForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Geometry.Geometries.Remove(distanceFormular);
        }

        public void UpdateTool()
        {
            distanceFormular.X1 = Misc.TextboxParse(tb_x1);
            distanceFormular.X2 = Misc.TextboxParse(tb_x2);
            distanceFormular.Y1 = Misc.TextboxParse(tb_y1);
            distanceFormular.Y2 = Misc.TextboxParse(tb_y2);
            CoordinateSystemForm.GraphProgram.Update();
        }

        private void tb_x1_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
        private void tb_x2_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
        private void tb_y1_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
        private void tb_y2_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
    }
}
