using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLib;
using MathLib.Interfaces;

namespace MathProgram.Controls
{
    public partial class DefaultCalculationControl : UserControl
    {
        private IResult iResult = null;

        public string Categorie 
        {
            get => GB_Categorie.Text;
            set => GB_Categorie.Text = value;
        }

        public DefaultCalculationControl()
        {
            InitializeComponent();
        }


        public void SetIResult(IResult iResult)
        {
            this.iResult = iResult;
            this.iResult.Calculation += OnCalculation;
        }

        private void OnCalculation()
        {
            //TB_Calculation.Text = iResult.GetCalculation();
            //TB_Result.Text = iResult.GetResult();
        }
    }
}
