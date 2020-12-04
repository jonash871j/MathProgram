using MathLib;
using MathLib.Geometry;
using MathProgram.Static;
using MathProgram.Interfaces;
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
    public partial class QuadraticEquationsForm : DockContent, IToolForm
    {
        private QuadraticEquation quadraticEquation = new QuadraticEquation();

        public QuadraticEquationsForm()
        {
            InitializeComponent();
            quadraticEquation = new QuadraticEquation();

            Geometry.Geometries.Add(quadraticEquation);
        }
        private void QuadraticEquationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Geometry.Geometries.Remove(quadraticEquation);
        }

        private void tb_inputA_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
        private void tb_inputB_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }
        private void tb_inputC_TextChanged(object sender, EventArgs e)
        {
            UpdateTool();
        }

        public void UpdateTool()
        {
            quadraticEquation.A = Misc.TextboxParse(tb_inputA);
            quadraticEquation.B = Misc.TextboxParse(tb_inputB);
            quadraticEquation.C = Misc.TextboxParse(tb_inputC);
            tb_function.Text = quadraticEquation.GetFunction();
            tb_dResult.Text = quadraticEquation.D.ToString();
            tb_dCalculation.Text = quadraticEquation.GetDiscriminantCalculation();
            tb_topPointCalculation.Text = quadraticEquation.GetTopPointCalulation();
            tb_topPointResult.Text = quadraticEquation.GetTopPointResult();
            tb_rootsCaluation.Text = quadraticEquation.GetRootsCalculation();
            tb_root1Caluation.Text = quadraticEquation.GetRootPositiveCalculation();
            tb_root2Caluation.Text = quadraticEquation.GetRootNegativeCalculation();
            tb_rootAmountOfSolutions.Text = quadraticEquation.GetSolutionMessage();
            tb_rootResult.Text = quadraticEquation.GetRootResult();
            CoordinateSystemForm.GraphProgram.Update();
        }
    }
}
