using MathLib.Geometry;
using MathProgram.Static;
using MathProgram.StaticContainers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace MathProgram.UIElements
{
    public class GraphProgram
    {
        public struct Colors
        {
            public Color Text;
            public Color LargeGrid;
            public Color SmallGrid;
            public Color Background;
            public Color Axis;
            public Color Graph;
            public Color Shape;
        }

        // Fields
        private double zoom = 0.5f;
        private double x = 0.0f;
        private double y = 0.0f;
        private SolidBrush textBrush;
        public Colors color;

        public SimpleOpenGlControl OpenGlControl { get; private set; }
        public int Width
        {
            get => OpenGlControl.Width;
        }
        public int Height
        {
            get => OpenGlControl.Height;
        }
        public double X
        {
            get => x;
            set => x = value;
        }
        public double Y
        {
            get => y;
            set => y = value;
        }
        public double ActualX
        {
            get { return Math.Round((X / GridFactor) * Zoom, 2); }
        }
        public double ActualY
        {
            get { return Math.Round((Y / GridFactor) * Zoom, 2); }
        }
        public double GridFactor = 12.0f;
        public double Zoom
        {
            get => zoom;
            set 
            {
                zoom = value;

                if (zoom < 0.001953125)
                {
                    zoom = 0.001953125;
                }
            }
        }
        public bool IsGridVisible { get; set; } = true;
        public bool IsAxisVisible { get; set; } = true;
  
        public Font Font { get; set; }

        public GraphProgram(ref SimpleOpenGlControl simpleOpenGlControl)
        {
            OpenGlControl = simpleOpenGlControl;

            color.Text = Color.FromArgb(51, 173, 255);
            color.LargeGrid = Color.FromArgb(48, 48, 48);
            color.SmallGrid = Color.FromArgb(32, 32, 32);
            color.Background = Color.FromArgb(16, 16, 16);
            color.Axis = Color.FromArgb(192, 192, 192);
            color.Graph = Color.FromArgb(64, 128, 64);
            color.Shape = Color.FromArgb(128, 64, 128);

            Font = new Font(new FontFamily("Microsoft Sans Serif"), 11.5f, FontStyle.Regular, GraphicsUnit.Pixel);
            textBrush = new SolidBrush(color.Text);
        }
        
        private void GLBoilerCode()
        {
            Gl.glViewport(0, 0, Width, Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0, Width, 0, Height, -1, 1);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }
        private void GLDrawLine(double x1, double y1, double x2, double y2, int thickness)
        {
            for (int i = 0; i < thickness; i++)
            {
                Gl.glVertex2d(x1 + i, y1);
                Gl.glVertex2d(x2 + i, y2);
            }
        }
        private void GLDrawGrid(double gridWidth, double gridHeight, Color color)
        {
            if (IsGridVisible)
            {
                gridWidth /= Zoom;
                gridHeight /= Zoom;

                // Sets grid color
                Gl.glColor3ub(color.R, color.G, color.B);

                // Draws horizontal grid lines
                for (double y = (-Y + Height / 2) % gridHeight; y < Height; y += gridHeight)
                {
                    // Draws line
                    Gl.glVertex2d(0, y);
                    Gl.glVertex2d(Width, y);
                }

                // Draws vertical grid lines
                for (double x = (-X + Width / 2) % gridWidth; x < Width; x += gridWidth)
                {
                    // Draws line
                    Gl.glVertex2d(x, 0);
                    Gl.glVertex2d(x, Height);
                }
            }
        }
        private void GLDrawAxis()
        {
            if (IsAxisVisible)
            {
                // Sets color
                Gl.glColor3ub(color.Axis.R, color.Axis.G, color.Axis.B);

                // Draws y axis
                Gl.glVertex2d(
                    x: -X + Width / 2.0, 
                    y: 0.0f
                );
                Gl.glVertex2d(
                    x: -X + Width / 2.0,
                    y: Height
                );

                // Draws x axis
                Gl.glVertex2d(
                    x: 0.0f, 
                    y: -Y + Height / 2.0
                );
                Gl.glVertex2d(
                    x: Width, 
                    y: -Y + Height / 2.0
                );
            }
        }
        private void GLDrawGraph(IFunction function, Color color)
        {
            double centerX = Width / 2;
            double centerY = Height / 2;
            double lastX = 0.0;
            double lastY = 0.0;

            // Sets graph color
            Gl.glColor3ub(color.R, color.G, color.B);

            // Loops throgh each pixel on the x axis
            for (double x = -centerX + X; x < centerX + X; x++)
            {
                // Gets y from math function and 
                // adds additional mathematics for scaling
                double y = function.Function(x / GridFactor * Zoom) * GridFactor / Zoom;

                // Don't draw the graph line the first loop iteration.
                // This is to avoid bad geometry
                if (x != -centerX + X)
                {
                    // Draws graph line
                    GLDrawLine(
                        x1: -X + x + centerX,
                        y1: -Y + y + centerY,
                        x2: -X + lastX + centerX,
                        y2: -Y + lastY + centerY,
                        thickness: 2
                    );
                }

                // Stores current point as last point
                lastX = x;
                lastY = y;
            }
        }
        private void GLDrawPoint(Point2D point)
        {
            double x = -X + (point.X * (GridFactor / Zoom)) + Width / 2;
            double y = -Y + (point.Y * (GridFactor / Zoom)) + Height / 2;
            int length = 6;

            Gl.glColor3ub(255, 0, 0);
            GLDrawLine(x - length, y - length, x + length, y + length, 3);
            GLDrawLine(x + length, y - length, x - length, y + length, 3);
        }
        private void GLDrawLine(Line line)
        {
            double x = -X + Width / 2;
            double y = -Y + Height / 2;

            Gl.glColor3ub(color.Shape.R, color.Shape.G, color.Shape.B);
            GLDrawLine(
                x + (line.A.X * (GridFactor / Zoom)), 
                y + (line.A.Y * (GridFactor / Zoom)), 
                x + (line.B.X * (GridFactor / Zoom)), 
                y + (line.B.Y * (GridFactor / Zoom)), 
                2
            );
        }
        private void GLDrawShape(Shape shape)
        {
            foreach (Line line in shape.Lines)
            {
                GLDrawLine(line);
            }
        }

        /// <summary>
        /// Used to draw coordinate sytem
        /// Must be called in Paint event
        /// </summary>
        public void GLDraw()
        {
            // Some required GL boiler code
            GLBoilerCode();

            // Clears old content
            Gl.glClearColor(0.06f, 0.06f, 0.06f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // Begin GL line drawing
            Gl.glBegin(Gl.GL_LINES);

            // Draws small grid
            GLDrawGrid(
                gridWidth: GridFactor,
                gridHeight: GridFactor,
                color: color.SmallGrid
            );

            // Draws large grid
            GLDrawGrid(
                gridWidth: (GridFactor * 5),
                gridHeight: (GridFactor * 5),
                color: color.LargeGrid
            );

            // Draws axis
            GLDrawAxis();

            // Draws each graph based on mathematical function
            foreach (IFunction iFunction in Geometry.Geometries.OfType<IFunction>())
            {
                GLDrawGraph(
                   function: iFunction,
                   color: color.Graph
                );
            }

            // Draws shapes
            foreach (IShape iShape in Geometry.Geometries.OfType<IShape>())
            {
                GLDrawShape(iShape.Shape());
            }

            // Draws points
            foreach (IPoints iPoints in Geometry.Geometries.OfType<IPoints>())
            {
                foreach (Point2D point in iPoints.Points())
                {
                    GLDrawPoint(point);
                }
            }

            // End GL drawing
            Gl.glEnd();

            // Updates GL window
            OpenGlControl.SwapBuffers();
        }

        /// <summary>
        /// Used to draw text which is for now bound to the CPU
        /// Must be called in Paint event
        /// </summary>
        public void CPUDraw(Graphics graphics)
        {
            if (IsAxisVisible)
            {
                //double centerX = Width / 2;
                //double centerY = Height / 2;

                //// Loops throgh each pixel on the x axis
                //for (double x = -centerX + X; x < centerX + X; x += GridFactor * 5)
                //{
                //    if (x == 0)
                //        continue;
                //    graphics.DrawString(
                //        ((int)(x + X) / 60).ToString(),
                //        Font,
                //        textBrush,
                //        new System.Drawing.Point(
                //            ((int)(-X + x + centerX) - (int)((-X + x + centerX) % 60)),
                //            (int)(0 + y + centerY)
                //        )
                //     );
                //}
            }
        }

        /// <summary>
        /// Used to load gl window
        /// Must be called in Load event
        /// </summary>
        public void Load()
        {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

            if (!isDesignMode)
            {
                OpenGlControl.InitializeContexts();
            }
        }

        /// <summary>
        /// Used to update Graph Program
        /// </summary>
        public void Update()
        {
            OpenGlControl.Refresh();
        }

        /// <summary>
        /// Goes to X: 0, Y: 0 and resets zoom
        /// </summary>
        public void GotoOrigin()
        {
            X = 0;
            Y = 0;
            Zoom = 0.5f;
            OpenGlControl.Refresh();
        }

        public void ChangeZoom(int direction, int mouseX = 0, int mouseY = 0)
        {
            if (direction > 0)
            {
                //X += mouseX - (Width / 2);
                //Y -= mouseY - (Height / 2);
                Zoom -= 0.1 * Zoom;
            }
            else
            {
                //X -= mouseX - (Width / 2);
                //Y += mouseY - (Height / 2);
                Zoom += 0.1 * Zoom;
            }
        }
    }
}