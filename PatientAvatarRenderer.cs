#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 3:06:46 PM
#endregion

using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;

namespace Philips.PIC.CommonControls
{
    /// <summary>
    /// 
    /// </summary>
    public class PatientAvatarRenderer
    {
        public PatientAvatarRenderer()
        {
            Transformation.A = 1.0f;
            Transformation.D = 1.0f;
        }

        public void Fill(PaintAvatarInfo paintAvatarInfo, IRenderPath renderPath)
        {
            if (FillColor == -1) return;

            paintAvatarInfo.PaintEventArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            paintAvatarInfo.PaintEventArgs.Graphics.CompositingQuality = CompositingQuality.HighQuality;
            var red = FillColor / 0x10000;
            var green = (FillColor / 0x100) % 0x100;
            var blue = FillColor % 0x100;

            int opacity = (int)System.Math.Round(Opacity * 255.0);
            if (opacity <= 0) return;
            if (opacity > 255) opacity = 255;

            SolidBrush redBrush = new SolidBrush(
                Color.FromArgb(opacity, red, green, blue));

            Matrix m = new Matrix(Transformation.A,
                Transformation.B,
                Transformation.C,
                Transformation.D,
                Transformation.E,
                Transformation.F);

            paintAvatarInfo.PaintEventArgs.Graphics.Transform = m;
            paintAvatarInfo.PaintEventArgs.Graphics.FillPath(redBrush, renderPath.Path);
        }

        public void Interpolate(PaintAvatarInfo paintAvatarInfo, IRenderPath min, IRenderPath max, IRenderPath time, RateProviderTopic topic)
        {
            if (FillColor == -1) return;

            // Generated Code should not contain such pathes
            if (min.Path.PointCount != max.Path.PointCount) return;

            // iterate through all points in min (and max)
            // calculate the interpolated Point between the one of min and max
            // and put that to Path

            var minPoints = min.Path.PathPoints;
            var maxPoints = max.Path.PathPoints;
            var pathTypes = min.Path.PathTypes;

            var resultPoints = new PointF[minPoints.Length];

            var t = topic.TimePosition;

            if (time != null)
                t = time.GetYForX(t);

            if (t < 0.0f) t = 0.0f;
            if (t > 1.0f) t = 1.0f;

            var t1 = 1.0f - t;

            for (var i = 0; i < minPoints.Length; i++)
            {
                resultPoints[i] = new PointF(
                        minPoints[i].X * t1 + maxPoints[i].X * t,
                        minPoints[i].Y * t1 + maxPoints[i].Y * t);
            }

            var tempRenderPath = new TemporaryRenderPath(resultPoints, pathTypes);

            Fill(paintAvatarInfo, tempRenderPath);
        }
        public void MultiPointInterpolate(PaintAvatarInfo paintAvatarInfo, IRenderPath[] list, IRenderPath time, RateProviderTopic topic)
        {
            if (FillColor == -1) return;

            var length = list.Length;

            // count is the number of key points of animation
            var count = list.Length;
            if (count > 2) count -= 3;
            if (count <= 0) count = 1;

            var pathTypes = list[0].Path.PathTypes;
            var resultPoints = new PointF[pathTypes.Length];

            var t = topic.TimePosition;
            if (time != null)
                t = time.GetYForX(t);

            if (t < 0.0f) t = 0.0f;
            if (t > 1.0f) t = 1.0f;

            // map t to "key points": Where we are in the array of control points
            t = t * count;
            int idx = (int)System.Math.Floor(t);

            t = t - idx; // = fract of t = where we are between two points

            // Interpolation: from "pB" to "pC"
            // as if we "come from pA" (=what happened before pB)
            // and "will go to pD" (=what happens after pC)
            // start is "idx" here, which should be pB, so step back one:
            idx--; if (idx < 0) idx += length; // wrap?

            // and get our point sources
            var pA = list[idx++].Path.PathPoints; if (idx >= length) idx -= length;
            var pB = list[idx++].Path.PathPoints; if (idx >= length) idx -= length;
            var pC = list[idx++].Path.PathPoints; if (idx >= length) idx -= length;
            var pD = list[idx++].Path.PathPoints; 

            // "catmull rom" factors for interpolation of our control points
            float t2 = t * t;
            float t3 = t * t * t;
            float fA = -0.5f * t + 1.0f * t2 - 0.5f * t3;
            float fB = 1.0f - 2.5f * t2 + 1.5f * t3;
            float fC = 0.5f * t + 2.0f * t2 - 1.5f * t3;
            float fD = -0.5f * t2 + 0.5f * t3;

            for (var i = 0; i < pA.Length; i++)
            {
                float pAx = pA[i].X;
                float pAy = pA[i].Y;
                float pBx = pB[i].X;
                float pBy = pB[i].Y;
                float pCx = pC[i].X;
                float pCy = pC[i].Y;
                float pDx = pD[i].X;
                float pDy = pD[i].Y;

                resultPoints[i] = new PointF(
                    pAx * fA + pBx * fB + pCx * fC + pDx * fD,
                    pAy * fA + pBy * fB + pCy * fC + pDy * fD);

            }

            var tempRenderPath = new TemporaryRenderPath(resultPoints, pathTypes);
            Fill(paintAvatarInfo, tempRenderPath);
        }

        public int FillColor { get; set; } = -1;
        public float Opacity { get; set; } = 1.0f;

        public TransformMatrix Transformation { get; set; } = new TransformMatrix();
    }



}
