
namespace MathProgram.Controls
{
    partial class DefaultCalculationControl
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
            this.GB_Title = new System.Windows.Forms.GroupBox();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.LB_ResultName = new System.Windows.Forms.Label();
            this.TB_Calculation = new System.Windows.Forms.TextBox();
            this.LB_Calculation = new System.Windows.Forms.Label();
            this.GB_Title.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Title
            // 
            this.GB_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Title.Controls.Add(this.TB_Result);
            this.GB_Title.Controls.Add(this.LB_ResultName);
            this.GB_Title.Controls.Add(this.TB_Calculation);
            this.GB_Title.Controls.Add(this.LB_Calculation);
            this.GB_Title.Location = new System.Drawing.Point(0, 0);
            this.GB_Title.Name = "GB_Title";
            this.GB_Title.Size = new System.Drawing.Size(287, 133);
            this.GB_Title.TabIndex = 0;
            this.GB_Title.TabStop = false;
            this.GB_Title.Text = "Titel";
            // 
            // TB_Result
            // 
            this.TB_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Result.Location = new System.Drawing.Point(9, 107);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(272, 20);
            this.TB_Result.TabIndex = 3;
            // 
            // LB_ResultName
            // 
            this.LB_ResultName.AutoSize = true;
            this.LB_ResultName.Location = new System.Drawing.Point(9, 91);
            this.LB_ResultName.Name = "LB_ResultName";
            this.LB_ResultName.Size = new System.Drawing.Size(33, 13);
            this.LB_ResultName.TabIndex = 2;
            this.LB_ResultName.Text = "Navn";
            // 
            // TB_Calculation
            // 
            this.TB_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Calculation.Location = new System.Drawing.Point(9, 32);
            this.TB_Calculation.Multiline = true;
            this.TB_Calculation.Name = "TB_Calculation";
            this.TB_Calculation.ReadOnly = true;
            this.TB_Calculation.Size = new System.Drawing.Size(272, 56);
            this.TB_Calculation.TabIndex = 1;
            // 
            // LB_Calculation
            // 
            this.LB_Calculation.AutoSize = true;
            this.LB_Calculation.Location = new System.Drawing.Point(9, 16);
            this.LB_Calculation.Name = "LB_Calculation";
            this.LB_Calculation.Size = new System.Drawing.Size(56, 13);
            this.LB_Calculation.TabIndex = 0;
            this.LB_Calculation.Text = "Udregning";
            // 
            // DefaultCalculationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GB_Title);
            this.Name = "DefaultCalculationControl";
            this.Size = new System.Drawing.Size(287, 136);
            this.GB_Title.ResumeLayout(false);
            this.GB_Title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Title;
        private System.Windows.Forms.Label LB_Calculation;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label LB_ResultName;
        private System.Windows.Forms.TextBox TB_Calculation;
    }
}
