
namespace MathProgram.Forms
{
    partial class FunctionScriptForm
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
            this.TEC_Main = new ICSharpCode.TextEditor.TextEditorControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LB_Y = new System.Windows.Forms.Label();
            this.LB_ErrorText = new System.Windows.Forms.Label();
            this.TNB_X = new MathProgram.Controls.ToggleableNumberBoxControl();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TEC_Main
            // 
            this.TEC_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TEC_Main.BackColor = System.Drawing.Color.White;
            this.TEC_Main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEC_Main.IsReadOnly = false;
            this.TEC_Main.Location = new System.Drawing.Point(4, 68);
            this.TEC_Main.Margin = new System.Windows.Forms.Padding(2);
            this.TEC_Main.Name = "TEC_Main";
            this.TEC_Main.Size = new System.Drawing.Size(510, 300);
            this.TEC_Main.TabIndex = 3;
            this.TEC_Main.Text = "return 2*x+4;";
            this.TEC_Main.TextChanged += new System.EventHandler(this.TEC_Main_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.LB_ErrorText);
            this.groupBox1.Controls.Add(this.LB_Y);
            this.groupBox1.Controls.Add(this.TNB_X);
            this.groupBox1.Controls.Add(this.TEC_Main);
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(517, 371);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // LB_Y
            // 
            this.LB_Y.AutoSize = true;
            this.LB_Y.Location = new System.Drawing.Point(176, 40);
            this.LB_Y.Name = "LB_Y";
            this.LB_Y.Size = new System.Drawing.Size(21, 13);
            this.LB_Y.TabIndex = 8;
            this.LB_Y.Text = "y =";
            // 
            // LB_ErrorText
            // 
            this.LB_ErrorText.AutoSize = true;
            this.LB_ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_ErrorText.Location = new System.Drawing.Point(176, 53);
            this.LB_ErrorText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LB_ErrorText.Name = "LB_ErrorText";
            this.LB_ErrorText.Size = new System.Drawing.Size(11, 13);
            this.LB_ErrorText.TabIndex = 5;
            this.LB_ErrorText.Text = "r";
            // 
            // TNB_X
            // 
            this.TNB_X.IsReadOnly = true;
            this.TNB_X.Location = new System.Drawing.Point(5, 15);
            this.TNB_X.Name = "TNB_X";
            this.TNB_X.Size = new System.Drawing.Size(175, 48);
            this.TNB_X.TabIndex = 6;
            this.TNB_X.Title = "x";
            this.TNB_X.Value = 0D;
            this.TNB_X.CheckBoxChanged += new System.EventHandler(this.TNB_X_CheckBoxChanged);
            this.TNB_X.NumberChanged += new System.EventHandler(this.TNB_X_NumberChanged);
            // 
            // FunctionScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 385);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FunctionScriptForm";
            this.Text = "Funktionsscript";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FunctionScriptForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ICSharpCode.TextEditor.TextEditorControl TEC_Main;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LB_ErrorText;
        private Controls.ToggleableNumberBoxControl TNB_X;
        private System.Windows.Forms.Label LB_Y;
    }
}