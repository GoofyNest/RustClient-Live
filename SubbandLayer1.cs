public class SubbandLayer1 : ASubband // TypeDefIndex: 7403
{	// Fields
	internal static readonly float[] TableFactor; // 0x0
	internal static readonly float[] TableOffset; // 0x8
	protected int Allocation; // 0x10
	protected float Factor; // 0x14
	protected float Offset; // 0x18
	protected float Sample; // 0x1C
	protected int Samplelength; // 0x20
	protected int Samplenumber; // 0x24
	protected float Scalefactor; // 0x28
	protected readonly int Subbandnumber; // 0x2C

	// Methods

	// RVA: 0x68D640 Offset: 0x68CA40 VA: 0x18068D640
	internal void .ctor(int subbandnumber) { }

	// RVA: 0x68D360 Offset: 0x68C760 VA: 0x18068D360 Slot: 4
	internal override void ReadAllocation(Bitstream stream, Header header, Crc16 crc) { }

	// RVA: 0x68D4D0 Offset: 0x68C8D0 VA: 0x18068D4D0 Slot: 5
	internal override void ReadScaleFactor(Bitstream stream, Header header) { }

	// RVA: 0x68D470 Offset: 0x68C870 VA: 0x18068D470 Slot: 6
	internal override bool ReadSampleData(Bitstream stream) { }

	// RVA: 0x68D310 Offset: 0x68C710 VA: 0x18068D310 Slot: 7
	internal override bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2) { }

	// RVA: 0x68D590 Offset: 0x68C990 VA: 0x18068D590
	private static void .cctor() { }

}

