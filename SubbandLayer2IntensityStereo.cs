public class SubbandLayer2IntensityStereo : SubbandLayer2 // TypeDefIndex: 7408
{
	protected float Channel2Scalefactor1; 
	protected float Channel2Scalefactor2; 
	protected float Channel2Scalefactor3; 
	protected int Channel2Scfsi; 


	internal void .ctor(int subbandnumber) { }

	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

