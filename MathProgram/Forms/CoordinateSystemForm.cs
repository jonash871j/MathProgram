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
using System.Drawing.Drawing2D;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;
using System.Drawing.Text;
using MathProgram.UIElements;

namespace MathProgram.Forms
{
    public partial class CoordinateSystemForm : DockContent
    {
        private GraphProgram graphProgram;
        private Point mouseStart = new Point(0, 0);
        private Point mouseMove = new Point(0, 0);
        private Point coordUpdate = new Point(0, 0);
        private bool isDown = false;

        public CoordinateSystemForm()
        {
            InitializeComponent();
            EnableVSRenderer();
            MouseWheel += new MouseEventHandler(gl_coordinateSystem_MouseWheel);

            graphProgram = new GraphProgram(ref gl_coordinateSystem);
            graphProgram.Functions.Add(x => 5.0 * Math.Sin(x));
            graphProgram.Functions.Add(x => 0.2 * Math.Pow(x, 2) + x);
            graphProgram.Functions.Add(x => x + 4);

            SetSettings();
        }

        private void CoordinateSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        /* Toolbar *******************/

        private void bn_toggleAxis_Click(object sender, EventArgs e)
        {
            UpdateSettings();
        }
        private void bn_toggleGrid_Click(object sender, EventArgs e)
        {
            UpdateSettings();
        }
        private void bn_gotoOrigin_Click(object sender, EventArgs e)
        {
            graphProgram.GotoOrigin();
            coordUpdate = new Point(0, 0);
        }

        /* Graph *********************/



        private void gl_coordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            tb_x.Text = graphProgram.ActualX.ToString();
            tb_y.Text = graphProgram.ActualY.ToString();
            tb_zoom.Text = (graphProgram.Zoom).ToString();

            graphProgram.GLDraw();
            if (!isDown)
            {
                //graphProgram.CPUDraw(e.Graphics);
            }
        }
        private void gl_coordinateSystem_Load(object sender, EventArgs e)
        {
            graphProgram.Load();
        }

        private void gl_coordinateSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                mouseMove = e.Location;
                graphProgram.X = coordUpdate.X + mouseStart.X - mouseMove.X;
                graphProgram.Y = coordUpdate.Y + mouseMove.Y - mouseStart.Y;
                gl_coordinateSystem.Refresh();
            }
        }
        private void gl_coordinateSystem_MouseDown(object sender, MouseEventArgs e)
        {
            mouseStart = e.Location;
            isDown = true;
        }
        private void gl_coordinateSystem_MouseUp(object sender, MouseEventArgs e)
        {
            coordUpdate.X += mouseStart.X - mouseMove.X;
            coordUpdate.Y += mouseMove.Y - mouseStart.Y;
            isDown = false;
            gl_coordinateSystem.Refresh();
        }
        private void gl_coordinateSystem_MouseWheel(object sender, MouseEventArgs e)
        {
            graphProgram.Zoom -= (e.Delta / 1000.0f) * graphProgram.Zoom;
            gl_coordinateSystem.Refresh();
        }

        private void EnableVSRenderer()
        {
            VSRender.SetStyle(ts_main);
        }

        private void SetSettings()
        {
            bn_toggleAxis.Checked = graphProgram.IsAxisVisible;
            bn_toggleGrid.Checked = graphProgram.IsGridVisible;
            gl_coordinateSystem.Refresh();
        }
        private void UpdateSettings()
        {
            graphProgram.IsAxisVisible = bn_toggleAxis.Checked;
            graphProgram.IsGridVisible = bn_toggleGrid.Checked;
            gl_coordinateSystem.Refresh();
        }
    }
}
