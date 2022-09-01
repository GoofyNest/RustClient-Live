public class SubbandLayer1Stereo : SubbandLayer1 // TypeDefIndex: 7406
{
	protected int Channel2Allocation; 
	protected float Channel2Factor; 
	protected float Channel2Offset; 
	protected float Channel2Sample; 
	protected int Channel2Samplelength; 
	protected float Channel2Scalefactor; 


	internal void .ctor(int subbandnumber) { }

	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool ReadSampleData(Bitstream stream) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

