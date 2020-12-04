
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
            this.bn_toggleAxis = new System.Windows.Forms.ToolStripButton();
            this.bn_toggleGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bn_gotoOrigin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_x = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tb_y = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.tb_zoom = new System.Windows.Forms.ToolStripTextBox();
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
            this.gl_coordinateSystem.Size = new System.Drawing.Size(506, 250);
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
            this.bn_toggleAxis,
            this.bn_toggleGrid,
            this.toolStripSeparator2,
            this.bn_gotoOrigin,
            this.toolStripLabel1,
            this.tb_x,
            this.toolStripLabel2,
            this.tb_y,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.tb_zoom});
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(506, 25);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "toolStrip1";
            // 
            // bn_toggleAxis
            // 
            this.bn_toggleAxis.CheckOnClick = true;
            this.bn_toggleAxis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_toggleAxis.Image = ((System.Drawing.Image)(resources.GetObject("bn_toggleAxis.Image")));
            this.bn_toggleAxis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bn_toggleAxis.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.bn_toggleAxis.Name = "bn_toggleAxis";
            this.bn_toggleAxis.Size = new System.Drawing.Size(23, 22);
            this.bn_toggleAxis.Text = "Vis/Skjul akse";
            this.bn_toggleAxis.Click += new System.EventHandler(this.bn_toggleAxis_Click);
            // 
            // bn_toggleGrid
            // 
            this.bn_toggleGrid.CheckOnClick = true;
            this.bn_toggleGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bn_toggleGrid.Image = ((System.Drawing.Image)(resources.GetObject("bn_toggleGrid.Image")));
            this.bn_toggleGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bn_toggleGrid.Name = "bn_toggleGrid";
            this.bn_toggleGrid.Size = new System.Drawing.Size(23, 22);
            this.bn_toggleGrid.Text = "Vis/Skjul gitter";
            this.bn_toggleGrid.ToolTipText = "Vis/Skjul gitter";
            this.bn_toggleGrid.Click += new System.EventHandler(this.bn_toggleGrid_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(14, 22);
            this.toolStripLabel1.Text = "X";
            // 
            // tb_x
            // 
            this.tb_x.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tb_x.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_x.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_x.Name = "tb_x";
            this.tb_x.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.tb_x.ReadOnly = true;
            this.tb_x.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(14, 22);
            this.toolStripLabel2.Text = "Y";
            // 
            // tb_y
            // 
            this.tb_y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tb_y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_y.ForeColor = System.Drawing.SystemColors.Control;
            this.tb_y.Name = "tb_y";
            this.tb_y.ReadOnly = true;
            this.tb_y.Size = new System.Drawing.Size(75, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(39, 22);
            this.toolStripLabel3.Text = "Zoom";
            // 
            // tb_zoom
            // 
            this.tb_zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tb_zoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_zoom.ForeColor = System.Drawing.SystemColors.Window;
            this.tb_zoom.Name = "tb_zoom";
            this.tb_zoom.ReadOnly = true;
            this.tb_zoom.Size = new System.Drawing.Size(50, 25);
            // 
            // CoordinateSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 274);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.gl_coordinateSystem);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_x;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox tb_y;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox tb_zoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton bn_toggleGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton bn_toggleAxis;
    }
}