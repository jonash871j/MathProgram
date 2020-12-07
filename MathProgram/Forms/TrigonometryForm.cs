using MathLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace MathProgram.Forms
{
    public partial class TrigonometryForm : DockContent
    {

        Trigonometry program = new Trigonometry();

        public TrigonometryForm()
        {
            InitializeComponent();
        }


        private void input_side_a_TextChanged(object sender, EventArgs e)
        {
            program.SideA = TextboxParse(input_side_a);
            UpdateTrigonometryEquation();
        }

        private void input_side_b_TextChanged(object sender, EventArgs e)
        {
            program.SideB = TextboxParse(input_side_b);
            UpdateTrigonometryEquation();
        }

        private void input_side_c_TextChanged(object sender, EventArgs e)
        {
            program.SideC = TextboxParse(input_side_c);
            UpdateTrigonometryEquation();
        }

        private void input_degree_a_TextChanged(object sender, EventArgs e)
        {
            program.DegreeA = TextboxParse(input_degree_a);
            UpdateTrigonometryEquation();
        }

        private void input_degree_b_TextChanged(object sender, EventArgs e)
        {
            program.DegreeB = TextboxParse(input_degree_b);
            UpdateTrigonometryEquation();
        }

        private void input_degree_c_TextChanged(object sender, EventArgs e)
        {
            program.DegreeC = TextboxParse(input_degree_c);
            UpdateTrigonometryEquation();
        }

        private void Side_UpdateTextBoxes(double value1, double value2, double degree, char isChar)
        {
            tb_tri_function.Text = program.GetCosinusSide_Regulation(value1, value2, degree, isChar);
            tb_result.Text = program.GetCosinusSide_Result(value1, value2, degree).ToString();
        }

        public void UpdateTrigonometryEquation()
        {
            if (program.SideB > 0 && program.SideC > 0 && program.DegreeA > 0)
            {
                Side_UpdateTextBoxes(program.SideB, program.SideC, program.DegreeA, 'a');
            }
            else if (program.SideA > 0 && program.SideC > 0 && program.DegreeB > 0)
            {
                Side_UpdateTextBoxes(program.SideA, program.SideC, program.DegreeB, 'b');
            }
            else if (program.SideA > 0 && program.SideB > 0 && program.DegreeC > 0)
            {
                Side_UpdateTextBoxes(program.SideA, program.SideB, program.DegreeC, 'c');
            }
            else if (program.SideA > 0 && program.SideB > 0 && program.SideC > 0)
            {
                
            }
            else
            {
                tb_tri_function.Text = "Ingen løsning for trigonometri!";
            }
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
