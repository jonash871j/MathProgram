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
        public string Title 
        {
            get => GB_Title.Text;
            set => GB_Title.Text = value;
        }
        public string Calulation
        {
            get => LB_Calculation.Text;
            set => LB_Calculation.Text = value;
        }
        public string ResultName
        {
            get => LB_ResultName.Text;
            set => LB_ResultName.Text = value;
        }


        public DefaultCalculationControl()
        {
            InitializeComponent();
        }

        public void Update(string calculation, string result)
        {
            TB_Calculation.Text = calculation;
            TB_Result.Text = result;
        }
    }
}
