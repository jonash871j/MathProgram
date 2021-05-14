
namespace MathProgram.Controls
{
    partial class NumberBox
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
            this.TB_Main = new System.Windows.Forms.TextBox();
            this.SB_Main = new System.Windows.Forms.VScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // TB_Main
            // 
            this.TB_Main.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TB_Main.Location = new System.Drawing.Point(3, 5);
            this.TB_Main.Name = "TB_Main";
            this.TB_Main.Size = new System.Drawing.Size(132, 20);
            this.TB_Main.TabIndex = 0;
            this.TB_Main.Text = "0";
            this.TB_Main.TextChanged += new System.EventHandler(this.TB_Main_TextChanged);
            this.TB_Main.Leave += new System.EventHandler(this.TB_Main_Leave);
            // 
            // SB_Main
            // 
            this.SB_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SB_Main.Location = new System.Drawing.Point(134, 0);
            this.SB_Main.Maximum = 99999999;
            this.SB_Main.Minimum = -99999999;
            this.SB_Main.Name = "SB_Main";
            this.SB_Main.Size = new System.Drawing.Size(22, 30);
            this.SB_Main.TabIndex = 1;
            this.SB_Main.Scroll += new System.Windows.Forms.ScrollEventHandler(this.SB_Main_Scroll);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(81, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(55, 30);
            this.panel1.TabIndex = 2;
            // 
            // NumberBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.TB_Main);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SB_Main);
            this.Name = "NumberBox";
            this.Size = new System.Drawing.Size(156, 30);
            this.Load += new System.EventHandler(this.NumberBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Main;
        private System.Windows.Forms.VScrollBar SB_Main;
        private System.Windows.Forms.Panel panel1;
    }
}
