using System;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
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

            Invalidate();
        }

        private void OnHeartRateTrackerChanged(object sender, EventArgs e)
        {
            _topicInfo.SetHeartRate(GetValue(heartRateTracker));
            UpdateTexts();
        }

        private void OnRRTrackerChanged(object sender, EventArgs e)
        {
            _topicInfo.SetRespRate(GetValue(RRTracker));
            UpdateTexts();
        }

        private void OnOxygenTrackerScroll(object sender, EventArgs e)
        {
            _topicInfo.SetSpO2(GetValue(oxygenTracker));
            UpdateTexts();
        }

        private void UpdateText(System.Windows.Forms.Label lbl, TrackBar tb, float factor = 1.0f )
        {
            if (tb.Value <= tb.Minimum)
                lbl.Text = "NA";
            else if (tb.Value >= tb.Maximum)
                lbl.Text = "Unk";
            else
                lbl.Text = (tb.Value * factor).ToString();
        }

        private float GetValue( TrackBar tb, float factor = 1.0f )
        {
            if (tb.Value <= tb.Minimum)
                return -2000.0f; // 'Not available' constant 
            else if (tb.Value >= tb.Maximum)
                return -1000.0f; // 'unknown' constant
            else
                return (tb.Value * factor);
        }

        private void UpdateTexts()
        {
            UpdateText( _lblRespRate, RRTracker);
            UpdateText( _lblSpo2, oxygenTracker);
            UpdateText( lblHeartRateValue, heartRateTracker);
            UpdateText( pulseLabel, pulseBar);
            UpdateText( pressureLabel, pressureBar);
            UpdateText(_lblTidalValue, tidalVolumeTracker);
            UpdateText( tempLabel, tempBar, 0.1f);
        }

        private void OnLoad(object sender, EventArgs e)
        {

            UpdateTexts();

            // for quick testing: directly set state, without using Method
            _topicInfo.PulseRateHeart.State = TopicStates.NotAvailable;
            _topicInfo.PulseRateBody.State = TopicStates.NotAvailable;
            _topicInfo.RespRate.State = TopicStates.NotAvailable;
            _topicInfo.ABP.State = TopicStates.NotAvailable;
            _topicInfo.CVP.State = TopicStates.NotAvailable;
            _topicInfo.Oxygen.State = TopicStates.NotAvailable;
            _topicInfo.TidalVolume.State = TopicStates.NotAvailable;
            _topicInfo.CO2.State = TopicStates.Safe;
            _topicInfo.Temp.State = TopicStates.NotAvailable;
            _topicInfo.Brain.State = TopicStates.TooHigh;
            _topicInfo.CO.State = TopicStates.NotAvailable;
            _topicInfo.FiO2.State = TopicStates.NotAvailable; 
            _topicInfo.AWP.State = TopicStates.NotAvailable;
            _topicInfo.Neuromuscular.State = TopicStates.NotAvailable;

            // todo: _topicInfo.STSegment

            _topicInfo.Orientation.State = Orientations.up;

    }

    private void OnTidalVolumeTrackerScroll(object sender, EventArgs e)
        {
            UpdateTexts();
            _topicInfo.SetTidalVolume(GetValue(tidalVolumeTracker));
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _topicInfo.SetTemp(GetValue(tempBar, 0.1f));
            UpdateTexts();
        }

        private void pulseBar_Scroll(object sender, EventArgs e)
        {
            _topicInfo.SetPulseRate(GetValue(pulseBar));
            UpdateTexts();
        }

        private void pressureBar_Scroll(object sender, EventArgs e)
        {
            _topicInfo.SetPressure(GetValue(pressureBar));
            UpdateTexts();
        }
    }
}
