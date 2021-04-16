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
using MathLib.Trigonometry;

namespace MathProgram.Forms
{
    public partial class TrigonometryForm : DockContent
    {

        TrigonometryManager trigonometryManager = new TrigonometryManager();

        public TrigonometryForm()
        {
            InitializeComponent();
            CoordinateSystemForm.Program.Geometries.Add(trigonometryManager);
        }
        private void TrigonometryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CoordinateSystemForm.Program.Geometries.Remove(trigonometryManager);
        }


        private void input_side_a_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.SideA = TextboxParse(input_side_a);
            UpdateTextBoxes();
        }

        private void input_side_b_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.SideB = TextboxParse(input_side_b);
            UpdateTextBoxes();
        }

        private void input_side_c_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.SideC = TextboxParse(input_side_c);
            UpdateTextBoxes();
        }

        private void input_degree_a_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.DegreeA = TextboxParse(input_degree_a);
            UpdateTextBoxes();
        }

        private void input_degree_b_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.DegreeB = TextboxParse(input_degree_b);
            UpdateTextBoxes();
        }

        private void input_degree_c_TextChanged(object sender, EventArgs e)
        {
            trigonometryManager.DegreeC = TextboxParse(input_degree_c);
            UpdateTextBoxes();
        }

        private void UpdateTextBoxes()
        {
            // Hva fuck er det her?
            string[] calculated = trigonometryManager.Calculate().Split(':');

            if (calculated[0] == "")
            {
                return;
            }

            if (calculated[0] != "Fandt ingen formel der matchede" && calculated[1] != "0")
            {
                tb_tri_function.Text = calculated[0].Replace("#", "\r\n");
                tb_tri_result.Text = calculated[1].Replace("#", "\r\n");
            }
            else
            {
                tb_tri_function.Text = calculated[0];
                tb_tri_result.Text = calculated[1];
            }
            CoordinateSystemForm.Program.Update();
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
