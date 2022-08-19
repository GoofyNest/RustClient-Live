public class SubbandLayer2IntensityStereo : SubbandLayer2 // TypeDefIndex: 7407
{	// Fields
	protected float Channel2Scalefactor1; // 0x68
	protected float Channel2Scalefactor2; // 0x6C
	protected float Channel2Scalefactor3; // 0x70
	protected int Channel2Scfsi; // 0x74

	// Methods

	// RVA: 0x68DCD0 Offset: 0x68D0D0 VA: 0x18068DCD0
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x68D880 Offset: 0x68CC80 VA: 0x18068D880 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x68D910 Offset: 0x68CD10 VA: 0x18068D910 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x68D6B0 Offset: 0x68CAB0 VA: 0x18068D6B0 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

