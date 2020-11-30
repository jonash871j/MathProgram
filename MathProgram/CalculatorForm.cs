using MathLib;
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
    public partial class CalculatorForm : DockContent
    {
        Calculator calculator = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void tb_calculation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculator.Calculation = tb_calculation.Text;
                tb_result.Text = calculator.Result;
            }
            catch
            {

            }
            
        }
    }
}
