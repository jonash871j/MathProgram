
namespace MathProgram.Forms
{
    partial class CalculatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_calculation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Udregning";
            // 
            // tb_calculation
            // 
            this.tb_calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_calculation.Location = new System.Drawing.Point(12, 29);
            this.tb_calculation.Name = "tb_calculation";
            this.tb_calculation.Size = new System.Drawing.Size(308, 20);
            this.tb_calculation.TabIndex = 1;
            this.tb_calculation.TextChanged += new System.EventHandler(this.tb_calculation_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Resultat";
            // 
            // tb_result
            // 
            this.tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_result.Location = new System.Drawing.Point(12, 79);
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(308, 20);
            this.tb_result.TabIndex = 3;
            // 
            // CalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.tb_result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_calculation);
            this.Controls.Add(this.label1);
            this.Name = "CalculatorForm";
            this.Text = "CalculatorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_calculation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_result;
    }
}