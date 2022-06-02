
namespace MathProgram.Forms
{
    partial class IntersectionPointBeetweenTwoLinesForm
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
            this.DC_D = new MathProgram.Controls.DefaultCalculationControl();
            this.DC_IntersectionPoint = new MathProgram.Controls.DefaultCalculationControl();
            this.IC_Main = new MathProgram.Controls.InputControl();
            this.SuspendLayout();
            // 
            // DC_D
            // 
            this.DC_D.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_D.Calulation = "Udregning";
            this.DC_D.Location = new System.Drawing.Point(600, 29);
            this.DC_D.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.DC_D.Name = "DC_D";
            this.DC_D.ResultName = "Resultat";
            this.DC_D.Size = new System.Drawing.Size(813, 484);
            this.DC_D.TabIndex = 4;
            this.DC_D.Title = "D";
            // 
            // DC_IntersectionPoint
            // 
            this.DC_IntersectionPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_IntersectionPoint.Calulation = "Udregning";
            this.DC_IntersectionPoint.Location = new System.Drawing.Point(32, 527);
            this.DC_IntersectionPoint.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.DC_IntersectionPoint.Name = "DC_IntersectionPoint";
            this.DC_IntersectionPoint.ResultName = "Resultat";
            this.DC_IntersectionPoint.Size = new System.Drawing.Size(1381, 329);
            this.DC_IntersectionPoint.TabIndex = 3;
            this.DC_IntersectionPoint.Title = "Krydspunkt";
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = true;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(32, 29);
            this.IC_Main.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(552, 484);
            this.IC_Main.TabIndex = 2;
            // 
            // IntersectionPointBeetweenTwoLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1445, 887);
            this.Controls.Add(this.DC_D);
            this.Controls.Add(this.DC_IntersectionPoint);
            this.Controls.Add(this.IC_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "IntersectionPointBeetweenTwoLinesForm";
            this.Text = "Geometri -> Krydspunkt Mellem To Linjer";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.DefaultCalculationControl DC_IntersectionPoint;
        private Controls.InputControl IC_Main;
        private Controls.DefaultCalculationControl DC_D;
    }
}