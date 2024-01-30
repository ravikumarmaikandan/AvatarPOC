#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
#endregion
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

        public float GetYForX(float x)
        {
            /* todo:
             * this function should look into the path and calculate the y value for a given x
             * 
             * but as a quick hack, this now just implements this simple calculation:
             */
            x = x * 2.0f;
            if (x > 1.0f) x = 2.0f - x;
            return x;
        }
    }


}