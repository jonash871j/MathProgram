
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
            this.pb_coordinateSystem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_coordinateSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_coordinateSystem
            // 
            this.pb_coordinateSystem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_coordinateSystem.BackColor = System.Drawing.Color.White;
            this.pb_coordinateSystem.Location = new System.Drawing.Point(-1, -2);
            this.pb_coordinateSystem.Name = "pb_coordinateSystem";
            this.pb_coordinateSystem.Size = new System.Drawing.Size(801, 452);
            this.pb_coordinateSystem.TabIndex = 0;
            this.pb_coordinateSystem.TabStop = false;
            // 
            // CoordinateSystemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pb_coordinateSystem);
            this.MinimumSize = new System.Drawing.Size(128, 128);
            this.Name = "CoordinateSystemForm";
            this.Text = "Koordinatsystem";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CoordinateSystemForm_FormClosing);
            this.Resize += new System.EventHandler(this.CoordinateSystemForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pb_coordinateSystem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_coordinateSystem;
    }
}