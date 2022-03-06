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

        private void InputControl_Load(object sender, EventArgs e)
        {
            ParentForm.FormClosed += OnFormClosed;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (geometry != null)
            {
                AlgebraContainer.Geometries.Remove(geometry);
            }
        }

        public void SetInput(IInput input)
        {
            this.input = input;
            CreateInputBoxes();
        }
        public void SetGeometry(IGeometry geometry)
        {
            this.geometry = geometry;
           AlgebraContainer.Geometries.Add(geometry);
        }

        private void CreateInputBoxesVertical(KeyValuePair<string, double> input, ref int y)
        {
            Label label = new Label();
            label.Location = new Point(8, y);
            label.Text = input.Key;
            y += 16;

            NumberBox numberBox = new NumberBox();
            numberBox.Location = new Point(8, y);
            numberBox.Width = GB_Main.Width - 16;
            numberBox.Name = input.Key;
            numberBox.Value = input.Value;
            numberBox.NumberChanged += OnNumberChanged;
            y += 28;

            GB_Main.Controls.Add(numberBox);
            GB_Main.Controls.Add(label);
        }
        private void CreateInputBoxesGrid(KeyValuePair<string, double> input, ref int i, ref int y)
        {
            int width = GB_Main.Width / GridColumns;
            int x = (i % GridColumns) * width + 8;
            int line = y + (i - (i % GridColumns));

            Label label = new Label();
            label.Location = new Point(x, line + 4);

            label.Text = input.Key;
            label.Width = width - 16;

            NumberBox numberBox = new NumberBox();
            numberBox.Location = new Point(x, line + 16);
            numberBox.Width = width - 16;
            numberBox.Name = input.Key;
            numberBox.Value = input.Value;
            numberBox.NumberChanged += OnNumberChanged;

            GB_Main.Controls.Add(numberBox);
            GB_Main.Controls.Add(label);

            i++;

            if ((i % (GridColumns)) == 0)
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
                    CreateInputBoxesGrid(input, ref i, ref y);
                }
                else
                {
                    CreateInputBoxesVertical(input, ref y);
                }
            }
            GB_Main.Show();
        }

        private void OnNumberChanged(object sender, EventArgs e)
        {
            NumberBox numberBox = (NumberBox)sender;
            input.Contants[numberBox.Name] = numberBox.Value;
            input.Calculate();
        }
    }
}
