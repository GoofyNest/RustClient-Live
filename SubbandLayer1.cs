public class SubbandLayer1 : ASubband // TypeDefIndex: 7411
{
	internal static readonly float[] TableFactor; 
	internal static readonly float[] TableOffset; 
	protected int Allocation; 
	protected float Factor; 
	protected float Offset; 
	protected float Sample; 
	protected int Samplelength; 
	protected int Samplenumber; 
	protected float Scalefactor; 
	protected readonly int Subbandnumber; 


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	private static void .cctor() { }

}

