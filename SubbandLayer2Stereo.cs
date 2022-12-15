public class SubbandLayer2Stereo : SubbandLayer2 // TypeDefIndex: 7426
{
	protected int Channel2Allocation;
	protected readonly float[] Channel2C;
	protected readonly int[] Channel2Codelength;
	protected readonly float[] Channel2D;
	protected readonly float[] Channel2Factor;
	protected readonly float[] Channel2Samples;
	protected float Channel2Scalefactor1;
	protected float Channel2Scalefactor2;
	protected float Channel2Scalefactor3;
	protected int Channel2Scfsi;


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

