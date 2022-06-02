﻿
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.glEngineControl1 = new MathProgram.Controls.GLEngineControl();
            this.ts_main = new System.Windows.Forms.ToolStrip();
            this.BN_TogglePoints = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleShapes = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleGraphs = new System.Windows.Forms.ToolStripButton();
            this.BN_ToggleTexts = new System.Windows.Forms.ToolStripButton();
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
            this.ts_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // glEngineControl1
            // 
            this.glEngineControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glEngineControl1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.glEngineControl1.Location = new System.Drawing.Point(0, 50);
            this.glEngineControl1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.glEngineControl1.Name = "glEngineControl1";
            this.glEngineControl1.Size = new System.Drawing.Size(680, 221);
            this.glEngineControl1.TabIndex = 2;
            // 
            // ts_main
            // 
            this.ts_main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ts_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BN_TogglePoints,
            this.BN_ToggleShapes,
            this.BN_ToggleGraphs,
            this.BN_ToggleTexts,
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
            this.ts_main.Location = new System.Drawing.Point(0, 0);
            this.ts_main.Name = "ts_main";
            this.ts_main.Size = new System.Drawing.Size(680, 51);
            this.ts_main.TabIndex = 3;
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
            this.BN_TogglePoints.Size = new System.Drawing.Size(58, 48);
            this.BN_TogglePoints.Text = "Vis/Skjul punkter";
            // 
            // BN_ToggleShapes
            // 
            this.BN_ToggleShapes.CheckOnClick = true;
            this.BN_ToggleShapes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleShapes.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleShapes.Image")));
            this.BN_ToggleShapes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleShapes.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleShapes.Name = "BN_ToggleShapes";
            this.BN_ToggleShapes.Size = new System.Drawing.Size(58, 48);
            this.BN_ToggleShapes.Text = "Vis/Skjul figurer";
            // 
            // BN_ToggleGraphs
            // 
            this.BN_ToggleGraphs.CheckOnClick = true;
            this.BN_ToggleGraphs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleGraphs.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleGraphs.Image")));
            this.BN_ToggleGraphs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleGraphs.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleGraphs.Name = "BN_ToggleGraphs";
            this.BN_ToggleGraphs.Size = new System.Drawing.Size(58, 48);
            this.BN_ToggleGraphs.Text = "Vis/Skjul grafer";
            // 
            // BN_ToggleTexts
            // 
            this.BN_ToggleTexts.CheckOnClick = true;
            this.BN_ToggleTexts.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleTexts.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleTexts.Image")));
            this.BN_ToggleTexts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleTexts.Name = "BN_ToggleTexts";
            this.BN_ToggleTexts.Size = new System.Drawing.Size(58, 44);
            this.BN_ToggleTexts.Text = "Vis/Skjul tekst mærker";
            // 
            // BN_ToggleAxis
            // 
            this.BN_ToggleAxis.CheckOnClick = true;
            this.BN_ToggleAxis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleAxis.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleAxis.Image")));
            this.BN_ToggleAxis.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleAxis.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.BN_ToggleAxis.Name = "BN_ToggleAxis";
            this.BN_ToggleAxis.Size = new System.Drawing.Size(58, 48);
            this.BN_ToggleAxis.Text = "Vis/Skjul akse";
            // 
            // BN_ToggleGrid
            // 
            this.BN_ToggleGrid.CheckOnClick = true;
            this.BN_ToggleGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_ToggleGrid.Image = ((System.Drawing.Image)(resources.GetObject("BN_ToggleGrid.Image")));
            this.BN_ToggleGrid.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_ToggleGrid.Name = "BN_ToggleGrid";
            this.BN_ToggleGrid.Size = new System.Drawing.Size(58, 44);
            this.BN_ToggleGrid.Text = "Vis/Skjul gitter";
            this.BN_ToggleGrid.ToolTipText = "Vis/Skjul gitter";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // BN_GotoOrigin
            // 
            this.BN_GotoOrigin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BN_GotoOrigin.Image = ((System.Drawing.Image)(resources.GetObject("BN_GotoOrigin.Image")));
            this.BN_GotoOrigin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BN_GotoOrigin.Name = "BN_GotoOrigin";
            this.BN_GotoOrigin.Size = new System.Drawing.Size(58, 44);
            this.BN_GotoOrigin.Text = "Gå til origo";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(36, 44);
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
            this.TB_X.Size = new System.Drawing.Size(75, 51);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(35, 44);
            this.toolStripLabel2.Text = "Y";
            // 
            // TB_Y
            // 
            this.TB_Y.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TB_Y.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Y.ForeColor = System.Drawing.SystemColors.Control;
            this.TB_Y.Name = "TB_Y";
            this.TB_Y.ReadOnly = true;
            this.TB_Y.Size = new System.Drawing.Size(75, 47);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(97, 41);
            this.toolStripLabel3.Text = "Zoom";
            // 
            // TB_Zoom
            // 
            this.TB_Zoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.TB_Zoom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Zoom.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_Zoom.Name = "TB_Zoom";
            this.TB_Zoom.ReadOnly = true;
            this.TB_Zoom.Size = new System.Drawing.Size(50, 47);
            // 
            // CoordinateSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(680, 274);
            this.Controls.Add(this.ts_main);
            this.Controls.Add(this.glEngineControl1);
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
        private System.Windows.Forms.Timer Timer;
        private Controls.GLEngineControl glEngineControl1;
        private System.Windows.Forms.ToolStrip ts_main;
        private System.Windows.Forms.ToolStripButton BN_TogglePoints;
        private System.Windows.Forms.ToolStripButton BN_ToggleShapes;
        private System.Windows.Forms.ToolStripButton BN_ToggleGraphs;
        private System.Windows.Forms.ToolStripButton BN_ToggleTexts;
        private System.Windows.Forms.ToolStripButton BN_ToggleAxis;
        private System.Windows.Forms.ToolStripButton BN_ToggleGrid;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BN_GotoOrigin;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TB_X;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripTextBox TB_Y;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
        private System.Windows.Forms.ToolStripTextBox TB_Zoom;
    }
}