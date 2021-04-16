﻿
namespace MathProgram.Forms
{
    partial class DistancePointToLineForm
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
            this.DC_Calculation = new MathProgram.Controls.DefaultCalculationControl();
            this.IC_Main = new MathProgram.Controls.InputControl();
            this.SuspendLayout();
            // 
            // DC_Calculation
            // 
            this.DC_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DC_Calculation.Calulation = "Udregning";
            this.DC_Calculation.Location = new System.Drawing.Point(236, 9);
            this.DC_Calculation.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.DC_Calculation.Name = "DC_Calculation";
            this.DC_Calculation.ResultName = "Længde";
            this.DC_Calculation.Size = new System.Drawing.Size(284, 151);
            this.DC_Calculation.TabIndex = 1;
            this.DC_Calculation.Title = "Resultat";
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = true;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(9, 9);
            this.IC_Main.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(221, 151);
            this.IC_Main.TabIndex = 0;
            // 
            // DistancePointToLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 164);
            this.Controls.Add(this.DC_Calculation);
            this.Controls.Add(this.IC_Main);
            this.Name = "DistancePointToLineForm";
            this.Text = "Afstand -> Punkt Til Linje (Distanceformlen)";
            this.ResumeLayout(false);

        }

        #endregion


        private Controls.InputControl IC_Main;
        private Controls.DefaultCalculationControl DC_Calculation;
    }
}