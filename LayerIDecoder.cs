public class LayerIDecoder : IFrameDecoder // TypeDefIndex: 7400
{	protected ABuffer Buffer; // 0x10
	protected readonly Crc16 CRC; // 0x18
	protected SynthesisFilter Filter1; // 0x20
	protected SynthesisFilter Filter2; // 0x28
	protected Header Header; // 0x30
	protected int Mode; // 0x38
	protected int NuSubbands; // 0x3C
	protected Bitstream Stream; // 0x40
	protected ASubband[] Subbands; // 0x48
	protected int WhichChannels; // 0x50


	internal void .ctor() { }

	public virtual void DecodeFrame() { }

	internal virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0) { }

	protected virtual void CreateSubbands() { }

	protected virtual void ReadAllocation() { }

	protected virtual void ReadScaleFactorSelection() { }

	protected virtual void ReadScaleFactors() { }

	protected virtual void ReadSampleData() { }

}

