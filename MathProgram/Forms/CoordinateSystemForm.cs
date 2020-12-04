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
using MathProgram.StaticContainers;

namespace MathProgram.Forms
{
    public partial class CoordinateSystemForm : DockContent
    {
        private Point mouseStart = new Point(0, 0);
        private Point mouseMove = new Point(0, 0);
        private Point coordUpdate = new Point(0, 0);
        private bool isDown = false;
        public static GraphProgram GraphProgram { get; set; }

        public CoordinateSystemForm()
        {
            InitializeComponent();
            EnableVSRenderer();
            MouseWheel += new MouseEventHandler(gl_coordinateSystem_MouseWheel);
            GraphProgram = new GraphProgram(ref gl_coordinateSystem);

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
            GraphProgram.GotoOrigin();
            coordUpdate = new Point(0, 0);
        }

        /* Graph *********************/

        private void gl_coordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            tb_x.Text = GraphProgram.ActualX.ToString();
            tb_y.Text = GraphProgram.ActualY.ToString();
            tb_zoom.Text = (GraphProgram.Zoom).ToString();

            GraphProgram.GLDraw();
            if (!isDown)
            {
                GraphProgram.CPUDraw(e.Graphics);
            }
        }
        private void gl_coordinateSystem_Load(object sender, EventArgs e)
        {
            GraphProgram.Load();
        }

        private void gl_coordinateSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                mouseMove = e.Location;
                GraphProgram.X = coordUpdate.X + mouseStart.X - mouseMove.X;
                GraphProgram.Y = coordUpdate.Y + mouseMove.Y - mouseStart.Y;
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
            if (e.Delta != 0)
            {
                GraphProgram.ChangeZoom(e.Delta, e.Location.X, e.Location.Y);
                gl_coordinateSystem.Refresh();
            }
        }

        private void EnableVSRenderer()
        {
            VSRender.SetStyle(ts_main);
        }

        private void SetSettings()
        {
            bn_toggleAxis.Checked = GraphProgram.IsAxisVisible;
            bn_toggleGrid.Checked = GraphProgram.IsGridVisible;
            gl_coordinateSystem.Refresh();
        }
        private void UpdateSettings()
        {
            GraphProgram.IsAxisVisible = bn_toggleAxis.Checked;
            GraphProgram.IsGridVisible = bn_toggleGrid.Checked;
            gl_coordinateSystem.Refresh();
        }
    }
}
