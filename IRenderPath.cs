#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
#endregion
using System.Drawing.Drawing2D;

namespace Philips.PIC.CommonControls
{
    public interface IRenderPath
    {
        GraphicsPath Path { get; set; }

        void Move(float x, float y);
        void Line(float x, float y);
        void Close();
        void Cubic(float x1, float y1, float x2, float y2, float x3, float y3);
    }
}
