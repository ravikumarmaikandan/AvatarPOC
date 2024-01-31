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

        public bool IsVisible(StateProviderTopic topic, int constant1)
        {
            return topic.Value == constant1;
        }
        public bool IsVisible(StateProviderTopic topic, int constant1, int constant2)
        {
            return (topic.Value == constant1) || (topic.Value == constant2);
        }
        public bool IsVisible(StateProviderTopic topic, int constant1, int constant2, int constant3)
        {
            return (topic.Value == constant1) || (topic.Value == constant2) || (topic.Value == constant3);
        }

    }

    public class TopicInfo
    {
        public TopicInfo()
        {
            /*
             * Some lines copied from Monitor code
             * 
            PulseRateHeart.rateLow = 0.16667; // 1.0 / (60.0/10);
            PulseRateHeart.rateSafe = 1.11667; // 1.0 / (60.0/67);
            PulseRateHeart.rateHigh = 3.33333; // 1.0 / (60.0/200);

            PulseRateBody.rateStopped = 0.0;
            PulseRateBody.rateLow = PulseRateHeart.rateLow;
            PulseRateBody.rateSafe = PulseRateHeart.rateSafe;
            PulseRateBody.rateHigh = PulseRateHeart.rateHigh;

            Oxygen.colors[notavail] = AsColor("#d0d0d0");
            Oxygen.colors[unknown] = AsColor("#d0d0d0");
            Oxygen.colors[low] = AsColor("#c04aff");
            Oxygen.colors[safe] = AsColor("#ad9890");
            Oxygen.colors[high] = AsColor("#aed6f1");
            Oxygen.shadowColors[notavail] = AsColor("#505050");
            Oxygen.shadowColors[unknown] = AsColor("#505050");
            Oxygen.shadowColors[low] = AsColor("#5b146e");
            Oxygen.shadowColors[safe] = AsColor("#6c5953");
            Oxygen.shadowColors[high] = AsColor("#839192");

            FiO2.colors[notavail] = AsColor("#c0c0c0");
            FiO2.colors[unknown] = AsColor("#c0c0c0");
            FiO2.colors[low] = AsColor("#9e009e");
            FiO2.colors[safe] = AsColor("#d4857c");
            FiO2.colors[high] = AsColor("#d9e7ff");
            FiO2.shadowColors[notavail] = AsColor("#505050");
            FiO2.shadowColors[unknown] = AsColor("#505050");
            FiO2.shadowColors[low] = AsColor("#55345F");
            FiO2.shadowColors[safe] = AsColor("#7B3A33");
            FiO2.shadowColors[high] = AsColor("#78808E");

            AWP.colors[notavail] = AsColor("#d0d0d0");
            AWP.colors[unknown] = AsColor("#d0d0d0");
            AWP.colors[low] = AsColor("#c04aff");
            AWP.colors[safe] = AsColor("#ad9890");
            AWP.colors[high] = AsColor("#aed6f1");
            AWP.shadowColors[notavail] = AsColor("#292929");
            AWP.shadowColors[unknown] = AsColor("#292929");
            AWP.shadowColors[low] = AsColor("#292929");
            AWP.shadowColors[safe] = AsColor("#292929");
            AWP.shadowColors[high] = AsColor("#292929");

            RespRate.rateStopped = 0.0;
            RespRate.rateLow = 1.0 / 20;
            RespRate.rateSafe = 1.0 / 2.2;
            RespRate.rateHigh = 1.0 / 0.26;
            */

        }

        // Rates are used in Animations
        public RateProviderTopic PulseRateHeart { get; } = new RateProviderTopic();
        public RateProviderTopic PulseRateBody { get; } = new RateProviderTopic();
        public RateProviderTopic RespRate { get; } = new RateProviderTopic();

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
        public int Value { get; set; }

        public void NextValue()
        {
            // obviously: this is completely nonsense!
            // just a test to have different Values
            Value += 1;
            if (Value == 10) Value = 0;
        }
    }

    public class PatientAvatarBase
    {
        public const int notavail = 0;
        public const int unknown = 1;
        public const int safe = 2;
    }
}
