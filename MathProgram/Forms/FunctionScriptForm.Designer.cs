
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
            this.LB_ErrorText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.TEC_Main.Location = new System.Drawing.Point(6, 58);
            this.TEC_Main.Name = "TEC_Main";
            this.TEC_Main.Size = new System.Drawing.Size(764, 507);
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
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.TEC_Main);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 571);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Script";
            // 
            // LB_ErrorText
            // 
            this.LB_ErrorText.AutoSize = true;
            this.LB_ErrorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ErrorText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LB_ErrorText.Location = new System.Drawing.Point(137, 22);
            this.LB_ErrorText.Name = "LB_ErrorText";
            this.LB_ErrorText.Size = new System.Drawing.Size(0, 20);
            this.LB_ErrorText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fejl information: ";
            // 
            // FunctionScriptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.groupBox1);
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
        private System.Windows.Forms.Label label1;
    }
}