public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
{
public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
	internal bool DoubleMonoToStereo; // 0x10
	private const int OUTPUT_CHANNELS = 2;
	private readonly byte[] _Buffer; // 0x18
	private readonly int[] _BufferChannelOffsets; // 0x20
	private int _End; // 0x28
	private int _Offset; // 0x2C

	internal int BytesLeft { get; }


	internal void .ctor() { }

	internal int get_BytesLeft() { }

	internal int Read(byte[] bufferOut, int offset, int count) { }

	protected override void Append(int channel, short sampleValue) { }

	internal override void AppendSamples(int channel, float[] samples) { }

	internal sealed override void ClearBuffer() { }

	internal override void WriteBuffer(int val) { }

}

