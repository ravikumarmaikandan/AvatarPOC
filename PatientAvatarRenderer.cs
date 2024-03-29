#region Header
// � 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 3:06:46 PM
#endregion

using System.Drawing;
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls
{
	/// <summary>
	/// 
	/// </summary>
	public class PatientAvatarRenderer
	{
		public PatientAvatarRenderer()
		{
			Transformation.a = 1.0f;
			Transformation.d = 1.0f;
		}

		public void Fill(PaintAvatarInfo paintAvatarInfo, IRenderPath renderPath)
		{
			paintAvatarInfo.PaintEventArgs.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			paintAvatarInfo.PaintEventArgs.Graphics.CompositingQuality = CompositingQuality.HighQuality;
			var red = FillColor / 0x10000;
			var green = (FillColor / 0x100) % 0x100;
			var blue = FillColor % 0x100;
			SolidBrush redBrush = new SolidBrush(
				Color.FromArgb(Opacity, red, green, blue));

			Matrix m = new Matrix(Transformation.a,
				Transformation.b,
				Transformation.c,
				Transformation.d,
				Transformation.e,
				Transformation.f);

			paintAvatarInfo.PaintEventArgs.Graphics.Transform = m;
			paintAvatarInfo.PaintEventArgs.Graphics.FillPath(redBrush, renderPath.Path);
		}

		public void Interpolate(PaintAvatarInfo paintAvatarInfo, IRenderPath min, IRenderPath max, IRenderPath time, RateProviderTopic topic)
		{

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

		public int FillColor { get; set; } = 0;
		public int Opacity { get; set; } = 255;

		public TransformMatrix Transformation { get; set; } = new TransformMatrix();
	}
}
