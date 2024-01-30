using System.Windows.Forms;

namespace Philips.PIC.CommonControls
{
    public partial class Form1 : Form
    {
        private readonly PaintAvatar _paintAvatar = new PaintAvatar();
        private readonly TopicInfo _topicInfo = new TopicInfo() { TemporyTimePosition = 0.0f };
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
            _topicInfo.TemporyTimePosition += 0.03f;
            if (_topicInfo.TemporyTimePosition > 1.0f)
            {
                _topicInfo.TemporyTimePosition -= 1.0f;
            }
            Invalidate();
        }
    }
}
