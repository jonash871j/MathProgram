
namespace MathProgram.Forms.ToolForms
{
    partial class TrigonometryForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TIC_Main = new MathProgram.Controls.TrigonometryInputControl();
            this.GP_Calculation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Calculation = new System.Windows.Forms.TextBox();
            this.GP_Calculation.SuspendLayout();
            this.SuspendLayout();
            // 
            // TIC_Main
            // 
            this.TIC_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIC_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TIC_Main.Location = new System.Drawing.Point(20, 21);
            this.TIC_Main.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.TIC_Main.Name = "TIC_Main";
            this.TIC_Main.Size = new System.Drawing.Size(855, 463);
            this.TIC_Main.TabIndex = 3;
            // 
            // GP_Calculation
            // 
            this.GP_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Calculation.Controls.Add(this.label1);
            this.GP_Calculation.Controls.Add(this.TB_Calculation);
            this.GP_Calculation.Location = new System.Drawing.Point(20, 503);
            this.GP_Calculation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GP_Calculation.Name = "GP_Calculation";
            this.GP_Calculation.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GP_Calculation.Size = new System.Drawing.Size(847, 463);
            this.GP_Calculation.TabIndex = 4;
            this.GP_Calculation.TabStop = false;
            this.GP_Calculation.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Udregning";
            // 
            // TB_Calculation
            // 
            this.TB_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Calculation.Location = new System.Drawing.Point(24, 76);
            this.TB_Calculation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TB_Calculation.Multiline = true;
            this.TB_Calculation.Name = "TB_Calculation";
            this.TB_Calculation.ReadOnly = true;
            this.TB_Calculation.Size = new System.Drawing.Size(800, 366);
            this.TB_Calculation.TabIndex = 0;
            // 
            // TrigonometryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(895, 987);
            this.Controls.Add(this.GP_Calculation);
            this.Controls.Add(this.TIC_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "TrigonometryForm";
            this.Text = "Trigonometri";
            this.GP_Calculation.ResumeLayout(false);
            this.GP_Calculation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TrigonometryInputControl TIC_Main;
        private System.Windows.Forms.GroupBox GP_Calculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Calculation;
    }
}