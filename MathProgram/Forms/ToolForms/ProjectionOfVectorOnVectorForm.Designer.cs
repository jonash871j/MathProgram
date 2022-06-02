
namespace MathProgram.Forms
{
    partial class ProjectionOfVectorOnVectorForm
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
            this.DC_Main = new MathProgram.Controls.DefaultCalculationControl();
            this.IC_Main = new MathProgram.Controls.InputControl();
            this.SuspendLayout();
            // 
            // DC_Main
            // 
            this.DC_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_Main.Calulation = "Udregning";
            this.DC_Main.Location = new System.Drawing.Point(600, 29);
            this.DC_Main.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.DC_Main.Name = "DC_Main";
            this.DC_Main.ResultName = "Projektionsvektorens koordinater";
            this.DC_Main.Size = new System.Drawing.Size(875, 489);
            this.DC_Main.TabIndex = 3;
            this.DC_Main.Title = "Projektion af vektor på vektor";
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = false;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(32, 29);
            this.IC_Main.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(552, 489);
            this.IC_Main.TabIndex = 2;
            // 
            // ProjectionOfVectorOnVectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1485, 522);
            this.Controls.Add(this.DC_Main);
            this.Controls.Add(this.IC_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ProjectionOfVectorOnVectorForm";
            this.Text = "Vektorer -> Projektion Af Vektor På Vektor";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DefaultCalculationControl DC_Main;
        private Controls.InputControl IC_Main;
    }
}