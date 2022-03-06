using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathProgram.StaticContainers;
using MathProgram.Interfaces;
using RendererLib;
using System.ComponentModel;
using System.Threading;

namespace MathProgram.Forms
{
    public partial class CoordinateSystemForm : DockContent, ISetForm
    {
        private Point mouseStart = new Point(0, 0);
        private Point mouseMove = new Point(0, 0);
        private Point debugMouseMove = new Point(0, 0);
        private Point coordUpdate = new Point(0, 0);
        private bool isDown = false;
        private bool isLoad = true;
        private bool isZooming = false;

        /* Init & uninit section *********************/
        public CoordinateSystemForm()
        {
            InitializeComponent();
            EnableVSRenderer();

            SetForm();
        }
        private void CoordinateSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }
        private void EnableVSRenderer()
        {
            VSRender.SetStyle(ts_main);
        }

        /* Toolbar *******************/
        private void BN_TogglePoints_Click(object sender, EventArgs e)  => UpdateForm();
        private void BN_ToggleShapes_Click(object sender, EventArgs e)  => UpdateForm();
        private void BN_ToggleGraph_Click(object sender, EventArgs e)   => UpdateForm();
        private void BN_ToggleAxis_Click(object sender, EventArgs e)    => UpdateForm();
        private void BN_ToggleGrid_Click(object sender, EventArgs e)    => UpdateForm();
        private void BN_ToggleTexts_Click(object sender, EventArgs e)   => UpdateForm();

        private void BN_GotoOrigin_Click(object sender, EventArgs e)
        {
            coordUpdate = new Point(0, 0);
        }

        /* Additional logic *********************/
        public void SetForm()
        {
            //BN_TogglePoints.Checked = Program.IsPointsVisible;
            //BN_ToggleShapes.Checked = Program.IsShapesVisible;
            //BN_ToggleGraphs.Checked = Program.IsFunctionsVisible;
            //BN_ToggleAxis.Checked = Program.IsAxisVisible;
            //BN_ToggleGrid.Checked = Program.IsGridVisible;
            //BN_ToggleTexts.Checked = Program.IsTextsVisible;
        }
        public void UpdateForm()
        {
            //Program.IsPointsVisible = BN_TogglePoints.Checked;
            //Program.IsShapesVisible = BN_ToggleShapes.Checked;
            //Program.IsFunctionsVisible = BN_ToggleGraphs.Checked;
            //Program.IsAxisVisible = BN_ToggleAxis.Checked;
            //Program.IsGridVisible = BN_ToggleGrid.Checked;
            //Program.IsTextsVisible = BN_ToggleTexts.Checked;
        }
    }
}