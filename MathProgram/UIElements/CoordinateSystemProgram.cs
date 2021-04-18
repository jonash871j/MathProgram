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
using Tao.Platform.Windows;
using static Tao.OpenGl.Gl;
using static Tao.FreeGlut.Glut;

namespace MathProgram.UIElements
{
    public class CoordinateSystemProgram
    {
        public struct Colors
        {
            public Color GraphText;
            public Color DefaultText;
            public Color LargeGrid;
            public Color SmallGrid;
            public Color Background;
            public Color Axis;
            public Color Graph;
            public Color Shape;
        }

        // Coordinates system fields
        public const double GRID_FACTOR = 12.0f;
        private double zoom;
        private double x;
        private double y;
        private double centerX = 0.0f;
        private double centerY = 0.0f;
        private double relX = 0.0f;
        private double relY = 0.0f;
        private double scale = 1.0f;

        // Properties
        #region properties
        public Font Font { get; set; }
        public SimpleOpenGlControl OpenGlControl { get; private set; }
        public List<IGeometry> Geometries { get; private set; }
        public int Width
        {
            get => OpenGlControl.Width;
        }
        public int Height
        {
            get => OpenGlControl.Height;
        }
        public double Zoom
        {
            get => zoom;
            set
            {
                zoom = value;

                if (zoom < 0.003125)
                {
                    zoom = 0.003125;
                }
                if (zoom > 1048576)
                {
                    zoom = 1048576;
                }
            }
        }
        public double ZoomPre { get; private set; }
        public double ZoomXGoto { get; private set; }
        public double ZoomYGoto { get; private set; }
        public double ZoomXTemp { get; private set; }
        public double ZoomYTemp { get; private set; }

        public double X
        {
            get => x;
            set
            {
                x = value;
                relX = -X + centerX;
            }
        }
        public double Y
        {
            get => y;
            set
            {
                y = value;
                relY = Y + centerY;
            }
        }
        public double ActualX
        {
            get { return Math.Round((X / GRID_FACTOR) * Zoom, 2); }
        }
        public double ActualY
        {
            get { return Math.Round((-Y / GRID_FACTOR) * Zoom, 2); }
        }

        public bool IsGridVisible { get; set; } = true;
        public bool IsAxisVisible { get; set; } = true;
        public bool IsGraphsVisible { get; set; } = true;
        public bool IsShapesVisible { get; set; } = true;
        public bool IsPointsVisible { get; set; } = true;

        #endregion

        public Colors color;

        public CoordinateSystemProgram(ref SimpleOpenGlControl simpleOpenGlControl)
        {
            color.GraphText = Color.FromArgb(51, 173, 255);
            color.DefaultText = Color.FromArgb(255, 255, 255);
            color.LargeGrid = Color.FromArgb(48, 48, 48);
            color.SmallGrid = Color.FromArgb(32, 32, 32);
            color.Background = Color.FromArgb(16, 16, 16);
            color.Axis = Color.FromArgb(192, 192, 192);
            color.Graph = Color.FromArgb(64, 128, 64);
            color.Shape = Color.FromArgb(255, 255, 255);

            OpenGlControl = simpleOpenGlControl;
            OpenGlControl.SizeChanged += OnSizeChanged;
            Geometries = new List<IGeometry>();

            Font = new Font(new FontFamily("Segoe UI"), 12.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            Zoom = 0.2;
            X = 0.0;
            Y = 0.0; 
        }

        private void OnSizeChanged(object sender, EventArgs e)
        {
            centerX = Width / 2;
            centerY = Height / 2;
            relX = -X + centerX;
            relY = Y + centerY;
        }

        private void GLBoilerCode()
        {
            glEnable(GL_SCISSOR_TEST);
            glViewport(0, 0, Width, Height);
            glScissor(0, Height, Width, Height);
            glMatrixMode(GL_PROJECTION);
            glLoadIdentity();
            glOrtho(0, Width, 0, Height, -1, 1);
            glMatrixMode(GL_MODELVIEW);
            glDisable(GL_SCISSOR_TEST);
        }
        private void GLDrawLine(double x1, double y1, double x2, double y2, int thickness)
        {
            for (int i = 0; i < thickness; i++)
            {
                glVertex2d(x1, y1 + i);
                glVertex2d(x2, y2 + i);
                glVertex2d(x1 + i, y1);
                glVertex2d(x2 + i, y2);
            }
        }
        private void GLDrawGrid(double gridWidth, double gridHeight, Color color)
        {
            if (IsGridVisible)
            {
                //gridWidth /= Zoom;
                //gridHeight /= Zoom;

                // Sets grid color
                glColor3ub(color.R, color.G, color.B);

                // Draws horizontal grid lines
                for (double y = relY % gridHeight; y < Height; y += gridHeight)
                {
                    // Draws line
                    glVertex2d(0, y);
                    glVertex2d(Width, y);
                }

                // Draws vertical grid lines
                for (double x = relX % gridWidth; x < Width; x += gridWidth)
                {
                    // Draws line
                    glVertex2d(x, 0);
                    glVertex2d(x, Height);
                }
            }
        }
        private void GLDrawAxis()
        {
            if (IsAxisVisible)
            {
                // Sets color
                glColor3ub(color.Axis.R, color.Axis.G, color.Axis.B);

                // Draws y axis
                GLDrawLine(relX, 0.0f, relX, Height, 1);

                // Draws x axis
                GLDrawLine(0.0f, relY, Width, relY, 1);
            }
        }
        private void GLDrawGraph(IFunction function, Color color)
        {
            double lastX = 0.0;
            double lastY = 0.0;

            // Sets graph color
            glColor3ub(color.R, color.G, color.B);

            // Loops throgh each pixel on the x axis
            for (double x = -centerX + X; x < centerX + X; x++)
            {
                // Gets y from math function and 
                // adds additional mathematics for scaling
                double rawY = function.Function(x / scale);
                double y = rawY * scale;

                if (rawY == 0.1254232)
                {
                    lastX = x;
                    lastY = 0;
                    continue;
                }

                // Dont draw if y is zero
                //if (y == 0)
                //    continue;

                // Don't draw the graph line the first loop iteration.
                // This is to avoid bad geometry
                if ((x != -relX) && (lastX != x))
                {
                    // Draws graph line
                    GLDrawLine(relX + x, relY + y, relX + lastX, relY + lastY, 2);
                }

                // Stores current point as last point
                lastX = x;
                lastY = (double)y;
            }
        }
        private void GLDrawPoint(Point2D point)
        {
            double x = relX + point.X * scale;
            double y = relY + point.Y * scale;
            int length = 4;

            glColor3ub(point.Color.R, point.Color.G, point.Color.B);
            for (int i = -length; i < length; i++)
            {
                glVertex2d(x - length, y + i);
                glVertex2d(x + length, y + i);
            }
        }
        private void GLDrawLine(Line line)
        {
            glColor3ub(color.Shape.R, color.Shape.G, color.Shape.B);
            GLDrawLine(
                relX + line.A.X * scale, 
                relY + line.A.Y * scale, 
                relX + line.B.X * scale, 
                relY + line.B.Y * scale, 
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
            glClearColor(0.06f, 0.06f, 0.06f, 1.0f);
            glClear(GL_COLOR_BUFFER_BIT);

            // Begin GL line drawing
            glBegin(GL_LINES);

            // Draws small grid
            GLDrawGrid(
                gridWidth: GRID_FACTOR,
                gridHeight: GRID_FACTOR,
                color: color.SmallGrid
            );

            // Draws large grid
            GLDrawGrid(
                gridWidth: (GRID_FACTOR * 5),
                gridHeight: (GRID_FACTOR * 5),
                color: color.LargeGrid
            );

            // Draws axis
            GLDrawAxis();

            // Draws each graph based on mathematical function
            if (IsGraphsVisible)
            {
                int index = 0;
                foreach (IFunction function in Geometries.OfType<IFunction>())
                {
                    GLDrawGraph(
                       function: function,
                       color: function.Properties.Color
                    );
                    index++;
                }
            }


            // Draws shapes
            if (IsShapesVisible)
            {
                foreach (IShape iShape in Geometries.OfType<IShape>())
                {
                    GLDrawShape(iShape.Shape());
                }
            }

            // Draws points
            if (IsPointsVisible)
            {
                foreach (IPoints iPoints in Geometries.OfType<IPoints>())
                {
                    foreach (Point2D point in iPoints.Points())
                    {
                        GLDrawPoint(point);
                    }
                }
            }

            // End GL drawing
            glEnd();

            // Updates GL window
            OpenGlControl.SwapBuffers();
        }


        /// <summary>
        /// Used to draw text which is for now bound to the CPU
        /// Must be called in Paint event
        /// </summary>
        public void CPUDraw(Graphics graphics)
        {
            void CPUNumberX()
            {
                double wideGridFactor = GRID_FACTOR * 5;
                double offset = relX % wideGridFactor;

                for (double x = (-relX - wideGridFactor) + offset; x < centerX + X + offset; x += wideGridFactor)
                {
                    double number = x / scale;
                    double y = this.y;

                    if (y < -centerY + Font.Height)
                    {
                        y = -centerY + Font.Height;
                    }
                    if (y >= centerY)
                    {
                        y = centerY;
                    }

                    if (Math.Abs(number) != 0)
                    {
                        string numberStr;
                        if (Math.Abs(number) < 100)
                            numberStr = Math.Round(number, 4).ToString();
                        else
                            numberStr = Math.Ceiling(number).ToString();
                        CPUDrawGraphText((int)(relX + x), (int)(centerY - y), numberStr);
                    }
                }
            }
            void CPUNumberY()
            {
                double wideGridFactor = GRID_FACTOR * 5;
                double relY = centerY - Y;
                double offset = relY % wideGridFactor;

                for (double y = (-relY - wideGridFactor) + offset; y < centerY + Y + offset; y += wideGridFactor)
                {
                    double number = -y / scale;
                    double x = this.x;

                    if (x < -centerX + Font.Height)
                    {
                        x = -centerX + Font.Height;
                    }
                    if (x >= centerX)
                    {
                        x = centerX;
                    }

                    if (Math.Abs(number) != 0)
                    {
                        string numberStr;
                        if (Math.Abs(number) < 100)
                            numberStr = Math.Round(number, 4).ToString();
                        else
                            numberStr = Math.Ceiling(number).ToString();

                        CPUDrawGraphText((int)(centerX - x), (int)(relY + y), numberStr);
                    }
                }
            }
            void CPUDrawGraphText(int x, int y, string text)
            {
                graphics.DrawString(
                    text,
                    Font,
                    new SolidBrush(color.GraphText),
                    new Point(
                        x,
                        y
                    )
                 );
            }
            void CPUDrawText(double x, double y, string text)
            {
                string[] lines = text.Split('\n');
                string longest = lines.OrderByDescending(s => s.Length).First();

                graphics.FillRectangle(new SolidBrush(color.Background), new Rectangle(
                    (int)(x * scale - X + centerX) + 4, 
                    (int)(y * -scale - Y + centerY) + 8,
                    longest.Length * 6,
                    lines.Length * 16)
                );
                graphics.DrawString(
                    text,
                    Font,
                        new SolidBrush(color.DefaultText),
                    new Point(
                        (int)(x * scale - X + centerX) + 4,
                        (int)(y * -scale - Y + centerY) + 8
                    )
                 );
            }

            if (IsAxisVisible)
            {
                CPUNumberX();
                CPUNumberY();
            }
            if (IsPointsVisible)
            {
                foreach (IPoints iPoints in Geometries.OfType<IPoints>())
                {
                    foreach (Point2D point in iPoints.Points())
                    {
                        CPUDrawText(point.X, point.Y, point.ToString());
                    }
                }
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
        /// Used to update coordinate system
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
            Zoom = 0.2f;
            ZoomPre = Zoom;
            ZoomXTemp = 0;
            ZoomYTemp = 0;
            OpenGlControl.Refresh();
        }

        public override string ToString()
        {
            return
                $"X: {X}\n" +
                $"Y: {Y}\n" +
                $"ActualX: {ActualX}\n" +
                $"ActualY: {ActualY}\n" +
                $"Zoom: {Zoom}\n" +
                $"ZoomPre: {ZoomPre}\n" +
                $"scale: {scale}\n" +
                $"centerX: {centerX}\n" +
                $"centerY: {centerY}\n" +
                $"ZoomXGoto: {ZoomXGoto}\n" +
                $"ZoomYGoto: {ZoomYGoto}\n" +
                $"ZoomXTemp: {ZoomXTemp}\n" +
                $"ZoomYTemp: {ZoomYTemp}\n";
        }

        public void ChangeZoom(int direction, int mouseX = 0, int mouseY = 0)
        {
            double xBefore = (mouseX - centerX + X) / scale;
            double yBefore = (mouseY - centerY + Y) / scale;

            if (direction > 0)
            {
                Zoom /= 2;
            }
            else
            {
                Zoom += Zoom;
            }

            double xAfter = (mouseX - centerX + X) / (GRID_FACTOR / Zoom);
            double yAfter = (mouseY - centerY + Y) / (GRID_FACTOR / Zoom);

            ZoomXGoto = X + ((xBefore - xAfter) * (GRID_FACTOR / Zoom));
            ZoomYGoto = Y + ((yBefore - yAfter) * (GRID_FACTOR / Zoom));
            ZoomXTemp = X;
            ZoomYTemp = Y;
        }
        public void UpdateScale()
        {
            double UpdateVar(double x, double xPre, double xDelta, double speed = 0.1, double limit = 0.002)
            {
                if (x > xPre)
                {
                    if (x <= xPre + limit)
                    {
                        return x;
                    }
                    return xPre + (speed * xDelta);
                }
                if (x < xPre)
                {
                    if (x >= xPre - limit)
                    {
                        return x;
                    }
                    return xPre - (speed * -xDelta);
                }
                return x;
            }

            double zoomDelta = Zoom - ZoomPre;
            double zoomXDelta = ZoomXGoto - ZoomXTemp;
            double zoomYDelta = ZoomYGoto - ZoomYTemp;

            ZoomXTemp = UpdateVar(ZoomXGoto, ZoomXTemp, zoomXDelta, 0.05, 20);
            ZoomYTemp = UpdateVar(ZoomYGoto, ZoomYTemp, zoomYDelta, 0.05, 20);

            ZoomPre = UpdateVar(Zoom, ZoomPre, zoomDelta, 0.1);

            if (ZoomXTemp == ZoomXGoto && ZoomYTemp == ZoomYGoto && ZoomPre == Zoom)
            {
                X = ZoomXGoto;
                Y = ZoomYGoto;
                scale = GRID_FACTOR / Zoom;
            }
            else
            {
                if (ZoomXTemp != ZoomXGoto) X = ZoomXTemp;
                if (ZoomYTemp != ZoomYGoto) Y = ZoomYTemp;
                if (ZoomPre != Zoom)   scale = GRID_FACTOR / ZoomPre;
            }
       
        }
    }
}