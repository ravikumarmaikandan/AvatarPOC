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
            this.lblHeartRateValue = new System.Windows.Forms.Label();
            this._gbxHeartRate = new System.Windows.Forms.GroupBox();
            this._gbxRespRate = new System.Windows.Forms.GroupBox();
            this._lblRespRate = new System.Windows.Forms.Label();
            this._gbxSPO2 = new System.Windows.Forms.GroupBox();
            this._lblSpo2 = new System.Windows.Forms.Label();
            this._gbxTidalValue = new System.Windows.Forms.GroupBox();
            this._lblTidalValue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).BeginInit();
            this._gbxHeartRate.SuspendLayout();
            this._gbxRespRate.SuspendLayout();
            this._gbxSPO2.SuspendLayout();
            this._gbxTidalValue.SuspendLayout();
            this.SuspendLayout();
            // 
            // drawImage
            // 
            this.drawImage.Enabled = true;
            this.drawImage.Interval = 50;
            this.drawImage.Tick += new System.EventHandler(this.OnTick);
            // 
            // heartRateTracker
            // 
            this.heartRateTracker.LargeChange = 10;
            this.heartRateTracker.Location = new System.Drawing.Point(6, 75);
            this.heartRateTracker.Maximum = 180;
            this.heartRateTracker.Minimum = 30;
            this.heartRateTracker.Name = "heartRateTracker";
            this.heartRateTracker.Size = new System.Drawing.Size(395, 69);
            this.heartRateTracker.TabIndex = 0;
            this.heartRateTracker.TickFrequency = 10;
            this.heartRateTracker.Value = 80;
            this.heartRateTracker.Scroll += new System.EventHandler(this.OnHeartRateTrackerChanged);
            // 
            // RRTracker
            // 
            this.RRTracker.LargeChange = 10;
            this.RRTracker.Location = new System.Drawing.Point(19, 65);
            this.RRTracker.Maximum = 60;
            this.RRTracker.Name = "RRTracker";
            this.RRTracker.Size = new System.Drawing.Size(327, 69);
            this.RRTracker.TabIndex = 1;
            this.RRTracker.TickFrequency = 10;
            this.RRTracker.Value = 10;
            this.RRTracker.Scroll += new System.EventHandler(this.OnRRTrackerChanged);
            // 
            // tidalVolumeTracker
            // 
            this.tidalVolumeTracker.LargeChange = 10;
            this.tidalVolumeTracker.Location = new System.Drawing.Point(6, 74);
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
            this.oxygenTracker.Location = new System.Drawing.Point(19, 60);
            this.oxygenTracker.Maximum = 100;
            this.oxygenTracker.Name = "oxygenTracker";
            this.oxygenTracker.Size = new System.Drawing.Size(395, 69);
            this.oxygenTracker.TabIndex = 3;
            this.oxygenTracker.TickFrequency = 10;
            this.oxygenTracker.Value = 96;
            this.oxygenTracker.Scroll += new System.EventHandler(this.OnOxygenTrackerScroll);
            // 
            // lblHeartRateValue
            // 
            this.lblHeartRateValue.Location = new System.Drawing.Point(35, 42);
            this.lblHeartRateValue.Name = "lblHeartRateValue";
            this.lblHeartRateValue.Size = new System.Drawing.Size(93, 30);
            this.lblHeartRateValue.TabIndex = 5;
            this.lblHeartRateValue.Text = "HR";
            // 
            // _gbxHeartRate
            // 
            this._gbxHeartRate.Controls.Add(this.heartRateTracker);
            this._gbxHeartRate.Controls.Add(this.lblHeartRateValue);
            this._gbxHeartRate.Location = new System.Drawing.Point(393, 12);
            this._gbxHeartRate.Name = "_gbxHeartRate";
            this._gbxHeartRate.Size = new System.Drawing.Size(408, 150);
            this._gbxHeartRate.TabIndex = 6;
            this._gbxHeartRate.TabStop = false;
            this._gbxHeartRate.Text = "Heart Rate";
            // 
            // _gbxRespRate
            // 
            this._gbxRespRate.Controls.Add(this._lblRespRate);
            this._gbxRespRate.Controls.Add(this.RRTracker);
            this._gbxRespRate.Location = new System.Drawing.Point(393, 180);
            this._gbxRespRate.Name = "_gbxRespRate";
            this._gbxRespRate.Size = new System.Drawing.Size(408, 134);
            this._gbxRespRate.TabIndex = 7;
            this._gbxRespRate.TabStop = false;
            this._gbxRespRate.Text = "Resp Rate";
            // 
            // _lblRespRate
            // 
            this._lblRespRate.AutoSize = true;
            this._lblRespRate.Location = new System.Drawing.Point(31, 26);
            this._lblRespRate.Name = "_lblRespRate";
            this._lblRespRate.Size = new System.Drawing.Size(33, 20);
            this._lblRespRate.TabIndex = 2;
            this._lblRespRate.Text = "RR";
            // 
            // _gbxSPO2
            // 
            this._gbxSPO2.Controls.Add(this._lblSpo2);
            this._gbxSPO2.Controls.Add(this.oxygenTracker);
            this._gbxSPO2.Location = new System.Drawing.Point(393, 334);
            this._gbxSPO2.Name = "_gbxSPO2";
            this._gbxSPO2.Size = new System.Drawing.Size(408, 135);
            this._gbxSPO2.TabIndex = 8;
            this._gbxSPO2.TabStop = false;
            this._gbxSPO2.Text = "SPo2";
            // 
            // _lblSpo2
            // 
            this._lblSpo2.AutoSize = true;
            this._lblSpo2.Location = new System.Drawing.Point(35, 26);
            this._lblSpo2.Name = "_lblSpo2";
            this._lblSpo2.Size = new System.Drawing.Size(51, 20);
            this._lblSpo2.TabIndex = 4;
            this._lblSpo2.Text = "SPO2";
            // 
            // _gbxTidalValue
            // 
            this._gbxTidalValue.Controls.Add(this._lblTidalValue);
            this._gbxTidalValue.Controls.Add(this.tidalVolumeTracker);
            this._gbxTidalValue.Location = new System.Drawing.Point(393, 498);
            this._gbxTidalValue.Name = "_gbxTidalValue";
            this._gbxTidalValue.Size = new System.Drawing.Size(414, 162);
            this._gbxTidalValue.TabIndex = 9;
            this._gbxTidalValue.TabStop = false;
            this._gbxTidalValue.Text = "Tidal";
            // 
            // _lblTidalValue
            // 
            this._lblTidalValue.AutoSize = true;
            this._lblTidalValue.Location = new System.Drawing.Point(39, 36);
            this._lblTidalValue.Name = "_lblTidalValue";
            this._lblTidalValue.Size = new System.Drawing.Size(42, 20);
            this._lblTidalValue.TabIndex = 3;
            this._lblTidalValue.Text = "Tidal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 688);
            this.Controls.Add(this._gbxTidalValue);
            this.Controls.Add(this._gbxSPO2);
            this.Controls.Add(this._gbxRespRate);
            this.Controls.Add(this._gbxHeartRate);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).EndInit();
            this._gbxHeartRate.ResumeLayout(false);
            this._gbxHeartRate.PerformLayout();
            this._gbxRespRate.ResumeLayout(false);
            this._gbxRespRate.PerformLayout();
            this._gbxSPO2.ResumeLayout(false);
            this._gbxSPO2.PerformLayout();
            this._gbxTidalValue.ResumeLayout(false);
            this._gbxTidalValue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer drawImage;
        private System.Windows.Forms.TrackBar heartRateTracker;
        private System.Windows.Forms.TrackBar RRTracker;
        private System.Windows.Forms.TrackBar tidalVolumeTracker;
        private System.Windows.Forms.TrackBar oxygenTracker;
        private System.Windows.Forms.Label lblHeartRateValue;
        private System.Windows.Forms.GroupBox _gbxHeartRate;
        private System.Windows.Forms.GroupBox _gbxRespRate;
        private System.Windows.Forms.Label _lblRespRate;
        private System.Windows.Forms.GroupBox _gbxSPO2;
        private System.Windows.Forms.Label _lblSpo2;
        private System.Windows.Forms.GroupBox _gbxTidalValue;
        private System.Windows.Forms.Label _lblTidalValue;
    }
}

