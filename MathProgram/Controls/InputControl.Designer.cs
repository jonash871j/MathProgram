
namespace MathProgram.Controls
{
    partial class InputControl
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
            this.GB_Main = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // GB_Main
            // 
            this.GB_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GB_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GB_Main.Location = new System.Drawing.Point(0, 0);
            this.GB_Main.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GB_Main.Name = "GB_Main";
            this.GB_Main.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.GB_Main.Size = new System.Drawing.Size(491, 272);
            this.GB_Main.TabIndex = 1;
            this.GB_Main.TabStop = false;
            this.GB_Main.Text = "Input";
            // 
            // InputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.GB_Main);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "InputControl";
            this.Size = new System.Drawing.Size(491, 272);
            this.Load += new System.EventHandler(this.InputControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Main;
    }
}
