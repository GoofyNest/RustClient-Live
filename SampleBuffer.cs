public class SampleBuffer : ABuffer // TypeDefIndex: 7396
{	private readonly short[] _Buffer; // 0x10
	private readonly int[] _Bufferp; // 0x18
	private readonly int _Channels; // 0x20
	private readonly int _Frequency; // 0x24


	internal void .ctor(int sampleFrequency, int numberOfChannels) { }

	protected override void Append(int channel, short valueRenamed) { }

	internal override void AppendSamples(int channel, float[] samples) { }

	internal override void WriteBuffer(int val) { }

	internal override void ClearBuffer() { }

}

