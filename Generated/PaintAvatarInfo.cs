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
        // Rates are used in Animations
        public RateProviderTopic PulseRateHeart { get; } = new RateProviderTopic();
        public RateProviderTopic PulseRateBody { get; } = new RateProviderTopic();
        public RateProviderTopic RespRate { get; }= new RateProviderTopic();

        public StateProviderTopic ABP { get; } = new StateProviderTopic();
        public StateProviderTopic CVP { get; } = new StateProviderTopic();
        public StateProviderTopic Oxygen { get; } = new StateProviderTopic();
        public StateProviderTopic TidalVolume { get; } = new StateProviderTopic();
        public StateProviderTopic CO2 { get; } = new StateProviderTopic();
        public StateProviderTopic Temp { get; } = new StateProviderTopic();
        public StateProviderTopic Brain { get; } = new StateProviderTopic();
        public StateProviderTopic CO { get; } = new StateProviderTopic();
        public StateProviderTopic FiO2 { get; } = new StateProviderTopic();
        public StateProviderTopic AWP { get; } = new StateProviderTopic();
        public StateProviderTopic Neuromuscular { get; } = new StateProviderTopic();

        //STE Parameter 
        public STStateProviderTopic STSegment { get; } = new STStateProviderTopic();

    }

    public class STStateProviderTopic
    {
    }

    public class StateProviderTopic
    {
    }
}
