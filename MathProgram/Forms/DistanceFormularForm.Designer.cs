
namespace MathProgram.Forms
{
    partial class DistanceFormularForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TB_Calculations = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // IC_Main
            // 
            this.IC_Main.Grid = false;
            this.IC_Main.GridColumns = 2;
            this.IC_Main.Location = new System.Drawing.Point(13, 14);
            this.IC_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IC_Main.Name = "IC_Main";
            this.IC_Main.Size = new System.Drawing.Size(333, 309);
            this.IC_Main.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox3.Controls.Add(this.TB_Calculations);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.TB_Result);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(353, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(393, 311);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Resultat";
            // 
            // TB_Calculations
            // 
            this.TB_Calculations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Calculations.Location = new System.Drawing.Point(6, 91);
            this.TB_Calculations.Multiline = true;
            this.TB_Calculations.Name = "TB_Calculations";
            this.TB_Calculations.ReadOnly = true;
            this.TB_Calculations.Size = new System.Drawing.Size(381, 51);
            this.TB_Calculations.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Udregning";
            // 
            // TB_Result
            // 
            this.TB_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Result.Location = new System.Drawing.Point(6, 32);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(381, 36);
            this.TB_Result.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lengde";
            // 
            // DistanceFormularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 337);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.IC_Main);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DistanceFormularForm";
            this.Text = "Afstandsformlen";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.InputControl IC_Main;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TB_Calculations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label label6;
    }
}