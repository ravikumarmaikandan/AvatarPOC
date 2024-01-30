#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 2:47:25 PM
#endregion

using System.Windows.Forms;

namespace Philips.PIC.CommonControls
{
    /// <summary>
    /// 
    /// </summary>
    public class PaintAvatarInfo
    {
        public PaintEventArgs PaintEventArgs { get; set; }
        public TopicInfo TopicInfo { get; set; }

    }

    public class TopicInfo
    {
        public RateProviderTopic PulseRateHeart { get; set; } = new RateProviderTopic();
        public RateProviderTopic RespirationRate { get; set; } = new RateProviderTopic();
    }
}
