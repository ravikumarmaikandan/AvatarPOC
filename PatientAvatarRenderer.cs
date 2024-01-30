#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 3:06:46 PM
#endregion

using Philips.PIC.CommonControls.Generated;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls
{
    /// <summary>
    /// 
    /// </summary>
    public class PatientAvatarRenderer: IRenderPath
    {
        public void Fill(PaintAvatarInfo paintAvatarInfo)
        {
            paintAvatarInfo.PaintEventArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintAvatarInfo.PaintEventArgs.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            var red = FillColor / 0x10000;
            var green = (FillColor / 0x100) % 0x100;
            var blue = FillColor % 0x100;
            SolidBrush redBrush = new SolidBrush(
                Color.FromArgb(Opacity, red, green, blue));
            paintAvatarInfo.PaintEventArgs.Graphics.FillPath(redBrush, Path);
        }

        public void Interpolate(PaintAvatarInfo paintAvatarInfo, IRenderPath min, IRenderPath max, IRenderPath time)
        {
            // min.Path;
            // max.Path;
            // -> Path

            if (min.Path.PointCount != max.Path.PointCount) return;

            // iterate through all points in min (and max)
            // calculate the interpolated Point between the one of min and max
            // and put that to Path

            var minPoints = min.Path.PathPoints;
            var maxPoints = max.Path.PathPoints;
            var pathTypes = min.Path.PathTypes;

            var resultPoints = new PointF[minPoints.Length];

            var t = paintAvatarInfo.TopicInfo.temporyTimePosition;

            var t1 = 1.0f - t;

            for ( var i = 0; i < minPoints.Length; i++ )
            {
                resultPoints[i] = new PointF(
                        minPoints[i].X*t1 + maxPoints[i].X*t,
                        minPoints[i].Y*t1 + maxPoints[i].Y*t );
            }

            Path = new GraphicsPath(resultPoints, pathTypes);

            Fill(paintAvatarInfo);
        }

        public Int32 FillColor { get; set; } = 0;
        public int Opacity { get; set; } = 255;
        public GraphicsPath Path { get; set; } = new GraphicsPath();
        private float _cursorX;
        private float _cursorY;


        public void Start()
        {
            Path = new GraphicsPath();
        }

        public void Move(float x, float y)
        {
            _cursorX = x;
            _cursorY = y;
        }
        public void Line(float x, float y)
        {
            Path.AddLine(_cursorX, _cursorY, x, y);
            _cursorX = x;
            _cursorY = y;
        }
        public void Cubic(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Path.AddBezier(_cursorX, _cursorY, x1, y1, x2, y2, x3, y3);
            _cursorX = x3;
            _cursorY = y3;
        }
        public void Close()
        {
            Path.CloseFigure();
        }

    }
}
