#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
#endregion
namespace Philips.PIC.CommonControls
{
    public class RateProviderTopic
    {
        public float TimePosition { get; set; } = 0.0f;
        public float RateInHz { get; set; } = 60;

        public void Step(float secondsFromLast)
        {
            TimePosition += secondsFromLast*RateInHz;
            if (TimePosition >= 1.0f)
            {
                TimePosition -= 1.0f;
            }

            // todo: Reset in case of Rate = 0
            //if (approximately(RateInHz, 0.0f)) TimePosition = 0.0f;
        }
    }
}