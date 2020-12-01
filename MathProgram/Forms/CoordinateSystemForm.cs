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

namespace MathProgram.Forms
{
    public partial class CoordinateSystemForm : DockContent
    {
        private Bitmap image;

        public CoordinateSystemForm()
        {
            InitializeComponent();
            image = new Bitmap(pb_coordinateSystem.Width, pb_coordinateSystem.Height);

            UpdateCoordinateSystem();
        }

        private void CoordinateSystemForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void UpdateCoordinateSystem()
        {
            int width = image.Width;
            int height = image.Height;

            Graphics renderer = Graphics.FromImage(image);
            renderer.SmoothingMode = SmoothingMode.AntiAlias;
            renderer.Clear(Color.FromArgb(16, 16, 16));

            Pen penBig = new Pen(Color.FromArgb(255, 192, 192, 192));
            Pen penMedium = new Pen(Color.FromArgb(255, 32, 32, 32));
            Pen penSmall = new Pen(Color.FromArgb(255, 24, 24, 24));
            Pen penFunction = new Pen(Color.FromArgb(255, 64, 127, 64));

            penFunction.Alignment = PenAlignment.Center;
            penFunction.Width = 2;

            CreateGrid(renderer, penSmall, 12, 12);
            CreateGrid(renderer, penMedium, 60, 60);

            renderer.DrawLine(penBig, width / 2, 0, width / 2, height);
            renderer.DrawLine(penBig, 0, height / 2, width, height / 2);

            int xPre = -width / 2;
            int yPre = 0;
            for (int x = -width / 2; x < width / 2; x++)
            {
                int y = (int)(0.01 * Math.Pow(x, 2) + x + 16);
                renderer.DrawLine(
                    penFunction,
                    x + width / 2,
                    y + height / 2,
                    xPre + width / 2,
                    yPre + height / 2
                );
                xPre = x;
                yPre = y;
            }

            pb_coordinateSystem.Image = image;
        }

        private void CreateGrid(Graphics renderer, Pen pen, int gridWidth, int gridHeight)
        {
            int width = image.Width;
            int height = image.Height;

            for (int y = (height / 2) % gridHeight; y < height; y += gridHeight)
            {
                renderer.DrawLine(pen, 0, y, width, y);
            }
            for (int x = (width / 2) % gridWidth; x < width; x += gridWidth)
            {
                renderer.DrawLine(pen, x, 0, x, height);
            }
        }

        private void CoordinateSystemForm_Resize(object sender, EventArgs e)
        {
            image = new Bitmap(pb_coordinateSystem.Width, pb_coordinateSystem.Height);
            UpdateCoordinateSystem();
        }

        private void pb_coordinateSystem_MouseMove(object sender, MouseEventArgs e)
        {
       
        }

        private void pb_coordinateSystem_MouseDown(object sender, MouseEventArgs e)
        {
        
        }

        private void pb_coordinateSystem_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}
