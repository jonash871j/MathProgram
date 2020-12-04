
namespace MathProgram.Forms
{
    partial class DistanceFormularForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_X1 = new System.Windows.Forms.TextBox();
            this.TB_X2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Y2 = new System.Windows.Forms.TextBox();
            this.TB_Y1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tb_calulation = new System.Windows.Forms.Label();
            this.tb_result = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TB_Y2);
            this.groupBox1.Controls.Add(this.TB_Y1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TB_X2);
            this.groupBox1.Controls.Add(this.TB_X1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 109);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.tb_result);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.tb_calulation);
            this.groupBox2.Location = new System.Drawing.Point(199, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 109);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Afstandsformlen";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "x1";
            // 
            // tb_x1
            // 
            this.TB_X1.Location = new System.Drawing.Point(6, 32);
            this.TB_X1.Name = "TB_X1";
            this.TB_X1.Size = new System.Drawing.Size(80, 20);
            this.TB_X1.TabIndex = 1;
            this.TB_X1.TextChanged += new System.EventHandler(this.TB_X1_TextChanged);
            // 
            // tb_x2
            // 
            this.TB_X2.Location = new System.Drawing.Point(95, 32);
            this.TB_X2.Name = "TB_X2";
            this.TB_X2.Size = new System.Drawing.Size(80, 20);
            this.TB_X2.TabIndex = 2;
            this.TB_X2.TextChanged += new System.EventHandler(this.TB_X2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "x2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "y2";
            // 
            // tb_y2
            // 
            this.TB_Y2.Location = new System.Drawing.Point(95, 73);
            this.TB_Y2.Name = "TB_Y2";
            this.TB_Y2.Size = new System.Drawing.Size(80, 20);
            this.TB_Y2.TabIndex = 6;
            this.TB_Y2.TextChanged += new System.EventHandler(this.TB_Y2_TextChanged);
            // 
            // tb_y1
            // 
            this.TB_Y1.Location = new System.Drawing.Point(6, 73);
            this.TB_Y1.Name = "TB_Y1";
            this.TB_Y1.Size = new System.Drawing.Size(80, 20);
            this.TB_Y1.TabIndex = 5;
            this.TB_Y1.TextChanged += new System.EventHandler(this.TB_Y1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "y1";
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(6, 32);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(282, 20);
            this.textBox5.TabIndex = 9;
            // 
            // tb_calulation
            // 
            this.tb_calulation.AutoSize = true;
            this.tb_calulation.Location = new System.Drawing.Point(6, 16);
            this.tb_calulation.Name = "tb_calulation";
            this.tb_calulation.Size = new System.Drawing.Size(56, 13);
            this.tb_calulation.TabIndex = 8;
            this.tb_calulation.Text = "Udregning";
            // 
            // tb_result
            // 
            this.tb_result.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_result.Location = new System.Drawing.Point(6, 73);
            this.tb_result.Name = "tb_result";
            this.tb_result.ReadOnly = true;
            this.tb_result.Size = new System.Drawing.Size(282, 20);
            this.tb_result.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Resultat";
            // 
            // DistanceFormularForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 129);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DistanceFormularForm";
            this.Text = "Afstandsformlen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DistanceFormularForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Y2;
        private System.Windows.Forms.TextBox TB_Y1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_X2;
        private System.Windows.Forms.TextBox TB_X1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_result;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label tb_calulation;
    }
}