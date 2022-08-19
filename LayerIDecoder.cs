public class LayerIDecoder : IFrameDecoder // TypeDefIndex: 7400
{	// Fields
	protected ABuffer Buffer; // 0x10
	protected readonly Crc16 CRC; // 0x18
	protected SynthesisFilter Filter1; // 0x20
	protected SynthesisFilter Filter2; // 0x28
	protected Header Header; // 0x30
	protected int Mode; // 0x38
	protected int NuSubbands; // 0x3C
	protected Bitstream Stream; // 0x40
	protected ASubband[] Subbands; // 0x48
	protected int WhichChannels; // 0x50

	// Methods

	// RVA: 0x67AD70 Offset: 0x67A170 VA: 0x18067AD70
	internal void .ctor() { }

	// RVA: 0x67A9E0 Offset: 0x679DE0 VA: 0x18067A9E0 Slot: 5
	public virtual void DecodeFrame() { }

	// RVA: 0x67A960 Offset: 0x679D60 VA: 0x18067A960 Slot: 6
	internal virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0) { }

	// RVA: 0x67A5C0 Offset: 0x6799C0 VA: 0x18067A5C0 Slot: 7
	protected virtual void CreateSubbands() { }

	// RVA: 0x67AB10 Offset: 0x679F10 VA: 0x18067AB10 Slot: 8
	protected virtual void ReadAllocation() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 9
	protected virtual void ReadScaleFactorSelection() { }

	// RVA: 0x67AD00 Offset: 0x67A100 VA: 0x18067AD00 Slot: 10
	protected virtual void ReadScaleFactors() { }

	// RVA: 0x67AB90 Offset: 0x679F90 VA: 0x18067AB90 Slot: 11
	protected virtual void ReadSampleData() { }

}

