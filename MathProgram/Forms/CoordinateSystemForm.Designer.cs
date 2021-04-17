
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoordinateSystemForm));
            this.GL_CoordinateSystem = new Tao.Platform.Windows.SimpleOpenGlControl();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.BN_TogglePoints = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleShapes = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleGraphs = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleAxis = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleGrid = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BN_GotoOrigin = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TB_X = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.TB_Y = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.TB_Zoom = new System.Windows.Forms.ToolStripTextBox();
            this.LB_Debug = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.ts_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // GL_CoordinateSystem
            // 
            this.GL_CoordinateSystem.AccumBits = ((byte)(0));
            this.GL_CoordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GL_CoordinateSystem.AutoCheckErrors = false;
            this.GL_CoordinateSystem.AutoFinish = false;
            this.GL_CoordinateSystem.AutoMakeCurrent = true;
            this.GL_CoordinateSystem.AutoSwapBuffers = false;
            this.GL_CoordinateSystem.BackColor = System.Drawing.Color.Black;
            this.GL_CoordinateSystem.ColorBits = ((byte)(32));
            this.GL_CoordinateSystem.DepthBits = ((byte)(16));
            this.GL_CoordinateSystem.Location = new System.Drawing.Point(0, 37);
            this.GL_CoordinateSystem.Name = "GL_CoordinateSystem";
            this.GL_CoordinateSystem.Size = new System.Drawing.Size(680, 238);
            this.GL_CoordinateSystem.StencilBits = ((byte)(0));
            this.GL_CoordinateSystem.TabIndex = 0;
            this.GL_CoordinateSystem.Load += new System.EventHandler(this.GL_CoordinateSystem_Load);
            this.GL_CoordinateSystem.Paint += new System.Windows.Forms.PaintEventHandler(this.GL_CoordinateSystem_Paint);
            this.GL_CoordinateSystem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GL_CoordinateSystem_KeyDown);
            this.GL_CoordinateSystem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GL_CoordinateSystem_MouseDown);
            this.GL_CoordinateSystem.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GL_CoordinateSystem_MouseMove);
            this.GL_CoordinateSystem.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GL_CoordinateSystem_MouseUp);
            // 
            // ts_main
            // 
            this.ts_main.Dock = System.Windows.Forms.DockStyle.None;
            this.ts_main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BN_TogglePoints,
            this.BN_ToggleShapes,
            this.BN_ToggleGraphs,
            this.BN_ToggleAxis,
            this.BN_ToggleGrid,
            this.toolStripSeparator2,
            this.BN_GotoOrigin,
            this.toolStripLabel1,
            this.TB_X,
            this.toolStripLabel2,
            this.TB_Y,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.TB_Zoom});
            this.ts_main.Location = new System.Drawing.Point(0, 3);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(559, 33);
            this.ts_main.TabIndex = 1;
            this.ts_main.Text = "toolStrip1";
            // 
            // BN_TogglePoints
            // 
            this.BN_TogglePoints.CheckOnClick = true;
            this.BN_TogglePoints.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_TogglePoints.Image = ((System.Drawing.Image)(resources.GetObject("BN_TogglePoints.Image")));
            this.BN_TogglePoints.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_TogglePoints.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_TogglePoints.Name = "BN_TogglePoints";
            this.BN_TogglePoints.Size = new System.Drawing.Size(34, 30);
            this.BN_TogglePoints.Text = "Vis/Skjul punkter";
            this.BN_TogglePoints.Click += new System.EventHandler(this.BN_TogglePoints_Click);
            // 
            // BN_ToggleShapes
            // 
            this.BN_ToggleShapes.CheckOnClick = true;
            this.BN_ToggleShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleShapes.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleShapes.Image")));
            this.BN_ToggleShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleShapes.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleShapes.Name = "BN_ToggleShapes";
            this.BN_ToggleShapes.Size = new System.Drawing.Size(34, 32);
            this.BN_ToggleShapes.Text = "Vis/Skjul figurer";
            this.BN_ToggleShapes.Click += new System.EventHandler(this.BN_ToggleShapes_Click);
            // 
            // BN_ToggleGraphs
            // 
            this.BN_ToggleGraphs.CheckOnClick = true;
            this.BN_ToggleGraphs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleGraphs.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleGraphs.Image")));
            this.BN_ToggleGraphs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleGraphs.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleGraphs.Name = "BN_ToggleGraphs";
            this.BN_ToggleGraphs.Size = new System.Drawing.Size(34, 32);
            this.BN_ToggleGraphs.Text = "Vis/Skjul grafer";
            this.BN_ToggleGraphs.Click += new System.EventHandler(this.BN_ToggleGraph_Click);
            // 
            // BN_ToggleAxis
            // 
            this.BN_ToggleAxis.CheckOnClick = true;
            this.BN_ToggleAxis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleAxis.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleAxis.Image")));
            this.BN_ToggleAxis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleAxis.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleAxis.Name = "BN_ToggleAxis";
            this.BN_ToggleAxis.Size = new System.Drawing.Size(34, 32);
            this.BN_ToggleAxis.Text = "Vis/Skjul akse";
            this.BN_ToggleAxis.Click += new System.EventHandler(this.BN_ToggleAxis_Click);
            // 
            // BN_ToggleGrid
            // 
            this.BN_ToggleGrid.CheckOnClick = true;
            this.BN_ToggleGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleGrid.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleGrid.Image")));
            this.BN_ToggleGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleGrid.Name = "BN_ToggleGrid";
            this.BN_ToggleGrid.Size = new System.Drawing.Size(34, 30);
            this.BN_ToggleGrid.Text = "Vis/Skjul gitter";
            this.BN_ToggleGrid.ToolTipText = "Vis/Skjul gitter";
            this.BN_ToggleGrid.Click += new System.EventHandler(this.BN_ToggleGrid_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // BN_GotoOrigin
            // 
            this.BN_GotoOrigin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_GotoOrigin.Image = ((System.Drawing.Image)(resources.GetObject("BN_GotoOrigin.Image")));
            this.BN_GotoOrigin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_GotoOrigin.Name = "BN_GotoOrigin";
            this.BN_GotoOrigin.Size = new System.Drawing.Size(34, 30);
            this.BN_GotoOrigin.Text = "Gå til origo";
            this.BN_GotoOrigin.Click += new System.EventHandler(this.BN_GotoOrigin_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(23, 30);
            this.toolStripLabel1.Text = "X";
            // 
            // TB_X
            // 
            this.TB_X.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TB_X.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_X.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_X.Name = "TB_X";
            this.TB_X.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.TB_X.ReadOnly = true;
            this.TB_X.Size = new System.Drawing.Size(75, 35);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(22, 30);
            this.toolStripLabel2.Text = "Y";
            // 
            // TB_Y
            // 
            this.TB_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TB_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Y.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.ReadOnly = true;
            this.TB_Y.Size = new System.Drawing.Size(75, 35);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(60, 25);
            this.toolStripLabel3.Text = "Zoom";
            // 
            // TB_Zoom
            // 
            this.TB_Zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TB_Zoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Zoom.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_Zoom.Name = "TB_Zoom";
            this.TB_Zoom.ReadOnly = true;
            this.TB_Zoom.Size = new System.Drawing.Size(50, 31);
            // 
            // LB_Debug
            // 
            this.LB_Debug.AutoSize = true;
            this.LB_Debug.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LB_Debug.ForeColor = System.Drawing.Color.Lime;
            this.LB_Debug.Location = new System.Drawing.Point(12, 41);
            this.LB_Debug.Name = "LB_Debug";
            this.LB_Debug.Size = new System.Drawing.Size(61, 23);
            this.LB_Debug.TabIndex = 2;
            this.LB_Debug.Text = "Debug";
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // CoordinateSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(680, 274);
            this.Controls.Add(this.LB_Debug);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.GL_CoordinateSystem);
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

        private Tao.Platform.Windows.SimpleOpenGlControl GL_CoordinateSystem;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton BN_GotoOrigin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TB_X;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TB_Y;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox TB_Zoom;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BN_ToggleGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BN_ToggleAxis;
        private System.Windows.Forms.ToolStripButton BN_ToggleGraphs;
        private System.Windows.Forms.ToolStripButton BN_TogglePoints;
        private System.Windows.Forms.ToolStripButton BN_ToggleShapes;
        private System.Windows.Forms.Label LB_Debug;
        private System.Windows.Forms.Timer Timer;
    }
}