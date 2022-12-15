public class OnePoleLowpassFilter : MonoBehaviour // TypeDefIndex: 10752
{
	[RangeAttribute]
	public float frequency;
	private int sampleRate;
	private float c;
	private float a1;
	private float b1;
	private OnePoleLowpassFilter.ChannelData[] channelData;
	private float prevFrequency;


	public void Update() { }

	private void OnAudioFilterRead(float[] data, int channels) { }

	private void SetupChannelData(int channels) { }

	private void UpdateFilterCoefficients() { }

	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 10753
{
	public float out1;


	public void .ctor() { }

}

