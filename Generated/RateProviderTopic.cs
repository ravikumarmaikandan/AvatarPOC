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
        public float StepRate { get; set; } = 0.03f;

        public void Step()
        {
            TimePosition += StepRate;
            if (TimePosition >= 1.0f)
            {
                TimePosition -= 1.0f;
            }

        }
    }
}