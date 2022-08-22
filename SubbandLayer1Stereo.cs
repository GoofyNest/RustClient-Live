public class SubbandLayer1Stereo : SubbandLayer1 // TypeDefIndex: 7405
{	protected int Channel2Allocation; // 0x30
	protected float Channel2Factor; // 0x34
	protected float Channel2Offset; // 0x38
	protected float Channel2Sample; // 0x3C
	protected int Channel2Samplelength; // 0x40
	protected float Channel2Scalefactor; // 0x44


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

