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

namespace MathProgram.Forms
{
    public partial class CoordinateSystemForm : DockContent
    {
        private int xPos = 0;
        private int yPos = 0;
        private Point mouseStart = new Point(0, 0);
        private Point mouseMove = new Point(0, 0);
        private Point coordUpdate = new Point(0, 0);
        private bool isDown = false;

        public CoordinateSystemForm()
        {
            InitializeComponent();
            EnableVSRenderer();
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
            xPos = 0;
            yPos = 0;
            coordUpdate = new Point(0, 0);
            gl_coordinateSystem.Refresh();
        }

        /* Graph *********************/

        Font font = new Font(new FontFamily("Microsoft Sans Serif"), 11.5f, FontStyle.Regular, GraphicsUnit.Pixel);
        SolidBrush fontColor = new SolidBrush(Color.FromArgb(255, 255, 255, 255));

        private void gl_coordinateSystem_Paint(object sender, PaintEventArgs e)
        {
            int width = gl_coordinateSystem.Width;
            int height = gl_coordinateSystem.Height;

            void DrawGrid(float r, float g, float b, int gridWidth, int gridHeight)
            {
                for (int y = (yPos + height / 2) % gridHeight; y < height; y += gridHeight)
                {
                    Gl.glColor3f(r, g, b);
                    Gl.glVertex2f(0, y);
                    Gl.glVertex2f(width, y);
                }
                for (int x = (xPos + width / 2) % gridWidth; x < width; x += gridWidth)
                {
                    Gl.glColor3f(r, g, b);
                    Gl.glVertex2f(x, 0);
                    Gl.glVertex2f(x, height);
                }
            }
            void DrawGraph(Func<int, int> function, float r, float g, float b)
            {
                int xPre = -width / 2;
                int yPre = 0;
                bool isFirstIteration = true;

                Gl.glColor3f(r, g, b);
                for (int x = (-width / 2) - xPos; x < (width / 2) - xPos; x++)
                {
                    int y = function(x);

                    if (!isFirstIteration)
                    {
                        Gl.glVertex2f(xPos + x + width / 2, yPos + y + height / 2);
                        Gl.glVertex2f(xPos + xPre + width / 2, yPos + yPre + height / 2);
                    }

                    xPre = x;
                    yPre = y;
                    isFirstIteration = false;
                }
            }

            Gl.glViewport(0, 0, width, height);

            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0, width, 0, height, -1, 1);

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // Clears old content
            Gl.glClearColor(0.06f, 0.06f, 0.06f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // Begin drawing
            Gl.glBegin(Gl.GL_LINES);

            // Draws grid
            DrawGrid(0.15f, 0.15f, 0.15f, 12, 12);
            DrawGrid(0.20f, 0.20f, 0.20f, 60, 60);

            // Draws origin
            Gl.glLineWidth(32.0f);
            Gl.glColor3f(0.75f, 0.75f, 0.75f);
            Gl.glVertex2f(xPos + width / 2, 0);
            Gl.glVertex2f(xPos + width / 2, height);
            Gl.glVertex2f(0, yPos + height / 2);
            Gl.glVertex2f(width, yPos + height / 2);

            int SineWave(int x)
            {
                return (int)(64.0 * (Math.Sin(x * 0.01) + Math.Sin(x * 0.05)));
            }
            int Parable(int x)
            {
                return (int)(0.2 * Math.Pow(x, 2) + x);
            }
            int Line(int x)
            {
                return (int)(x);
            }

            // Draws graph
            DrawGraph(SineWave, 0.25f, 0.5f, 0.25f);
            DrawGraph(Parable, 0.5f, 0.25f, 0.5f);
            DrawGraph(Line, 0.5f, 0.25f, 0.25f);

            // End drawing
            Gl.glEnd();

            // Update OpenGl window
            gl_coordinateSystem.SwapBuffers();

            // Bad
            if (!isDown)
            {
                for (int x = xPos; x < (width / 2) - xPos; x += 60)
                {
                    if (x == 0)
                        continue;
                    e.Graphics.DrawString(((x - xPos) / 60).ToString(), font, fontColor, new PointF((width / 2) + x, (height / 2) - yPos));
                }
                for (int x = xPos; x > (-width / 2) - xPos; x -= 60)
                {
                    if (x == 0)
                        continue;
                    e.Graphics.DrawString(((x - xPos) / 60).ToString(), font, fontColor, new PointF((width / 2) + x, (height / 2) - yPos));
                }
            }
        }
        private void gl_coordinateSystem_Load(object sender, EventArgs e)
        {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

            if (!isDesignMode)
            {
                gl_coordinateSystem.InitializeContexts();
            }
        }

        private void gl_coordinateSystem_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
            {
                mouseMove = e.Location;
                xPos = coordUpdate.X + mouseMove.X - mouseStart.X;
                yPos = coordUpdate.Y + mouseStart.Y - mouseMove.Y;
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
