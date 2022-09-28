public class LayerIDecoder : IFrameDecoder // TypeDefIndex: 7373
{
	protected ABuffer Buffer; 
	protected readonly Crc16 CRC; 
	protected SynthesisFilter Filter1; 
	protected SynthesisFilter Filter2; 
	protected Header Header; 
	protected int Mode; 
	protected int NuSubbands; 
	protected Bitstream Stream; 
	protected ASubband[] Subbands; 
	protected int WhichChannels; 


	internal void .ctor() { }

	public virtual void DecodeFrame() { }

	internal virtual void Create(Bitstream stream0, Header header0, SynthesisFilter filtera, SynthesisFilter filterb, ABuffer buffer0, int whichCh0) { }

	protected virtual void CreateSubbands() { }

	protected virtual void ReadAllocation() { }

	protected virtual void ReadScaleFactorSelection() { }

	protected virtual void ReadScaleFactors() { }

	protected virtual void ReadSampleData() { }

}

