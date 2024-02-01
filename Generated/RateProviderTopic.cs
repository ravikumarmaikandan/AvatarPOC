#region Header
// © 2024 Koninklijke Philips N.V.  All rights reserved.
// Reproduction or transmission in whole or in part, in any form or by any means, 
// electronic, mechanical or otherwise, is prohibited without the prior  written consent of 
// the owner.
#endregion
using AvatarPOC;

namespace Philips.PIC.CommonControls
{
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
}