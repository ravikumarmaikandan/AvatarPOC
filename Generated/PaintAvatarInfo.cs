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

			Oxygen.SetColor(TopicStates.NotAvailable, 0xd0d0d0);
			Oxygen.SetColor(TopicStates.Unknown, 0xd0d0d0);
			Oxygen.SetColor(TopicStates.TooLow, 0xc04aff);
			Oxygen.SetColor(TopicStates.Safe, 0xad9890);
			Oxygen.SetColor(TopicStates.TooHigh, 0xaed6f1);
			Oxygen.SetShadowColor(TopicStates.NotAvailable, 0x505050);
			Oxygen.SetShadowColor(TopicStates.Unknown, 0x505050);
			Oxygen.SetShadowColor(TopicStates.TooLow, 0x5b146e);
			Oxygen.SetShadowColor(TopicStates.Safe, 0x6c5953);
			Oxygen.SetShadowColor(TopicStates.TooHigh, 0x839192);
			FiO2.SetColor(TopicStates.NotAvailable, 0xc0c0c0);
			FiO2.SetColor(TopicStates.Unknown, 0xc0c0c0);
			FiO2.SetColor(TopicStates.TooLow, 0x9e009e);
			FiO2.SetColor(TopicStates.Safe, 0xd4857c);
			FiO2.SetColor(TopicStates.TooHigh, 0xd9e7ff);
			FiO2.SetShadowColor(TopicStates.NotAvailable, 0x505050);
			FiO2.SetShadowColor(TopicStates.Unknown, 0x505050);
			FiO2.SetShadowColor(TopicStates.TooLow, 0x55345F);
			FiO2.SetShadowColor(TopicStates.Safe, 0x7B3A33);
			FiO2.SetShadowColor(TopicStates.TooHigh, 0x78808E);
			AWP.SetColor(TopicStates.NotAvailable, 0xd0d0d0);
			AWP.SetColor(TopicStates.Unknown, 0xd0d0d0);
			AWP.SetColor(TopicStates.TooLow, 0xc04aff);
			AWP.SetColor(TopicStates.Safe, 0xad9890);
			AWP.SetColor(TopicStates.TooHigh, 0xaed6f1);
			AWP.SetShadowColor(TopicStates.NotAvailable, 0x292929);
			AWP.SetShadowColor(TopicStates.Unknown, 0x292929);
			AWP.SetShadowColor(TopicStates.TooLow, 0x292929);
			AWP.SetShadowColor(TopicStates.Safe, 0x292929);
			AWP.SetShadowColor(TopicStates.TooHigh, 0x292929);

			RespRate.RateStopped = 0.0f;
			RespRate.RateLow = 1.0f / 20f;
			RespRate.RateSafe = 1.0f / 2.2f;
			RespRate.RateHigh = 1.0f / 0.26f;

			// ------------------------
			// not from monitor code, receive these values at runtime!
			PulseRateHeart.ThresholdMin = 50.0f;
			PulseRateHeart.ThresholdMax = 115.0f;

			RespRate.ThresholdMin = 8.0f;
			RespRate.ThresholdMax = 30.0f;

			Oxygen.ThresholdMin = 90.0f;
			Oxygen.ThresholdMax = 100.0f;

			TidalVolume.ThresholdMin = 7.0f;
			TidalVolume.ThresholdMax = 25.0f;

		}

		// Rates are used in Animations
		public RateProviderTopic PulseRateHeart { get; } = new RateProviderTopic();
		public RateProviderTopic PulseRateBody { get { return PulseRateHeart; } }
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

		public OrientationTopic Orientation { get; } = new OrientationTopic();

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

		public void SetTidalVolume(int measuredValue)
		{
			TidalVolume.SetMeasuredValue(measuredValue);
		}
	}

	public class STStateProviderTopic
	{
		// todo
	}

	public enum Orientations
	{
		up,
		down,
		perpendicular,
	}

	public class OrientationTopic
	{
		public virtual Orientations State { get; set; }
	}

	public class StateProviderTopic
	{
		public virtual TopicStates State { get; set; } = TopicStates.Safe;

		public float ThresholdMin { get; set; }
		public float ThresholdMax { get; set; }

		public void SetMeasuredValue(float value)
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

		public int[] ColorMap = new int[(int)TopicStates.Max];
		public int[] ShadowColorMap = new int[(int)TopicStates.Max];

		public void SetColor(TopicStates index, int value)
		{
			ColorMap[(int)index] = value;
		}
		public void SetShadowColor(TopicStates index, int value)
		{
			ShadowColorMap[(int)index] = value;
		}

		public int GetColor()
		{
			return ColorMap[(int)State];

		}

		public int GetShadowColor()
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

		public override TopicStates State
		{
			get { return base.State; }
			set
			{
				base.State = value;
				switch (value)
				{
					default: RateInHz = RateStopped; break;
					case TopicStates.TooLow: RateInHz = RateLow; break;
					case TopicStates.Safe: RateInHz = RateSafe; break;
					case TopicStates.TooHigh: RateInHz = RateHigh; break;
				}
			}
		}

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
		public const TopicStates low = TopicStates.TooLow;
		public const TopicStates safe = TopicStates.Safe;
		public const TopicStates high = TopicStates.TooHigh;

		public const TopicStates zero = TopicStates.Unknown;

		// todo: ST States
		public const TopicStates inferior = TopicStates.Unknown;
		public const TopicStates anterior = TopicStates.Unknown;
		public const TopicStates posterior = TopicStates.Unknown;
		public const TopicStates multi = TopicStates.Unknown;


		public const Orientations up = Orientations.up;
		public const Orientations down = Orientations.down;
		public const Orientations perpendicular = Orientations.perpendicular;

		public bool IsVisible(OrientationTopic topic, Orientations constant1)
		{
			return topic.State == constant1;
		}

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

		public bool IsVisible(STStateProviderTopic topic, TopicStates constant1)
		{
			return false; // todo
		}
		public bool IsVisible(STStateProviderTopic topic, TopicStates constant1, TopicStates constant2)
		{
			return false; // todo
		}

		public bool IsVisible(STStateProviderTopic topic, TopicStates constant1, TopicStates constant2, TopicStates constant3)
		{
			return false; // todo
		}




		public int GetColorFrom(StateProviderTopic topic)
		{
			return topic.GetColor();
		}
		public int GetShadowColorFrom(StateProviderTopic topic)
		{
			return topic.GetShadowColor();
		}

		public void PushMatrix(double a, double b, double c, double d, double e, double f)
		{
			TransformMatrix o = _patientAvatarRenderer.Transformation;

			float a1 = o.a; float c1 = o.c; float e1 = o.e;
			float b1 = o.b; float d1 = o.d; float f1 = o.f;

			float a2 = (float)a; float c2 = (float)c; float e2 = (float)e;
			float b2 = (float)b; float d2 = (float)d; float f2 = (float)f;

			TransformMatrix m = new TransformMatrix
			{

				a = a1 * a2 + b2 * c1,
				c = a1 * c2 + c1 * d2,
				e = e1 + a1 * e2 + c1 * f2,
				b = a2 * b1 + b2 * d1,
				d = b1 * c2 + d1 * d2,
				f = f1 + b1 * e2 + d1 * f2
			};
			_patientAvatarRenderer.Transformation = m;
		}

		protected readonly PatientAvatarRenderer _patientAvatarRenderer = new PatientAvatarRenderer();

	}
}
