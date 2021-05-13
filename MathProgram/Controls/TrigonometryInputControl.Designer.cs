
namespace MathProgram.Controls
{
    partial class TrigonometryInputControl
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TNB_AngleC = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.TNB_SiteC = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.TNB_AngleB = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.TNB_AngleA = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.TNB_SiteA = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.TNB_SiteB = new MathProgram.Controls.GlobalControls.ToggleableNumberBoxControl();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.TNB_AngleC, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.TNB_SiteC, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.TNB_AngleB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TNB_AngleA, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TNB_SiteA, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TNB_SiteB, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(402, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TNB_AngleC
            // 
            this.TNB_AngleC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_AngleC.IsReadOnly = true;
            this.TNB_AngleC.Location = new System.Drawing.Point(204, 115);
            this.TNB_AngleC.Name = "TNB_AngleC";
            this.TNB_AngleC.Size = new System.Drawing.Size(195, 47);
            this.TNB_AngleC.TabIndex = 5;
            this.TNB_AngleC.Title = "Vinkel C";
            this.TNB_AngleC.Value = 0D;
            // 
            // TNB_SiteC
            // 
            this.TNB_SiteC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_SiteC.IsReadOnly = true;
            this.TNB_SiteC.Location = new System.Drawing.Point(3, 115);
            this.TNB_SiteC.Name = "TNB_SiteC";
            this.TNB_SiteC.Size = new System.Drawing.Size(195, 47);
            this.TNB_SiteC.TabIndex = 4;
            this.TNB_SiteC.Title = "Siden c";
            this.TNB_SiteC.Value = 0D;
            // 
            // TNB_AngleB
            // 
            this.TNB_AngleB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_AngleB.IsReadOnly = true;
            this.TNB_AngleB.Location = new System.Drawing.Point(204, 59);
            this.TNB_AngleB.Name = "TNB_AngleB";
            this.TNB_AngleB.Size = new System.Drawing.Size(195, 47);
            this.TNB_AngleB.TabIndex = 3;
            this.TNB_AngleB.Title = "Vinkel B";
            this.TNB_AngleB.Value = 0D;
            // 
            // TNB_AngleA
            // 
            this.TNB_AngleA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_AngleA.IsReadOnly = true;
            this.TNB_AngleA.Location = new System.Drawing.Point(204, 3);
            this.TNB_AngleA.Name = "TNB_AngleA";
            this.TNB_AngleA.Size = new System.Drawing.Size(195, 47);
            this.TNB_AngleA.TabIndex = 1;
            this.TNB_AngleA.Title = "Vinkel A";
            this.TNB_AngleA.Value = 0D;
            // 
            // TNB_SiteA
            // 
            this.TNB_SiteA.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_SiteA.IsReadOnly = true;
            this.TNB_SiteA.Location = new System.Drawing.Point(3, 3);
            this.TNB_SiteA.Name = "TNB_SiteA";
            this.TNB_SiteA.Size = new System.Drawing.Size(195, 47);
            this.TNB_SiteA.TabIndex = 0;
            this.TNB_SiteA.Title = "Siden a";
            this.TNB_SiteA.Value = 0D;
            // 
            // TNB_SiteB
            // 
            this.TNB_SiteB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TNB_SiteB.IsReadOnly = true;
            this.TNB_SiteB.Location = new System.Drawing.Point(3, 59);
            this.TNB_SiteB.Name = "TNB_SiteB";
            this.TNB_SiteB.Size = new System.Drawing.Size(195, 47);
            this.TNB_SiteB.TabIndex = 2;
            this.TNB_SiteB.Title = "Siden b";
            this.TNB_SiteB.Value = 0D;
            // 
            // TrigonometryInputControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "TrigonometryInputControl";
            this.Size = new System.Drawing.Size(425, 194);
            this.Load += new System.EventHandler(this.TrigonometryInputControl_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private GlobalControls.ToggleableNumberBoxControl TNB_AngleC;
        private GlobalControls.ToggleableNumberBoxControl TNB_SiteC;
        private GlobalControls.ToggleableNumberBoxControl TNB_AngleB;
        private GlobalControls.ToggleableNumberBoxControl TNB_AngleA;
        private GlobalControls.ToggleableNumberBoxControl TNB_SiteA;
        private GlobalControls.ToggleableNumberBoxControl TNB_SiteB;
    }
}
