
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
            this.GB_Categorie = new System.Windows.Forms.GroupBox();
            this.TB_Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Calculation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GB_Categorie.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_Categorie
            // 
            this.GB_Categorie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Categorie.Controls.Add(this.TB_Result);
            this.GB_Categorie.Controls.Add(this.label2);
            this.GB_Categorie.Controls.Add(this.TB_Calculation);
            this.GB_Categorie.Controls.Add(this.label1);
            this.GB_Categorie.Location = new System.Drawing.Point(0, 0);
            this.GB_Categorie.Name = "GB_Categorie";
            this.GB_Categorie.Size = new System.Drawing.Size(287, 133);
            this.GB_Categorie.TabIndex = 0;
            this.GB_Categorie.TabStop = false;
            this.GB_Categorie.Text = "Unnamed";
            // 
            // TB_Result
            // 
            this.TB_Result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Result.Location = new System.Drawing.Point(9, 107);
            this.TB_Result.Multiline = true;
            this.TB_Result.Name = "TB_Result";
            this.TB_Result.ReadOnly = true;
            this.TB_Result.Size = new System.Drawing.Size(275, 20);
            this.TB_Result.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultat";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Udregning";
            // 
            // DefaultCalculationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GB_Categorie);
            this.Name = "DefaultCalculationControl";
            this.Size = new System.Drawing.Size(287, 136);
            this.GB_Categorie.ResumeLayout(false);
            this.GB_Categorie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Categorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Calculation;
    }
}
