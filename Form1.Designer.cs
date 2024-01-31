namespace Philips.PIC.CommonControls
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
            this.components = new System.ComponentModel.Container();
            this.drawImage = new System.Windows.Forms.Timer(this.components);
            this.heartRateTracker = new System.Windows.Forms.TrackBar();
            this.RRTracker = new System.Windows.Forms.TrackBar();
            this.tidalVolumeTracker = new System.Windows.Forms.TrackBar();
            this.oxygenTracker = new System.Windows.Forms.TrackBar();
            this.lblHeartRate = new System.Windows.Forms.Label();
            this.lblHeartRateValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // drawImage
            // 
            this.drawImage.Enabled = true;
            this.drawImage.Tick += new System.EventHandler(this.OnTick);
            // 
            // heartRateTracker
            // 
            this.heartRateTracker.LargeChange = 10;
            this.heartRateTracker.Location = new System.Drawing.Point(393, 134);
            this.heartRateTracker.Maximum = 180;
            this.heartRateTracker.Minimum = 30;
            this.heartRateTracker.Name = "heartRateTracker";
            this.heartRateTracker.Size = new System.Drawing.Size(395, 69);
            this.heartRateTracker.TabIndex = 0;
            this.heartRateTracker.TickFrequency = 10;
            this.heartRateTracker.Value = 30;
            this.heartRateTracker.Scroll += new System.EventHandler(this.OnHeartRateTrackerChanged);
            // 
            // RRTracker
            // 
            this.RRTracker.LargeChange = 10;
            this.RRTracker.Location = new System.Drawing.Point(393, 254);
            this.RRTracker.Maximum = 60;
            this.RRTracker.Name = "RRTracker";
            this.RRTracker.Size = new System.Drawing.Size(395, 69);
            this.RRTracker.TabIndex = 1;
            this.RRTracker.TickFrequency = 10;
            this.RRTracker.Value = 10;
            this.RRTracker.Scroll += new System.EventHandler(this.OnRRTrackerChanged);
            // 
            // tidalVolumeTracker
            // 
            this.tidalVolumeTracker.LargeChange = 10;
            this.tidalVolumeTracker.Location = new System.Drawing.Point(393, 496);
            this.tidalVolumeTracker.Maximum = 180;
            this.tidalVolumeTracker.Minimum = 30;
            this.tidalVolumeTracker.Name = "tidalVolumeTracker";
            this.tidalVolumeTracker.Size = new System.Drawing.Size(395, 69);
            this.tidalVolumeTracker.TabIndex = 2;
            this.tidalVolumeTracker.TickFrequency = 10;
            this.tidalVolumeTracker.Value = 30;
            // 
            // oxygenTracker
            // 
            this.oxygenTracker.LargeChange = 10;
            this.oxygenTracker.Location = new System.Drawing.Point(393, 370);
            this.oxygenTracker.Maximum = 180;
            this.oxygenTracker.Minimum = 30;
            this.oxygenTracker.Name = "oxygenTracker";
            this.oxygenTracker.Size = new System.Drawing.Size(395, 69);
            this.oxygenTracker.TabIndex = 3;
            this.oxygenTracker.TickFrequency = 10;
            this.oxygenTracker.Value = 30;
            // 
            // lblHeartRate
            // 
            this.lblHeartRate.AutoSize = true;
            this.lblHeartRate.Location = new System.Drawing.Point(389, 74);
            this.lblHeartRate.Name = "lblHeartRate";
            this.lblHeartRate.Size = new System.Drawing.Size(88, 20);
            this.lblHeartRate.TabIndex = 4;
            this.lblHeartRate.Text = "Heart Rate";
            // 
            // lblHeartRateValue
            // 
            this.lblHeartRateValue.AutoSize = true;
            this.lblHeartRateValue.Location = new System.Drawing.Point(510, 74);
            this.lblHeartRateValue.Name = "lblHeartRateValue";
            this.lblHeartRateValue.Size = new System.Drawing.Size(0, 10);
            this.lblHeartRateValue.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 590);
            this.Controls.Add(this.lblHeartRateValue);
            this.Controls.Add(this.lblHeartRate);
            this.Controls.Add(this.oxygenTracker);
            this.Controls.Add(this.tidalVolumeTracker);
            this.Controls.Add(this.RRTracker);
            this.Controls.Add(this.heartRateTracker);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer drawImage;
        private System.Windows.Forms.TrackBar heartRateTracker;
        private System.Windows.Forms.TrackBar RRTracker;
        private System.Windows.Forms.TrackBar tidalVolumeTracker;
        private System.Windows.Forms.TrackBar oxygenTracker;
        private System.Windows.Forms.Label lblHeartRate;
        private System.Windows.Forms.Label lblHeartRateValue;
    }
}

