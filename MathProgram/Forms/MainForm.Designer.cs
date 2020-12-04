
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
            this.ms_main = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.visToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_coordSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.værktøjerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_calculator = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_quadraticEquations = new System.Windows.Forms.ToolStripMenuItem();
            this.indstillingerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mi_isFullscreen = new System.Windows.Forms.ToolStripMenuItem();
            this.dp_main = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ms_main.SuspendLayout();
            this.ss_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            this.ms_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.visToolStripMenuItem,
            this.værktøjerToolStripMenuItem,
            this.indstillingerToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(800, 24);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(31, 20);
            this.fileToolStripMenuItem.Text = "Fil";
            // 
            // mi_exit
            // 
            this.mi_exit.Name = "mi_exit";
            this.mi_exit.Size = new System.Drawing.Size(105, 22);
            this.mi_exit.Text = "Afslut";
            this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
            // 
            // visToolStripMenuItem
            // 
            this.visToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_coordSystem});
            this.visToolStripMenuItem.Name = "visToolStripMenuItem";
            this.visToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.visToolStripMenuItem.Text = "Vis";
            // 
            // mi_coordSystem
            // 
            this.mi_coordSystem.Name = "mi_coordSystem";
            this.mi_coordSystem.Size = new System.Drawing.Size(163, 22);
            this.mi_coordSystem.Text = "Koordinatsystem";
            this.mi_coordSystem.Click += new System.EventHandler(this.mi_coordSystem_Click);
            // 
            // værktøjerToolStripMenuItem
            // 
            this.værktøjerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_calculator,
            this.mi_quadraticEquations});
            this.værktøjerToolStripMenuItem.Name = "værktøjerToolStripMenuItem";
            this.værktøjerToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.værktøjerToolStripMenuItem.Text = "Værktøjer";
            // 
            // mi_calculator
            // 
            this.mi_calculator.Name = "mi_calculator";
            this.mi_calculator.Size = new System.Drawing.Size(175, 22);
            this.mi_calculator.Text = "Lommeregner";
            this.mi_calculator.Click += new System.EventHandler(this.mi_calculator_Click);
            // 
            // mi_quadraticEquations
            // 
            this.mi_quadraticEquations.Name = "mi_quadraticEquations";
            this.mi_quadraticEquations.Size = new System.Drawing.Size(175, 22);
            this.mi_quadraticEquations.Text = "Andengradsligning";
            this.mi_quadraticEquations.Click += new System.EventHandler(this.mi_quadraticEquations_Click);
            // 
            // indstillingerToolStripMenuItem
            // 
            this.indstillingerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_isFullscreen});
            this.indstillingerToolStripMenuItem.Name = "indstillingerToolStripMenuItem";
            this.indstillingerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.indstillingerToolStripMenuItem.Text = "Indstillinger";
            // 
            // mi_isFullscreen
            // 
            this.mi_isFullscreen.CheckOnClick = true;
            this.mi_isFullscreen.Name = "mi_isFullscreen";
            this.mi_isFullscreen.Size = new System.Drawing.Size(133, 22);
            this.mi_isFullscreen.Text = "Fuldskærm";
            this.mi_isFullscreen.Click += new System.EventHandler(this.mi_isFullscreen_Click);
            // 
            // dp_main
            // 
            this.dp_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dp_main.BackColor = System.Drawing.Color.Black;
            this.dp_main.Location = new System.Drawing.Point(0, 22);
            this.dp_main.Name = "dp_main";
            this.dp_main.Size = new System.Drawing.Size(800, 518);
            this.dp_main.TabIndex = 1;
            // 
            // ss_main
            // 
            this.ss_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ss_main.Location = new System.Drawing.Point(0, 539);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(800, 22);
            this.ss_main.TabIndex = 4;
            this.ss_main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel1.Text = "Math Program 2.0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 561);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(this.dp_main);
            this.Controls.Add(this.ms_main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainForm";
            this.Text = "Math Program";
            this.ms_main.ResumeLayout(false);
            this.ms_main.PerformLayout();
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_main;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_exit;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dp_main;
        private System.Windows.Forms.ToolStripMenuItem værktøjerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_calculator;
        private System.Windows.Forms.ToolStripMenuItem mi_quadraticEquations;
        private System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.ToolStripMenuItem visToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_coordSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem indstillingerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mi_isFullscreen;
    }
}

