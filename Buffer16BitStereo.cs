public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
{
// Namespace: MP3Sharp
public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
	// Fields
	internal bool DoubleMonoToStereo; // 0x10
	private const int OUTPUT_CHANNELS = 2;
	private readonly byte[] _Buffer; // 0x18
	private readonly int[] _BufferChannelOffsets; // 0x20
	private int _End; // 0x28
	private int _Offset; // 0x2C

	// Properties
	internal int BytesLeft { get; }

	// Methods

	// RVA: 0x5F5AA0 Offset: 0x5F4EA0 VA: 0x1805F5AA0
	internal void .ctor() { }

	// RVA: 0x5F5B30 Offset: 0x5F4F30 VA: 0x1805F5B30
	internal int get_BytesLeft() { }

	// RVA: 0x5F5950 Offset: 0x5F4D50 VA: 0x1805F5950
	internal int Read(byte[] bufferOut, int offset, int count) { }

	// RVA: 0x5F5830 Offset: 0x5F4C30 VA: 0x1805F5830 Slot: 4
	protected override void Append(int channel, short sampleValue) { }

	// RVA: 0x5F55B0 Offset: 0x5F49B0 VA: 0x1805F55B0 Slot: 5
	internal override void AppendSamples(int channel, float[] samples) { }

	// RVA: 0x5F5900 Offset: 0x5F4D00 VA: 0x1805F5900 Slot: 7
	internal sealed override void ClearBuffer() { }

	// RVA: 0x5F5A60 Offset: 0x5F4E60 VA: 0x1805F5A60 Slot: 6
	internal override void WriteBuffer(int val) { }

}

