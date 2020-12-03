using MathLib;
using MathLib.Geometry;
using MathProgram.Containers;
using MathProgram.StaticContainers;
using MathProgram.UIElements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.Forms
{
    public partial class QuadraticEquationsForm : DockContent
    {
        private QuadraticEquation quadraticEquation = new QuadraticEquation();

        public QuadraticEquationsForm()
        {
            InitializeComponent();
            quadraticEquation = new QuadraticEquation();

            Geometry.Functions.Add(quadraticEquation);
            Geometry.Points.Add(quadraticEquation);
        }
        private void QuadraticEquationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Geometry.Functions.Remove(quadraticEquation);
            Geometry.Points.Remove(quadraticEquation);
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
            quadraticEquation.A = TextboxParse(tb_inputA);
            quadraticEquation.B = TextboxParse(tb_inputB);
            quadraticEquation.C = TextboxParse(tb_inputC);
            tb_function.Text = quadraticEquation.GetFunctionCalculation();
            tb_dResult.Text = quadraticEquation.D.ToString();
            tb_dCalculation.Text = quadraticEquation.GetDiscriminantCalculation();
            CoordinateSystemForm.GraphProgram.Update();
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
