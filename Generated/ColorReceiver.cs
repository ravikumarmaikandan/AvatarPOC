using System;

namespace Philips.PIC.CommonControls
{
    internal class ColorReceiver
    {
        public ColorReceiver(int intialColor)
        {
            FillColor = intialColor;
        }
        public Int32 FillColor { get; set; }
    }

    internal class OpacityReceiver
    {
        public OpacityReceiver(float intial)
        {
            Opacity = intial;
        }
        public float Opacity { get; set; }

    }
}