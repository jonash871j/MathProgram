
namespace MathProgram.Forms
{
    partial class DotProductForm
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
            this.IC_Main = new MathProgram.Controls.InputControl();
            this.DC_Main = new MathProgram.Controls.DefaultCalculationControl();
            this.SuspendLayout();
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = false;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(12, 12);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(174, 198);
            this.IC_Main.TabIndex = 0;
            // 
            // DC_Main
            // 
            this.DC_Main.Calulation = "Udregning";
            this.DC_Main.Location = new System.Drawing.Point(205, 12);
            this.DC_Main.Name = "DC_Main";
            this.DC_Main.ResultName = "Resultat";
            this.DC_Main.Size = new System.Drawing.Size(274, 198);
            this.DC_Main.TabIndex = 1;
            this.DC_Main.Title = "Skalarprodukt";
            // 
            // DotProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 222);
            this.Controls.Add(this.DC_Main);
            this.Controls.Add(this.IC_Main);
            this.Name = "DotProductForm";
            this.Text = "DotProductForm";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.InputControl IC_Main;
        private Controls.DefaultCalculationControl DC_Main;
    }
}