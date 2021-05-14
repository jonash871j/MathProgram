using System;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathProgram.StaticContainers;
using MathProgram.Interfaces;
using MathLib;
using MathProgram.Forms.ToolForms;
using System.Drawing;
using MathProgram.Controls;

namespace MathProgram.Forms
{


    public partial class MainForm : Form
    {
        // Link to math formular libary: http://numerator.sourceforge.net/components.php
        private readonly CoordinateSystemForm coordinateSystemForm = new CoordinateSystemForm();

        public static bool IsDebugInformationShown { get; private set; } = false;

        /* Init & uninit section *********************/
        public MainForm()
        {
            InitializeComponent();
            EnableVSRenderer();

            ShowDockForm(coordinateSystemForm, DockState.Document, DockStyle.Fill);
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
        private void MI_CoordSystem_Click(object sender, EventArgs e)       => ShowDockForm(coordinateSystemForm, DockState.Document, DockStyle.Fill);
        private void MI_DebugInfomation_Click(object sender, EventArgs e)   => IsDebugInformationShown = MI_DebugInfomation.Checked;

        /* Tools */
        private void MI_FunctionScript_Click(object sender, EventArgs e)                    => ShowDockForm(new FunctionScriptForm());
        private void MI_QuadraticEquations_Click(object sender, EventArgs e)                => ShowDockForm(new QuadraticEquationsForm());
        private void MI_PointToPoint_Click(object sender, EventArgs e)                      => ShowDockForm(new DistancePointToPointForm());
        private void MI_PointToLine_Click(object sender, EventArgs e)                       => ShowDockForm(new DistancePointToLineForm());
        private void MI_Trigonometry_Click(object sender, EventArgs e)                      => ShowDockForm(new ToolForms.TrigonometryForm());
        private void MI_AngleBetweenTwoVectors_Click(object sender, EventArgs e)            => ShowDockForm(new AngleBetweenTwoVectorsForm());
        private void MI_ProjectionOfVetorOnVector_Click(object sender, EventArgs e)         => ShowDockForm(new ProjectionOfVectorOnVectorForm());
        private void MI_IntersectionPointBeetweenTwoLines_Click(object sender, EventArgs e) => ShowDockForm(new IntersectionPointBeetweenTwoLinesForm());
        private void MI_DotProduct_Click(object sender, EventArgs e)                        => ShowDockForm(new DotProductForm());

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
        private void ShowDockForm(DockContent dockForm, DockState dockState = DockState.DockLeft, DockStyle dockStyle = DockStyle.Left)
        {
            dockForm.Show(DP_Main, dockState);
            dockForm.DockTo(DP_Main, dockStyle);
        }

        private void TB_IncrementValue_Leave(object sender, EventArgs e)
        {
            double value = 1.0;
            if (double.TryParse(TB_IncrementValue.Text, out value))
            {
                TB_IncrementValue.Text = value.ToString();
                NumberBox.IncrementValue = value;
            }
            else
            {
                TB_IncrementValue.Text = "1.0";
                NumberBox.IncrementValue = 1;
            }

        }
    }
}
