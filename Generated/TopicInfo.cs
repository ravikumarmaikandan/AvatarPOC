using Philips.PIC.CommonControls;

namespace AvatarPOC
{
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
			PulseRateHeart.ThresholdMax = 160.0f;

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
}
