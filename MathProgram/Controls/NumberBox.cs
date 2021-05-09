using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProgram.Controls
{
    public partial class NumberBox : UserControl
    {
        public double Value { get; set; }
        public event EventHandler NumberChanged;

        public NumberBox()
        {
            InitializeComponent();
        }

        private void SB_Main_Scroll(object sender, ScrollEventArgs e)
        {
            int delta = e.OldValue - e.NewValue;
            if (delta < 0)
            {
                Value++;
            }
            if (delta > 0)
            {
                Value--;
            }
            TB_Main.Text = Value.ToString();
        }

        private void TB_Main_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Value = double.Parse(TB_Main.Text);
            }
            catch
            {
                Value = 0.0;
            }
            NumberChanged.Invoke(this, e);
        }

        private void TB_Main_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Main.Text))
            {
                Value = 0.0;
                TB_Main.Text = "0";
            }
        }
    }
}
