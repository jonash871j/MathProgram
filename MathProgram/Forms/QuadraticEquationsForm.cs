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

namespace MathProgram.Forms
{
    public partial class QuadraticEquationsForm : DockContent
    {
        QuadraticEquation program = new QuadraticEquation();

        public QuadraticEquationsForm()
        {
            InitializeComponent();
        }

        private void tb_inputA_TextChanged(object sender, EventArgs e)
        {
            UpdateQuadraticEquation();
        }
        private void tb_inputB_TextChanged(object sender, EventArgs e)
        {
            UpdateQuadraticEquation();
        }
        private void tb_inputC_TextChanged(object sender, EventArgs e)
        {
            UpdateQuadraticEquation();
        }

        private void UpdateQuadraticEquation()
        {
            program.A = TextboxParse(tb_inputA);
            program.B = TextboxParse(tb_inputB);
            program.C = TextboxParse(tb_inputC);
            tb_function.Text = program.GetFunctionCalculation();
            tb_dResult.Text = program.D.ToString();
            tb_dCalculation.Text = program.GetDiscriminantCalculation();
        }

        private double TextboxParse(TextBox textBox)
        {
            try
            {
                return double.Parse(textBox.Text);
            }
            catch
            {
                return 0.0;
            }
        }
    }
}
