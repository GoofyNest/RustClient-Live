public class OggEncoder : IDisposable // TypeDefIndex: 9014
{	// Fields
	private IntPtr _nativeEncoder; // 0x10

	// Methods

	// RVA: 0xA485E0 Offset: 0xA479E0 VA: 0x180A485E0
	private static extern IntPtr OGG_CreateEncoder(int sampleRate) { }

	// RVA: 0xA48660 Offset: 0xA47A60 VA: 0x180A48660
	private static extern void OGG_DestroyEncoder(IntPtr pEncoder) { }

	// RVA: 0xA486E0 Offset: 0xA47AE0 VA: 0x180A486E0
	private static extern bool OGG_Encode(IntPtr pEncoder, float* pSamples, int sampleCount) { }

	// RVA: 0xA48780 Offset: 0xA47B80 VA: 0x180A48780
	private static extern bool OGG_FinishEncode(IntPtr pEncoder) { }

	// RVA: 0xA48800 Offset: 0xA47C00 VA: 0x180A48800
	private static extern int OGG_GetEncodedData(IntPtr pEncoder, out byte* pData) { }

	// RVA: 0xA488A0 Offset: 0xA47CA0 VA: 0x180A488A0
	public void .ctor() { }

	// RVA: 0xA47AB0 Offset: 0xA46EB0 VA: 0x180A47AB0 Slot: 1
	protected override void Finalize() { }

	// RVA: 0xA48120 Offset: 0xA47520 VA: 0x180A48120 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0xA481E0 Offset: 0xA475E0 VA: 0x180A481E0 Slot: 4
	public void Dispose() { }

	// RVA: 0xA48250 Offset: 0xA47650 VA: 0x180A48250
	public bool Encode(float[] samples) { }

	// RVA: 0xA48380 Offset: 0xA47780 VA: 0x180A48380
	public bool Finish() { }

	// RVA: 0xA48460 Offset: 0xA47860 VA: 0x180A48460
	public byte[] GetData() { }

}

