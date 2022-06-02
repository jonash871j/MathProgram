namespace MathProgram.Controls
{
    partial class ToggleableNumberBoxControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LB_Title = new System.Windows.Forms.Label();
            this.CB_Toggler = new System.Windows.Forms.CheckBox();
            this.NB_NumberField = new MathProgram.Controls.NumberBox();
            this.SuspendLayout();
            // 
            // LB_Title
            // 
            this.LB_Title.AutoSize = true;
            this.LB_Title.Location = new System.Drawing.Point(19, 12);
            this.LB_Title.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LB_Title.Name = "LB_Title";
            this.LB_Title.Size = new System.Drawing.Size(69, 32);
            this.LB_Title.TabIndex = 5;
            this.LB_Title.Text = "Titel";
            // 
            // CB_Toggler
            // 
            this.CB_Toggler.AutoSize = true;
            this.CB_Toggler.Location = new System.Drawing.Point(24, 57);
            this.CB_Toggler.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.CB_Toggler.Name = "CB_Toggler";
            this.CB_Toggler.Size = new System.Drawing.Size(34, 33);
            this.CB_Toggler.TabIndex = 0;
            this.CB_Toggler.UseVisualStyleBackColor = true;
            this.CB_Toggler.CheckedChanged += new System.EventHandler(this.CB_Toggler_CheckedChanged);
            // 
            // NB_NumberField
            // 
            this.NB_NumberField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NB_NumberField.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.NB_NumberField.IsReadOnly = false;
            this.NB_NumberField.Location = new System.Drawing.Point(80, 38);
            this.NB_NumberField.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.NB_NumberField.Name = "NB_NumberField";
            this.NB_NumberField.Size = new System.Drawing.Size(379, 79);
            this.NB_NumberField.TabIndex = 1;
            this.NB_NumberField.Value = 0D;
            // 
            // ToggleableNumberBoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.LB_Title);
            this.Controls.Add(this.CB_Toggler);
            this.Controls.Add(this.NB_NumberField);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ToggleableNumberBoxControl";
            this.Size = new System.Drawing.Size(467, 114);
            this.Load += new System.EventHandler(this.ToggleableNumberBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Title;
        private System.Windows.Forms.CheckBox CB_Toggler;
        private NumberBox NB_NumberField;
    }
}
