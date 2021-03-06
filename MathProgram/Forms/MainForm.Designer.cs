﻿
namespace MathProgram.Forms
{
    partial class MainForm
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
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.visToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_CoordSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.værktøjerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MI_QuadraticEquations = new System.Windows.Forms.ToolStripMenuItem();
            this.analytiskPlangeometriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afstandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_PointToPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.punktTilLinjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.determinantformlenAreaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinkelMellemToLinjerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vinkelMellemToLinjerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelleLinjerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linjerVinkelretPåHinandenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indstillingerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_IsFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.DP_Main = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.MI_Trigonometry = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_Main.SuspendLayout();
            this.SS_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // MS_Main
            // 
            this.MS_Main.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.MS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.visToolStripMenuItem,
            this.værktøjerToolStripMenuItem,
            this.indstillingerToolStripMenuItem});
            this.MS_Main.Location = new System.Drawing.Point(0, 0);
            this.MS_Main.Name = "MS_Main";
            this.MS_Main.Size = new System.Drawing.Size(800, 25);
            this.MS_Main.TabIndex = 0;
            this.MS_Main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(32, 21);
            this.fileToolStripMenuItem.Text = "Fil";
            // 
            // MI_Exit
            // 
            this.MI_Exit.Name = "MI_Exit";
            this.MI_Exit.Size = new System.Drawing.Size(108, 22);
            this.MI_Exit.Text = "Afslut";
            this.MI_Exit.Click += new System.EventHandler(this.MI_Exit_Click);
            // 
            // visToolStripMenuItem
            // 
            this.visToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_CoordSystem});
            this.visToolStripMenuItem.Name = "visToolStripMenuItem";
            this.visToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.visToolStripMenuItem.Text = "Vis";
            // 
            // MI_CoordSystem
            // 
            this.MI_CoordSystem.Name = "MI_CoordSystem";
            this.MI_CoordSystem.Size = new System.Drawing.Size(174, 22);
            this.MI_CoordSystem.Text = "Koordinatsystem";
            this.MI_CoordSystem.Click += new System.EventHandler(this.MI_CoordSystem_Click);
            // 
            // værktøjerToolStripMenuItem
            // 
            this.værktøjerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_Calculator,
            this.toolStripSeparator1,
            this.MI_QuadraticEquations,
            this.analytiskPlangeometriToolStripMenuItem,
            this.MI_Trigonometry});
            this.værktøjerToolStripMenuItem.Name = "værktøjerToolStripMenuItem";
            this.værktøjerToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.værktøjerToolStripMenuItem.Text = "Værktøjer";
            // 
            // MI_Calculator
            // 
            this.MI_Calculator.Name = "MI_Calculator";
            this.MI_Calculator.Size = new System.Drawing.Size(207, 22);
            this.MI_Calculator.Text = "Lommeregner";
            this.MI_Calculator.Click += new System.EventHandler(this.MI_Calculator_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // MI_QuadraticEquations
            // 
            this.MI_QuadraticEquations.Name = "MI_QuadraticEquations";
            this.MI_QuadraticEquations.Size = new System.Drawing.Size(207, 22);
            this.MI_QuadraticEquations.Text = "Andengradsligning";
            this.MI_QuadraticEquations.Click += new System.EventHandler(this.MI_QuadraticEquations_Click);
            // 
            // analytiskPlangeometriToolStripMenuItem
            // 
            this.analytiskPlangeometriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afstandToolStripMenuItem,
            this.determinantformlenAreaToolStripMenuItem,
            this.vinkelMellemToLinjerToolStripMenuItem});
            this.analytiskPlangeometriToolStripMenuItem.Name = "analytiskPlangeometriToolStripMenuItem";
            this.analytiskPlangeometriToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.analytiskPlangeometriToolStripMenuItem.Text = "Analytisk Plangeometri";
            // 
            // afstandToolStripMenuItem
            // 
            this.afstandToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_PointToPoint,
            this.punktTilLinjeToolStripMenuItem});
            this.afstandToolStripMenuItem.Name = "afstandToolStripMenuItem";
            this.afstandToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.afstandToolStripMenuItem.Text = "Afstand";
            // 
            // MI_PointToPoint
            // 
            this.MI_PointToPoint.Name = "MI_PointToPoint";
            this.MI_PointToPoint.Size = new System.Drawing.Size(266, 22);
            this.MI_PointToPoint.Text = "Punkt Til Punkt (Afstandsformlen)";
            this.MI_PointToPoint.Click += new System.EventHandler(this.MI_PointToPoint_Click);
            // 
            // punktTilLinjeToolStripMenuItem
            // 
            this.punktTilLinjeToolStripMenuItem.Name = "punktTilLinjeToolStripMenuItem";
            this.punktTilLinjeToolStripMenuItem.Size = new System.Drawing.Size(266, 22);
            this.punktTilLinjeToolStripMenuItem.Text = "Punkt Til Linje";
            // 
            // determinantformlenAreaToolStripMenuItem
            // 
            this.determinantformlenAreaToolStripMenuItem.Name = "determinantformlenAreaToolStripMenuItem";
            this.determinantformlenAreaToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.determinantformlenAreaToolStripMenuItem.Text = "Areal (Determinantformlen)";
            // 
            // vinkelMellemToLinjerToolStripMenuItem
            // 
            this.vinkelMellemToLinjerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vinkelMellemToLinjerToolStripMenuItem1,
            this.parallelleLinjerToolStripMenuItem,
            this.linjerVinkelretPåHinandenToolStripMenuItem});
            this.vinkelMellemToLinjerToolStripMenuItem.Name = "vinkelMellemToLinjerToolStripMenuItem";
            this.vinkelMellemToLinjerToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.vinkelMellemToLinjerToolStripMenuItem.Text = "Linjer";
            // 
            // vinkelMellemToLinjerToolStripMenuItem1
            // 
            this.vinkelMellemToLinjerToolStripMenuItem1.Name = "vinkelMellemToLinjerToolStripMenuItem1";
            this.vinkelMellemToLinjerToolStripMenuItem1.Size = new System.Drawing.Size(238, 22);
            this.vinkelMellemToLinjerToolStripMenuItem1.Text = "Vinkel Mellem To Linjer";
            // 
            // parallelleLinjerToolStripMenuItem
            // 
            this.parallelleLinjerToolStripMenuItem.Name = "parallelleLinjerToolStripMenuItem";
            this.parallelleLinjerToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.parallelleLinjerToolStripMenuItem.Text = "Parallelle Linjer";
            // 
            // linjerVinkelretPåHinandenToolStripMenuItem
            // 
            this.linjerVinkelretPåHinandenToolStripMenuItem.Name = "linjerVinkelretPåHinandenToolStripMenuItem";
            this.linjerVinkelretPåHinandenToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.linjerVinkelretPåHinandenToolStripMenuItem.Text = "Linjer Vinkelret På Hinanden";
            // 
            // indstillingerToolStripMenuItem
            // 
            this.indstillingerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_IsFullscreen});
            this.indstillingerToolStripMenuItem.Name = "indstillingerToolStripMenuItem";
            this.indstillingerToolStripMenuItem.Size = new System.Drawing.Size(87, 21);
            this.indstillingerToolStripMenuItem.Text = "Indstillinger";
            // 
            // MI_IsFullscreen
            // 
            this.MI_IsFullscreen.CheckOnClick = true;
            this.MI_IsFullscreen.Name = "MI_IsFullscreen";
            this.MI_IsFullscreen.Size = new System.Drawing.Size(139, 22);
            this.MI_IsFullscreen.Text = "Fuldskærm";
            this.MI_IsFullscreen.Click += new System.EventHandler(this.MI_IsFullscreen_Click);
            // 
            // DP_Main
            // 
            this.DP_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DP_Main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DP_Main.BackColor = System.Drawing.Color.Black;
            this.DP_Main.Location = new System.Drawing.Point(0, 47);
            this.DP_Main.Name = "DP_Main";
            this.DP_Main.Size = new System.Drawing.Size(800, 493);
            this.DP_Main.TabIndex = 1;
            // 
            // SS_Main
            // 
            this.SS_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.SS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.SS_Main.Location = new System.Drawing.Point(0, 539);
            this.SS_Main.Name = "SS_Main";
            this.SS_Main.Size = new System.Drawing.Size(800, 22);
            this.SS_Main.TabIndex = 4;
            this.SS_Main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Math Program 2.0";
            // 
            // TS_Main
            // 
            this.TS_Main.Location = new System.Drawing.Point(0, 25);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(800, 25);
            this.TS_Main.TabIndex = 7;
            this.TS_Main.Text = "toolStrip1";
            // 
            // MI_Trigonometry
            // 
            this.MI_Trigonometry.Name = "MI_Trigonometry";
            this.MI_Trigonometry.Size = new System.Drawing.Size(207, 22);
            this.MI_Trigonometry.Text = "Trigonometri";
            this.MI_Trigonometry.Click += new System.EventHandler(this.MI_Trigonometry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.TS_Main);
            this.Controls.Add(this.SS_Main);
            this.Controls.Add(this.DP_Main);
            this.Controls.Add(this.MS_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_Main;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Math Program";
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Exit;
        private WeifenLuo.WinFormsUI.Docking.DockPanel DP_Main;
        private System.Windows.Forms.ToolStripMenuItem værktøjerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Calculator;
        private System.Windows.Forms.ToolStripMenuItem MI_QuadraticEquations;
        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.ToolStripMenuItem visToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_CoordSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem indstillingerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_IsFullscreen;
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripMenuItem analytiskPlangeometriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem determinantformlenAreaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinkelMellemToLinjerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vinkelMellemToLinjerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem parallelleLinjerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linjerVinkelretPåHinandenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afstandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_PointToPoint;
        private System.Windows.Forms.ToolStripMenuItem punktTilLinjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Trigonometry;
    }
}