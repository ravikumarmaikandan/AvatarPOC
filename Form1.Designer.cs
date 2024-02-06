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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempBar = new System.Windows.Forms.TrackBar();
            this.pulseLabel = new System.Windows.Forms.Label();
            this.pulseBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pressureBar = new System.Windows.Forms.TrackBar();
            this.pressureLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).BeginInit();
            this._gbxHeartRate.SuspendLayout();
            this._gbxRespRate.SuspendLayout();
            this._gbxSPO2.SuspendLayout();
            this._gbxTidalValue.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pressureBar)).BeginInit();
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
            this.heartRateTracker.AutoSize = false;
            this.heartRateTracker.LargeChange = 10;
            this.heartRateTracker.Location = new System.Drawing.Point(54, 19);
            this.heartRateTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.heartRateTracker.Maximum = 180;
            this.heartRateTracker.Minimum = 30;
            this.heartRateTracker.Name = "heartRateTracker";
            this.heartRateTracker.Size = new System.Drawing.Size(302, 30);
            this.heartRateTracker.TabIndex = 0;
            this.heartRateTracker.TickFrequency = 10;
            this.heartRateTracker.Value = 30;
            this.heartRateTracker.Scroll += new System.EventHandler(this.OnHeartRateTrackerChanged);
            // 
            // RRTracker
            // 
            this.RRTracker.AutoSize = false;
            this.RRTracker.LargeChange = 10;
            this.RRTracker.Location = new System.Drawing.Point(54, 19);
            this.RRTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RRTracker.Maximum = 60;
            this.RRTracker.Minimum = 1;
            this.RRTracker.Name = "RRTracker";
            this.RRTracker.Size = new System.Drawing.Size(302, 30);
            this.RRTracker.TabIndex = 1;
            this.RRTracker.TickFrequency = 10;
            this.RRTracker.Value = 1;
            this.RRTracker.Scroll += new System.EventHandler(this.OnRRTrackerChanged);
            // 
            // tidalVolumeTracker
            // 
            this.tidalVolumeTracker.AutoSize = false;
            this.tidalVolumeTracker.Location = new System.Drawing.Point(54, 19);
            this.tidalVolumeTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tidalVolumeTracker.Maximum = 25;
            this.tidalVolumeTracker.Minimum = 1;
            this.tidalVolumeTracker.Name = "tidalVolumeTracker";
            this.tidalVolumeTracker.Size = new System.Drawing.Size(302, 30);
            this.tidalVolumeTracker.TabIndex = 2;
            this.tidalVolumeTracker.TickFrequency = 10;
            this.tidalVolumeTracker.Value = 1;
            this.tidalVolumeTracker.Scroll += new System.EventHandler(this.OnTidalVolumeTrackerScroll);
            // 
            // oxygenTracker
            // 
            this.oxygenTracker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.oxygenTracker.AutoSize = false;
            this.oxygenTracker.LargeChange = 10;
            this.oxygenTracker.Location = new System.Drawing.Point(54, 17);
            this.oxygenTracker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oxygenTracker.Maximum = 100;
            this.oxygenTracker.Minimum = 70;
            this.oxygenTracker.Name = "oxygenTracker";
            this.oxygenTracker.Size = new System.Drawing.Size(302, 30);
            this.oxygenTracker.TabIndex = 3;
            this.oxygenTracker.TickFrequency = 10;
            this.oxygenTracker.Value = 70;
            this.oxygenTracker.Scroll += new System.EventHandler(this.OnOxygenTrackerScroll);
            // 
            // lblHeartRateValue
            // 
            this.lblHeartRateValue.Location = new System.Drawing.Point(6, 17);
            this.lblHeartRateValue.Name = "lblHeartRateValue";
            this.lblHeartRateValue.Size = new System.Drawing.Size(83, 24);
            this.lblHeartRateValue.TabIndex = 5;
            this.lblHeartRateValue.Text = "HR";
            // 
            // _gbxHeartRate
            // 
            this._gbxHeartRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gbxHeartRate.Controls.Add(this.heartRateTracker);
            this._gbxHeartRate.Controls.Add(this.lblHeartRateValue);
            this._gbxHeartRate.ForeColor = System.Drawing.Color.White;
            this._gbxHeartRate.Location = new System.Drawing.Point(349, 10);
            this._gbxHeartRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxHeartRate.Name = "_gbxHeartRate";
            this._gbxHeartRate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxHeartRate.Size = new System.Drawing.Size(363, 63);
            this._gbxHeartRate.TabIndex = 6;
            this._gbxHeartRate.TabStop = false;
            this._gbxHeartRate.Text = "Heart Rate";
            // 
            // _gbxRespRate
            // 
            this._gbxRespRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gbxRespRate.Controls.Add(this._lblRespRate);
            this._gbxRespRate.Controls.Add(this.RRTracker);
            this._gbxRespRate.ForeColor = System.Drawing.Color.White;
            this._gbxRespRate.Location = new System.Drawing.Point(349, 211);
            this._gbxRespRate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxRespRate.Name = "_gbxRespRate";
            this._gbxRespRate.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxRespRate.Size = new System.Drawing.Size(363, 63);
            this._gbxRespRate.TabIndex = 7;
            this._gbxRespRate.TabStop = false;
            this._gbxRespRate.Text = "Resp Rate";
            // 
            // _lblRespRate
            // 
            this._lblRespRate.AutoSize = true;
            this._lblRespRate.Location = new System.Drawing.Point(6, 17);
            this._lblRespRate.Name = "_lblRespRate";
            this._lblRespRate.Size = new System.Drawing.Size(27, 16);
            this._lblRespRate.TabIndex = 2;
            this._lblRespRate.Text = "RR";
            // 
            // _gbxSPO2
            // 
            this._gbxSPO2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gbxSPO2.Controls.Add(this._lblSpo2);
            this._gbxSPO2.Controls.Add(this.oxygenTracker);
            this._gbxSPO2.ForeColor = System.Drawing.Color.White;
            this._gbxSPO2.Location = new System.Drawing.Point(351, 291);
            this._gbxSPO2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxSPO2.Name = "_gbxSPO2";
            this._gbxSPO2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxSPO2.Size = new System.Drawing.Size(363, 63);
            this._gbxSPO2.TabIndex = 8;
            this._gbxSPO2.TabStop = false;
            this._gbxSPO2.Text = "SPo2";
            // 
            // _lblSpo2
            // 
            this._lblSpo2.AutoSize = true;
            this._lblSpo2.Location = new System.Drawing.Point(6, 17);
            this._lblSpo2.Name = "_lblSpo2";
            this._lblSpo2.Size = new System.Drawing.Size(42, 16);
            this._lblSpo2.TabIndex = 4;
            this._lblSpo2.Text = "SPO2";
            // 
            // _gbxTidalValue
            // 
            this._gbxTidalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._gbxTidalValue.Controls.Add(this._lblTidalValue);
            this._gbxTidalValue.Controls.Add(this.tidalVolumeTracker);
            this._gbxTidalValue.ForeColor = System.Drawing.Color.White;
            this._gbxTidalValue.Location = new System.Drawing.Point(358, 488);
            this._gbxTidalValue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxTidalValue.Name = "_gbxTidalValue";
            this._gbxTidalValue.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this._gbxTidalValue.Size = new System.Drawing.Size(368, 63);
            this._gbxTidalValue.TabIndex = 9;
            this._gbxTidalValue.TabStop = false;
            this._gbxTidalValue.Text = "Tidal";
            // 
            // _lblTidalValue
            // 
            this._lblTidalValue.AutoSize = true;
            this._lblTidalValue.Location = new System.Drawing.Point(10, 17);
            this._lblTidalValue.Name = "_lblTidalValue";
            this._lblTidalValue.Size = new System.Drawing.Size(38, 16);
            this._lblTidalValue.TabIndex = 3;
            this._lblTidalValue.Text = "Tidal";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tempLabel);
            this.groupBox1.Controls.Add(this.tempBar);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(351, 387);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(363, 63);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temp";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(6, 17);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(43, 16);
            this.tempLabel.TabIndex = 4;
            this.tempLabel.Text = "Temp";
            // 
            // tempBar
            // 
            this.tempBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tempBar.AutoSize = false;
            this.tempBar.LargeChange = 10;
            this.tempBar.Location = new System.Drawing.Point(54, 17);
            this.tempBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tempBar.Maximum = 400;
            this.tempBar.Minimum = 350;
            this.tempBar.Name = "tempBar";
            this.tempBar.Size = new System.Drawing.Size(302, 30);
            this.tempBar.TabIndex = 3;
            this.tempBar.TickFrequency = 10;
            this.tempBar.Value = 350;
            this.tempBar.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // pulseLabel
            // 
            this.pulseLabel.Location = new System.Drawing.Point(6, 17);
            this.pulseLabel.Name = "pulseLabel";
            this.pulseLabel.Size = new System.Drawing.Size(83, 24);
            this.pulseLabel.TabIndex = 5;
            this.pulseLabel.Text = "Pulse";
            // 
            // pulseBar
            // 
            this.pulseBar.AutoSize = false;
            this.pulseBar.LargeChange = 10;
            this.pulseBar.Location = new System.Drawing.Point(54, 19);
            this.pulseBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pulseBar.Maximum = 180;
            this.pulseBar.Minimum = 30;
            this.pulseBar.Name = "pulseBar";
            this.pulseBar.Size = new System.Drawing.Size(302, 30);
            this.pulseBar.TabIndex = 0;
            this.pulseBar.TickFrequency = 10;
            this.pulseBar.Value = 30;
            this.pulseBar.Scroll += new System.EventHandler(this.pulseBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.pulseBar);
            this.groupBox2.Controls.Add(this.pulseLabel);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(349, 77);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(363, 63);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pulse Rate";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.pressureBar);
            this.groupBox3.Controls.Add(this.pressureLabel);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(351, 144);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(363, 63);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Blood Pressure";
            // 
            // pressureBar
            // 
            this.pressureBar.AutoSize = false;
            this.pressureBar.LargeChange = 10;
            this.pressureBar.Location = new System.Drawing.Point(54, 19);
            this.pressureBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pressureBar.Maximum = 180;
            this.pressureBar.Minimum = 70;
            this.pressureBar.Name = "pressureBar";
            this.pressureBar.Size = new System.Drawing.Size(302, 30);
            this.pressureBar.TabIndex = 0;
            this.pressureBar.TickFrequency = 10;
            this.pressureBar.Value = 70;
            this.pressureBar.Scroll += new System.EventHandler(this.pressureBar_Scroll);
            // 
            // pressureLabel
            // 
            this.pressureLabel.Location = new System.Drawing.Point(6, 17);
            this.pressureLabel.Name = "pressureLabel";
            this.pressureLabel.Size = new System.Drawing.Size(83, 24);
            this.pressureLabel.TabIndex = 5;
            this.pressureLabel.Text = "BP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(724, 571);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._gbxTidalValue);
            this.Controls.Add(this._gbxSPO2);
            this.Controls.Add(this._gbxRespRate);
            this.Controls.Add(this._gbxHeartRate);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.heartRateTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RRTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tidalVolumeTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxygenTracker)).EndInit();
            this._gbxHeartRate.ResumeLayout(false);
            this._gbxRespRate.ResumeLayout(false);
            this._gbxRespRate.PerformLayout();
            this._gbxSPO2.ResumeLayout(false);
            this._gbxSPO2.PerformLayout();
            this._gbxTidalValue.ResumeLayout(false);
            this._gbxTidalValue.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulseBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pressureBar)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.TrackBar tempBar;
        private System.Windows.Forms.Label pulseLabel;
        private System.Windows.Forms.TrackBar pulseBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TrackBar pressureBar;
        private System.Windows.Forms.Label pressureLabel;
    }
}

