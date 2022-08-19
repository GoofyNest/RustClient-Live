public class SubbandLayer2Stereo : SubbandLayer2 // TypeDefIndex: 7408
{	// Fields
	protected int Channel2Allocation; // 0x68
	protected readonly float[] Channel2C; // 0x70
	protected readonly int[] Channel2Codelength; // 0x78
	protected readonly float[] Channel2D; // 0x80
	protected readonly float[] Channel2Factor; // 0x88
	protected readonly float[] Channel2Samples; // 0x90
	protected float Channel2Scalefactor1; // 0x98
	protected float Channel2Scalefactor2; // 0x9C
	protected float Channel2Scalefactor3; // 0xA0
	protected int Channel2Scfsi; // 0xA4

	// Methods

	// RVA: 0x68E900 Offset: 0x68DD00 VA: 0x18068E900
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x68DFC0 Offset: 0x68D3C0 VA: 0x18068DFC0 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x68E430 Offset: 0x68D830 VA: 0x18068E430 Slot: 10
	internal override void ReadScaleFactorSelection(Bitstream stream, Crc16 crc) { }

	// RVA: 0x68E4D0 Offset: 0x68D8D0 VA: 0x18068E4D0 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x68E060 Offset: 0x68D460 VA: 0x18068E060 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x68DD30 Offset: 0x68D130 VA: 0x18068DD30 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

}

