using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using MathLib;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.Forms
{
    public partial class FunctionScriptForm : DockContent
    {
        private System.Timers.Timer timer;
        private FunctionScriptTool functionScript = new FunctionScriptTool();

        public FunctionScriptForm()
        {
            InitializeComponent();

            timer = new System.Timers.Timer(500);
            timer.Elapsed += OnTimerElapsed;
            timer.Start();

            TEC_Main.SetHighlighting("C#");
            TEC_Main.Font = new Font("Consolas", 16.0f, FontStyle.Regular);
            CoordinateSystemForm.Program.Geometries.Add(functionScript);
        }

        private void OnTimerElapsed(object sender, ElapsedEventArgs e)
        {
            timer.Stop();
            BeginInvoke(new MethodInvoker(() => 
            {
                if (functionScript.Script != TEC_Main.Text)
                {
                    functionScript.Script = TEC_Main.Text;
                    functionScript.Update();
                    LB_ErrorText.Text = functionScript.ErrorText;
                    CoordinateSystemForm.Program.Update();
                }
            }));
        }

        private void FunctionScriptForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CoordinateSystemForm.Program.Geometries.Remove(functionScript);
        }

        private void TEC_Main_TextChanged(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                timer.Start();
            }
            else
            {
                timer.Stop();
                timer.Start();
            }
        }
    }
}
