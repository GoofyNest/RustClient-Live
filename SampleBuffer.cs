public class SampleBuffer : ABuffer // TypeDefIndex: 7396
{	// Fields
	private readonly short[] _Buffer; // 0x10
	private readonly int[] _Bufferp; // 0x18
	private readonly int _Channels; // 0x20
	private readonly int _Frequency; // 0x24

	// Methods

	// RVA: 0x225DC90 Offset: 0x225D090 VA: 0x18225DC90
	internal void .ctor(int sampleFrequency, int numberOfChannels) { }

	// RVA: 0x225DBB0 Offset: 0x225CFB0 VA: 0x18225DBB0 Slot: 4
	protected override void Append(int channel, short valueRenamed) { }

	// RVA: 0x225DAB0 Offset: 0x225CEB0 VA: 0x18225DAB0 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 6
	internal override void WriteBuffer(int val) { }

	// RVA: 0x225DC40 Offset: 0x225D040 VA: 0x18225DC40 Slot: 7
	internal override void ClearBuffer() { }

}

