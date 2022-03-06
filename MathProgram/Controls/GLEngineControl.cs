using RendererLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProgram.Controls
{
    public unsafe partial class GLEngineControl : UserControl
    {
        private static bool isInitialized = false;
        private bool isResize = false;
        private CoordinateSystem coordinateSystem;

        public GLEngineControl()
        {
            InitializeComponent();

       
        }

        private void GLEngineControl_Resize(object sender, EventArgs e)
        {
            isResize = true;
        }

        private void GLEngineControl_Paint(object sender, PaintEventArgs e)
        {
            bool isDesignMode = LicenseManager.UsageMode == LicenseUsageMode.Designtime;

            if (!isDesignMode && !isInitialized)
            {
                isInitialized = true;
                void* ptr = Handle.ToPointer();
                Thread t = new Thread(() =>
                {
                    coordinateSystem = new CoordinateSystem(ptr, Width, Height);
                    while (true)
                    {
                        coordinateSystem.Logic();

                        if (isResize)
                        {
                            coordinateSystem.Resize(Width, Height);
                            isResize = false;
                        }
                    }
                });
                t.Start();
            }
        }
    }
}
