using Philips.PIC.CommonControls;

namespace AvatarPOC
{
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
				case TopicStates.Max: State = TopicStates.Unknown; break;
			}
		}
	}
}
