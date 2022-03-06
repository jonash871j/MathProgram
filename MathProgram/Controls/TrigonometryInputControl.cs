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
using MathLib.Tools;
using MathLib.Tools.Trigonometry;
using MathProgram.Controls;
using MathProgram.Forms;
using MathProgram.Static;

namespace MathProgram.Controls
{
    public partial class TrigonometryInputControl : UserControl
    {
        private TrigonometryTool trigonometry = null;
        private Dictionary<string, ToggleableNumberBoxControl> fields;

        public TrigonometryInputControl()
        {
            InitializeComponent();
            fields = new Dictionary<string, ToggleableNumberBoxControl>()
            {
                { "a", TNB_SiteA },
                { "b", TNB_SiteB },
                { "c", TNB_SiteC },
                { "A", TNB_AngleA },
                { "B", TNB_AngleB },
                { "C", TNB_AngleC },
            };

            foreach (var field in fields)
            {
                field.Value.CheckBoxChanged += OnCheckboxChanged;
                field.Value.NumberChanged += OnNumberChanged;
            }
        }

        private void TrigonometryInputControl_Load(object sender, EventArgs e)
        {
            ParentForm.FormClosed += OnFormClosed;
        }

        public void SetTrigonometryTool(TrigonometryTool trigonometry)
        {
            this.trigonometry = trigonometry;
            this.trigonometry.Calculation += OnCalculation;
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            if (trigonometry != null)
            {
                AlgebraContainer.Geometries.Remove(trigonometry);
            }
        }

        private void OnNumberChanged(object sender, EventArgs e)
        {
            foreach (var field in fields)
            {
                if (!field.Value.IsReadOnly)
                {
                    trigonometry.Constants[field.Key] = field.Value.Value;
                }
                else
                {
                    trigonometry.Constants[field.Key] = 0;
                    field.Value.Value = 0;
                }
            };
            trigonometry.Calculate();
        }

        private void OnCalculation()
        {
            foreach (var field in fields)
            {
                if (field.Value.IsReadOnly)
                {
                    field.Value.Value = trigonometry.Constants[field.Key];
                }
            }
        }

        private void OnCheckboxChanged(object sender, EventArgs e)
        {
            ToggleableNumberBoxControl toggleableNumberBox = (ToggleableNumberBoxControl)sender;
            List<ToggleableNumberBoxControl> fieldList = fields.Values.ToList();

            if (fieldList.FindAll(f => f.IsReadOnly == false).Count > 3)
            {
                toggleableNumberBox.ChangeIsReadOnly(true);
            }

            if (fieldList.FindAll(f => f.Name.Contains("Site") && f.IsReadOnly == false).Count > 2)
            {
                if (toggleableNumberBox.Name.Contains("Site") && fields["C"].Value == 90.0)
                {
                    toggleableNumberBox.ChangeIsReadOnly(true);
                }
            }
            if (fieldList.FindAll(f => f.Name.Contains("Angle") && f.IsReadOnly == false).Count > 2)
            {
                if (toggleableNumberBox.Name.Contains("Angle"))
                {
                    toggleableNumberBox.ChangeIsReadOnly(true);
                }
            }

            foreach (var field in fields)
            {
                if (field.Value.IsReadOnly)
                {
                    trigonometry.Constants[field.Key] = 0;
                    field.Value.Value = 0;
                }
            };
            trigonometry.Calculate();
        }
    }
}
