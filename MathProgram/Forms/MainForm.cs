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

namespace MathProgram.Forms
{
    public partial class MainForm : Form
    {
        // Link to math formular libary: http://numerator.sourceforge.net/components.php
        private CoordinateSystemForm coordinateSystemForm = new CoordinateSystemForm();
        private bool isFullscreen = false;

        public MainForm()
        {
            InitializeComponent();
            EnableVSRenderer();
            WindowState = FormWindowState.Maximized;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
         
        }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mi_coordSystem_Click(object sender, EventArgs e)
        {
            ShowDockForm(coordinateSystemForm, DockState.Document);
        }
        private void mi_calculator_Click(object sender, EventArgs e)
        {
            ShowDockForm(new CalculatorForm(), DockState.DockRight);
        }
        private void mi_quadraticEquations_Click(object sender, EventArgs e)
        {
            ShowDockForm(new QuadraticEquationsForm(), DockState.DockLeft);
        }

        private void mi_isFullscreen_Click(object sender, EventArgs e)
        {
            if (mi_isFullscreen.Checked)
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Normal;
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                TopMost = false;
                FormBorderStyle = FormBorderStyle.Sizable;
            }
        }

        private void ShowDockForm(DockContent dockForm, DockState dockState = DockState.Document)
        {
            dockForm.Show(dp_main, dockState);
        }

        private void EnableVSRenderer()
        {
            dp_main.Theme = VSRender.Theme;
            VSRender.SetStyle(ms_main);
            VSRender.SetStyle(ss_main);
        }
    }
}
