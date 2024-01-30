#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 3:06:46 PM
#endregion

using AvatarPOC.Generated;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace AvatarPOC
{
    /// <summary>
    /// 
    /// </summary>
    public class PatientAvatarRenderer
    {
        public void Fill(PaintAvatarInfo paintAvatarInfo)
        {
            paintAvatarInfo.PaintEventArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintAvatarInfo.PaintEventArgs.Graphics.CompositingQuality = CompositingQuality.HighQuality;

            SolidBrush redBrush = new SolidBrush(FillColor);
            paintAvatarInfo.PaintEventArgs.Graphics.FillPath(redBrush, Path);
        }

        public void Ellipse(float x, float y, float width, float height)
        {
            Path = new GraphicsPath();
            Path.AddEllipse(x, y, width, height);
        }


        public Color FillColor { get; set; }
        public GraphicsPath Path { get; set; } = new GraphicsPath();
        private float _cursorX;
        private float _cursorY;

        public void Move(float x, float y)
        {
            _cursorX = x;
            _cursorY = y;
        }

        public void Curve(float x1, float y1, float x2, float y2, float x3, float y3)
        {
            Path.AddBezier(_cursorX, _cursorY, x1, y1, x2, y2, x3, y3);
            _cursorX = x3;
            _cursorY = y3;
        }
    }
}
