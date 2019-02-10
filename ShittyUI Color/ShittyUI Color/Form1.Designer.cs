namespace ShittyUI_Color
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ColorChoice = new System.Windows.Forms.Button();
            this.VolumeLabel = new System.Windows.Forms.Label();
            this.Volume = new System.Windows.Forms.Label();
            this.VolumeSlider = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // ColorChoice
            // 
            this.ColorChoice.Location = new System.Drawing.Point(36, 63);
            this.ColorChoice.Name = "ColorChoice";
            this.ColorChoice.Size = new System.Drawing.Size(130, 23);
            this.ColorChoice.TabIndex = 0;
            this.ColorChoice.Text = "Choose Colour";
            this.ColorChoice.UseVisualStyleBackColor = true;
            this.ColorChoice.Click += new System.EventHandler(this.ColorChoice_Click);
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.Location = new System.Drawing.Point(13, 13);
            this.VolumeLabel.Name = "VolumeLabel";
            this.VolumeLabel.Size = new System.Drawing.Size(42, 13);
            this.VolumeLabel.TabIndex = 2;
            this.VolumeLabel.Text = "Volume";
            // 
            // Volume
            // 
            this.Volume.AutoSize = true;
            this.Volume.Location = new System.Drawing.Point(55, 13);
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(13, 13);
            this.Volume.TabIndex = 3;
            this.Volume.Text = "0";
            // 
            // VolumeSlider
            // 
            this.VolumeSlider.Location = new System.Drawing.Point(91, 12);
            this.VolumeSlider.Maximum = 100;
            this.VolumeSlider.Name = "VolumeSlider";
            this.VolumeSlider.Size = new System.Drawing.Size(104, 45);
            this.VolumeSlider.TabIndex = 4;
            this.VolumeSlider.Scroll += new System.EventHandler(this.VolumeSlider_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 106);
            this.Controls.Add(this.VolumeSlider);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.VolumeLabel);
            this.Controls.Add(this.ColorChoice);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.VolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button ColorChoice;
        private System.Windows.Forms.Label VolumeLabel;
        private System.Windows.Forms.Label Volume;
        private System.Windows.Forms.TrackBar VolumeSlider;
    }
}

