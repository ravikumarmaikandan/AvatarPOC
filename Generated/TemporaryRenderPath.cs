using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls
{
    internal class TemporaryRenderPath : IRenderPath
    {
        public TemporaryRenderPath()
        {
            Path = new GraphicsPath();
        }
        public TemporaryRenderPath(PointF[] points, byte[] pathTypes)
        {
            Path = new GraphicsPath(points, pathTypes);
        }

        public GraphicsPath Path { get; set; }
        private float _cursorX;
        private float _cursorY;

        public void Close()
        {
            Path.CloseFigure();
        }

        public void Cubic(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Path.AddBezier(_cursorX, _cursorY, x1, y1, x2, y2, x3, y3);
            _cursorX = x3;
            _cursorY = y3;
        }

        public void Line(float x, float y)
        {
            Path.AddLine(_cursorX, _cursorY, x, y);
            _cursorX = x;
            _cursorY = y;

        }

        public void Move(float x, float y)
        {
            _cursorX = x;
            _cursorY = y;
        }
    }
}