using MathProgram.Interfaces;
using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathLib;
using MathProgram.Static;

namespace MathProgram.Forms
{
    public partial class DistanceFormularForm : DockContent, IUpdateForm
    {
        private readonly DistanceFormular distanceFormular = new DistanceFormular();

        /* Init & uninit section *********************/
        public DistanceFormularForm()
        {
            InitializeComponent();
            CoordinateSystemForm.Program.Geometries.Add(distanceFormular);
        }
        private void DistanceFormularForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoordinateSystemForm.Program.Geometries.Remove(distanceFormular);
        }

        /* Input section *********************/
        private void TB_X1_TextChanged(object sender, EventArgs e) => UpdateForm();
        private void TB_X2_TextChanged(object sender, EventArgs e) => UpdateForm();
        private void TB_Y1_TextChanged(object sender, EventArgs e) => UpdateForm();
        private void TB_Y2_TextChanged(object sender, EventArgs e) => UpdateForm();

        /* Additional logic *********************/
        public void UpdateForm()
        {
            distanceFormular.X1 = Misc.TextboxParse(TB_X1);
            distanceFormular.X2 = Misc.TextboxParse(TB_X2);
            distanceFormular.Y1 = Misc.TextboxParse(TB_Y1);
            distanceFormular.Y2 = Misc.TextboxParse(TB_Y2);
            CoordinateSystemForm.Program.Update();
        }
    }
}
