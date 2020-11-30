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

        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            dp_main.Theme = new VS2015DarkTheme();
         }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lommeregnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDockForm(new CalculatorForm(), DockState.DockRight);
        }

        private void mi_quadraticEquations_Click(object sender, EventArgs e)
        {
            ShowDockForm(new QuadraticEquationsForm(), DockState.DockLeft);
        }

        void ShowDockForm(DockContent dockForm, DockState dockState = DockState.Document)
        {
            dockForm.Show(dp_main, dockState);
        }
    }
}
