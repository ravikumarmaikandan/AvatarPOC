namespace Philips.PIC.CommonControls.Generated
{
    public class RateProviderTopic
    {
        public float timePosition { get; set; } = 0.0f;

        public void Step()
        {
            timePosition += 0.03f;
            if (timePosition >= 1.0f)
            {
                timePosition -= 1.0f;
            }

        }
    }
}