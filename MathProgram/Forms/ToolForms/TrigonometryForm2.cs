using MathLib.Tools;
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

namespace MathProgram.Forms.ToolForms
{
    public partial class TrigonometryForm2 : DockContent
    {
        public TrigonometryTool trigonometryTool = new TrigonometryTool();

        public TrigonometryForm2()
        {
            InitializeComponent();
            TIC_Main.SetTrigonometryTool(trigonometryTool);
            trigonometryTool.Calculation += OnCalculation;
        }

        private void OnCalculation()
        {
            GP_Calculation.Text = trigonometryTool.TriangleName;
            TB_Calculation.Text = trigonometryTool.Calculations;
        }
    }
}
