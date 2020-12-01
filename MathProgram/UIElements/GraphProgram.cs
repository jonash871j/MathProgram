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
        public Point Position = new Point(0, 0);

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
        
        public List<Func<int, int>> Functions { get; set; } = new List<Func<int, int>>();

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

        private void DrawGrid(int gridWidth, int gridHeight, float r, float g, float b)
        {
            if (IsGridVisible)
            {
                // Sets grid color
                Gl.glColor3f(r, g, b);

                // Draws horizontal grid lines
                for (int y = (Position.Y + Height / 2) % gridHeight; y < Height; y += gridHeight)
                {
                    Gl.glVertex2f(0, y);
                    Gl.glVertex2f(Width, y);
                }

                // Draws vertical grid lines
                for (int x = (Position.X + Width / 2) % gridWidth; x < Width; x += gridWidth)
                {
                    Gl.glVertex2f(x, 0);
                    Gl.glVertex2f(x, Height);
                }
            }
        }
        private void DrawOrigin()
        {
            if (IsOriginVisible)
            {
                // Sets color
                Gl.glColor3f(0.75f, 0.75f, 0.75f);

                // Draws vertical origin line
                Gl.glVertex2f(Position.X + Width / 2, 0);
                Gl.glVertex2f(Position.X + Width / 2, Height);

                // Draws horizontal origin line
                Gl.glVertex2f(0, Position.Y + Height / 2);
                Gl.glVertex2f(Width, Position.Y + Height / 2);
            }
        }
        private void DrawGraph(Func<int, int> function, float r, float g, float b)
        {
            int xPre = 0;
            int yPre = 0;
            bool isFirstIteration = true;

            Gl.glColor3f(r, g, b);
            for (int x = (-Width / 2) - Position.X; x < (Width / 2) - Position.X; x++)
            {
                int y = function(x);

                if (!isFirstIteration)
                {
                    Gl.glVertex2f(Position.X + x + Width / 2, Position.Y + y + Height / 2);
                    Gl.glVertex2f(Position.X + xPre + Width / 2, Position.Y + yPre + Height / 2);
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

            DrawGrid(12, 12, 0.15f, 0.15f, 0.15f);
            DrawGrid(60, 60, 0.20f, 0.20f, 0.20f);
            DrawOrigin();

            // Draws each graph based on mathematical function
            foreach (var function in Functions)
            {
                DrawGraph(function, 0.5f, 0.25f, 0.25f);
            }

            // End GL drawing
            Gl.glEnd();

            // Updates GL window
            OpenGlControl.SwapBuffers();
        }

        public void GotoOrigin()
        {
            Position = new Point(0, 0);
            OpenGlControl.Refresh();
        }
    }
}