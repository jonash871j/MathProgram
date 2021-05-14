using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathProgram.Controls;

namespace MathProgram.Controls
{
    public partial class ToggleableNumberBoxControl : UserControl
    {
        public string Title
        {
            get => LB_Title.Text;
            set => LB_Title.Text = value;
        }
        public bool IsReadOnly { get => NB_NumberField.IsReadOnly; set => NB_NumberField.IsReadOnly = value; }
        public double Value { get => NB_NumberField.Value; set => NB_NumberField.Value = value; }
        public event EventHandler CheckBoxChanged;
        public event EventHandler NumberChanged;
        
        public ToggleableNumberBoxControl()
        {
            InitializeComponent();
            NB_NumberField.NumberChanged += OnNumberChanged;
        }

        public void ChangeIsReadOnly(bool state)
        {
            IsReadOnly = state;
            CB_Toggler.Checked = !IsReadOnly;
        }

        private void ToggleableNumberBox_Load(object sender, EventArgs e)
        {
            CB_Toggler.Checked = !IsReadOnly;
        }

        private void CB_Toggler_CheckedChanged(object sender, EventArgs e)
        {
            IsReadOnly = !CB_Toggler.Checked;
            CheckBoxChanged?.Invoke(this, e);
        }
        private void OnNumberChanged(object sender, EventArgs e)
        {
            NumberChanged?.Invoke(this, e);
        }
    }
}
