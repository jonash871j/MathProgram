
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MS_Main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.visToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_CoordSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_DebugInfomation = new System.Windows.Forms.ToolStripMenuItem();
            this.værktøjerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_FunctionScript = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_PointToPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_PointToLine = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_DotTool = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_AngleBetweenTwoVectors = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_ProjectionOfVetorOnVector = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_DotProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.andetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_IntersectionPointBeetweenTwoLines = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_QuadraticEquations = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_Trigonometry = new System.Windows.Forms.ToolStripMenuItem();
            this.indstillingerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MI_IsFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.DP_Main = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.SS_Main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.TS_Main = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.TB_IncrementValue = new System.Windows.Forms.ToolStripTextBox();
            this.MS_Main.SuspendLayout();
            this.SS_Main.SuspendLayout();
            this.TS_Main.SuspendLayout();
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
            this.MI_CoordSystem,
            this.MI_DebugInfomation});
            this.visToolStripMenuItem.Name = "visToolStripMenuItem";
            this.visToolStripMenuItem.Size = new System.Drawing.Size(37, 21);
            this.visToolStripMenuItem.Text = "Vis";
            // 
            // MI_CoordSystem
            // 
            this.MI_CoordSystem.Name = "MI_CoordSystem";
            this.MI_CoordSystem.Size = new System.Drawing.Size(186, 22);
            this.MI_CoordSystem.Text = "Koordinatsystem";
            this.MI_CoordSystem.Click += new System.EventHandler(this.MI_CoordSystem_Click);
            // 
            // MI_DebugInfomation
            // 
            this.MI_DebugInfomation.CheckOnClick = true;
            this.MI_DebugInfomation.Name = "MI_DebugInfomation";
            this.MI_DebugInfomation.Size = new System.Drawing.Size(186, 22);
            this.MI_DebugInfomation.Text = "Debug Information";
            this.MI_DebugInfomation.Click += new System.EventHandler(this.MI_DebugInfomation_Click);
            // 
            // værktøjerToolStripMenuItem
            // 
            this.værktøjerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_FunctionScript,
            this.toolStripSeparator1,
            this.menuItem2,
            this.MI_DotTool,
            this.andetToolStripMenuItem,
            this.MI_QuadraticEquations,
            this.MI_Trigonometry});
            this.værktøjerToolStripMenuItem.Name = "værktøjerToolStripMenuItem";
            this.værktøjerToolStripMenuItem.Size = new System.Drawing.Size(76, 21);
            this.værktøjerToolStripMenuItem.Text = "Værktøjer";
            // 
            // MI_FunctionScript
            // 
            this.MI_FunctionScript.Name = "MI_FunctionScript";
            this.MI_FunctionScript.Size = new System.Drawing.Size(186, 22);
            this.MI_FunctionScript.Text = "Funktionsscript";
            this.MI_FunctionScript.Click += new System.EventHandler(this.MI_FunctionScript_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
            // 
            // menuItem2
            // 
            this.menuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_PointToPoint,
            this.MI_PointToLine});
            this.menuItem2.ForeColor = System.Drawing.SystemColors.Control;
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(186, 22);
            this.menuItem2.Text = "Afstand";
            // 
            // MI_PointToPoint
            // 
            this.MI_PointToPoint.Name = "MI_PointToPoint";
            this.MI_PointToPoint.Size = new System.Drawing.Size(266, 22);
            this.MI_PointToPoint.Text = "Punkt Til Punkt (Afstandsformlen)";
            this.MI_PointToPoint.Click += new System.EventHandler(this.MI_PointToPoint_Click);
            // 
            // MI_PointToLine
            // 
            this.MI_PointToLine.Name = "MI_PointToLine";
            this.MI_PointToLine.Size = new System.Drawing.Size(266, 22);
            this.MI_PointToLine.Text = "Punkt Til Linje (Distanceformlen)";
            this.MI_PointToLine.Click += new System.EventHandler(this.MI_PointToLine_Click);
            // 
            // MI_DotTool
            // 
            this.MI_DotTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_AngleBetweenTwoVectors,
            this.MI_ProjectionOfVetorOnVector,
            this.MI_DotProduct});
            this.MI_DotTool.Name = "MI_DotTool";
            this.MI_DotTool.Size = new System.Drawing.Size(186, 22);
            this.MI_DotTool.Text = "Vektorer";
            // 
            // MI_AngleBetweenTwoVectors
            // 
            this.MI_AngleBetweenTwoVectors.Name = "MI_AngleBetweenTwoVectors";
            this.MI_AngleBetweenTwoVectors.Size = new System.Drawing.Size(250, 22);
            this.MI_AngleBetweenTwoVectors.Text = "Vinkel Mellem To Vektorer";
            this.MI_AngleBetweenTwoVectors.Click += new System.EventHandler(this.MI_AngleBetweenTwoVectors_Click);
            // 
            // MI_ProjectionOfVetorOnVector
            // 
            this.MI_ProjectionOfVetorOnVector.Name = "MI_ProjectionOfVetorOnVector";
            this.MI_ProjectionOfVetorOnVector.Size = new System.Drawing.Size(250, 22);
            this.MI_ProjectionOfVetorOnVector.Text = "Projektion Af Vektor På Vektor";
            this.MI_ProjectionOfVetorOnVector.Click += new System.EventHandler(this.MI_ProjectionOfVetorOnVector_Click);
            // 
            // MI_DotProduct
            // 
            this.MI_DotProduct.Name = "MI_DotProduct";
            this.MI_DotProduct.Size = new System.Drawing.Size(250, 22);
            this.MI_DotProduct.Text = "Skalar Produkt";
            this.MI_DotProduct.Click += new System.EventHandler(this.MI_DotProduct_Click);
            // 
            // andetToolStripMenuItem
            // 
            this.andetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MI_IntersectionPointBeetweenTwoLines});
            this.andetToolStripMenuItem.Name = "andetToolStripMenuItem";
            this.andetToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.andetToolStripMenuItem.Text = "Geometri";
            // 
            // MI_IntersectionPointBeetweenTwoLines
            // 
            this.MI_IntersectionPointBeetweenTwoLines.Name = "MI_IntersectionPointBeetweenTwoLines";
            this.MI_IntersectionPointBeetweenTwoLines.Size = new System.Drawing.Size(241, 22);
            this.MI_IntersectionPointBeetweenTwoLines.Text = "Krydspunkt Mellem To Linjer";
            this.MI_IntersectionPointBeetweenTwoLines.Click += new System.EventHandler(this.MI_IntersectionPointBeetweenTwoLines_Click);
            // 
            // MI_QuadraticEquations
            // 
            this.MI_QuadraticEquations.Name = "MI_QuadraticEquations";
            this.MI_QuadraticEquations.Size = new System.Drawing.Size(186, 22);
            this.MI_QuadraticEquations.Text = "Andengradsligning";
            this.MI_QuadraticEquations.Click += new System.EventHandler(this.MI_QuadraticEquations_Click);
            // 
            // MI_Trigonometry
            // 
            this.MI_Trigonometry.Name = "MI_Trigonometry";
            this.MI_Trigonometry.Size = new System.Drawing.Size(186, 22);
            this.MI_Trigonometry.Text = "Trigonometri";
            this.MI_Trigonometry.Click += new System.EventHandler(this.MI_Trigonometry_Click);
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
            this.TS_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.TS_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TB_IncrementValue});
            this.TS_Main.Location = new System.Drawing.Point(0, 25);
            this.TS_Main.Name = "TS_Main";
            this.TS_Main.Size = new System.Drawing.Size(800, 25);
            this.TS_Main.TabIndex = 7;
            this.TS_Main.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 22);
            this.toolStripLabel1.Text = "Stigningsværdi:";
            // 
            // TB_IncrementValue
            // 
            this.TB_IncrementValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.TB_IncrementValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_IncrementValue.ForeColor = System.Drawing.SystemColors.Window;
            this.TB_IncrementValue.Name = "TB_IncrementValue";
            this.TB_IncrementValue.Size = new System.Drawing.Size(50, 25);
            this.TB_IncrementValue.Text = "1,0";
            this.TB_IncrementValue.Leave += new System.EventHandler(this.TB_IncrementValue_Leave);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MS_Main;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Math Program";
            this.MS_Main.ResumeLayout(false);
            this.MS_Main.PerformLayout();
            this.SS_Main.ResumeLayout(false);
            this.SS_Main.PerformLayout();
            this.TS_Main.ResumeLayout(false);
            this.TS_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MS_Main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_Exit;
        private WeifenLuo.WinFormsUI.Docking.DockPanel DP_Main;
        private System.Windows.Forms.ToolStripMenuItem værktøjerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_QuadraticEquations;
        private System.Windows.Forms.StatusStrip SS_Main;
        private System.Windows.Forms.ToolStripMenuItem visToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_CoordSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem indstillingerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_IsFullscreen;
        private System.Windows.Forms.ToolStrip TS_Main;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MI_Trigonometry;
        private System.Windows.Forms.ToolStripMenuItem menuItem2;
        private System.Windows.Forms.ToolStripMenuItem MI_PointToPoint;
        private System.Windows.Forms.ToolStripMenuItem MI_PointToLine;
        private System.Windows.Forms.ToolStripMenuItem MI_FunctionScript;
        private System.Windows.Forms.ToolStripMenuItem MI_DebugInfomation;
        private System.Windows.Forms.ToolStripMenuItem MI_DotTool;
        private System.Windows.Forms.ToolStripMenuItem MI_AngleBetweenTwoVectors;
        private System.Windows.Forms.ToolStripMenuItem MI_ProjectionOfVetorOnVector;
        private System.Windows.Forms.ToolStripMenuItem andetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MI_IntersectionPointBeetweenTwoLines;
        private System.Windows.Forms.ToolStripMenuItem MI_DotProduct;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox TB_IncrementValue;
    }
}