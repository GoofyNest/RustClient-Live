public class OnePoleLowpassFilter : MonoBehaviour // TypeDefIndex: 9015
{	[RangeAttribute] // RVA: 0xCAB60 Offset: 0xC9F60 VA: 0x1800CAB60
	public float frequency; // 0x18
	private int sampleRate; // 0x1C
	private float c; // 0x20
	private float a1; // 0x24
	private float b1; // 0x28
	private OnePoleLowpassFilter.ChannelData[] channelData; // 0x30
	private float prevFrequency; // 0x38


	public void Update() { }

	private void OnAudioFilterRead(float[] data, int channels) { }

	private void SetupChannelData(int channels) { }

	private void UpdateFilterCoefficients() { }

	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 9016
{	public float out1; // 0x10


	public void .ctor() { }

}

