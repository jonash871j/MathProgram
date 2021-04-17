using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathProgram.StaticContainers;
using MathProgram.Interfaces;
using MathLib;

namespace MathProgram.Forms
{
    public partial class MainForm : Form
    {
        // Link to math formular libary: http://numerator.sourceforge.net/components.php
        private readonly CoordinateSystemForm coordinateSystemForm = new CoordinateSystemForm();

        /* Init & uninit section *********************/
        public MainForm()
        {
            InitializeComponent();
            EnableVSRenderer();

            ShowDockForm(coordinateSystemForm, DockState.Document);
            //ShowDockForm(new DistanceFormularForm(), DockState.DockLeft);
            WindowState = FormWindowState.Maximized;
        }
        private void EnableVSRenderer()
        {
            DP_Main.Theme = VSRender.Theme;
            VSRender.SetStyle(MS_Main);
            VSRender.SetStyle(TS_Main);
            VSRender.SetStyle(SS_Main);
        }

        /* Menubar *********************/
        /* File */
        private void MI_Exit_Click(object sender, EventArgs e) => Close();

        /* View */
        private void MI_CoordSystem_Click(object sender, EventArgs e) => ShowDockForm(coordinateSystemForm, DockState.Document);

        /* Tools */
        private void MI_FunctionScript_Click(object sender, EventArgs e)     => ShowDockForm(new FunctionScriptForm(), DockState.DockLeft);
        private void MI_Calculator_Click(object sender, EventArgs e)         => ShowDockForm(new CalculatorForm(), DockState.DockRight);
        private void MI_QuadraticEquations_Click(object sender, EventArgs e) => ShowDockForm(new QuadraticEquationsForm(), DockState.DockLeft);
        private void MI_PointToPoint_Click(object sender, EventArgs e)       => ShowDockForm(new DistancePointToPointForm(), DockState.DockLeft);
        private void MI_PointToLine_Click(object sender, EventArgs e)        => ShowDockForm(new DistancePointToLineForm(), DockState.DockLeft);
        private void MI_Trigonometry_Click(object sender, EventArgs e)       => ShowDockForm(new TrigonometryForm(), DockState.DockLeft);

        /* Settings */
        private void MI_IsFullscreen_Click(object sender, EventArgs e)
        {
            if (MI_IsFullscreen.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        /* Additional logic *********************/
        private void ShowDockForm(DockContent dockForm, DockState dockState = DockState.Document)
        {
            dockForm.Show(DP_Main, dockState);
        }
    }
}
