using MathLib;
using MathLib.Geometry;
using MathLib.Interfaces;
using MathProgram.Forms;
using MathProgram.Static;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathProgram.Controls
{
    public partial class InputControl : UserControl
    {
        private IInput input = null;
        private IGeometry geometry = null;

        public bool Grid { get; set; } = false;
        public int GridColumns { get; set; } = 2;

        public InputControl()
        {
            InitializeComponent();
        }
        private void InputControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (geometry != null)
                CoordinateSystemForm.Program.Geometries.Remove(geometry);
        }

        public void SetInput(IInput input)
        {
            this.input = input;
            CreateInputBoxes();
        }
        public void SetIGeometry(IGeometry geometry)
        {
            this.geometry = geometry;
            CoordinateSystemForm.Program.Geometries.Add(geometry);
        }

        private void CreateInputBoxesVertical(string key, ref int y)
        {
            Label label = new Label();
            label.Location = new Point(8, y);
            label.Text = key;
            y += 16;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(8, y);
            textBox.Width = GB_Main.Width - 16;
            textBox.Name = key;
            textBox.TextChanged += OnTextChanged;
            y += 24;

            GB_Main.Controls.Add(textBox);
            GB_Main.Controls.Add(label);
        }
        private void CreateInputBoxesGrid(string key, ref int i, ref int y)
        {
            int width = GB_Main.Width / GridColumns;
            int x = (i % GridColumns) * width + 8;
            int line = y + (i - (i % GridColumns));

            Label label = new Label();
            label.Location = new Point(x, line);

            label.Text = key;
            label.Width = width - 16;

            TextBox textBox = new TextBox();
            textBox.Location = new Point(x, line + 16);
            textBox.Width = width - 16;
            textBox.Name = key;
            textBox.TextChanged += OnTextChanged;

            GB_Main.Controls.Add(textBox);
            GB_Main.Controls.Add(label);

            i++;

            if ((i % (GridColumns+1)) == GridColumns)
            {
                y += 40;
            }
        }
        private void CreateInputBoxes()
        {
            int y = 16;
            int i = 0;

            foreach (var input in input.Contants)
            {
                if (Grid)
                {
                    CreateInputBoxesGrid(input.Key, ref i, ref y);
                }
                else
                {
                    CreateInputBoxesVertical(input.Key, ref y);
                }
            }
            GB_Main.Show();
        }

        private void OnTextChanged(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            input.Contants[textBox.Name] = Misc.TextboxParse(textBox);
            input.Calculate();
            CoordinateSystemForm.Program.Update();
        }
    }
}
