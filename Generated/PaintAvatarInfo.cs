#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
// Author:      Ravikumar.Maikandan
// Date:        1/29/2024 2:47:25 PM
#endregion

using System.Drawing;
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
    public enum TopicStates
    {
        NotAvailable,
        Unknown,
        TooLow,
        Safe,
        TooHigh,
        Max
    }

    public class TopicInfo
    {
        public TopicInfo()
        {
            /*
             * all these constants are copied from Monitor code:
             * 
             * They were defined by the designers, but are not placed into the image file
             * 
             * The order of lines is kept to be identical to the monitor code
             */

            PulseRateHeart.RateStopped = 0.0f;
            PulseRateHeart.RateLow = 0.16667f; // 1.0 / (60.0/10);
            PulseRateHeart.RateSafe = 1.11667f; // 1.0 / (60.0/67);
            PulseRateHeart.RateHigh = 3.33333f; // 1.0 / (60.0/200);

            PulseRateBody.RateStopped = 0.0f;
            PulseRateBody.RateLow = PulseRateHeart.RateLow;
            PulseRateBody.RateSafe = PulseRateHeart.RateSafe;
            PulseRateBody.RateHigh = PulseRateHeart.RateHigh;

            Oxygen.SetColor(TopicStates.NotAvailable, 0xd0, 0xd0, 0xd0);
            Oxygen.SetColor(TopicStates.Unknown, 0xd0, 0xd0, 0xd0);
            Oxygen.SetColor(TopicStates.TooLow, 0xc0, 0x4a, 0xff);
            Oxygen.SetColor(TopicStates.Safe, 0xad, 0x98, 0x90);
            Oxygen.SetColor(TopicStates.TooHigh, 0xae, 0xd6, 0xf1);


            Oxygen.SetShadowColor(TopicStates.NotAvailable, 0x50, 0x50, 0x50);
            Oxygen.SetShadowColor(TopicStates.Unknown, 0x50, 0x50, 0x50);
            Oxygen.SetShadowColor(TopicStates.TooLow, 0x5b, 0x14, 0x6e);
            Oxygen.SetShadowColor(TopicStates.Safe, 0x6c, 0x59, 0x53);
            Oxygen.SetShadowColor(TopicStates.TooHigh, 0x83, 0x91, 0x92);

            FiO2.SetColor(TopicStates.NotAvailable, 0xc0, 0xc0, 0xc0);
            FiO2.SetColor(TopicStates.Unknown, 0xc0, 0xc0, 0xc0);
            FiO2.SetColor(TopicStates.TooLow, 0x9e, 0x00, 0x9e);
            FiO2.SetColor(TopicStates.Safe, 0xd4, 0x85, 0x7c);
            FiO2.SetColor(TopicStates.TooHigh, 0xd9, 0xe7, 0xff);
            FiO2.SetShadowColor(TopicStates.NotAvailable, 0x50, 0x50, 0x50);
            FiO2.SetShadowColor(TopicStates.Unknown, 0x50, 0x50, 0x50);
            FiO2.SetShadowColor(TopicStates.TooLow, 0x55, 0x34, 0x5F);
            FiO2.SetShadowColor(TopicStates.Safe, 0x7B, 0x3A, 0x33);
            FiO2.SetShadowColor(TopicStates.TooHigh, 0x78, 0x80, 0x8E);
            AWP.SetColor(TopicStates.NotAvailable, 0xd0, 0xd0, 0xd0);
            AWP.SetColor(TopicStates.Unknown, 0xd0, 0xd0, 0xd0);
            AWP.SetColor(TopicStates.TooLow, 0xc0, 0x4a, 0xff);
            AWP.SetColor(TopicStates.Safe, 0xad, 0x98, 0x90);
            AWP.SetColor(TopicStates.TooHigh, 0xae, 0xd6, 0xf1);
            AWP.SetShadowColor(TopicStates.NotAvailable, 0x29, 0x29, 0x29);
            AWP.SetShadowColor(TopicStates.Unknown, 0x29, 0x29, 0x29);
            AWP.SetShadowColor(TopicStates.TooLow, 0x29, 0x29, 0x29);
            AWP.SetShadowColor(TopicStates.Safe, 0x29, 0x29, 0x29);
            AWP.SetShadowColor(TopicStates.TooHigh, 0x29, 0x29, 0x29);

            RespRate.RateStopped = 0.0f;
            RespRate.RateLow = 1.0f / 20f;
            RespRate.RateSafe = 1.0f / 2.2f;
            RespRate.RateHigh = 1.0f / 0.26f;
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

        public void SometimeHavePassed(float secondsFromLast)
        {
            PulseRateHeart.Step(secondsFromLast);
            PulseRateBody.Step(secondsFromLast);
            RespRate.Step(secondsFromLast);
        }

        public void SetHeartRate(int value)
        {
            //Compare the heart rate with the threshold
            if (value < 50)
            {
                PulseRateHeart.RateInHz = PulseRateHeart.RateLow;
                PulseRateHeart.Value = TopicStates.TooLow;
            }
            else if (value > 130)
            {
                PulseRateHeart.RateInHz = PulseRateHeart.RateHigh;
                PulseRateHeart.Value = TopicStates.TooHigh;
            }
            else
            {
                PulseRateHeart.RateInHz = PulseRateHeart.RateSafe;
                PulseRateHeart.Value = TopicStates.Safe;
            }

        }
        public void SetRespRate(int rrTrackerValue)
        {
            //Compare the Resp rate with the threshold
            if (rrTrackerValue < 8)
            {
                RespRate.RateInHz = RespRate.RateLow;
                RespRate.Value = TopicStates.TooLow;
            }
            else if (rrTrackerValue > 30)
            {
                RespRate.RateInHz = RespRate.RateHigh;
                RespRate.Value = TopicStates.TooHigh;
            }
            else
            {
                RespRate.RateInHz = RespRate.RateSafe;
                RespRate.Value = TopicStates.Safe;
            }
        }
    }

    public class STStateProviderTopic
    {
        // todo
    }

    public class StateProviderTopic
    {
        public TopicStates Value { get; set; }

        public Color[] ColorMap = new Color[(int)TopicStates.Max];
        public Color[] ShadowColorMap = new Color[(int)TopicStates.Max];

        public void SetColor(TopicStates index, int r, int g, int b)
        {
            ColorMap[(int)index] = Color.FromArgb(255, r, g, b);
        }
        public void SetShadowColor(TopicStates index, int r, int g, int b)
        {
            ShadowColorMap[(int)index] = Color.FromArgb(255, r, g, b);
        }

        public Color GetColor()
        {
            return ColorMap[(int)Value];
        }

        public Color GetShadowColor()
        {
            return ShadowColorMap[(int)Value];
        }

        public void NextValue()
        {
            // obviously: this is completely nonsense!
            // just a test to have different Values
            switch (Value)
            {
                case TopicStates.NotAvailable: Value = TopicStates.Unknown; break;
                case TopicStates.Unknown: Value = TopicStates.TooLow; break;
                case TopicStates.TooLow: Value = TopicStates.Safe; break;
                default:
                case TopicStates.Safe: Value = TopicStates.Unknown; break;
                case TopicStates.TooHigh: Value = TopicStates.Unknown; break;
            }
        }
    }

    public class RateProviderTopic : StateProviderTopic
    {
        internal float RateStopped;
        internal float RateLow;
        internal float RateSafe;
        internal float RateHigh;

        public float TimePosition { get; set; } = 0.0f;
        public float RateInHz { get; set; } = 60;

        public void Step(float secondsFromLast)
        {
            TimePosition += secondsFromLast * RateInHz;
            if (TimePosition >= 1.0f)
            {
                TimePosition -= 1.0f;
            }

            // todo: Reset in case of Rate = 0, with epsilon = 0.0001
            if (RateInHz < 0.0001f) TimePosition = 0.0f;
        }
    }


    public class PatientAvatarBase
    {
        // these constants are defined here, as the generated code expect these identifiers:
        // (they are written like this in the wuschel.svg file)
        public const TopicStates notavail = TopicStates.NotAvailable;
        public const TopicStates unknown = TopicStates.Unknown;
        public const TopicStates safe = TopicStates.Safe;

        public bool IsVisible(StateProviderTopic topic, TopicStates constant1)
        {
            return topic.Value == constant1;
        }

        public bool IsVisible(StateProviderTopic topic, TopicStates constant1, TopicStates constant2)
        {
            return (topic.Value == constant1) || (topic.Value == constant2);
        }

        public bool IsVisible(StateProviderTopic topic, TopicStates constant1, TopicStates constant2, TopicStates constant3)
        {
            return (topic.Value == constant1) || (topic.Value == constant2) || (topic.Value == constant3);
        }
    }
}
