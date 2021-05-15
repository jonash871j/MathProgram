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
using RendererLib;

namespace MathProgram.UIElements
{
    public class CoordinateSystemProgram
    {
        public static class Colors
        {
            //public static Color GraphText = Color.FromArgb(0, 0, 0);
            //public static Color DefaultText = Color.FromArgb(0, 0, 0);
            //public static Color LargeGrid = Color.FromArgb(160, 160, 160);
            //public static Color SmallGrid = Color.FromArgb(192, 192, 192);
            //public static Color Background = Color.FromArgb(255, 255, 255);
            //public static Color Axis = Color.FromArgb(0, 0, 0);

            public static Color GraphText = Color.FromArgb(51, 173, 255);
            public static Color DefaultText = Color.FromArgb(255, 255, 255);
            public static Color LargeGrid = Color.FromArgb(48, 48, 48);
            public static Color SmallGrid = Color.FromArgb(32, 32, 32);
            public static Color Background = Color.FromArgb(16, 16, 16);
            public static Color Axis = Color.FromArgb(192, 192, 192);
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
        public bool IsFunctionsVisible { get; set; } = true;
        public bool IsShapesVisible { get; set; } = true;
        public bool IsPointsVisible { get; set; } = true;
        public bool IsTextsVisible { get; set; } = true;

        #endregion

        public CoordinateSystemProgram(ref SimpleOpenGlControl simpleOpenGlControl)
        {
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

        private void GLDrawPoint(Point2D point)
        {
            Draw.Color(point.Color);
            Draw.Point(relX + point.X * scale, relY + point.Y * scale, 4);
        }
        private void GLDrawLine(Line line)
        {
            Draw.Color(line.Color);
            Draw.Line(
                relX + line.A.X * scale,
                relY + line.A.Y * scale,
                relX + line.B.X * scale,
                relY + line.B.Y * scale,
                2,
                line.IsStriped
            );
        }

        private void GLDrawGrid(double gridWidth, double gridHeight, Color color)
        {
            if (IsGridVisible)
            {
                // Sets grid color
                Draw.Color(color);

                // Draws horizontal grid lines
                for (double y = relY % gridHeight; y < Height; y += gridHeight)
                {
                    Draw.Line(0, y, Width, y, 1);
                }

                // Draws vertical grid lines
                for (double x = relX % gridWidth; x < Width; x += gridWidth)
                {
                    Draw.Line(x, 0, x, Height, 1);
                }
            }
        }
        private void GLDrawAxis()
        {
            if (IsAxisVisible)
            {
                // Sets color
                Draw.Color(Colors.Axis);

                // Draws y axis
                Draw.Line(relX, 0.0f, relX, Height, 1);

                // Draws x axis
                Draw.Line(0.0f, relY, Width, relY, 1);
            }
        }
        private void GLDrawFunction(IFunction function, Color color)
        {
            double lastX = 0.0;
            double lastY = 0.0;

            // Sets graph color
            Draw.Color(color);

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
                    lastY = 0.1254232;
                    continue;
                }

                // Dont draw if y is zero
                //if (y == 0)
                //    continue;

                // Don't draw the graph line the first loop iteration.
                // This is to avoid bad geometry
                if ((x != -relX) && (lastX != x))
                {
                    Draw.Line(relX + x, relY + y, relX + lastX, relY + lastY, 2);
                }

                // Stores current point as last point
                lastX = x;
                lastY = (double)y;
            }
        }

        private void GLDrawFunctions()
        {
            if (IsFunctionsVisible)
            {
                foreach (IFunction function in Geometries.OfType<IFunction>())
                {
                    GLDrawFunction(
                       function: function,
                       color: function.Properties.Color
                    );
                }
            }
        }
        private void GLDrawShapes()
        {
            if (IsShapesVisible)
            {
                foreach (IShape shape in Geometries.OfType<IShape>())
                {
                    foreach (Line line in shape.Shape().Lines)
                    {
                        GLDrawLine(line);
                    }
                }
            }
        }
        private void GLDrawPoints()
        {
            if (IsPointsVisible)
            {
                foreach (IPoints points in Geometries.OfType<IPoints>())
                {
                    foreach (Point2D point in points.Points())
                    {
                        GLDrawPoint(point);
                    }
                }
            }
        }

        /// <summary>
        /// Used to draw coordinate sytem
        /// Must be called in Paint event
        /// </summary>
        public void GLDraw()
        {
            Draw.Setup(Width, Height);
            Draw.Clear(Colors.Background);

            Draw.Begin();
            GLDrawGrid( // Small grid
                gridWidth: GRID_FACTOR,
                gridHeight: GRID_FACTOR,
                color: Colors.SmallGrid
            );
            GLDrawGrid( // Large grid
                gridWidth: (GRID_FACTOR * 5),
                gridHeight: (GRID_FACTOR * 5),
                color: Colors.LargeGrid
            );
            GLDrawAxis();

            GLDrawFunctions();
            GLDrawShapes();
            GLDrawPoints();
            Draw.End();

            OpenGlControl.SwapBuffers(); // Updates GL window
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
                    new SolidBrush(Colors.GraphText),
                    new Point(
                        x,
                        y
                    )
                 );
            }
            void CPUDrawText(double x, double y, string text)
            {
                if (string.IsNullOrEmpty(text))
                {
                    return;
                }

                try
                {
                    string[] lines = text.Split('\n');
                    string longest = lines.OrderByDescending(s => s.Length).First();

                    graphics.FillRectangle(new SolidBrush(Colors.Background), new Rectangle(
                        (int)(x * scale - X + centerX) + 4,
                        (int)(y * -scale - Y + centerY) + 8,
                        longest.Length * 6,
                        lines.Length * 16)
                    );
                    graphics.DrawString(
                        text,
                        Font,
                            new SolidBrush(Colors.DefaultText),
                        new Point(
                            (int)(x * scale - X + centerX) + 4,
                            (int)(y * -scale - Y + centerY) + 8
                        )
                     );
                }
                catch
                {
                }
            }

            if (IsAxisVisible)
            {
                CPUNumberX();
                CPUNumberY();
            }
            if (IsPointsVisible && IsTextsVisible)
            {
                foreach (IPoints points in Geometries.OfType<IPoints>())
                {
                    foreach (Point2D point in points.Points())
                    {
                        CPUDrawText(point.X, point.Y, point.ToString());
                    }
                }
            }
            if (IsShapesVisible && IsTextsVisible)
            {
                foreach (IShape shape in Geometries.OfType<IShape>())
                {
                    foreach (Line line in shape.Shape().Lines)
                    {
                        CPUDrawText((line.B.X + line.A.X) / 2, (line.B.Y + line.A.Y) / 2, line.Text);
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