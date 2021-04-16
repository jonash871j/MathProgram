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
    public partial class QuadraticEquationsForm : DockContent
    {
        private QuadraticEquationTool quadraticEquation = new QuadraticEquationTool();

        /* Init & uninit section *********************/
        public QuadraticEquationsForm()
        {
            InitializeComponent();

            IC_QuadraticEquations.SetGeometry(quadraticEquation);
            IC_QuadraticEquations.SetInput(quadraticEquation);

            quadraticEquation.Calculation += OnCalulation;
        }

        /* Additional logic *********************/
        public void OnCalulation()
        {
            TB_Function.Text = quadraticEquation.GetFunction();
            TB_Calculations.Text = quadraticEquation.GetCalulations();
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
