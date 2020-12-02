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
        private float zoom = 1.0f;
        private float x = 0.0f;
        private float y = 0.0f;

        public float X
        {
            get 
            { 
                return x; 
            }
            set
            {
                x = value;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public float Zoom
        {
            get 
            { 
                return zoom; 
            }
            set 
            {
                if (value <= 0.0002f)
                    zoom = 0.0002f;
                else if (value >= 1000.0f)
                    zoom = 1000.0f;
                else
                    zoom = value;

                if ((zoom >= 0.9f) && (zoom < 1.0f))
                    zoom = (float)Math.Round(zoom);
            }
        }

        public SimpleOpenGlControl OpenGlControl { get; private set; }
        public int Width
        {
            get { return OpenGlControl.Width; }
        }
        public int Height
        {
            get { return OpenGlControl.Height; }
        }

        public bool IsGridVisible { get; set; } = true;
        public bool IsOriginVisible { get; set; } = true;
        
        public List<Func<float, float>> Functions { get; set; } = new List<Func<float, float>>();

        public GraphProgram(ref SimpleOpenGlControl simpleOpenGlControl)
        {
            OpenGlControl = simpleOpenGlControl;
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

        private void GLDrawGrid(int gridWidth, int gridHeight, float r, float g, float b)
        {
            if (IsGridVisible)
            {
                // Sets grid color
                Gl.glColor3f(r, g, b);

                // Draws horizontal grid lines
                for (float y = (Y + Height / 2) % gridHeight; y < Height; y += gridHeight)
                {
                    Gl.glVertex2f(0, y);
                    Gl.glVertex2f(Width, y);
                }

                // Draws vertical grid lines
                for (float x = (X + Width / 2) % gridWidth; x < Width; x += gridWidth)
                {
                    Gl.glVertex2f(x, 0);
                    Gl.glVertex2f(x, Height);
                }
            }
        }
        private void GLDrawOrigin()
        {
            if (IsOriginVisible)
            {
                // Sets color
                Gl.glColor3f(0.75f, 0.75f, 0.75f);

                // Draws vertical origin line
                Gl.glVertex2f(X + Width / 2, 0);
                Gl.glVertex2f(X + Width / 2, Height);

                // Draws horizontal origin line
                Gl.glVertex2f(0, Y + Height / 2);
                Gl.glVertex2f(Width, Y + Height / 2);
            }
        }
        private void GLDrawGraph(Func<float, float> function, float r, float g, float b)
        {
            float xPre = 0;
            float yPre = 0;
            bool isFirstIteration = true;

            Gl.glColor3f(r, g, b);
            for (float x = (-Width / 2) - X; x < (Width / 2) - X; x++)
            {
                float y = function(x);

                if (!isFirstIteration)
                {
                    Gl.glVertex2f(X + x + Width / 2, Y + y + Height / 2);
                    Gl.glVertex2f(X + xPre + Width / 2, Y + yPre + Height / 2);
                }

                xPre = x;
                yPre = y;
                isFirstIteration = false;
            }
        }
        public void Draw()
        {
            // Some required GL boiler code
            Gl.glViewport(0, 0, Width, Height);
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Gl.glOrtho(0, Width, 0, Height, -1, 1);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // Clears old content
            Gl.glClearColor(0.06f, 0.06f, 0.06f, 1.0f);
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // Begin GL line drawing
            Gl.glBegin(Gl.GL_LINES);

            GLDrawGrid(12, 12, 0.15f, 0.15f, 0.15f);
            GLDrawGrid(60, 60, 0.20f, 0.20f, 0.20f);
            GLDrawOrigin();

            // Draws each graph based on mathematical function
            foreach (var function in Functions)
            {
                GLDrawGraph(function, 0.5f, 0.25f, 0.25f);
            }

            Gl.glColor3f(0, 1, 0);
            Gl.glBegin(Gl.GL_POINTS);
            Gl.glVertex2f(X * 10, Y * 10);
            Gl.glVertex2f(X * 10 + 10, Y * 10);
            Gl.glVertex2f(X * 10, Y * 10 + 10);
            Gl.glVertex2f(X * 10 + 10, Y * 10 + 10);
            Gl.glPointSize(128.0f);

            // End GL drawing
            Gl.glEnd();

            // Updates GL window
            OpenGlControl.SwapBuffers();
        }

        public void GotoOrigin()
        {
            X = 0;
            Y = 0;
            OpenGlControl.Refresh();
        }
    }
}