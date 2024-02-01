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

    public class TransformMatrix
    {
        public float a;
        public float b;
        public float c;
        public float d;
        public float e;
        public float f;
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

            // PulseRateBody.RateStopped = 0.0f;
            // PulseRateBody.RateLow = PulseRateHeart.RateLow;
            // PulseRateBody.RateSafe = PulseRateHeart.RateSafe;
            // PulseRateBody.RateHigh = PulseRateHeart.RateHigh;

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

            // ------------------------
            // not from monitor code, receive these values at runtime!
            PulseRateHeart.ThresholdMin = 50.0f;
            PulseRateHeart.ThresholdMax = 50.0f;

            RespRate.ThresholdMin = 8.0f;
            RespRate.ThresholdMax = 30.0f;

            Oxygen.ThresholdMin = 90.0f;
            Oxygen.ThresholdMax = 100.0f;

            TidalVolume.ThresholdMin = 7.0f;
            TidalVolume.ThresholdMax = 25.0f;

        }

        // Rates are used in Animations
        public RateProviderTopic PulseRateHeart { get; } = new RateProviderTopic();
        public RateProviderTopic PulseRateBody { get { return PulseRateHeart;  } } 
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
            RespRate.Step(secondsFromLast);
        }

        public void SetHeartRate(int measuredValue)
        {
            PulseRateHeart.SetMeasuredValue(measuredValue);
        }
        public void SetRespRate(int measuredValue)
        {
            //Compare the Resp rate with the threshold
            RespRate.SetMeasuredValue(measuredValue);
        }
        public void SetSpO2(int measuredValue)
        {
            //Compare the Resp rate with the threshold
            Oxygen.SetMeasuredValue(measuredValue);
        }
    }

    public class STStateProviderTopic
    {
        // todo
    }

    public class StateProviderTopic
    {
        public virtual TopicStates State { get; set; } = TopicStates.TooLow;

        public float ThresholdMin { get; set; }
        public float ThresholdMax { get; set; }

        public void SetMeasuredValue( float value )
        {
            if (value < ThresholdMin)
            {
                State = TopicStates.TooLow;
            }
            else if (value > ThresholdMax)
            {
                State = TopicStates.TooHigh;
            }
            else
            {
                State = TopicStates.Safe;
            }
        }

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

        public int GetColor()
        {
            var c = ColorMap[(int)State];

            return c.R * 0x10000 + c.G * 0x100 + c.B;

        }

        public Color GetShadowColor()
        {
            return ShadowColorMap[(int)State];
        }

        public void NextValue()
        {
            // obviously: this is completely nonsense!
            // just a test to have different Values
            switch (State)
            {
                case TopicStates.NotAvailable: State = TopicStates.Unknown; break;
                case TopicStates.Unknown: State = TopicStates.TooLow; break;
                case TopicStates.TooLow: State = TopicStates.Safe; break;
                default:
                case TopicStates.Safe: State = TopicStates.Unknown; break;
                case TopicStates.TooHigh: State = TopicStates.Unknown; break;
            }
        }
    }

    public class RateProviderTopic : StateProviderTopic
    {
        internal float RateStopped;
        internal float RateLow;
        internal float RateSafe;
        internal float RateHigh;

        public override TopicStates State { get { return base.State; } set
            {
                base.State = value;
                switch (value)
                {
                    default: RateInHz = RateStopped;break;
                    case TopicStates.TooLow: RateInHz = RateLow; break;
                    case TopicStates.Safe: RateInHz = RateSafe; break;
                    case TopicStates.TooHigh: RateInHz = RateHigh; break;
                }
            } }

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
            return topic.State == constant1;
        }

        public bool IsVisible(StateProviderTopic topic, TopicStates constant1, TopicStates constant2)
        {
            return (topic.State == constant1) || (topic.State == constant2);
        }

        public bool IsVisible(StateProviderTopic topic, TopicStates constant1, TopicStates constant2, TopicStates constant3)
        {
            return (topic.State == constant1) || (topic.State == constant2) || (topic.State == constant3);
        }

        public void SetColorFrom(PatientAvatarRenderer r, StateProviderTopic topic)
        {
            r.FillColor = topic.GetColor();
        }

        public void PushMatrix(double a, double b, double c, double d, double e, double f)
        {
            TransformMatrix o = _patientAvatarRenderer.transformation;

            float a1 = o.a; float c1 = o.c; float e1 = o.e;
            float b1 = o.b; float d1 = o.d; float f1 = o.f;

            float a2 = (float)a; float c2 = (float)c; float e2 = (float)e;
            float b2 = (float)b; float d2 = (float)d; float f2 = (float)f;

            TransformMatrix m = new TransformMatrix();

            m.a = a1 * a2 + b2 * c1; m.c = a1 * c2 + c1 * d2; m.e = e1 + a1 * e2 + c1 * f2;
            m.b = a2 * b1 + b2 * d1; m.d = b1 * c2 + d1 * d2; m.f = f1 + b1 * e2 + d1 * f2;

            _patientAvatarRenderer.transformation = m;
        }

        protected readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();

    }
}
