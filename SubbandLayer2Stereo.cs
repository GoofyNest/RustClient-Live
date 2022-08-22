public class SubbandLayer2Stereo : SubbandLayer2 // TypeDefIndex: 7408
{	protected int Channel2Allocation; // 0x68
	protected readonly float[] Channel2C; // 0x70
	protected readonly int[] Channel2Codelength; // 0x78
	protected readonly float[] Channel2D; // 0x80
	protected readonly float[] Channel2Factor; // 0x88
	protected readonly float[] Channel2Samples; // 0x90
	protected float Channel2Scalefactor1; // 0x98
	protected float Channel2Scalefactor2; // 0x9C
	protected float Channel2Scalefactor3; // 0xA0
	protected int Channel2Scfsi; // 0xA4


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

