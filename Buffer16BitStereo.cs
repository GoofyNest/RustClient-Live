public class Buffer16BitStereo : ABuffer // TypeDefIndex: 7377
{

public class Buffer16BitStereo : ABuffer 
	internal bool DoubleMonoToStereo; 
private const int OUTPUT_CHANNELS = 2;
	private readonly byte[] _Buffer; 
	private readonly int[] _BufferChannelOffsets; 
	private int _End; 
	private int _Offset; 

internal int BytesLeft { get; }


internal void .ctor() { }

internal int get_BytesLeft() { }

internal int Read(byte[] bufferOut, int offset, int count) { }

protected override void Append(int channel, short sampleValue) { }

internal override void AppendSamples(int channel, float[] samples) { }

internal sealed override void ClearBuffer() { }

internal override void WriteBuffer(int val) { }

}

