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
          

           
        }

        private void mi_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lommeregnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            CalculatorForm form = new CalculatorForm();
            form.Show(dp_main, DockState.Document);
        }
    }
}
