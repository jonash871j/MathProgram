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
    public partial class QuadraticEquationsForm : DockContent, IUpdateForm
    {
        private QuadraticEquation quadraticEquation = new QuadraticEquation();

        /* Init & uninit section *********************/
        public QuadraticEquationsForm()
        {
            InitializeComponent();
            quadraticEquation = new QuadraticEquation();

            CoordinateSystemForm.Program.Geometries.Add(quadraticEquation);
        }
        private void QuadraticEquationsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CoordinateSystemForm.Program.Geometries.Remove(quadraticEquation);
        }

        /* Input section *********************/
        private void TB_InputA_TextChanged(object sender, EventArgs e) => UpdateForm();
        private void TB_InputB_TextChanged(object sender, EventArgs e) => UpdateForm();
        private void TB_InputC_TextChanged(object sender, EventArgs e) => UpdateForm();

        /* Additional logic *********************/
        public void UpdateForm()
        {
            quadraticEquation.A = Misc.TextboxParse(TB_InputA);
            quadraticEquation.B = Misc.TextboxParse(TB_InputB);
            quadraticEquation.C = Misc.TextboxParse(TB_InputC);

            TB_Function.Text = quadraticEquation.GetFunction();
            TB_DResult.Text = quadraticEquation.D.ToString();
            TB_DCalculation.Text = quadraticEquation.GetDiscriminantCalculation();
            TB_TopPointCalculation.Text = quadraticEquation.GetTopPointCalulation();
            TB_TopPointResult.Text = quadraticEquation.GetTopPointResult();
            TB_RootsCaluation.Text = quadraticEquation.GetRootsCalculation();
            TB_Root1Caluation.Text = quadraticEquation.GetRootPositiveCalculation();
            TB_Root2Caluation.Text = quadraticEquation.GetRootNegativeCalculation();
            TB_RootAmountOfSolutions.Text = quadraticEquation.GetSolutionMessage();
            TB_RootResult.Text = quadraticEquation.GetRootResult();

            CoordinateSystemForm.Program.Update();
        }
    }
}
