public class OnePoleLowpassFilter : MonoBehaviour // TypeDefIndex: 9015
{	// Fields
	[RangeAttribute] // RVA: 0xCAB60 Offset: 0xC9F60 VA: 0x1800CAB60
	public float frequency; // 0x18
	private int sampleRate; // 0x1C
	private float c; // 0x20
	private float a1; // 0x24
	private float b1; // 0x28
	private OnePoleLowpassFilter.ChannelData[] channelData; // 0x30
	private float prevFrequency; // 0x38

	// Methods

	// RVA: 0xA49D60 Offset: 0xA49160 VA: 0x180A49D60
	public void Update() { }

	// RVA: 0xA499E0 Offset: 0xA48DE0 VA: 0x180A499E0
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0xA49BC0 Offset: 0xA48FC0 VA: 0x180A49BC0
	private void SetupChannelData(int channels) { }

	// RVA: 0xA49CC0 Offset: 0xA490C0 VA: 0x180A49CC0
	private void UpdateFilterCoefficients() { }

	// RVA: 0xA49E40 Offset: 0xA49240 VA: 0x180A49E40
	public void .ctor() { }

}

private class OnePoleLowpassFilter.ChannelData // TypeDefIndex: 9016
{	// Fields
	public float out1; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

