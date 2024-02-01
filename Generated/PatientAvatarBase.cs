using Philips.PIC.CommonControls;

namespace AvatarPOC
{
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
