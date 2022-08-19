public class SubbandLayer1Stereo : SubbandLayer1 // TypeDefIndex: 7405
{	// Fields
	protected int Channel2Allocation; // 0x30
	protected float Channel2Factor; // 0x34
	protected float Channel2Offset; // 0x38
	protected float Channel2Sample; // 0x3C
	protected int Channel2Samplelength; // 0x40
	protected float Channel2Scalefactor; // 0x44

	// Methods

	// RVA: 0x68D270 Offset: 0x68C670 VA: 0x18068D270
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x68CD80 Offset: 0x68C180 VA: 0x18068CD80 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x68D140 Offset: 0x68C540 VA: 0x18068D140 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x68D0A0 Offset: 0x68C4A0 VA: 0x18068D0A0 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x68CCC0 Offset: 0x68C0C0 VA: 0x18068CCC0 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

