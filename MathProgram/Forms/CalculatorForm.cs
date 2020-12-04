using MathLib;
using System;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.Forms
{
    public partial class CalculatorForm : DockContent
    {
        readonly Calculator calculator = new Calculator();

        /* Init & uninit section *********************/
        public CalculatorForm()
        {
            InitializeComponent();
        }

        /* Input section *********************/
        private void TB_Calculation_TextChanged(object sender, EventArgs e)
        {
            try
            {
                calculator.Calculation = TB_Calculation.Text;
                TB_Result.Text = calculator.Result;
            }
            catch
            {

            }
        }
    }
}
