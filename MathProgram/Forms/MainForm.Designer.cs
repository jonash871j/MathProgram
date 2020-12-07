
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
            this.dp_main = new WeifenLuo.WinFormsUI.Docking.DockPanel();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.mi_trigonometry = new System.Windows.Forms.ToolStripMenuItem();
            this.dockPanel1 = new WeifenLuo.WinFormsUI.Docking.DockPanel();
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
            this.værktøjerToolStripMenuItem});
            this.ms_main.Location = new System.Drawing.Point(0, 0);
            this.ms_main.Name = "ms_main";
            this.ms_main.Size = new System.Drawing.Size(1067, 28);
            this.ms_main.TabIndex = 0;
            this.ms_main.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(38, 24);
            this.fileToolStripMenuItem.Text = "Fil";
            // 
            // mi_exit
            // 
            this.mi_exit.Name = "mi_exit";
            this.mi_exit.Size = new System.Drawing.Size(130, 26);
            this.mi_exit.Text = "Afslut";
            this.mi_exit.Click += new System.EventHandler(this.mi_exit_Click);
            // 
            // visToolStripMenuItem
            // 
            this.visToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_coordSystem});
            this.visToolStripMenuItem.Name = "visToolStripMenuItem";
            this.visToolStripMenuItem.Size = new System.Drawing.Size(42, 24);
            this.visToolStripMenuItem.Text = "Vis";
            // 
            // mi_coordSystem
            // 
            this.mi_coordSystem.Name = "mi_coordSystem";
            this.mi_coordSystem.Size = new System.Drawing.Size(203, 26);
            this.mi_coordSystem.Text = "Koordinatsystem";
            this.mi_coordSystem.Click += new System.EventHandler(this.mi_coordSystem_Click);
            // 
            // værktøjerToolStripMenuItem
            // 
            this.værktøjerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mi_calculator,
            this.mi_quadraticEquations,
            this.mi_trigonometry});
            this.værktøjerToolStripMenuItem.Name = "værktøjerToolStripMenuItem";
            this.værktøjerToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.værktøjerToolStripMenuItem.Text = "Værktøjer";
            // 
            // mi_calculator
            // 
            this.mi_calculator.Name = "mi_calculator";
            this.mi_calculator.Size = new System.Drawing.Size(224, 26);
            this.mi_calculator.Text = "Lommeregner";
            this.mi_calculator.Click += new System.EventHandler(this.mi_calculator_Click);
            // 
            // mi_quadraticEquations
            // 
            this.mi_quadraticEquations.Name = "mi_quadraticEquations";
            this.mi_quadraticEquations.Size = new System.Drawing.Size(224, 26);
            this.mi_quadraticEquations.Text = "Andengradsligning";
            this.mi_quadraticEquations.Click += new System.EventHandler(this.mi_quadraticEquations_Click);
            // 
            // dp_main
            // 
            this.dp_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_main.BackColor = System.Drawing.Color.Black;
            this.dp_main.Location = new System.Drawing.Point(0, 27);
            this.dp_main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dp_main.Name = "dp_main";
            this.dp_main.Size = new System.Drawing.Size(1067, 638);
            this.dp_main.TabIndex = 1;
            // 
            // ss_main
            // 
            this.ss_main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.ss_main.Location = new System.Drawing.Point(0, 664);
            this.ss_main.Name = "ss_main";
            this.ss_main.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ss_main.Size = new System.Drawing.Size(1067, 26);
            this.ss_main.TabIndex = 4;
            this.ss_main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(127, 20);
            this.toolStripStatusLabel1.Text = "Math Program 2.0";
            // 
            // mi_trigonometry
            // 
            this.mi_trigonometry.Name = "mi_trigonometry";
            this.mi_trigonometry.Size = new System.Drawing.Size(224, 26);
            this.mi_trigonometry.Text = "Trigonometri";
            this.mi_trigonometry.Click += new System.EventHandler(this.mi_trigonometry_Click);
            // 
            // dockPanel1
            // 
            this.dockPanel1.Location = new System.Drawing.Point(252, 0);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Size = new System.Drawing.Size(8, 8);
            this.dockPanel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.dockPanel1);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(this.dp_main);
            this.Controls.Add(this.ms_main);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_main;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
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
        private System.Windows.Forms.ToolStripMenuItem mi_trigonometry;
        private WeifenLuo.WinFormsUI.Docking.DockPanel dockPanel1;
    }
}

