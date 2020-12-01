
namespace MathProgram.Forms
{
    partial class CoordinateSystemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinateSystemForm));
            this.gl_coordinateSystem = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.bn_gotoOrigin = new System.Windows.Forms.ToolStripButton();
            this.ts_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // gl_coordinateSystem
            // 
            this.gl_coordinateSystem.AccumBits = ((byte)(0));
            this.gl_coordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gl_coordinateSystem.AutoCheckErrors = false;
            this.gl_coordinateSystem.AutoFinish = false;
            this.gl_coordinateSystem.AutoMakeCurrent = true;
            this.gl_coordinateSystem.AutoSwapBuffers = false;
            this.gl_coordinateSystem.BackColor = System.Drawing.Color.Black;
            this.gl_coordinateSystem.ColorBits = ((byte)(32));
            this.gl_coordinateSystem.DepthBits = ((byte)(16));
            this.gl_coordinateSystem.Location = new System.Drawing.Point(0, 25);
            this.gl_coordinateSystem.Name = "gl_coordinateSystem";
            this.gl_coordinateSystem.Size = new System.Drawing.Size(803, 427);
            this.gl_coordinateSystem.StencilBits = ((byte)(0));
            this.gl_coordinateSystem.TabIndex = 0;
            this.gl_coordinateSystem.Load += new System.EventHandler(this.gl_coordinateSystem_Load);
            this.gl_coordinateSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.gl_coordinateSystem_Paint);
            this.gl_coordinateSystem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gl_coordinateSystem_MouseDown);
            this.gl_coordinateSystem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gl_coordinateSystem_MouseMove);
            this.gl_coordinateSystem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gl_coordinateSystem_MouseUp);
            // 
            // ts_main
            // 
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bn_gotoOrigin});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(800, 25);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "toolStrip1";
            // 
            // bn_gotoOrigin
            // 
            this.bn_gotoOrigin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_gotoOrigin.Image = ((System.Drawing.Image)(resources.GetObject("bn_gotoOrigin.Image")));
            this.bn_gotoOrigin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bn_gotoOrigin.Name = "bn_gotoOrigin";
            this.bn_gotoOrigin.Size = new System.Drawing.Size(23, 22);
            this.bn_gotoOrigin.Text = "Gå til origo";
            this.bn_gotoOrigin.Click += new System.EventHandler(this.bn_gotoOrigin_Click);
            // 
            // CoordinateSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.gl_coordinateSystem);
            this.MinimumSize = new System.Drawing.Size(128, 128);
            this.Name = "CoordinateSystemForm";
            this.Text = "Koordinatsystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoordinateSystemForm_FormClosing);
            this.ts_main.ResumeLayout(false);
            this.ts_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tao.Platform.Windows.SimpleOpenGlControl gl_coordinateSystem;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton bn_gotoOrigin;
    }
}