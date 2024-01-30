﻿using Philips.PIC.CommonControls.Generated;
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
            _paintAvatar.PaintSVG(avatarInfo);
        }

        private void OnTick(object sender, System.EventArgs e)
        {
            _topicInfo.PulseRateHeart.Step();
            _topicInfo.RespirationRate.Step();

            Invalidate();
        }
    }
}
