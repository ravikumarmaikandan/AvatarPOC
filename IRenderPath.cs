using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Philips.PIC.CommonControls
{
    public interface IRenderPath
    {
        GraphicsPath Path { get; set; }

        void Start();
        void Move(float x, float y);
        void Line(float x, float y);
        void Close();
        void Cubic(float x1, float y1, float x2, float y2, float x3, float y3);
    }
}
