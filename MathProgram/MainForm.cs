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

namespace MathProgram
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
          

            TestForm f1 = new TestForm();
            f1.Show(dp_main, DockState.DockLeft);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
