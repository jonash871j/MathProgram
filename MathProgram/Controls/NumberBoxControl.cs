using MathLib;
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
    public partial class NumberBox : UserControl
    {
        private double _value;
        private bool _isReadOnly;

        public static double IncrementValue { get; set; } = 1.0;
        public double Value 
        {
            get => _value;
            set
            {
                _value = value;
                TB_Main.Text = Settings.Limit(Value);
            }
        }
        public bool IsReadOnly
        {
            get => _isReadOnly;
            set
            {
                _isReadOnly = value;
                TB_Main.ReadOnly = value;
                SB_Main.Visible = !value;

                if (IsReadOnly == true)
                {
                    TB_Main.Text = "-";
                    TB_Main.BackColor = Color.FromArgb(240, 240, 240);
                }
                else
                {
                    Value = 0;
                    TB_Main.BackColor = Color.White;
                }
            }
        }
        public event EventHandler NumberChanged;

        public NumberBox()
        {
            InitializeComponent();
        }
        private void NumberBox_Load(object sender, EventArgs e)
        {
            if (IsReadOnly)
            {
                TB_Main.Text = "-";
                TB_Main.BackColor = Color.FromArgb(240, 240, 240);
            }
            else
            {
                TB_Main.BackColor = Color.White;
            }
        }

        private void SB_Main_Scroll(object sender, ScrollEventArgs e)
        {
            int delta = e.OldValue - e.NewValue;

            if (delta > 0)
            {
                Value += IncrementValue;
            }
            if (delta < 0)
            {
                Value -= IncrementValue;
            }
            TB_Main.Text = Settings.Limit(Value);
            TB_Main.SelectionStart = TB_Main.Text.Length;
        }

        private void TB_Main_TextChanged(object sender, EventArgs e)
        {
            if (!IsReadOnly )
            {
                try
                {
                    _value = double.Parse(TB_Main.Text);
                    TB_Main.BackColor = Color.White;
                }
                catch
                {
                    _value = 0.0;
                    TB_Main.BackColor = Color.FromArgb(255, 224, 224);
                }
                NumberChanged?.Invoke(this, e);
            }
        }

        private void TB_Main_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TB_Main.Text))
            {
                Value = 0.0;
            }
            TB_Main.Text = Settings.Limit(Value);
        }
    }
}
