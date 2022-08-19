public abstract class ASubband // TypeDefIndex: 7398
{	// Fields
	internal static readonly float[] ScaleFactors; // 0x2B0AA98

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	internal abstract void ReadAllocation(Bitstream stream, Header header, Crc16 crc);

	// RVA: -1 Offset: -1 Slot: 5
	internal abstract void ReadScaleFactor(Bitstream stream, Header header);

	// RVA: -1 Offset: -1 Slot: 6
	internal abstract bool ReadSampleData(Bitstream stream);

	// RVA: -1 Offset: -1 Slot: 7
	internal abstract bool PutNextSample(int channels, SynthesisFilter filter1, SynthesisFilter filter2);

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x5F3EB0 Offset: 0x5F32B0 VA: 0x1805F3EB0
	private static void .cctor() { }

}

