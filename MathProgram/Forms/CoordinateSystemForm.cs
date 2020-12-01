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

            graphProgram = new GraphProgram(ref gl_coordinateSystem);
            graphProgram.Functions.Add(x => (int)(64.0 * (Math.Sin(x * 0.01) + Math.Sin(x * 0.05))));
            graphProgram.Functions.Add(x => (int)(0.2 * Math.Pow(x, 2) + x));
            graphProgram.Functions.Add(x => x);
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

        private void bn_gotoOrigin_Click(object sender, EventArgs e)
        {
            graphProgram.GotoOrigin();
            coordUpdate = new Point(0, 0);
        }

        /* Graph *********************/

        Font font = new Font(new FontFamily("Microsoft Sans Serif"), 11.5f, FontStyle.Regular, GraphicsUnit.Pixel);
        SolidBrush fontColor = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

        private void gl_coordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            graphProgram.Draw();

            // Bad
            //if (!isDown)
            //{
            //    for (int x = xPos; x < (width / 2) - xPos; x += 60)
            //    {
            //        if (x == 0)
            //            continue;
            //        e.Graphics.DrawString(((x - xPos) / 60).ToString(), font, fontColor, new PointF((width / 2) + x, (height / 2) - yPos));
            //    }
            //    for (int x = xPos; x > (-width / 2) - xPos; x -= 60)
            //    {
            //        if (x == 0)
            //            continue;
            //        e.Graphics.DrawString(((x - xPos) / 60).ToString(), font, fontColor, new PointF((width / 2) + x, (height / 2) - yPos));
            //    }
            //}
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
                graphProgram.Position.X = coordUpdate.X + mouseMove.X - mouseStart.X;
                graphProgram.Position.Y = coordUpdate.Y + mouseStart.Y - mouseMove.Y;
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
            coordUpdate.X += mouseMove.X - mouseStart.X;
            coordUpdate.Y += mouseStart.Y - mouseMove.Y;
            isDown = false;
            gl_coordinateSystem.Refresh();
        }

        private void EnableVSRenderer()
        {
            VSRender.SetStyle(ts_main);
        }
    }
}
