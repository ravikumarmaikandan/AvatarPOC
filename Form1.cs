using System;
using System.Windows.Forms;

namespace Philips.PIC.CommonControls
{
    public partial class Form1 : Form
    {
        private readonly PaintAvatar _paintAvatar = new PaintAvatar();
        private readonly TopicInfo _topicInfo = new TopicInfo();
        public Form1()
        {
            InitializeComponent();
            _topicInfo.PulseRateHeart.RateInHz = (67.0f / 60.0f);  // BPM to Hz
            _topicInfo.RespRate.RateInHz = (23.0f / 60.0f); // BPM to Hz
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            PaintAvatarInfo avatarInfo = new PaintAvatarInfo() { PaintEventArgs = e, TopicInfo = _topicInfo };


            int destWidth = ClientSize.Width - 280;// -280 for the controls, anchored right
            int destHeight = ClientSize.Height;

            float sourceWidth = 150.0f;
            float sourceHeight = 150.0f;

            /* Example to calculate initial matrix:
             * 
             * Image is scaled to maximum size that is possible within destWidth/destHeight
             * and then centered in that area.
             */
            float scaleFactorX = destWidth / sourceWidth; 
            float scaleFactorY = destHeight / sourceHeight;

            // limit scaling: not zero and no negative values
            if (scaleFactorX < 0.01f) scaleFactorX = 0.01f;
            if (scaleFactorY < 0.01f) scaleFactorY = 0.01f;

            // use the smaller one, so it fits
            float scaleFactor = scaleFactorX;
            if (scaleFactorY < scaleFactor) scaleFactor = scaleFactorY;

            // this will give us this size:
            float resultWidth = sourceWidth * scaleFactor;
            float resultHeight = sourceHeight * scaleFactor; 

            // that can be centered this way (one of the values typically is 0)
            float xOffset = (destWidth - resultWidth) / 2;
            float yOffset = (destHeight - resultHeight) / 2;

            _paintAvatar.SetInitialMatrix(scaleFactor, 0.0f, 0.0f, scaleFactor, xOffset, yOffset);

            _paintAvatar.PaintSVG(avatarInfo);
        }

        private void OnTick(object sender, System.EventArgs e)
        {
            _topicInfo.SometimeHavePassed(0.05f);
            //_topicInfo.TidalVolume.NextValue();

            Invalidate();
        }

        private void OnHeartRateTrackerChanged(object sender, EventArgs e)
        {
            lblHeartRateValue.Text = heartRateTracker.Value.ToString();
            _topicInfo.SetHeartRate(heartRateTracker.Value);
        }

        private void OnRRTrackerChanged(object sender, EventArgs e)
        {
            _lblRespRate.Text = RRTracker.Value.ToString();
            _topicInfo.SetRespRate(RRTracker.Value);
        }

        private void OnOxygenTrackerScroll(object sender, EventArgs e)
        {
            _lblSpo2.Text = oxygenTracker.Value.ToString();
            _topicInfo.SetSpO2(oxygenTracker.Value);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            _lblRespRate.Text = RRTracker.Value.ToString();
            _lblSpo2.Text = oxygenTracker.Value.ToString();
            lblHeartRateValue.Text = heartRateTracker.Value.ToString();
        }

        private void OnTidalVolumeTrackerScroll(object sender, EventArgs e)
        {
            _lblTidalValue.Text = tidalVolumeTracker.Value.ToString();
            _topicInfo.SetTidalVolume(tidalVolumeTracker.Value);
        }
    }
}
