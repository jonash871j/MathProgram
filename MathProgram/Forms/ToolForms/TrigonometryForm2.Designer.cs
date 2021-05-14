
namespace MathProgram.Forms.ToolForms
{
    partial class TrigonometryForm2
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
            this.GP_Calculation = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_Calculation = new System.Windows.Forms.TextBox();
            this.TIC_Main = new MathProgram.Controls.TrigonometryInputControl();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.GP_Calculation.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GP_Calculation
            // 
            this.GP_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GP_Calculation.Controls.Add(this.label1);
            this.GP_Calculation.Controls.Add(this.TB_Calculation);
            this.GP_Calculation.Location = new System.Drawing.Point(309, 3);
            this.GP_Calculation.Name = "GP_Calculation";
            this.GP_Calculation.Size = new System.Drawing.Size(300, 194);
            this.GP_Calculation.TabIndex = 1;
            this.GP_Calculation.TabStop = false;
            this.GP_Calculation.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Udregning";
            // 
            // TB_Calculation
            // 
            this.TB_Calculation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Calculation.Location = new System.Drawing.Point(9, 32);
            this.TB_Calculation.Multiline = true;
            this.TB_Calculation.Name = "TB_Calculation";
            this.TB_Calculation.ReadOnly = true;
            this.TB_Calculation.Size = new System.Drawing.Size(285, 156);
            this.TB_Calculation.TabIndex = 0;
            // 
            // TIC_Main
            // 
            this.TIC_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TIC_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TIC_Main.Location = new System.Drawing.Point(4, 5);
            this.TIC_Main.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TIC_Main.Name = "TIC_Main";
            this.TIC_Main.Size = new System.Drawing.Size(298, 194);
            this.TIC_Main.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.TIC_Main, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GP_Calculation, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(612, 206);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TrigonometryForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(636, 229);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "TrigonometryForm2";
            this.Text = "TrigonometryForm2";
            this.GP_Calculation.ResumeLayout(false);
            this.GP_Calculation.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.TrigonometryInputControl TIC_Main;
        private System.Windows.Forms.GroupBox GP_Calculation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_Calculation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}