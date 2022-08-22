public class SubbandLayer2IntensityStereo : SubbandLayer2 // TypeDefIndex: 7407
{	protected float Channel2Scalefactor1; // 0x68
	protected float Channel2Scalefactor2; // 0x6C
	protected float Channel2Scalefactor3; // 0x70
	protected int Channel2Scfsi; // 0x74


	internal void .ctor(int subbandnumber) { }

	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

