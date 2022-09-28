public abstract class ASubband // TypeDefIndex: 7371
{
	internal static readonly float[] ScaleFactors; 


	internal abstract void ReadAllocation(Bitstream stream, Header header, Crc16 crc);

	internal abstract void ReadScaleFactor(Bitstream stream, Header header);

	internal abstract bool ReadSampleData(Bitstream stream);

	internal abstract bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2);

	protected void .ctor() { }

	private static void .cctor() { }

}

