
namespace MathProgram.Forms
{
    partial class DistancePointToPointForm
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
            this.DC_Length = new MathProgram.Controls.DefaultCalculationControl();
            this.IC_Main = new MathProgram.Controls.InputControl();
            this.DC_MidPoint = new MathProgram.Controls.DefaultCalculationControl();
            this.SuspendLayout();
            // 
            // DC_Length
            // 
            this.DC_Length.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_Length.Calulation = "Udregning";
            this.DC_Length.Location = new System.Drawing.Point(629, 21);
            this.DC_Length.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.DC_Length.Name = "DC_Length";
            this.DC_Length.ResultName = "Resultat";
            this.DC_Length.Size = new System.Drawing.Size(765, 267);
            this.DC_Length.TabIndex = 3;
            this.DC_Length.Title = "Længde";
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = false;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(24, 21);
            this.IC_Main.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(589, 565);
            this.IC_Main.TabIndex = 2;
            // 
            // DC_MidPoint
            // 
            this.DC_MidPoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_MidPoint.Calulation = "Udregning";
            this.DC_MidPoint.Location = new System.Drawing.Point(629, 322);
            this.DC_MidPoint.Margin = new System.Windows.Forms.Padding(21, 17, 21, 17);
            this.DC_MidPoint.Name = "DC_MidPoint";
            this.DC_MidPoint.ResultName = "Resultat";
            this.DC_MidPoint.Size = new System.Drawing.Size(765, 267);
            this.DC_MidPoint.TabIndex = 4;
            this.DC_MidPoint.Title = "Midtpunkt";
            // 
            // DistancePointToPointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1411, 610);
            this.Controls.Add(this.DC_MidPoint);
            this.Controls.Add(this.DC_Length);
            this.Controls.Add(this.IC_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "DistancePointToPointForm";
            this.Text = "Afstand -> Punkt Til Punkt (Afstandsformlen)";
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.InputControl IC_Main;
        private Controls.DefaultCalculationControl DC_Length;
        private Controls.DefaultCalculationControl DC_MidPoint;
    }
}