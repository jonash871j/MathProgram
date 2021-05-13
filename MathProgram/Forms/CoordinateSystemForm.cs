using System;
using System.Drawing;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using MathProgram.UIElements;
using MathProgram.StaticContainers;
using MathProgram.Interfaces;

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

        public static CoordinateSystemProgram Program { get; private set; }

        /* Init & uninit section *********************/
        public CoordinateSystemForm()
        {
            InitializeComponent();
            EnableVSRenderer();
            MouseWheel += new MouseEventHandler(GL_CoordinateSystem_MouseWheel);
            Program = new CoordinateSystemProgram(ref GL_CoordinateSystem);

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
            Program.GotoOrigin();
            coordUpdate = new Point(0, 0);
        }

        /* Program *********************/
        private void GL_CoordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            TB_X.Text = Program.ActualX.ToString();
            TB_Y.Text = Program.ActualY.ToString();
            TB_Zoom.Text = (Math.Round(Program.Zoom * 5, 3)).ToString();

            Program.GLDraw();

            if (((isLoad) || (!isDown)) && (!isZooming))
            {
                if (isLoad)
                {
                    System.Threading.Thread.Sleep(10);
                    isLoad = false;
                }

                Program.CPUDraw(e.Graphics);
            }
        }
        private void GL_CoordinateSystem_Load(object sender, EventArgs e)
        {
            Program.Load();
        }
        private void GL_CoordinateSystem_MouseMove(object sender, MouseEventArgs e)
        {
            debugMouseMove = e.Location;

            if (isDown)
            {
                mouseMove = e.Location;
                Program.X = coordUpdate.X + mouseStart.X - mouseMove.X;
                Program.Y = coordUpdate.Y - mouseMove.Y + mouseStart.Y;
                GL_CoordinateSystem.Refresh();
            }
        }
        private void GL_CoordinateSystem_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isZooming)
            {
                mouseStart = e.Location;
                isDown = true;
            }
        }
        private void GL_CoordinateSystem_MouseUp(object sender, MouseEventArgs e)
        {
            if(isDown)
            {
                coordUpdate.X += mouseStart.X - mouseMove.X;
                coordUpdate.Y -= mouseMove.Y - mouseStart.Y;
                isDown = false;
                GL_CoordinateSystem.Refresh();
            }
        }
        private void GL_CoordinateSystem_MouseWheel(object sender, MouseEventArgs e)
        {
            if ((isDown == false) && (e.Delta != 0))
            {
                Program.ChangeZoom(e.Delta, e.Location.X, e.Location.Y);
                coordUpdate.X = (int)Program.X;
                coordUpdate.Y = (int)Program.Y;

            }
        }
        private void GL_CoordinateSystem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                BN_GotoOrigin_Click(sender, null);
            }
        }

        /* Additional logic *********************/
        public void SetForm()
        {
            BN_TogglePoints.Checked = Program.IsPointsVisible;
            BN_ToggleShapes.Checked = Program.IsShapesVisible;
            BN_ToggleGraphs.Checked = Program.IsGraphsVisible;
            BN_ToggleAxis.Checked = Program.IsAxisVisible;
            BN_ToggleGrid.Checked = Program.IsGridVisible;
            BN_ToggleTexts.Checked = Program.IsTextsVisible;
            GL_CoordinateSystem.Refresh();
        }
        public void UpdateForm()
        {
            Program.IsPointsVisible = BN_TogglePoints.Checked;
            Program.IsShapesVisible = BN_ToggleShapes.Checked;
            Program.IsGraphsVisible = BN_ToggleGraphs.Checked;
            Program.IsAxisVisible = BN_ToggleAxis.Checked;
            Program.IsGridVisible = BN_ToggleGrid.Checked;
            Program.IsTextsVisible = BN_ToggleTexts.Checked;
            GL_CoordinateSystem.Refresh();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            LB_Debug.Visible = MainForm.IsDebugInformationShown;
            LB_Debug.Text = Program.ToString() + 
                $"MouseX: {debugMouseMove.X}\n" + 
                $"MouseY: {debugMouseMove.Y}";

       
            if (Program.Zoom != Program.ZoomPre)
            {
                isZooming = true;
                Program.UpdateScale();
                GL_CoordinateSystem.Refresh();
            }
            else if (isZooming)
            {
                if (Program.ZoomXGoto != Program.ZoomXTemp || Program.ZoomYGoto != Program.ZoomYTemp)
                {
                    Program.UpdateScale();
                    GL_CoordinateSystem.Refresh();
                }
                else
                {
                    isZooming = false;
                    GL_CoordinateSystem.Refresh();
                    coordUpdate.X = (int)Program.X;
                    coordUpdate.Y = (int)Program.Y;
                }
            }
        }

    }
}