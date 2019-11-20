namespace _1
{
    partial class Form1
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
            this.picHisto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHisto)).BeginInit();
            this.SuspendLayout();
            // 
            // picHisto
            // 
            this.picHisto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picHisto.Location = new System.Drawing.Point(0, 0);
            this.picHisto.Name = "picHisto";
            this.picHisto.Size = new System.Drawing.Size(800, 450);
            this.picHisto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHisto.TabIndex = 0;
            this.picHisto.TabStop = false;
            this.picHisto.Click += new System.EventHandler(this.PicHisto_Click);
            this.picHisto.Paint += new System.Windows.Forms.PaintEventHandler(this.PicHisto_Paint);
            this.picHisto.Resize += new System.EventHandler(this.PicHisto_Resize);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picHisto);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picHisto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picHisto;
    }
}